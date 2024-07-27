grammar SetCalc;

main: stat* EOF;
stat: expr;
expr: e1=expr '\\' e2=expr  #ExprSubtract
    | e1=expr '&' e2=expr   #ExprIntercept
    | e1=expr '+' e2=expr   #ExprUnion
    | '(' e=expr ')'        #ExprParen
    | set                   #ExprSet
    | VAR '=' e=expr        #ExprAssign
    | VAR                   #ExprVar
    ;
set: '{' (elem (',' elem)*)? '}';
elem: WORD | NUM;
WORD: [a-z]+;
NUM: [-+]?[0-9]+;
VAR: [A-Z]+;
COMMENT: '--' .*? '\n' -> skip;
WS: [ \t\r\n]+ -> skip;
ERROR: .; // to convert all lexer errors to parser errors!
