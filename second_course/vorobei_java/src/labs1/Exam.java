package labs1;

import java.time.LocalDateTime;

public class Exam {
    private String name;
    private int mark;
    private LocalDateTime date;

    public Exam() {
        this.name = "";
        this.mark = 0;
        this.date = null;
    }

    public Exam(String name, int mark, LocalDateTime date) {
        this.name = name;
        this.mark = mark;
        this.date = date;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getMark() {
        return mark;
    }

    public void setMark(int mark) {
        this.mark = mark;
    }

    public LocalDateTime getDate() {
        return date;
    }

    public void setDate(LocalDateTime date) {
        this.date = date;
    }

    @Override
    public String toString() {
        return String.format("{0} {1} {2}", this.getName(), this.getMark(), this.getDate());
    }
}
