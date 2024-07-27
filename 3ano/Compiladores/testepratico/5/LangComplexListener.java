// Generated from LangComplex.g4 by ANTLR 4.13.1
import org.antlr.v4.runtime.tree.ParseTreeListener;

/**
 * This interface defines a complete listener for a parse tree produced by
 * {@link LangComplexParser}.
 */
public interface LangComplexListener extends ParseTreeListener {
	/**
	 * Enter a parse tree produced by {@link LangComplexParser#program}.
	 * @param ctx the parse tree
	 */
	void enterProgram(LangComplexParser.ProgramContext ctx);
	/**
	 * Exit a parse tree produced by {@link LangComplexParser#program}.
	 * @param ctx the parse tree
	 */
	void exitProgram(LangComplexParser.ProgramContext ctx);
	/**
	 * Enter a parse tree produced by {@link LangComplexParser#statement}.
	 * @param ctx the parse tree
	 */
	void enterStatement(LangComplexParser.StatementContext ctx);
	/**
	 * Exit a parse tree produced by {@link LangComplexParser#statement}.
	 * @param ctx the parse tree
	 */
	void exitStatement(LangComplexParser.StatementContext ctx);
	/**
	 * Enter a parse tree produced by {@link LangComplexParser#displayStmt}.
	 * @param ctx the parse tree
	 */
	void enterDisplayStmt(LangComplexParser.DisplayStmtContext ctx);
	/**
	 * Exit a parse tree produced by {@link LangComplexParser#displayStmt}.
	 * @param ctx the parse tree
	 */
	void exitDisplayStmt(LangComplexParser.DisplayStmtContext ctx);
	/**
	 * Enter a parse tree produced by {@link LangComplexParser#assigStmt}.
	 * @param ctx the parse tree
	 */
	void enterAssigStmt(LangComplexParser.AssigStmtContext ctx);
	/**
	 * Exit a parse tree produced by {@link LangComplexParser#assigStmt}.
	 * @param ctx the parse tree
	 */
	void exitAssigStmt(LangComplexParser.AssigStmtContext ctx);
	/**
	 * Enter a parse tree produced by {@link LangComplexParser#expr}.
	 * @param ctx the parse tree
	 */
	void enterExpr(LangComplexParser.ExprContext ctx);
	/**
	 * Exit a parse tree produced by {@link LangComplexParser#expr}.
	 * @param ctx the parse tree
	 */
	void exitExpr(LangComplexParser.ExprContext ctx);
}