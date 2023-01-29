
public class Ejercicios{

    public static void Main(string[] args){
        Ejercicio();
        Poligono();
    }

    public static void Ejercicio(){
        //Ejercicio 1
        System.Console.WriteLine("Greilyn Polanco Tejada");
        //Ejercicio 5
        System.Console.WriteLine("Me gusta la pasta mucho");
    }

    public static void Poligono(){
        int Sides = 8;
        int Longitudes = 4;
        int Perimeters = Sides * Longitudes;
        System.Console.WriteLine("La longitud del perimetor es: " + Perimeters);
    }
}

