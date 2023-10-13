using Quiz.Models;

namespace Quiz;

public partial class MainPage : ContentPage
{
    public int _count = 0;
    public int pontuation = 0;
    public int qtdQuestion = 0;
    public MainPage()
    {
        InitializeComponent();
        Dados = AddQuestions();

    }

    private List<Information> Dados { get; set; }
    private void Start(object sender, EventArgs e)
    {
        Home.IsVisible = false;
        Perguntas.IsVisible = true;

        Pontos.IsVisible = true;

        ResultMapping();
    }

    private void ResultMapping()
    {
        if (qtdQuestion < Dados.Count)
        {
            LabelPergunta.Text = Dados[_count].Title;

            Random random = new Random();

            var listaEmbaralhada = Dados[_count].Options.OrderBy(x => random.Next()).ToList();

            Btn01.Text = listaEmbaralhada[0];

            Btn02.Text = listaEmbaralhada[1];

            Btn03.Text = listaEmbaralhada[2];

            Btn04.Text = listaEmbaralhada[3];

            Imagem.Source = Dados[_count].Image;

            listaEmbaralhada.Clear();
        }
        else
        {
            Perguntas.IsVisible = false;
            LayoutFinal.IsVisible = true;
            LabelFinal.Text = $"Total de acertos: {pontuation}";
        }
        qtdQuestion++;
    }

    private void Validation(object sender, EventArgs e)
    {
        string result = Dados[_count].Result;
        Button button = (Button)sender;


        if (button.Text == result)
        {
            button.BackgroundColor = Color.FromArgb("#00AB37");
            pontuation += 1;
            Btn01.IsEnabled = false;
            Btn02.IsEnabled = false;
            Btn03.IsEnabled = false;
            Btn04.IsEnabled = false;
        }
        else if (button.Text != result)
        {
            Btn01.IsEnabled = false;
            Btn02.IsEnabled = false;
            Btn03.IsEnabled = false;
            Btn04.IsEnabled = false;
            button.BackgroundColor = Color.FromArgb("#FF0000");
        }


        Pontos.Text = $"Pontuação: {pontuation}";
        Next.IsVisible = true;

    }
    private void NextQuestion(object sender, EventArgs e)
    {
        Next.IsVisible = false;

        Clear();

        Btn01.IsEnabled = true;

        Btn02.IsEnabled = true;

        Btn03.IsEnabled = true;

        Btn04.IsEnabled = true;

        _count += 1;

        ResultMapping();
    }

    private void ResetGame(object sender, EventArgs e)
    {
        Pontos.Text = "Pontuação: 0";

        LayoutFinal.IsVisible = false;

        Perguntas.IsVisible = true;

        _count = 0;

        pontuation = 0;

        qtdQuestion = 0;

        ResultMapping();
    }

    private void Clear()
    {

        Btn01.BackgroundColor = Color.FromArgb("#FFFFFF");
        Btn02.BackgroundColor = Color.FromArgb("#FFFFFF");
        Btn03.BackgroundColor = Color.FromArgb("#FFFFFF");
        Btn04.BackgroundColor = Color.FromArgb("#FFFFFF");

    }

    private List<Information> AddQuestions()
    {
        Question p1 = new Question();
        List<string> l1 = new List<string>() { "Java", "C#", "Python", "PHP" };
        Information dado1 = new Information("Qual linguagem foi criada em 2002?", l1, "C#", @"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT_iLs50Ddx1vg8YkWSw6If6p1fHlh5-OiUGctVBYW0&s");

        List<string> l2 = new List<string>() { "Brasil", "Japão", "Estados unidos", "Alemanha" };
        Information dado2 = new Information("Quem teve maior participação na 2 guerra mundial?", l2, "Estados unidos", @"https://cdn.pixabay.com/photo/2023/07/30/17/00/spider-web-8159315_1280.jpg");

        List<string> l3 = new List<string>() { "São Paulo", "Rio de Janeiro", "Brasília", "Salvador" };
        Information dado3 = new Information("Qual é a capital do Brasil?", l3, "Brasília", @"https://media.istockphoto.com/id/1488043800/pt/foto/beautiful-flower-growing-out-of-crack-in-asphalt-space-for-text-hope-concept.jpg?s=2048x2048&w=is&k=20&c=xKcoRGAWZuzDRcjSEhyRcV7Ep6LZ_o6cEbZm5hnZaac=");

        List<string> l4 = new List<string>() { "Machado de Assis", "Aluísio Azevedo", "José de Alencar", "Manuel Antônio de Almeida" };
        Information dado4 = new Information("Quem escreveu “Dom Casmurro”?", l4, "Machado de Assis", @"https://cdn.pixabay.com/photo/2023/10/08/14/49/ai-generated-8302263_1280.jpg");

        List<string> l5 = new List<string>() { "Dólar", "Euro", "Libra", "Iene" };
        Information dado5 = new Information("Qual é a moeda oficial do Japão?", l5, "Iene", @"https://cdn.pixabay.com/photo/2013/03/02/02/41/alley-89197_1280.jpg");

        List<string> l6 = new List<string>() { "1965", "1975", "1971 ", "1969" };
        Information dado6 = new Information("Em que ano Neil Armstrong pisou na lua?", l6, "1969", @"https://media.istockphoto.com/id/1219849120/pt/foto/dark-and-eerie-urban-city-alley-at-night.jpg?s=2048x2048&w=is&k=20&c=PDe64R6FYOlA8126AuqFbXqep_lyg3UUonIKhRI2Hgs=");

        List<string> l7 = new List<string>() { "Michelangelo", "Leonardo da Vinci", "Rafael Sanzio", "Donatello" };
        Information dado7 = new Information("Quem pintou a “Mona Lisa”?", l7, "Leonardo da Vinci", @"https://cdn.pixabay.com/photo/2016/11/25/23/15/moon-1859616_1280.jpg");

        List<string> l8 = new List<string>() { "Cálcio", "Potássio", "Kriptônio", "Cobre" };
        Information dado8 = new Information("Qual é o elemento químico representado pela letra K na tabela periódica?", l8, "Potássio", @"https://cdn.pixabay.com/photo/2017/11/07/00/07/fantasy-2925250_1280.jpg");

        List<string> l9 = new List<string>() { "Chile", "Peru", "Bolívia", "Equador" };
        Information dado9 = new Information("Em que país se encontra a cidade de Machu Picchu?", l9, "Peru", @"https://cdn.pixabay.com/photo/2018/01/12/10/19/fantasy-3077928_1280.jpg");


        List<string> l10 = new List<string>() { "Isaac Newton", "Albert Einstein", "Nikola Tesla", "Thomas Edison" };
        Information dado10 = new Information("Quem é o autor da teoria da relatividade?", l10, "Albert Einstein", @"https://cdn.pixabay.com/photo/2014/12/16/22/25/woman-570883_1280.jpg");

        List<string> l11 = new List<string>() { "Rio Amazonas", "Rio Nilo", "Rio Yangtzé", "Rio Mississippi" };
        Information dado11 = new Information("Qual é o rio mais longo do mundo?", l11, "Rio Nilo", @"https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885_1280.jpg");

        p1.Requests.Add(dado1);
        p1.Requests.Add(dado2);
        p1.Requests.Add(dado3);
        p1.Requests.Add(dado4);
        p1.Requests.Add(dado5);
        p1.Requests.Add(dado6);
        p1.Requests.Add(dado7);
        p1.Requests.Add(dado8);
        p1.Requests.Add(dado9);
        p1.Requests.Add(dado10);
        p1.Requests.Add(dado11);

        var lista = p1.Requests.ToList();

        return lista;
    }

}

