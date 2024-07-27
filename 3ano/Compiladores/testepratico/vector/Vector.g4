grammar Vector;

program: statement*;

statement: showStmt ';'
         | assignmentStmt ';'
         ;

showStmt: 'show' expr? ;

assignmentStmt: expr '->' VAR ;


expr:    '(' expr ')'
        |op=('+'|'-') expr
        |expr op=('+'|'-') expr
        |expr op=('*'|'.') expr
        | vector
        | VAR 
        | NUM
        ;

vector: '[' NUM (',' NUM)* ']';

VAR: [a-zA-Z_][a-zA-Z0-9_]*;
NUM: [0-9]+('.'[0-9]+)?;

WS: [ \t\r\n]+ -> skip;
COMMENT: '#' ~[\r\n]* -> skip;
