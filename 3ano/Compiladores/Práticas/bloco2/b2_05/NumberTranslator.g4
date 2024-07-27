grammar NumberTranslator;

program:
        stat* EOF
    ;

stat:
        NUM '-' NAME NEWLINE
    ;

NUM: [0-9]+;
NAME: [a-zA-Z]+;
NEWLINE: '\r'? '\n';
WS: [ \t]+ -> skip;