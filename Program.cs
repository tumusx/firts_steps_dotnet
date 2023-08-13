using learning_dot_net.oop;

Musica musica1 = new Musica();
musica1.nomeMusica = "Ô Sol";

Musica musica2 = new Musica();
musica2.nomeMusica = "Sei tudo";
Artista artista = new Artista();
artista.idadeArtista = 21;
artista.nomeArtista = "Murillo Alves";
artista.generoMusicalArtista = "MPB";
artista.isAposentado = false;
List<Musica> musicas = new List<Musica>();
musicas.Add(musica1);
musicas.Add(musica2);
artista.AdicionarMusica(musica1);
artista.AdicionarMusica(musica2);
Console.WriteLine(artista);