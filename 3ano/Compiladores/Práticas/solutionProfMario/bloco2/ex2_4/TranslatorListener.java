// Generated from Translator.g4 by ANTLR 4.12.0
import org.antlr.v4.runtime.tree.ParseTreeListener;

/**
 * This interface defines a complete listener for a parse tree produced by
 * {@link TranslatorParser}.
 */
public interface TranslatorListener extends ParseTreeListener {
	/**
	 * Enter a parse tree produced by {@link TranslatorParser#dictionary}.
	 * @param ctx the parse tree
	 */
	void enterDictionary(TranslatorParser.DictionaryContext ctx);
	/**
	 * Exit a parse tree produced by {@link TranslatorParser#dictionary}.
	 * @param ctx the parse tree
	 */
	void exitDictionary(TranslatorParser.DictionaryContext ctx);
	/**
	 * Enter a parse tree produced by {@link TranslatorParser#translation}.
	 * @param ctx the parse tree
	 */
	void enterTranslation(TranslatorParser.TranslationContext ctx);
	/**
	 * Exit a parse tree produced by {@link TranslatorParser#translation}.
	 * @param ctx the parse tree
	 */
	void exitTranslation(TranslatorParser.TranslationContext ctx);
	/**
	 * Enter a parse tree produced by {@link TranslatorParser#expr}.
	 * @param ctx the parse tree
	 */
	void enterExpr(TranslatorParser.ExprContext ctx);
	/**
	 * Exit a parse tree produced by {@link TranslatorParser#expr}.
	 * @param ctx the parse tree
	 */
	void exitExpr(TranslatorParser.ExprContext ctx);
}