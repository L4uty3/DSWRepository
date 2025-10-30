package views;

import data.Persistencia;
import domain.*;

import java.util.ArrayList;
import java.util.InvalidPropertiesFormatException;
import java.util.List;

public class Controlador {
    private static ArrayList<Mamifero> animales = new ArrayList<>();
    private static ArrayList<Sector> sectores = new ArrayList<>();
    private static ArrayList<Especie> especies = new ArrayList<>();
    private static ArrayList<Pais> paises = new ArrayList<>();
    
    
    
    public static TipoAlimentacion[] getTiposAlimentacion(){
        return  TipoAlimentacion.values();
    }
    public static ArrayList<Especie> getEspecies(){
        return Persistencia.getEspecies();
    }
    public static ArrayList<Sector> getSectores(){
        return Persistencia.getSectores();
    }
    public static ArrayList<Pais> getPaises(){
        return Persistencia.getPaises();
    }
    
    public static ArrayList<AnimalViewModel> getAnimales(){
        ArrayList<AnimalViewModel> animales = new ArrayList<>();
        for(Mamifero animal : Persistencia.getAnimales()){
            animales.add(new AnimalViewModel(animal));
        }
        return animales;
    }
    
    public static ComidaViewModel  calcularComida(){
        double totalCarnivoros = Persistencia.getTotalComida(TipoAlimentacion.CARNIVORO);
        double totalHerbivoros = Persistencia.getTotalComida(TipoAlimentacion.HERBIVORO);
        return new ComidaViewModel(totalCarnivoros, totalHerbivoros);
    }
    
    public static void setViewMenuTrue(){
        if(v == null || !v.isDisplayable()){
            views.Menu v = new views.Menu();  
            v.setVisible(true);
        }else if (v.isVisible()){
            v.setVisible(false);
        }else{
            v.setVisible(true);
        }
    }
    
    public static void setViewListarTrue(){
        if(v == null || !v.isDisplayable()){
            views.ListarAnimalesView v = new views.ListarAnimalesView();
            v.setDefaultCloseOperation(javax.swing.JFrame.DISPOSE_ON_CLOSE);
            
            v.setVisible(true);
        }else if (v.isVisible()){
            v.setVisible(false);
        }else{
            v.setVisible(true);
        }
    }
    
    private static views.Menu v = null;
    
    public static void setViewAgregar(){
        if(v == null || !v.isDisplayable()){
            views.Agregar v = new views.Agregar();
            v.setDefaultCloseOperation(javax.swing.JFrame.DISPOSE_ON_CLOSE);
            v.setVisible(true);
        }else if (v.isVisible()){
            v.setVisible(false);
        }else{
            v.setVisible(true);
        }
    }
    
    
    
    
    
    public static void agregarCarnivoro(String nombreEspecie, String nombrePais, int numeroSector, double peso, int edad) throws InvalidPropertiesFormatException{
        for(Especie especie : getEspecies()){
            if(especie.getNombre().equals(nombreEspecie)){
                for(Sector sector : getSectores()){
                    if(sector.getNumero() == numeroSector){
                        for(Pais pais : getPaises()){
                            if(pais.getNombre().equals(nombrePais)){
                                Persistencia.agregarCarnivoro(edad, peso, especie, sector, pais);
                                break;
                            }                           
                        }
                    }
                }
            }
        }
    }
    
    public static void agregarHerbivoro(int numeroSector, double peso, String nombreEspecie, int edad, double valorFijo, String nombrePais) throws InvalidPropertiesFormatException{
        for(Especie especie : getEspecies()){
            if(especie.getNombre().equals(nombreEspecie)){
                for(Sector sector : getSectores()){
                    if(sector.getNumero() == numeroSector){
                        for(Pais pais : getPaises()){
                            if(pais.getNombre().equals(nombrePais)){  
                                Persistencia.agregarHerbivoro(edad, peso, especie, sector, valorFijo, pais);
                                break;
                            }    
                        } 
                    }
                }
                
                
            }
        }
    }
   
    
}


