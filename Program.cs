
public class Ejercicios{

    public static void Main(string[] args){
        Ejercicio();
        Poligono();
        GradosRadianes();
        CambiodeDolares();
        //----------- ejercicio de numero par
        System.Console.WriteLine("Ingrese un numero: ");
        int num = Convert.ToInt32(Console.ReadLine());
        NumerosPar(num);

        //----- Ejercicio del dia de la semana
        System.Console.WriteLine("Ingrese un numero del 1 al 7: ");
        int opcion = Convert.ToInt32(Console.ReadLine());
        Semana(opcion);
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

    public static void CambiodeDolares(){
        float dolar = 50.00f;
        float euro = 0.92f;
        float convert = dolar * euro;
        System.Console.WriteLine($"la cantidad del {dolar} en euro es: {convert}");
    }

    public static void NumerosPar(int num){
        if(num %2==0){
            System.Console.WriteLine( "Numero Par");
        }
        else{
            System.Console.WriteLine("Numero Impar");
        }
    }

    public static void Semana(int opcion){
        switch(opcion){
            case 1:
                System.Console.WriteLine("Lunes");
                break;
            case 2:
                System.Console.WriteLine("Martes");
                break;
            case 3:
                System.Console.WriteLine("Miercoles");
                break;
            case 4:
                System.Console.WriteLine("Jueves");
                break;
            case 5:
                System.Console.WriteLine("Viernes");
                break;
            case 6:
                System.Console.WriteLine("Sabado");
                break;
            case 7:
                System.Console.WriteLine("Domingo");
                break;
            default:
                System.Console.WriteLine("Opcion no valida");
                break;
        }
    }

}

