import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.LocalTime;
import java.time.format.DateTimeFormatter;
import java.util.Scanner;

public class DateTimeOperations {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        DateTimeFormatter dateFormatter = DateTimeFormatter.ofPattern("dd-MM-yyyy");
        DateTimeFormatter timeFormatter = DateTimeFormatter.ofPattern("HH:mm:ss");
        DateTimeFormatter dateTimeFormatter = DateTimeFormatter.ofPattern("dd-MM-yyyy HH:mm:ss");

        System.out.println("Выберите тип операции:");
        System.out.println("1. Прибавить дни/месяцы/часы/минуты");
        System.out.println("2. Вычесть дни/месяцы/часы/минуты");
        int operationType = scanner.nextInt();

        System.out.println("Выберите объект для операции:");
        System.out.println("1. Дата");
        System.out.println("2. Время");
        System.out.println("3. Дата и время");
        int objectType = scanner.nextInt();

        // Получаем текущую дату, время и дату-время
        // LocalDate currentDate = LocalDate.now();
        // LocalTime currentTime = LocalTime.now();
        // LocalDateTime currentDateTime = LocalDateTime.now();

        // System.out.println("Текущая дата: " + currentDate);
        // System.out.println("Текущее время: " + currentTime);
        // System.out.println("Текущее дата и время: " + currentDateTime);

        if (objectType == 1) {
            // Операции с датой
            LocalDate date = LocalDate.now();
            System.out.println("Текущая дата: " + date.format(dateFormatter));

            if (operationType == 1) {
                System.out.println("Введите количество дней для прибавления:");
                int days = scanner.nextInt();

                System.out.println("Введите количество месяцев для прибавления:");
                int months = scanner.nextInt();

                LocalDate newDate = date.plusDays(days).plusMonths(months);
                System.out.println("Новая дата: " + newDate.format(dateFormatter));
            } else {
                System.out.println("Введите количество дней для вычитания:");
                int days = scanner.nextInt();

                System.out.println("Введите количество месяцев для вычитания:");
                int months = scanner.nextInt();

                LocalDate newDate = date.minusDays(days).minusMonths(months);
                System.out.println("Новая дата: " + newDate.format(dateFormatter));
            }

        } else if (objectType == 2) {
            // Операции со временем
            LocalTime time = LocalTime.now();
            System.out.println("Текущее время: " + time.format(timeFormatter));

            if (operationType == 1) {
                System.out.println("Введите количество часов для прибавления:");
                int hours = scanner.nextInt();

                System.out.println("Введите количество минут для прибавления:");
                int minutes = scanner.nextInt();

                LocalTime newTime = time.plusHours(hours).plusMinutes(minutes);
                System.out.println("Новое время: " + newTime.format(timeFormatter));
            } else {
                System.out.println("Введите количество часов для вычитания:");
                int hours = scanner.nextInt();

                System.out.println("Введите количество минут для вычитания:");
                int minutes = scanner.nextInt();

                LocalTime newTime = time.minusHours(hours).minusMinutes(minutes);
                System.out.println("Новое время: " + newTime.format(timeFormatter));
            }

        } else if (objectType == 3) {
            // Операции с датой и временем
            LocalDateTime dateTime = LocalDateTime.now();
            System.out.println("Текущие дата и время: " + dateTime.format(dateTimeFormatter));

            if (operationType == 1) {
                System.out.println("Введите количество дней для прибавления:");
                int days = scanner.nextInt();

                System.out.println("Введите количество месяцев для прибавления:");
                int months = scanner.nextInt();

                System.out.println("Введите количество часов для прибавления:");
                int hours = scanner.nextInt();

                System.out.println("Введите количество минут для прибавления:");
                int minutes = scanner.nextInt();

                LocalDateTime newDateTime = dateTime.plusDays(days).plusMonths(months).plusHours(hours).plusMinutes(minutes);
                System.out.println("Новые дата и время: " + newDateTime.format(dateTimeFormatter));
            } else {
                System.out.println("Введите количество дней для вычитания:");
                int days = scanner.nextInt();

                System.out.println("Введите количество месяцев для вычитания:");
                int months = scanner.nextInt();

                System.out.println("Введите количество часов для вычитания:");
                int hours = scanner.nextInt();

                System.out.println("Введите количество минут для вычитания:");
                int minutes = scanner.nextInt();

                LocalDateTime newDateTime = dateTime.minusDays(days).minusMonths(months).minusHours(hours).minusMinutes(minutes);
                System.out.println("Новые дата и время: " + newDateTime.format(dateTimeFormatter));
            }
        }

       // Ввод и разбор даты
       scanner.nextLine(); // consume the newline
       System.out.println("Введите дату в формате 'dd-MM-yyyy':");
       String dateString = scanner.nextLine();
       if (dateString != null && !dateString.trim().isEmpty()) {
           try {
               LocalDate parsedDate = LocalDate.parse(dateString, dateFormatter);
               System.out.println("Преобразованная дата: " + parsedDate);
           } catch (Exception e) {
               System.out.println("Ошибка: Некорректный формат даты.");
           }
       } else {
           System.out.println("Ошибка: Дата не может быть пустой.");
       }

       // Ввод и разбор даты и времени
       System.out.println("Введите дату и время в формате 'dd-MM-yyyy HH:mm:ss':");
       String dateTimeString = scanner.nextLine();
       if (dateTimeString != null && !dateTimeString.trim().isEmpty()) {
           try {
               LocalDateTime parsedDateTime = LocalDateTime.parse(dateTimeString, dateTimeFormatter);
               System.out.println("Преобразованные дата и время: " + parsedDateTime);
           } catch (Exception e) {
               System.out.println("Ошибка: Некорректный формат даты и времени.");
           }
       } else {
           System.out.println("Ошибка: Дата и время не могут быть пустыми.");
       }

        scanner.close();
    }
}