# Kompresja plików z wykorzystaniem kodowania Huffmanna

Wejściem programu będzie plik, a jego wyjściem  będzie ten plik po skompresowaniu z wykorzystaniem kodowania Huffmanna. 

## Opis algorytmu kodowania Huffmanna

Kodowanie Huffmanna to jedna z najprostszych metod bezstratnej kompresji danych. Kodowanie polega na utworzeniu słów kodowych (ciągów bitowych), których długość jest odwrotnie proporcjonalna do prawdopodobieństwa wystąpienia zastępowanego symbolu, tzn. najczęściej występujące symbole zostaną zastąpione najkrótszymi ciągami bitów. 

Algorytm Huffmana: https://pl.wikipedia.org/wiki/Kodowanie_Huffmana

## Planowana struktrua klas

- główna klasa - otwiera plik, czyta z niego i przekazuje wszystkie informacje pozostalym klasom 
- klasa tworząca słownik liczby wystąpień - tworzenie słownika liczby wystąpień 
- klasa która dostaje słownik liczby wystąpień symboli i buduje drzewo, na podstawie którego zwraca informację o tym jaki znak tlumaczy się na symbol
- klasa która na podstawie zawartości pliku oraz słownika tłumaczeń tworzy i zwraca skompresowany plik

## Planowane testy 
- sprawdzenie poprawności budowy drzewa (najwięcej testów, ponieważ to najważniejsza część programu)
- zliczanie liczby wystąpień symboli
- walidowanie samego kodowania na podstawie słownika tłumaczeń
