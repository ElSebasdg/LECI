import static java.lang.System.*;
import java.util.Set;
import java.util.HashSet;
import java.util.Map;
import java.util.HashMap;
import java.util.Iterator;

public class Execute extends SetCalcBaseVisitor<Set<String>> {
   @Override public Set<String> visitStat(SetCalcParser.StatContext ctx) {
      Set<String> result = visit(ctx.expr());
      String str = result.toString();
      str = "{"+str.substring(1,str.length()-1).replaceAll(" ","")+"}";
      out.println("result: "+str);
      return result;
   }

   @Override public Set<String> visitExprSubtract(SetCalcParser.ExprSubtractContext ctx) {
      Set<String> res = new HashSet<String>();
      Set<String> s1 = visit(ctx.e1);
      Set<String> s2 = visit(ctx.e2);
      Iterator<String> iter = s1.iterator();
      while(iter.hasNext())
      {
         String e = iter.next();
         if (!s2.contains(e))
            res.add(e);
      }
      return res;
   }

   @Override public Set<String> visitExprIntercept(SetCalcParser.ExprInterceptContext ctx) {
      Set<String> res = new HashSet<String>();
      Set<String> s1 = visit(ctx.e1);
      Set<String> s2 = visit(ctx.e2);
      Iterator<String> iter = s1.iterator();
      while(iter.hasNext())
      {
         String e = iter.next();
         if (s2.contains(e))
            res.add(e);
      }
      return res;
   }

   @Override public Set<String> visitExprUnion(SetCalcParser.ExprUnionContext ctx) {
      Set<String> res;
      Set<String> s1 = visit(ctx.e1);
      Set<String> s2 = visit(ctx.e2);
      res = new HashSet<String>(s1);
      Iterator<String> iter = s2.iterator();
      while(iter.hasNext())
         res.add(iter.next());
      return res;
   }

   @Override public Set<String> visitExprParen(SetCalcParser.ExprParenContext ctx) {
      return visit(ctx.e);
   }

   @Override public Set<String> visitExprSet(SetCalcParser.ExprSetContext ctx) {
      return visit(ctx.set());
   }

   @Override public Set<String> visitExprAssign(SetCalcParser.ExprAssignContext ctx) {
      Set<String> res = visit(ctx.e);
      String var = ctx.VAR().getText();
      varTable.put(var, res);
      for (Map.Entry<String,Set<String>)
      return res;
   }

   @Override public Set<String> visitExprVar(SetCalcParser.ExprVarContext ctx) {
      Set<String> res = null;
      String var = ctx.VAR().getText();
      if (!varTable.containsKey(var))
      {
         err.println("ERROR: variable \""+var+"\" not defined!");
         exit(1);
      }
      res= varTable.get(var);
      return res;
   }

   @Override public Set<String> visitSet(SetCalcParser.SetContext ctx) {
      tempSet = new HashSet<String>();
      visitChildren(ctx);
      return tempSet;
   }

   @Override public Set<String> visitElem(SetCalcParser.ElemContext ctx) {
      tempSet.add(ctx.getText());
      return null;
   }

   protected Set<String> tempSet;
   protected Map<String,Set<String>> varTable = new HashMap<String,Set<String>>();
}
