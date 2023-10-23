%%
%public
%class CustomLexer
%{
    private int counter;
%}

%type CustomYytoken

%init{
    counter = 0;
%init}

%eof{
%eof}

%line

%char

/* Regular expresions */

    DIGIT = [0-9]
    NUMBER = {DIGIT} {DIGIT}*
    LETTER = [A-Za-z]
    WORD = {LETTER} {LETTER}*
    SYMBOL = "*"|"+"|"-"|"/"|"#"
    SPACE = " "
    NEWLINE = \n|\r|\r\n

%%

{NUMBER} {
    counter++;
    return new CustomYytoken(counter, yytext(), "NUMBER", yyline, yychar);
}
 
{WORD} {
    counter++;
    return new CustomYytoken(counter, yytext(), "WORD", yyline, yychar);
}
 
{SYMBOL} {
    counter++;
    return new CustomYytoken(counter, yytext(), "SYMBOL", yyline, yychar);
}
 
{SPACE} {
    // Ignore when it's a space
}
 
{NEWLINE} {
    counter++;
    return new CustomYytoken(counter, " ", "NEWLINE", yyline, yychar);
}