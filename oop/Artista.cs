namespace learning_dot_net.oop;

public class Artista
{
    public string nomeArtista;
    public int idadeArtista;
    public string generoMusicalArtista;
    public bool isAposentado;
    public List<Musica> musicas = new();

    public override string ToString()
    {
        return $"Nome do artista: {nomeArtista}, idade: {idadeArtista}, genero musical:" +
               $" {generoMusicalArtista} {string.Join(", ", musicas)}";
    }

    public bool AdicionarMusica(Musica newMusic)
    {
        bool isSuccess;
        if (isAposentado)
        {
            isSuccess = false;
        }
        else
        {
            musicas.Add(newMusic);
            isSuccess = true;
        }

        return isSuccess;
    }

    public List<Musica> ListarMusicas()
    {
        return musicas;
    }
}