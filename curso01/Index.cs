// //List<string> bandList = new List<string>{"U2", "Calypso", "The Beatles"};

// Dictionary<string, List<int>> RegisteredBands = new Dictionary<string, List<int>>();
// RegisteredBands.Add("Linkin Park", new List<int> { 10, 8, 6 });
// RegisteredBands.Add("The Beatles", new List<int>());

// void ShowLogo()
// {
//     Console.Clear();
//     string  welcome = "Welcome to Screen Sound";
//     Console.WriteLine(@"
// ░██████╗░█████╗░██████╗░███████╗███╗░░██╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
// ██╔════╝██╔══██╗██╔══██╗██╔════╝████╗░██║████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
// ╚█████╗░██║░░╚═╝██████╔╝█████╗░░██╔██╗██║██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
// ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██║╚████║██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
// ██████╔╝╚█████╔╝██║░░██║███████╗██║░╚███║██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
// ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░╚══╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
//     ");

//     Console.WriteLine(welcome);
// }

// void RegisterBand()
// {
//     Console.Clear();
//     ShowTitleForOption("Registro de bandas");
//     Console.Write("Digite o nome da banda que deseja registrar: ");
//     string bandName = Console.ReadLine()!;
//     RegisteredBands.Add(bandName, new List<int>());
//     Console.Write($"A banda {bandName} foi registrar com sucesso");
//     Thread.Sleep(2000);
//     ShowOptionsMenu();
// }

// void ShowRegisteredBands()
// {
//     Console.Clear();
//     ShowTitleForOption("Exibindo todas as bandas registradas");
//     // for (int i = 0; i< bandList.Count; i++)
//     // {
//     //     Console.WriteLine($"Banda: {bandList[i]}");
//     // }
    
//     foreach (string band in RegisteredBands.Keys)
//     {
//         Console.WriteLine($"Banda: {band}");
//     }
//     Console.WriteLine("\nDigite uma tecla para voltar ao menu");
//     Console.ReadKey();
//     ShowOptionsMenu();
// }

// void ShowTitleForOption(string title) 
// {
//     int quantityForLyrics = title.Length;
//     string asteriscs = string.Empty.PadLeft(quantityForLyrics, '*');
//     Console.WriteLine(asteriscs);
//     Console.WriteLine(title);
//     Console.WriteLine(asteriscs + "\n");
// }

// void RateBand()
// {
//     // Digite qual banda deseja avaliar
//     // Se a banda existir no dicionário >> atribuir uma nota
//     // Senão, volta ao menu principal

//     Console.Clear();
//     ShowTitleForOption("Avaliar banda");
//     Console.Write("Digite o nome da banda que deseja avaliar: ");
//     string bandName = Console.ReadLine()!;
//     if(RegisteredBands.ContainsKey(bandName))
//     {
//         Console.Write($"Qual a nota que a banda {bandName} merece: ");
//         int note = int.Parse(Console.ReadLine()!);
//         RegisteredBands[bandName].Add(note);
//         Console.WriteLine($"\nA nota {note} foi registrada com sucesso para a banda {bandName}");
//         Thread.Sleep(2000);
//         ShowOptionsMenu();
//     } else {
//         Console.WriteLine($"\nA banda {bandName} não foi encontrada");
//         Console.WriteLine("Digite uma tecla para voltar ao menu princial");
//         Console.ReadKey();
//         ShowOptionsMenu();
//     };
// }

// void ShowAverage()
// {
//     Console.Clear();
//     ShowTitleForOption("Exibir a média da banda");
//     Console.Write("Digite o nome da banda para exibir média: ");
//     string bandName = Console.ReadLine()!;
//     if (RegisteredBands.ContainsKey (bandName))
//     {
//         List<int> bandNotes = RegisteredBands[bandName];
//         Console.WriteLine($"\nA média da banda {bandName} é {bandNotes.Average()}");
//         Console.WriteLine("Digite uma tecla para voltar ao menu principal");
//         Console.ReadKey();
//         ShowOptionsMenu();
//     } else 
//     {
//         Console.WriteLine($"\nA banda {bandName} não foi encontrada");
//         Console.WriteLine("Digite uma tecla para voltar ao menu princial");
//         Console.ReadKey();
//         ShowOptionsMenu();
//     }

// }

// void ShowOptionsMenu()
// {
//     ShowLogo();
//     Console.WriteLine("\nDigite 1 para registrar uma banda");
//     Console.WriteLine("Digite 2 para mostrar todas as bandas");
//     Console.WriteLine("Digite 3 para avaliar uma banda");
//     Console.WriteLine("Digite 4 para exibir a média de uma banda");
//     Console.WriteLine("Digite -1 para sair");

//     Console.Write("\nDigite a sua opção: ");
//     string chosenOption = Console.ReadLine()!;
//     int chosenNumericOption = int.Parse(chosenOption);
//     switch (chosenNumericOption)
//     {
//         case 1: RegisterBand();
//             break;
//         case 2: ShowRegisteredBands();
//             break;
//         case 3: RateBand();
//             break;
//         case 4: ShowAverage();
//             break;
//         case -1: Console.WriteLine("Tchau tchau =)");
//             break;
//         default: Console.WriteLine("Opção inválida");
//             break;
//     }
// }

// ShowOptionsMenu();
