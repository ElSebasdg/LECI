grammar LangComplex;

program: statement* EOF;

statement: displayStmt ';'
        | assigStmt ';'
        ;

displayStmt: 'display' expr;
assigStmt: VAR '<=' expr;

expr: '(' expr ')'
    | expr op=('*' | ':') expr
    | expr op=('+' | '-') expr
    | op=('+' | '-') expr
    | VAR
    | NUM
    ;

VAR: [a-zA-Z_][a-zA-Z0-9_]*;
NUM: [0-9]+('.'[0-9]+)*'i'?;

WS: [ \t\r\n]+ -> skip;
COMMENT: '*COM*' ~[\r\n]* -> skip;