public class Serie{
    public int IdSerie {get; set;}
    public string Nombre {get; set;}
    public int AñoInicio {get; set;}
    public string Sinopsis {get; set;}
    public string ImagenSerie {get; set;}

    public Serie(int idSer, string nom, int añoIn, string sinop, string imgSerie){
        IdSerie = idSer;
        Nombre = nom; 
        AñoInicio = añoIn;
        Sinopsis = sinop;
        ImagenSerie = imgSerie;
    }
}