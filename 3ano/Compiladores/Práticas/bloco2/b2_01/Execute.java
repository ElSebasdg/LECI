import org.antlr.v4.runtime.tree.TerminalNode;

@SuppressWarnings("CheckReturnValue")
public class Execute extends HelloBaseVisitor<String> {

   @Override public String visitHello(HelloParser.HelloContext ctx) {
      String res = null;
      System.out.print("Hello ");
      for(TerminalNode i : ctx.ID() ) {
         System.out.print(i.getText() + " ");
      }
      System.out.println();
      return visitChildren(ctx);
   }

   @Override public String visitBye(HelloParser.ByeContext ctx) {
      String res = null;
      System.out.print("Bye ");
      for(TerminalNode i : ctx.ID() ) {
         System.out.print(i.getText() + " ");
      }
      System.out.println();
      return visitChildren(ctx);
   }
}
