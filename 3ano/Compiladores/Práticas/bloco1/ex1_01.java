import java.util.Scanner;

public class ex1_01 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double n1, n2, result = 0;
        String op;


        System.out.println("Insira a sua conta no seguinte formato:  numero operador numero");

            try{

                String[] tokens = sc.nextLine().split(" ");
                n1 = Double.parseDouble(tokens[0]);
                op = tokens[1];
                n2 = Double.parseDouble(tokens[2]);
                
                switch(op) {
                    case "+": 
                            result = n1 + n2;
                            break;

                    case "-":
                            result = n1 - n2;
                            break;

                    case "*":
                            result = n1 * n2;
                            break;
                    
                    case "/":
                            result = n1 / n2;
                            break;
                    default:
                            System.err.println("Invalid operator");
                }

                System.out.println("Result: " + result);

            } catch(NumberFormatException e) {
                System.out.println("Operators must be a number");
                sc.close();
            } catch(ArrayIndexOutOfBoundsException e) {
                System.err.println("Incorrect number of inputs <num> <operator> <num>");
                sc.close();      
            }

    }
}
