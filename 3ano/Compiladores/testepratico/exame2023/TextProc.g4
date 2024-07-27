grammar TextProc;

main: (stat ';')*? EOF;

stat: output | assignment;

output: 'output' expr;

assignment: VAR '=' expr;

expr: 
      expr '|' '+' expr              #exprConcat
    | expr '|' 'replace' expr expr   #exprReplace
    | expr '|' 'grep' expr            #exprGrep
    | '(' expr ')'          #exprBraces
    | 'input' expr          #exprUserInput
    | '<' expr              #exprFileInput
    | '>' expr              #exprFileOutput
    | VAR                   #exprVAR
    | STR                   #exprSTR
    | NL                    #exprNL
    | ShitySTR              #exprShitySTR
    ;

NL: 'nl'|'NL'|'nL'|'Nl';
VAR: '$'[a-zA-Z1-9]+;
STR: '"' .*? '"';
ShitySTR: [a-zA-Z1-9]+;
WS: [\r\t\n ] -> Skip;
Comment: '#' .*? '\n' -> Skip;
ERROR: . ;
