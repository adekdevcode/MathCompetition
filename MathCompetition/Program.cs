// Użytkownik zostanie przywitany
// Dodanie wyboru akcji
//// a. Wprowadzenie wyniku
//// b. Usunięcie wyniku
//// c. Sprawdzenie kto wygrał
//// d. Zwrócenie listy wyników o zadanym filtrze (nazwa gry)
///// a1. Najpierw dostanę do wyboru Grę
///// a2. Zostanę poproszony o wprowadzenie wszystkich szczegółów danego wyniku
///// b1. Zostanę poproszony o id albo nazwę wyniku
///// b2. Usunę ten wynik z listy wyników
///// c1. Zostanę poproszony o podanie id wyniku
///// c2. Wyświetlę wszystkie informacje związane z tym wynikiem
///// d1. Zostanę poproszony o wprowadzenie nazwy gry albo id gry
///// d2. Wyświetlę listę wyników

using MathCompetition;
using MathCompetition.App.Concrete;
using MathCompetition.App.Managers;

MenuActionService actionService = new MenuActionService();
ResultService resultService = new ResultService();
ResultManager resultManager = new ResultManager(actionService, resultService);

Console.WriteLine("Welcome to MathCompetition app!");

while (true)
{
    Console.WriteLine("Please, let me know what you want to do: ");
    var mainMenu = actionService.GetMenuActionsByMenuName("Main");

    for (int i = 0; i < mainMenu.Count; i++)
    {
        Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
    }

    var operation = Console.ReadKey();

    Console.WriteLine();

    switch (operation.KeyChar)
    {
        case '1':
            var newId = resultManager.AddNewResult();
            break;
        case '2':
            //var removeId = resultService.RemoveResultView();
            //resultService.RemoveResult(removeId);
            break;
        case '3':
            //var detailId = resultService.DetailSelectionResultView();
            //resultService.ResultDetailView(detailId);
            break;
        case '4':
            //var resultId = resultService.ResultTypeSelectionView();
            //resultService.ResultByTypeIdView(resultId);
            break;
        default:
            Console.WriteLine("Action you entered does not exist");
            break;
    }
}