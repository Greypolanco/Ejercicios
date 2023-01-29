
public class Ejercicios{

    public static void Main(string[] args){
        Ejercicio();
        Poligono();
        GradosRadianes();
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

    public static void GradosRadianes(){
        float pi = 3.1416f;
        float Degrees = 35;
        float convert = (Degrees * pi)/180;
        System.Console.WriteLine($"Los grados {Degrees} a Radianes es: {convert}");
    }
}

