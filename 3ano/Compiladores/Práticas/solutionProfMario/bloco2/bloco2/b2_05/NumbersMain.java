import static java.lang.System.*;
import java.util.*;
import java.io.*;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.tree.*;

public class NumbersMain {
   final static Scanner in = new Scanner(System.in);

   public static void main(String[] args) throws Exception {
      InputStream in_stream = null;
      try {
         in_stream = new FileInputStream(new File("numbers.txt"));
      }
      catch(FileNotFoundException e) {
         err.println("ERROR: reading number file!");
         exit(1);
      }
      CharStream input = CharStreams.fromStream(in_stream);
      // create a lexer that feeds off of input CharStream:
      NumbersLexer lexer = new NumbersLexer(input);
      // create a buffer of tokens pulled from the lexer:
      CommonTokenStream tokens = new CommonTokenStream(lexer);
      // create a parser that feeds off the tokens buffer:
      NumbersParser parser = new NumbersParser(tokens);
      // replace error listener:
      //parser.removeErrorListeners(); // remove ConsoleErrorListener
      //parser.addErrorListener(new ErrorHandlingListener());
      // begin parsing at file rule:
      ParseTree tree = parser.file();
      if (parser.getNumberOfSyntaxErrors() == 0) {
         // print LISP-style tree:
         // System.out.println(tree.toStringTree(parser));
         ParseTreeWalker walker = new ParseTreeWalker();
         NumberMappings mappings = new NumberMappings();
         walker.walk(mappings, tree);

         while(in.hasNextLine())
         {
            String line = in.nextLine();
            String processedLine = line.replace('-', ' ');
            Scanner scline = new Scanner(processedLine);
            boolean first = true;
            while(scline.hasNext())
            {
               String output = scline.next();
               String text = output.toLowerCase();
               if (!first)
                  out.print(" ");
               if (mappings.exists(text))
                  output = mappings.value(text).toString();
               out.print(output);
               first = false;
            }
            out.println();
         }
      }
   }
}
