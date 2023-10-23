import java.io.BufferedReader;
import java.io.FileReader;
 
public class Main {
 
  public static void main(String[] args) {

    try {

      String fileName = "jflex_test.txt";

      BufferedReader buffer = new BufferedReader(new FileReader(fileName));
      CustomLexer customLexer = new CustomLexer(buffer);

      while(true) {

        CustomYytoken token = customLexer.yylex();

        if (token == null)
          break;

        System.out.println(token.toString());
      }
    }
    catch (Exception e) {
      System.out.println(e.toString());
    }
  }
}