// Generated from Vector.g4 by ANTLR 4.13.1
import org.antlr.v4.runtime.tree.ParseTreeListener;

/**
 * This interface defines a complete listener for a parse tree produced by
 * {@link VectorParser}.
 */
public interface VectorListener extends ParseTreeListener {
	/**
	 * Enter a parse tree produced by {@link VectorParser#program}.
	 * @param ctx the parse tree
	 */
	void enterProgram(VectorParser.ProgramContext ctx);
	/**
	 * Exit a parse tree produced by {@link VectorParser#program}.
	 * @param ctx the parse tree
	 */
	void exitProgram(VectorParser.ProgramContext ctx);
	/**
	 * Enter a parse tree produced by {@link VectorParser#statement}.
	 * @param ctx the parse tree
	 */
	void enterStatement(VectorParser.StatementContext ctx);
	/**
	 * Exit a parse tree produced by {@link VectorParser#statement}.
	 * @param ctx the parse tree
	 */
	void exitStatement(VectorParser.StatementContext ctx);
	/**
	 * Enter a parse tree produced by {@link VectorParser#showStmt}.
	 * @param ctx the parse tree
	 */
	void enterShowStmt(VectorParser.ShowStmtContext ctx);
	/**
	 * Exit a parse tree produced by {@link VectorParser#showStmt}.
	 * @param ctx the parse tree
	 */
	void exitShowStmt(VectorParser.ShowStmtContext ctx);
	/**
	 * Enter a parse tree produced by {@link VectorParser#assignmentStmt}.
	 * @param ctx the parse tree
	 */
	void enterAssignmentStmt(VectorParser.AssignmentStmtContext ctx);
	/**
	 * Exit a parse tree produced by {@link VectorParser#assignmentStmt}.
	 * @param ctx the parse tree
	 */
	void exitAssignmentStmt(VectorParser.AssignmentStmtContext ctx);
	/**
	 * Enter a parse tree produced by {@link VectorParser#expr}.
	 * @param ctx the parse tree
	 */
	void enterExpr(VectorParser.ExprContext ctx);
	/**
	 * Exit a parse tree produced by {@link VectorParser#expr}.
	 * @param ctx the parse tree
	 */
	void exitExpr(VectorParser.ExprContext ctx);
	/**
	 * Enter a parse tree produced by {@link VectorParser#vector}.
	 * @param ctx the parse tree
	 */
	void enterVector(VectorParser.VectorContext ctx);
	/**
	 * Exit a parse tree produced by {@link VectorParser#vector}.
	 * @param ctx the parse tree
	 */
	void exitVector(VectorParser.VectorContext ctx);
}