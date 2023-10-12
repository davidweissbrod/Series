using Dapper;
using System.Data.SqlClient;

public class BD{
    private static string _connectionString = @"Server=localhost; DataBase=TP10.scriptBDSeries; Trusted_Connection = True;";
    private static List<Serie> listaSeries = new List<Serie>();
    private static List<Actores> listaActores = new List<Actores>();
    private static List<Temporadas> listaTemporadas = new List<Temporadas>();
    public static List<Serie> LevantarSeries(){
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Series";
            listaSeries = db.Query<Serie>(sql).ToList();
        }
        return listaSeries;
    }

    public static List<Actores> LevantarActores(){
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Actores";
            listaActores = db.Query<Actores>(sql).ToList();
        }
        return listaActores;
    }

    public static List<Temporadas> LevantarTemporadas(){
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Temporadas";
            listaTemporadas = db.Query<Temporadas>(sql).ToList();
        }
        return listaTemporadas;
    }
}