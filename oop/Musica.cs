namespace learning_dot_net.oop;

public class Musica
{
    public string nomeMusica;
    public bool disponivel;
    public float duracao;

    public override string ToString()
    {
        return $"Nome da música: {nomeMusica}. Disponível = {disponivel}, duração da música: " +
               $"{duracao}"; 
    }
}