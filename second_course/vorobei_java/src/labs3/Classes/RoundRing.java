package labs3.Classes;

public class RoundRing {
	
	private float innerDiametr;
	private float outerDiametr;
	final float PI = 3.14f;
	
	public RoundRing(float innerDiametr, float outerDiametr) {
		this.innerDiametr = innerDiametr;
		this.outerDiametr = outerDiametr;	
	}
	
	public void increaseSize(int n) {
		this.innerDiametr *= n;
		this.outerDiametr *= n;
	}
	
	public void decreaseSize(int n) {
		this.innerDiametr /= n;
		this.outerDiametr /= n;
	}
		
	public float sqrtRound() {
		return (float)(2*PI*Math.pow(this.outerDiametr/2, 2));
	}
	
	public float mediumRadius() {
		return (this.innerDiametr + this.outerDiametr)/4;
		
	}
	
	public float findThickness() {
		return this.innerDiametr - this.outerDiametr;
	}
	
}
