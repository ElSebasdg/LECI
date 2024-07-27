grammar BigIntCalc;

program: statement* EOF;

statement:	showStmt ';'
		|	assignStmt ';'
		;


showStmt: 'show' expr;
assignStmt: expr '->' VAR;

expr: '(' expr ')'
	|  op = ('+' | '-') expr
	| expr op='*' expr
	| expr 'mod' expr
	| expr 'div' expr
	| expr op=('+'|'-') expr
	| VAR
	| NUM
	;

VAR: [a-zA-Z_][a-zA-Z0-9_]*;
NUM: [0-9]+;

WS: [ \t\r\n]+ -> skip;
COMMENT: '#' ~[\r\n]* -> skip;