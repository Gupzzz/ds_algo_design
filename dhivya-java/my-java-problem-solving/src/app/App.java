package app;

public class App {
    public static void main(String[] args) throws Exception {
        System.out.println("Welcome to java Dhivya");
        App app = new App();

        app.FibonacciM();
    }

    public void FibonacciM(){
        FibonacciC fibonacciC = new FibonacciC();
        System.out.println(fibonacciC.NthFibonacciValue(5));
    }
}