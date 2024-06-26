using ScreenSound.Banco;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuMostrarMusicasPorAno : Menu
{
    public override void Executar(DAL<Artista> artistaDAL)
    {
        base.Executar(artistaDAL);
        ExibirTituloDaOpcao("Exibir músicas por ano de lançamento");
        Console.Write("Digite o ano para consultar as músicas: ");
        int anoDeLancamento = Convert.ToInt32(Console.ReadLine())!;
        var musicaDAL = new DAL<Musica>(new ScreenSoundContext());
        var listaDeMusicas = musicaDAL.ListarPor(a => a.AnoLancamento == anoDeLancamento);
        if (listaDeMusicas.Any())
        {
            foreach (var musica in listaDeMusicas)
            {
                musica!.ExibirFichaTecnica();
            }
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nO ano {anoDeLancamento} não foi encontrado!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
