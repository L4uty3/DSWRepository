package views;

public class ComidaViewModel {
    private double carnivoros;
    private double herbivoros;

    public ComidaViewModel(double carnivoros, double herbivoros) {
        this.carnivoros = carnivoros;
        this.herbivoros = herbivoros;
    }

    public  double getTotal(){
        return carnivoros + herbivoros;
    }

    public double getCarnivoros() {
        return carnivoros;
    }

    public double getHerbivoros() {
        return herbivoros;
    }
}
