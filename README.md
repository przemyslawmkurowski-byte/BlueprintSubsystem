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
