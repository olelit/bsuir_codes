package labs1;

import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.List;

public class Student {
    private Person data;
    private Education education;
    private int group;
    private ArrayList<Exam> exams;

    public Student() {
        this.data = new Person();
        this.education = Education.Specialist;
        this.group = 0;
        this.exams = new ArrayList<Exam>();
    }

    public Student(Person data, Education education, int group) {
        this.data = data;
        this.education = education;
        this.group = group;
    }

    public Person getData() {
        return data;
    }

    public void setData(Person data) {
        this.data = data;
    }

    public Education getEducation() {
        return education;
    }

    public void setEducation(Education education) {
        this.education = education;
    }

    public int getGroup() {
        return group;
    }

    public void setGroup(int group) {
        this.group = group;
    }

    public ArrayList<Exam> getExams() {
        return exams;
    }

    public void setExams(ArrayList<Exam> exams) {
        this.exams = exams;
    }

    public double getAvg() {
        int sum = 0;
        for(Exam x : exams) sum += x.getMark();
        return sum / (exams.size() ==  0 ? 1 : exams.size());
    }

    public boolean index(Education e) {
        return e == this.education;
    }

    public void AddExams(ArrayList<Exam> e) {
        this.exams.addAll(e);
    }

    @Override
    public String toString() {
        // Todo: exams
        return String.format("{0} {1} {2} {3}", this.getData(), this.getEducation(), this.getGroup(), "TODO");
    }

    public String toShortString() {
        return String.format("{0} {1} {2} {3}", this.getData(), this.getEducation(), this.getGroup(), this.getAvg());
    }
}
