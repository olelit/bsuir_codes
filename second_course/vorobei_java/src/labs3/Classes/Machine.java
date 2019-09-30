package labs3.Classes;

public class Machine {
	
	private float weightBorder;
	private float speed;
	private float lifeCycle;
	private String company;
	
	
	public Machine(String company, float lifeCycle, float speed, float weightBorder) {
		this.company = company;
		this.speed = speed;
		this.lifeCycle = lifeCycle;
		this.weightBorder = weightBorder;
	}
	
	public Machine() {
		this.company = "DBS";
		this.speed = 100;
		this.lifeCycle = 5;
		this.weightBorder = 456;
	}
	
	public float getAllWeight() {
		return this.weightBorder * this.lifeCycle;
	}
	
	public Boolean isBetterInAllCharater(Machine anotherMachine) {
		Boolean isBetter = false;
		
		if(anotherMachine.speed > this.speed && anotherMachine.weightBorder > this.weightBorder) {
			isBetter = true;
		}
		
		return isBetter;
	}
	
	public void setCompany(String companyName) {
		this.company = companyName;
	}
	
}