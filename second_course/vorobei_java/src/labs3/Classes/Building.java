import java.time.LocalDateTime;


public class Building {
	
	private float cost;
	private float height;
	private float width;
	private String name;
	
	
	public Building(String name, float height, float width, float cost) {
		this.cost = cost;
		this.name = name;
		this.height = height;
		this.width = width;
	}
	
	public Building() {
		this.cost = 100;
		this.name = "Объект";
		this.height = 400;
		this.width = 200;
	}
	
	
	public float getFrontSquare() {
		return this.width * this.height;
	}
	
	public float costForAOneSquare() {
		return this.getFrontSquare() / this.cost;
	}
	
	public void changeBuildingHeigth(float newHeight) {
		this.cost *= newHeight / this.height;
		this.height = newHeight;
	}
	
}