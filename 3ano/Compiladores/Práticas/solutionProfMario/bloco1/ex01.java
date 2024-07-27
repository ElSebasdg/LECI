import java.util.Scanner;

public class ex01 {
    public static void main(String[] args) {
        double int1, int2, result = 0;
        String op;
        
        Scanner sc = new Scanner(System.in);

        System.out.println("Insira a sua conta no seguinte formato:  numero operador numero");
        
        while(true) {
            try {
                String[] simbolos = sc.nextLine().split(" ");
                int1 = Double.parseDouble(simbolos[0]);
                op = simbolos[1];
                int2 = Double.parseDouble(simbolos[2]);
    
                switch(op) {
                    case "+": 
                            result = int1 + int2;
                            break;
    
                    case "-":
                            result = int1 - int2;
                            break;
    
                    case "*":
                            result = int1 * int2;
                            break;
                    
                    case "/":
                            result = int1 / int2;
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
}