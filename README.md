# Cel eksperymentu

Celem eksperymentu jest sprawdzenie, czy da się łatwo stworzyć subsystem blueprincie.

# Próba zero

1. Stwórz nowy projekt.
2. Zadeklaruj klasę GameInstanceBlueprintSubsystem, która jest Abstract
3. W edyytorze stwórz blueprint TestSubsystem dziedziczący po GameInstanceBlueprintSubsystem
4. Stwórz w TestSubsystem funkcję, która wyświetla Hello World
5. W blueprincie levelu podepnij pod debug key pozyskanie TestSubsystemu i wywołanie na nim funkcji.

Spodziewany rezultat: Unreal zgłasza error z wywoływaniem funkcji na nullu.
