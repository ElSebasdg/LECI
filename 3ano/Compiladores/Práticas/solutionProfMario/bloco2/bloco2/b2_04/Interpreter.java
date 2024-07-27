public class Interpreter extends PrefixCalculatorBaseVisitor<Double> {

   @Override public Double visitStat(PrefixCalculatorParser.StatContext ctx) {
      Double res = null;
      if (ctx.expr() != null)
      {
         res = visit(ctx.expr());
         if (res != null)
            System.out.println("Result: "+res);
      }
      return res;
   }

   @Override public Double visitExprPrefix(PrefixCalculatorParser.ExprPrefixContext ctx) {
      Double res = null;
      Double e1 = visit(ctx.expr(0));
      Double e2 = visit(ctx.expr(1));
      if (e1 != null && e2 != null) {
         switch(ctx.op.getText()) {
            case "+":
               res = e1 + e2;
               break;
            case "-":
               res = e1 - e2;
               break;
            case "*":
               res = e1 * e2;
               break;
            case "/":
               if (e1 == 0)
                  System.err.println("ERROR: divide by zero!");
               else
                  res = e1 / e2;
               break;
         }
      }
      return res;
   }

   @Override public Double visitExprNumber(PrefixCalculatorParser.ExprNumberContext ctx) {
      return Double.parseDouble(ctx.Number().getText());
   }
}
