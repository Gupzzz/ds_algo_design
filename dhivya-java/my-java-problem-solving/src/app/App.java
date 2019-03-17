package app;

public class App {
    public static void main(String[] args) throws Exception {
        App app = new App();

        // app.FibonacciM();

        app.PrimeNumbersM();

    }

    public void PrimeNumbersM(){
        PrimeNumbersC primeNumbersC = new PrimeNumbersC();
        int number = 15;
        System.out.println("Prime number or not.\n" + number + " : " + primeNumbersC.IsPrimeNumber(number)); 
    }

    public void FibonacciM(){
        FibonacciC fibonacciC = new FibonacciC();
        System.out.println(fibonacciC.NthFibonacciValue(5));
    }
}