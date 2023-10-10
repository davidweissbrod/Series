public class Temporadas{
    public int IdTemporada {get; set;}
    public int IdSerie {get; set;}
    public int NumeroTemporada {get; set;}
    public string TituloTemporada {get; set;}

    public Temporadas(int idTem, int idSer, int numTem, string titTem){
        IdTemporada = idTem;
        IdSerie = idSer;
        NumeroTemporada = numTem;
        TituloTemporada = titTem;
    }
}