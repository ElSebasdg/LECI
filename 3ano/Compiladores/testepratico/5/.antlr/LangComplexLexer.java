// Generated from /home/sebastian/2Semestre/Compiladores/testepratico/5/LangComplex.g4 by ANTLR 4.13.1
import org.antlr.v4.runtime.Lexer;
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.Token;
import org.antlr.v4.runtime.TokenStream;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.misc.*;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast", "CheckReturnValue", "this-escape"})
public class LangComplexLexer extends Lexer {
	static { RuntimeMetaData.checkVersion("4.13.1", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		VAR=10, NUM=11, WS=12, COMMENT=13;
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	private static String[] makeRuleNames() {
		return new String[] {
			"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
			"VAR", "NUM", "WS", "COMMENT"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "';'", "'display'", "'<='", "'('", "')'", "'*'", "':'", "'+'", 
			"'-'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, null, null, null, null, null, null, null, null, null, "VAR", "NUM", 
			"WS", "COMMENT"
		};
	}
	private static final String[] _SYMBOLIC_NAMES = makeSymbolicNames();
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}


	public LangComplexLexer(CharStream input) {
		super(input);
		_interp = new LexerATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@Override
	public String getGrammarFileName() { return "LangComplex.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public String[] getChannelNames() { return channelNames; }

	@Override
	public String[] getModeNames() { return modeNames; }

	@Override
	public ATN getATN() { return _ATN; }

	public static final String _serializedATN =
		"\u0004\u0000\rc\u0006\uffff\uffff\u0002\u0000\u0007\u0000\u0002\u0001"+
		"\u0007\u0001\u0002\u0002\u0007\u0002\u0002\u0003\u0007\u0003\u0002\u0004"+
		"\u0007\u0004\u0002\u0005\u0007\u0005\u0002\u0006\u0007\u0006\u0002\u0007"+
		"\u0007\u0007\u0002\b\u0007\b\u0002\t\u0007\t\u0002\n\u0007\n\u0002\u000b"+
		"\u0007\u000b\u0002\f\u0007\f\u0001\u0000\u0001\u0000\u0001\u0001\u0001"+
		"\u0001\u0001\u0001\u0001\u0001\u0001\u0001\u0001\u0001\u0001\u0001\u0001"+
		"\u0001\u0001\u0002\u0001\u0002\u0001\u0002\u0001\u0003\u0001\u0003\u0001"+
		"\u0004\u0001\u0004\u0001\u0005\u0001\u0005\u0001\u0006\u0001\u0006\u0001"+
		"\u0007\u0001\u0007\u0001\b\u0001\b\u0001\t\u0001\t\u0005\t7\b\t\n\t\f"+
		"\t:\t\t\u0001\n\u0004\n=\b\n\u000b\n\f\n>\u0001\n\u0001\n\u0004\nC\b\n"+
		"\u000b\n\f\nD\u0005\nG\b\n\n\n\f\nJ\t\n\u0001\n\u0003\nM\b\n\u0001\u000b"+
		"\u0004\u000bP\b\u000b\u000b\u000b\f\u000bQ\u0001\u000b\u0001\u000b\u0001"+
		"\f\u0001\f\u0001\f\u0001\f\u0001\f\u0001\f\u0001\f\u0005\f]\b\f\n\f\f"+
		"\f`\t\f\u0001\f\u0001\f\u0000\u0000\r\u0001\u0001\u0003\u0002\u0005\u0003"+
		"\u0007\u0004\t\u0005\u000b\u0006\r\u0007\u000f\b\u0011\t\u0013\n\u0015"+
		"\u000b\u0017\f\u0019\r\u0001\u0000\u0005\u0003\u0000AZ__az\u0004\u0000"+
		"09AZ__az\u0001\u000009\u0003\u0000\t\n\r\r  \u0002\u0000\n\n\r\ri\u0000"+
		"\u0001\u0001\u0000\u0000\u0000\u0000\u0003\u0001\u0000\u0000\u0000\u0000"+
		"\u0005\u0001\u0000\u0000\u0000\u0000\u0007\u0001\u0000\u0000\u0000\u0000"+
		"\t\u0001\u0000\u0000\u0000\u0000\u000b\u0001\u0000\u0000\u0000\u0000\r"+
		"\u0001\u0000\u0000\u0000\u0000\u000f\u0001\u0000\u0000\u0000\u0000\u0011"+
		"\u0001\u0000\u0000\u0000\u0000\u0013\u0001\u0000\u0000\u0000\u0000\u0015"+
		"\u0001\u0000\u0000\u0000\u0000\u0017\u0001\u0000\u0000\u0000\u0000\u0019"+
		"\u0001\u0000\u0000\u0000\u0001\u001b\u0001\u0000\u0000\u0000\u0003\u001d"+
		"\u0001\u0000\u0000\u0000\u0005%\u0001\u0000\u0000\u0000\u0007(\u0001\u0000"+
		"\u0000\u0000\t*\u0001\u0000\u0000\u0000\u000b,\u0001\u0000\u0000\u0000"+
		"\r.\u0001\u0000\u0000\u0000\u000f0\u0001\u0000\u0000\u0000\u00112\u0001"+
		"\u0000\u0000\u0000\u00134\u0001\u0000\u0000\u0000\u0015<\u0001\u0000\u0000"+
		"\u0000\u0017O\u0001\u0000\u0000\u0000\u0019U\u0001\u0000\u0000\u0000\u001b"+
		"\u001c\u0005;\u0000\u0000\u001c\u0002\u0001\u0000\u0000\u0000\u001d\u001e"+
		"\u0005d\u0000\u0000\u001e\u001f\u0005i\u0000\u0000\u001f \u0005s\u0000"+
		"\u0000 !\u0005p\u0000\u0000!\"\u0005l\u0000\u0000\"#\u0005a\u0000\u0000"+
		"#$\u0005y\u0000\u0000$\u0004\u0001\u0000\u0000\u0000%&\u0005<\u0000\u0000"+
		"&\'\u0005=\u0000\u0000\'\u0006\u0001\u0000\u0000\u0000()\u0005(\u0000"+
		"\u0000)\b\u0001\u0000\u0000\u0000*+\u0005)\u0000\u0000+\n\u0001\u0000"+
		"\u0000\u0000,-\u0005*\u0000\u0000-\f\u0001\u0000\u0000\u0000./\u0005:"+
		"\u0000\u0000/\u000e\u0001\u0000\u0000\u000001\u0005+\u0000\u00001\u0010"+
		"\u0001\u0000\u0000\u000023\u0005-\u0000\u00003\u0012\u0001\u0000\u0000"+
		"\u000048\u0007\u0000\u0000\u000057\u0007\u0001\u0000\u000065\u0001\u0000"+
		"\u0000\u00007:\u0001\u0000\u0000\u000086\u0001\u0000\u0000\u000089\u0001"+
		"\u0000\u0000\u00009\u0014\u0001\u0000\u0000\u0000:8\u0001\u0000\u0000"+
		"\u0000;=\u0007\u0002\u0000\u0000<;\u0001\u0000\u0000\u0000=>\u0001\u0000"+
		"\u0000\u0000><\u0001\u0000\u0000\u0000>?\u0001\u0000\u0000\u0000?H\u0001"+
		"\u0000\u0000\u0000@B\u0005.\u0000\u0000AC\u0007\u0002\u0000\u0000BA\u0001"+
		"\u0000\u0000\u0000CD\u0001\u0000\u0000\u0000DB\u0001\u0000\u0000\u0000"+
		"DE\u0001\u0000\u0000\u0000EG\u0001\u0000\u0000\u0000F@\u0001\u0000\u0000"+
		"\u0000GJ\u0001\u0000\u0000\u0000HF\u0001\u0000\u0000\u0000HI\u0001\u0000"+
		"\u0000\u0000IL\u0001\u0000\u0000\u0000JH\u0001\u0000\u0000\u0000KM\u0005"+
		"i\u0000\u0000LK\u0001\u0000\u0000\u0000LM\u0001\u0000\u0000\u0000M\u0016"+
		"\u0001\u0000\u0000\u0000NP\u0007\u0003\u0000\u0000ON\u0001\u0000\u0000"+
		"\u0000PQ\u0001\u0000\u0000\u0000QO\u0001\u0000\u0000\u0000QR\u0001\u0000"+
		"\u0000\u0000RS\u0001\u0000\u0000\u0000ST\u0006\u000b\u0000\u0000T\u0018"+
		"\u0001\u0000\u0000\u0000UV\u0005*\u0000\u0000VW\u0005C\u0000\u0000WX\u0005"+
		"O\u0000\u0000XY\u0005M\u0000\u0000YZ\u0005*\u0000\u0000Z^\u0001\u0000"+
		"\u0000\u0000[]\b\u0004\u0000\u0000\\[\u0001\u0000\u0000\u0000]`\u0001"+
		"\u0000\u0000\u0000^\\\u0001\u0000\u0000\u0000^_\u0001\u0000\u0000\u0000"+
		"_a\u0001\u0000\u0000\u0000`^\u0001\u0000\u0000\u0000ab\u0006\f\u0000\u0000"+
		"b\u001a\u0001\u0000\u0000\u0000\b\u00008>DHLQ^\u0001\u0006\u0000\u0000";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}