package domain;

public class Empleado {
    private String nombre;
    private String documento;
    private String domicilio;

    public Empleado(String nombre, String documento, String domicilio) {
        this.nombre = nombre;
        this.documento = documento;
        this.domicilio = domicilio;
    }

    public String getNombre() {
        return nombre;
    }
}
