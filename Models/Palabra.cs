public class Palabra
{ 
    //Atributos
    public string PalabraIngresada { get; private set;}
    public string NombrePalabra { get; private set;}
    public int Contador { get; private set;}
    public List<char> ListaLetrasArriesgada { get; private set;}
    public List<string> ListaPalabrasCorrectas { get; private set;}

    //Constructor
    public Palabra (string PalabraIngresada, string NombrePalabra, int Contador, List<char> ListaLetrasArriesgada, List<string> ListaPalabrasCorrectas)
    {
        
        this.PalabraIngresada = PalabraIngresada;
        this.NombrePalabra = NombrePalabra;
        this.Contador = Contador;
        this.ListaLetrasArriesgada = new List<char> ();
        this.ListaPalabrasCorrectas = new List<string> ();
    }

    //Metodos
    public void InicializarPalabra()
    {
        //TODO VA EN EL MODEL Y FALTA LA PARTE DE VERIFICAR
        string [] ListaPalabrasCorrectas = {"Escribo", "Estrella", "Brillante", "Onda", "Playa", "Color", "Rojo", "Feliz", "Sueño"};
        Random rnd = new Random ();
        int aleatorio = rnd.Next(ListaPalabrasCorrectas.Length);
        string palabraElegida = ListaPalabrasCorrectas[aleatorio];
        NombrePalabra = palabraElegida;
    
        
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


    public void VerificarLetra()
    {
        string letraEncontrada = null;
//Hay que concatenar, con un string, +=
        char []AdivinaPalabra = new char[NombrePalabra.Length];
       /* for(int x = 0; x < AdivinaPalabra.Length; x++)
        {
            AdivinaPalabra[x] = '_';
        }*/
//Recorremos la palabra
//Nos vamos fijando posicion por posicion, de la palabra , si la letra conincide con la letra ingresada
//Recorre la lista de letras arriesgadas, comparamos 
//Si la letra esta mostramos la letra, sino mostramos el _

        foreach (char i in NombrePalabra)
        {
            if (ListaLetrasArriesgada.Contains(NombrePalabra[i]))
            {

            }
        }
        foreach (char i in ListaLetrasArriesgada)
        {
            if()
            {

            }
                
            else
            {
                letraEncontrada = "_";
            }
        }

        
    }


    



}