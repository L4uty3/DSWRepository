package domain;

public enum TipoAlimentacion {
    CARNIVORO,
    HERBIVORO,
    OMNIVORO;

    public boolean esCarnivoro () {
        return this == CARNIVORO;
    }

    public boolean esHerbivoro(){
        return this == HERBIVORO;
    }
}
