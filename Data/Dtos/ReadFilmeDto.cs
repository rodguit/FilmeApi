using System.Security.Cryptography.X509Certificates;

namespace FilmeApi.Data.Dtos
{
    public class ReadFilmeDto
    {
            public string Titulo { get; set; }
            public string Genero { get; set; }
            public string Duracao { get; set; }
            public DateTime HoraDaConsulta { get; set; } = DateTime.Now;
    }
    
    
}
        

        
    



   

    
    

