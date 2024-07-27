import static java.lang.System.*;

// Note: To discover the proper rules, view the parse tree over a simple java class

public class ExtractInformation extends Java8BaseListener {
	@Override public void enterNormalClassDeclaration(Java8Parser.NormalClassDeclarationContext ctx) {
      out.println("class "+ctx.Identifier().getText());
   }

	@Override public void enterMethodDeclarator(Java8Parser.MethodDeclaratorContext ctx) {
      out.println("   "+ctx.Identifier().getText());
   }
}
