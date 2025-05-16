public class Palabra
{ 
    //Atributos
    public string PalabraIngresada { get; private set;}
    public int Contador { get; private set;}
    public List<string> ListaLetrasCorrectas { get; private set;}
    public List<string> ListaLetrasArriesgada { get; private set;}
     public List<string> ListaPalabrasCorrectas { get; private set;}

    //Constructor
    public Palabra (string PalabraIngresada, int Contador, List<string> ListaLetrasCorrectas, List<string> ListaLetrasArriesgada, List<string> ListaPalabrasCorrectas)
    {
        
        this.PalabraIngresada = PalabraIngresada;
        this.Contador = Contador;
        this.ListaLetrasCorrectas = new List<string> ();
        this.ListaLetrasArriesgada = new List<string> ();
        this.ListaPalabrasCorrectas = new List<string> ();
    }

    //Metodos
    public string InicializarPalabra()
    {
        ///TODO VA EN EL MODEL Y FALTA LA PARTE DE VERIFICAR
        string [] ListaPalabrasCorrectas = {"Escribo", "Estrella", "Brillante", "Onda", "Playa", "Color", "Rojo", "Feliz", "Sueño"};
        Random rnd = new Random ();
        int aleatorio = rnd.Next(ListaPalabrasCorrectas.Length);
        string palabraElegida = ListaPalabrasCorrectas[aleatorio];
        return palabraElegida;
    
    }
 
   public void VerificarPalabra(string palabraElegida)
    {
        if(PalabraIngresada == palabraElegida)
        {
            
            
        }
        else
        {
           
        }
    }


    public void VerificarLetra(string palabraElegida)
    {
        foreach (int x in ListaLetrasCorrectas)
        {
            if(ListaLetrasArriesgada[0] == palabraElegida[0].ToString()){

            }
        }
        
    }


    



}