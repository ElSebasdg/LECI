grammar QuestionBD;

file: question* EOF;

question: ID '(' STRING ')' '{' answer* '}';

answer: STRING ':' INTEGER ';';

INTEGER: [0-9]+;
STRING: '"' .*? '"';
ID: [a-zA-Z0-9.]+;

COMMENT: '#' .*? '\n' -> skip;
WS: [ \t\n\r]+ -> skip;

