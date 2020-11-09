package labs3.Classes;

public class WorkerMan{
	
	private String name;
	private int fullYearExpiriense;
	private float salary;
	private float pensionProcent;
	
	public WorkerMan() {
		this.name = "Неизвестно";
		this.fullYearExpiriense = 1;
		this.salary = 200;
		this.pensionProcent = 0.2f;
	}
	
	public WorkerMan(String name, int fullYearExpiriense, float salary, float pensionProcent) {
		this.name = name;
		this.fullYearExpiriense = this.fullYearExpiriense;
		this.salary = salary;
		this.pensionProcent = pensionProcent;
	}
	
	public float getPencionForYears(int years) {
		return (this.salary * this.pensionProcent) * (12 * years);
	}
	
	
	public void increaseSalary() {
		this.salary += this.salary * ((this.fullYearExpiriense * 10)/this.salary);
	}
	
	public float getSalary() {
		return this.salary - (this.salary * this.pensionProcent);
	}
	
	public void blackSalary() {
		this.pensionProcent = 0f;
	}
	
	
	
}