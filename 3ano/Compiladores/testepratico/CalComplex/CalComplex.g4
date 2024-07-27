grammar CalComplex;

program: statement*;

statement: output ';'
        |  assignement ';'     
        ;     

output: 'output' expr;

assignement: expr '=>' VAR;

expr:       '(' expr ')' 
        |       input   
        |      expr op=('+' | '-') expr 
        |      expr op=(':'| '*') expr 
        |       '-'? NUM
        |       VAR
        ;

input: 'input' '"' VAR '"';
NUM: [0-9]+'i'?;
VAR: [a-zA-Z0-9_]+;
WS: [ \n\t\r] -> skip;
Comment: '**' .*? '\n' -> skip;
