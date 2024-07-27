import java.util.HashMap;

public class Interpreter extends CalculatorBaseVisitor<Long> {

	@Override public Long visitStatExpr(CalculatorParser.StatExprContext ctx) {
      Long res = null;
      res = visit(ctx.expr());
      if (res != null)
         System.out.println(res);
      return res;
   }

	@Override public Long visitAssignment(CalculatorParser.AssignmentContext ctx) {
      Long res = visit(ctx.expr());
      String id = ctx.ID().getText();
      if (res != null) {
         symbolTable.put(id, res);
         System.out.println(id+" = "+res);
      }
      return res;
   }

	@Override public Long visitExprUnary(CalculatorParser.ExprUnaryContext ctx) {
      Long res = null;
      Long e = visit(ctx.expr());
      String op = ctx.op.getText();
      if (e != null) {
         switch(op) {
            case "+":
               res = e;
               break;
            case "-":
               res = -e;
               break;
         }
      }
      return res;
   }

   @Override public Long visitExprMultDivMod(CalculatorParser.ExprMultDivModContext ctx) {
      Long res = null;
      Long e1 = visit(ctx.expr(0));
      Long e2 = visit(ctx.expr(1));
      String op = ctx.op.getText();
      if (e1 != null && e2 != null) {
         switch(op) {
            case "*":
               res = e1 * e2;
               break;
            case "/":
               if (e2 == 0)
                  System.err.println("ERROR: divide by zero!");
               else
                  res = e1 / e2;
               break;
            case "%":
               if (e2 == 0)
                  System.err.println("ERROR: divide by zero!");
               else
                  res = e1 % e2;
               break;
         }
      }
      return res;
   }

   @Override public Long visitExprAddSub(CalculatorParser.ExprAddSubContext ctx) {
      Long res = null;
      Long e1 = visit(ctx.expr(0));
      Long e2 = visit(ctx.expr(1));
      String op = ctx.op.getText();
      if (e1 != null && e2 != null) {
         switch(op) {
            case "+":
               res = e1 + e2;
               break;
            case "-":
               res = e1 - e2;
               break;
         }
      }
      return res;
   }

   @Override public Long visitExprParent(CalculatorParser.ExprParentContext ctx) {
      return visit(ctx.expr());
   }

	@Override public Long visitExprId(CalculatorParser.ExprIdContext ctx) {
      Long res = null;
      String id = ctx.ID().getText();
      if (!symbolTable.containsKey(id))
         System.err.println("ERROR: variable \""+id+"\" not found!");
      else
         res = symbolTable.get(id);
      return res;
   }

   @Override public Long visitExprInteger(CalculatorParser.ExprIntegerContext ctx) {
      return Long.parseLong(ctx.Integer().getText());
   }

   private HashMap<String,Long> symbolTable = new HashMap<>();
}
