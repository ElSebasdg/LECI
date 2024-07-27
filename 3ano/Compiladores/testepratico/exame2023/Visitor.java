import java.util.HashMap;
import java.util.Scanner;
import java.io.File;  // Import the File class
import java.io.FileNotFoundException;  // Import this class to handle errors

@SuppressWarnings("CheckReturnValue")
public class Visitor extends TextProcBaseVisitor<String> {
   
   private HashMap<String,String> vars = new HashMap<>();

   @Override public String visitMain(TextProcParser.MainContext ctx) {
      String res = null;
      return visitChildren(ctx);
   }

   @Override public String visitStat(TextProcParser.StatContext ctx) {
      String res = null;
      return visitChildren(ctx);
   }

   //done
   @Override public String visitOutput(TextProcParser.OutputContext ctx) {
      System.out.println(visit(ctx.expr()));
      return null;
   }

   //done
   @Override public String visitAssignment(TextProcParser.AssignmentContext ctx) {
      String key = ctx.VAR().getText();
      String value = visit(ctx.expr());
      vars.put(key,value);
      //System.out.println("Assignment:" + key + ":" + value);
      return null;
   }

   //done mas nao entendo se é suposto retornar todas as linhas que contêm o expr1 ou só a primeira
   @Override public String visitExprGrep(TextProcParser.ExprGrepContext ctx) {
      String expr0 = visit(ctx.expr(0));
      String expr1 = visit(ctx.expr(1));
      String text[] = expr0.split("\n");
      String res = "";
      for(int i = 0 ; i < text.length; i++){

         if(text[i].contains(expr1)){
            res += text[i];
         }
      }
      return res;
   }

   @Override public String visitExprConcat(TextProcParser.ExprConcatContext ctx) {
      String expr0 = visit(ctx.expr(0));
      String expr1 = visit(ctx.expr(1));
      return expr0+expr1;
   }

   @Override public String visitExprUserInput(TextProcParser.ExprUserInputContext ctx) {
      String res = visit(ctx.expr());
      System.out.print(res);
      Scanner sc = new Scanner(System.in);
      String text = sc.nextLine();
      sc.close();
      return text;
      //return res;
   }

   //done
   @Override public String visitExprSTR(TextProcParser.ExprSTRContext ctx) {
      String res = ctx.STR().getText();
      res =res.substring(1,res.length()-1);
      return res;
   }

   @Override public String visitExprFileInput(TextProcParser.ExprFileInputContext ctx) {
      String res = visit(ctx.expr());
      String text = "";
      try {
         File filename = new File(res);
         Scanner reader = new Scanner(filename);
         
         while(reader.hasNextLine()){
         text += reader.nextLine();
         }
         reader.close();
         
      }catch(FileNotFoundException e){
         System.out.println("An error occurred.");
         e.printStackTrace();
      }
      return text;
      //return res;
   }
   //done
   @Override public String visitExprVAR(TextProcParser.ExprVARContext ctx) {
      String res = ctx.VAR().getText();
      if(vars.containsKey(res)){
         return vars.get(res);
      }
      return null;
   }

   //done
   @Override public String visitExprNL(TextProcParser.ExprNLContext ctx) {
      return "\n";
   }

   //done
   @Override public String visitExprShitySTR(TextProcParser.ExprShitySTRContext ctx) {
      String res = ctx.ShitySTR().getText();
      return res;
   }

   //done
   @Override public String visitExprReplace(TextProcParser.ExprReplaceContext ctx) {
      String expr0 = visit(ctx.expr(0));
      String expr1 = visit(ctx.expr(1));
      String expr2 = visit(ctx.expr(2));

      return expr0.replace(expr1,expr2);
   }

   //done
   @Override public String visitExprBraces(TextProcParser.ExprBracesContext ctx) {
      String res = visit(ctx.expr());
      return res;
   }

   @Override public String visitExprFileOutput(TextProcParser.ExprFileOutputContext ctx) {
      String res = null;
      return visitChildren(ctx);
      //return res;
   }
}
