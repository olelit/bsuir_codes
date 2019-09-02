import java.time.LocalDateTime;

public class Person {

    private String name;
    private String surname;
    private LocalDateTime datetime;

    public Person(String name, String surname, LocalDateTime datetime){
        this.name = name;
        this.surname = surname;
        this.datetime = datetime;
    }

    public Person(){
        this.name = "Артем";
        this.surname = "Перинеев";
        this.datetime = LocalDateTime.now();
    }

    public String getName() {
        return name;
    }

    public String getSurname() {
        return surname;
    }

    public LocalDateTime getDatetime() {
        return datetime;
    }

    public void setDatetime(LocalDateTime datetime) {
        this.datetime = datetime;
    }

    public void setDate(int value){
        this.datetime.withYear(value);
    }

    public void setMount(int value){
        this.datetime.withMonth(value);
    }

    public int getDay(){
        return this.datetime.getDayOfMonth();
    }

    public int getYear(){
        return this.datetime.getYear();
    }

    public int getMonth(){
        return this.datetime.getMonthValue();
    }

    public void setDay(int value){
        this.datetime.withDayOfMonth(value);
    }

    public String toShortString(){
        return this.name + " "+ this.surname;
    }

    @Override
    public String toString() {
        return this.name + " "+ this.surname + " " + this.datetime;
    }
}
