package labs3;


import labs3.Classes.Building;
import labs3.Classes.Machine;
import labs3.Classes.RoundRing;
import labs3.Classes.WorkerMan;

class Main {
	
	public static void main(String[] args) {
		//Вариант 20: гражданское строительство
		Building building = new Building();
		Machine machine = new Machine();
		WorkerMan worker = new WorkerMan();
		
		RoundRing roundRing = new RoundRing(6,3);
		
		System.out.println(building.getFrontSquare());
		System.out.println(machine.getAllWeight());
		System.out.println(worker.getPencionForYears(5));
		
		System.out.println(roundRing.findThickness());
		roundRing.increaseSize(3);
		System.out.println(roundRing.findThickness());
		
	}
	
}