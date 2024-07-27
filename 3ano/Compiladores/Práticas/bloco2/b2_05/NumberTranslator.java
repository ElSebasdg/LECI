@SuppressWarnings("CheckReturnValue")
public class NumberTranslator extends NumberTranslatorBaseVisitor<Listener> {

   @Override public Listener visitProgram(NumberTranslatorParser.ProgramContext ctx) {
      Listener res = null;
      return visitChildren(ctx);
      //return res;
   }

   @Override public Listener visitStat(NumberTranslatorParser.StatContext ctx) {
      Listener res = null;
      return visitChildren(ctx);
      //return res;
   }
}
