// LoggerTest.java
public class LoggerTest {
    public static void main(String[] args) {
        // Retrieve logger instances
        Logger logger1 = Logger.getInstance();
        Logger logger2 = Logger.getInstance();

        // Logging messages
        logger1.log("This is the first log message.");
        logger2.log("This is the second log message.");

        // Verifying that both instances are the same
        if (logger1 == logger2) {
            System.out.println("Both logger1 and logger2 refer to the same instance.");
        } else {
            System.out.println("logger1 and logger2 are different instances.");
        }
    }
}
