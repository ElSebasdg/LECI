grammar Calculator;

program:
     stat* EOF
   ;

stat:
     NEWLINE                      #StatEmpty
   | expr NEWLINE                 #StatExpr
   | assignment NEWLINE           #StatAssignment
   ;

assignment: ID '=' expr;

expr:
     op=('+'|'-') expr            #ExprUnary
   | expr op=('*'|'/'|'%') expr   #ExprMultDivMod
   | expr op=('+'|'-') expr       #ExprAddSub
   | Integer                      #ExprInteger
   | ID                           #ExprId
   | '(' expr ')'                 #ExprParent
   ;

Integer: [0-9]+;  // implement with long integers
ID: [a-zA-Z_]+;
NEWLINE: '\r'? '\n';
WS: [ \t]+ -> skip;
COMMENT: '#' .*? '\n' -> skip;