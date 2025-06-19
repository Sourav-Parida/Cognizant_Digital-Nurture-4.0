import java.util.Scanner;

public class FinancialForecast {

    // Recursive method
    public static double futureValue(double principal, double rate, int years) {
        if (years == 0) {
            return principal;
        }
        return futureValue(principal, rate, years - 1) * (1 + rate);
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Input
        System.out.print("Enter the initial amount (principal): ");
        double principal = scanner.nextDouble();

        System.out.print("Enter the annual growth rate (in %, e.g., 5 for 5%): ");
        double ratePercent = scanner.nextDouble();
        double rate = ratePercent / 100;

        System.out.print("Enter the number of years to forecast: ");
        int years = scanner.nextInt();

        // recursive function implementation
        double result = futureValue(principal, rate, years);

        // Output 
        System.out.printf("Future value after %d years: %.2f%n", years, result);

        scanner.close();
    }
}
