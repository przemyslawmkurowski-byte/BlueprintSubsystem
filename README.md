# Cel eksperymentu

Celem eksperymentu jest sprawdzenie, czy da się łatwo stworzyć subsystem blueprincie.

# Próba zero

1. Stwórz nowy projekt.
2. Zadeklaruj klasę TestSubsystem, dziedziczący po GameInstanceSubsystem, która jest Abstract
3. W edyytorze stwórz blueprint BP_TestSubsystem dziedziczący po TestSubsystem
4. Stwórz w BP_TestSubsystem funkcję, która wyświetla Hello World
5. W blueprincie levelu podepnij pod debug key pozyskanie BP_TestSubsystemu i wywołanie na nim funkcji.

Spodziewany rezultat: Unreal zgłasza error z wywoływaniem funkcji na nullu.

Rezultat: Wciśnięcie debug keya powoduje wyświetlenie "Hello World"

# Próba zero, podejście drugie

1. Stwórz nowy projekt.
2. Zadeklaruj klasę TestSubsystem, dziedziczący po GameInstanceSubsystem, która jest Abstract
3. Zadeklaruj funkcję MyFunction w TestSubsystem (BlueprintCallable, BlueprintImplementableEvent)
4. W edyytorze stwórz blueprint BP_TestSubsystem dziedziczący po TestSubsystem
5. Overriduj funkcję MyFunction, tak, żeby wyświetlała "Hello World"
6. W blueprincie levelu podepnij pod debug key pozyskanie TestSubsystemu (w domyśle: jego jedyną nie-abstrakcyjną podklasę) i wywołanie na nim funkcji.

Spodziewany rezultat: Unreal zgłasza error z wywoływaniem funkcji na nullu.

Rezultat: Niestabilny. Przy pierwszej próbie wyświetliło się hello world; przy drugiej (po wyłączeniu i włączeniu projektu) jak oczekiwano.

## Hipoteza

Subsystemy są dodawane do listy subsystemów w chwili, w której zostaną załadowane. Podczas pierwszej próby BP_TestSubsystem był otwarty (a więc załadowany). Przy drugiej nie.

Wobec tego należy wymusić załadowanie Subsystemu, w momencie odpalenia gry.

## Rozwiązanie

1. Stwórz BP_GameIstance. Ustaw ją jako GameInstance gry.
2. Dodaj do BP_GameInstance TArray<TSubclassOf<TestSubsystem>>
3. Wstaw do tablicy BP_TestSubsystem.

Spodziewany rezultat: wciśnięcie debug keya powoduje wyświetlenie hello world

Rezultat: jak oczekiwano, zarówno w edytorze, jak i buildzie

# Podsumowanie

Wstawienie twardej referencji na Subsystem, do GameInstance'a, wymusza załadowanie Subsystemu. To z kolei powoduje, że subsystem zostaje zarejestrowany w liście subsystemów i jest dostępny.

Innymi słowy, eksperyment zakończył się sukcesem.