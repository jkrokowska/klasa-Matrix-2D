Klasa Matrix2D
Twoim zadaniem jest zaimplementowanie klasy Matrix2D o podanych poniżej funkcjonalnościach, opracowanie testów jednostkowych oraz przetestowanie jej działania na prostych przykładach w aplikacji konsolowej.

Matrix2D jest niezmienniczą macierzą 2x2 liczb całkowitych.

Zadbaj o niezmienniczość instancji klasy Matrix2D.
Ustal wewnętrzną reprezentację macierzy:
ponieważ macierz jest mała, możesz przyjąć, że używasz 4 zmiennych typu int, np. a, b, c, d odpowiednio rozmieszczonych w kwadratowej tablicy
[acbd]
możesz równie dobrze wykorzystać typ tablicy regularnej int[2,2]
Konstrukcja obiektu:
zdefiniuj konstruktor z 4 parametrami Matrix2D(a, b, c, d)
zdefiniuj konstruktor bezparametrowy, tworzący macierz identycznościową
[1001]
Zdefiniuj publiczne stałe (formalnie public static readonly):

o nazwie Id reprezentującą macierz identycznościową (jak w konstruktorze bezparametrowym)
o nazwie Zero reprezentującą macierz zerową (wszystkie jej elementy są zerami)
Zrealizuj je jako property typu get

Zaimplementuj przesłonięcie metody ToString(). Tekstową reprezentacją macierzy 2D jest "[[a, b], [c, d]]" (na przykład: [[1, 2], [3, 4]]).
Zaimplementuj interfejs IEquatable<Matrix2D>, zdefiniuj pojęcie równości dwóch macierzy -- jak w matematyce. Zaprogramuj przeciążenie operatorów == oraz !=. Przesłoń również metodę Equals() dla object oraz GetHashCode(). Pamiętaj o łańcuchowaniu kodu.
Zaimplementuj operacje arytmetyczne na macierzach w formie przeciążenia stosownych operatorów:
A + B, A - B - dodawanie i odejmowanie macierzy
A * B - mnożenie macierzy
k * A oraz A * k - mnożenie skalarne macierzy (przez liczbę całkowitą) lewo- i prawostronne
-A - jednoargumentowy operator zmiany znaku elementów macierzy (równoważny (-1) * A).
Zaimplementuj operację transpozycji macierzy Transpose(A) - zamiany wierszy na kolumny, jako metodę klasy.
Zaimplementuj funkcję obliczającą wyznacznik macierzy:
Determinant(A), jako metodę klasy
Det(), jako metodę instancji
Zaimplementuj operator jawnego rzutowania obiektu Matrix2D na typ tablicy regularnej int[2,2]
Zaimplementuj metodę klasy Parse() parsującą string do obiektu Matrix2D, działającą w odwrotny sposób niż ToString() -- na przykład Parse("[2, 1], [3, 2]]") utworzy poprawnie obiekt, zaś Parse("[[2, 1] [3, 2]]") zgłosi wyjątek FormatException - w tym przypadku brak przecinka w środku
