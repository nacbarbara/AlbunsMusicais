using AlbunsMusicais.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbunsMusicais.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<Album> Albuns { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Albuns = new List<Album>()
            {
                new Album()
                {
                    Numero = 1,
                    NomeAlbum = "Nada como um dia após o outro dia",
                    Artista = "Racionais Mc's",
                    AnoLancamento = 2002,
                    Produtora = "Unimar Music",
                    Genero = { "Rap" },
                    Descricao = "Quinto álbum de estúdio do grupo brasileiro de rap, Racionais Mc's.",
                    Faixas = { "Sou mais você", "Vivão e vivendo", "Vida Loka intro", "Vida Loka", "Negro drama", "A vítima", "Na fé firmão", "12 de outubro", "Eu sou 157", "A vida é desafio", "1 por amor 2 por dinheiro" },
                    Capa = "img/NadaComoUmDia.jpeg"
                },
                new Album()
                {
                    Numero = 2,
                    NomeAlbum = "Ainda há tempo",
                    Artista = "Criolo",
                    AnoLancamento = 2006,
                    Produtora = "Oloko",
                    Genero = { "Rap", "Hip Hop" },
                    Descricao = "Álbum de estreia de Criolo.",
                    Faixas = { "É o teste", "Chuva ácida", "Tô pra ver (part. Rael)", "Breáco", "Até me emocionei", "Demorô", "Vasilhame", "Ainda há tempo" },
                    Capa = "img/aindahatempo.jpg"
                },
                new Album()
                {
                    Numero = 3,
                    NomeAlbum = "Infinito",
                    Artista = "Fresno",
                    AnoLancamento = 2012,
                    Produtora = "Tratore",
                    Genero = { "Rock Alternativo" },
                    Descricao = "Sexto álbum da banda.",
                    Faixas = { "Homem ao mar", "Infinito", "Maior que as muralhas", "O resto é nada mais (O sonho de um Visconde)", "Diga pt. 2", "Seis", "Cativeiro (Ana Cruse)", "Sobreviver e acreditar", "Sutjeska", "Farol", "Vida (Biografia em ré menor)" },
                    Capa = "img/infinito.jpg"
                },
                new Album()
                {
                    Numero = 4,
                    NomeAlbum = "AmarElo",
                    Artista = "Emicida",
                    AnoLancamento = 2019,
                    Produtora = "Laboratório Fantasma",
                    Genero = { "Rap", "Hip Hop" },
                    Descricao = "O show de lançamento do disco marcou uma das raríssimas passagens do rap no Theatro Municipal de São Paulo.",
                    Faixas = {  "Principia (part. Pastor Henrique Vieira, Fabiana Cozza & Pastoras do Rosário)", "A ordem natural das coisas (part. MC Tha)", "Pequenas alegrias da vida adulta", "Quem tem um amigo (tem tudo) (part. Tokyo Ska Paradise Orchestra e Os Prettos & Zeca Pagodinho)", "Paisagem", "Cananéia, Iguape e Ilha Comprida", "9nha (part. Drik Barbosa)", "Ismália (part. Larissa Luz & Fernanda Montenegro)", "Eminência parda (part. Dona Onete, Jé Santiago, Papillon)", "AmarElo (part. Majur e Pabllo Vittar)", "Libre (com Ibeyi)" },
                    Capa = "img/amarelo.jpg"
                },
                new Album()
                {
                    Numero = 2,
                    NomeAlbum = "",
                    Artista = "",
                    AnoLancamento = 2000,
                    Produtora = "",
                    Genero = { "" },
                    Descricao = "",
                    Faixas = { "" },
                    Capa = ""
                },
                new Album()
                {
                    Numero = 2,
                    NomeAlbum = "",
                    Artista = "",
                    AnoLancamento = 2000,
                    Produtora = "",
                    Genero = { "" },
                    Descricao = "",
                    Faixas = { "" },
                    Capa = ""
                }

            };
        }
    }
}
