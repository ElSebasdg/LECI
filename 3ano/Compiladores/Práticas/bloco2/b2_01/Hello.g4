
grammar Hello;

greetings: (hello | bye) ( EOF | greetings );
hello: 'hello' ID+ ;
bye: 'bye' ID+ ;
ID : [a-zA-Z]+;
WS : [ \t\r\n]+ -> skip ;

