public class Actores{
    public int IdActor {get; set;}
    public int IdSerie{get; set;}
    public string Nombre{get; set;}

    public Actores(int idAct, int idSer, string nom){
        IdActor = idAct;
        IdSerie = idSer;
        Nombre = nom;
    }
}