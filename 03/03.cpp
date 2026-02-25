// 03.cpp : Tento soubor obsahuje funkci main. Provádění programu se tam zahajuje a ukončuje.
//

#include <iostream>

using namespace std;

int main()
{
    int n;
    cout << "zadejte cele cislo n: "; cin >> n;

    int pole[20];
    cout << "Zadavejte cisla posloupnosti:" << endl;
    for (int i = 0; i < n; i++) {
        int cislo;
        cin >> cislo;
        pole[i] = cislo;
    }

    int posledni = pole[n - 1];
    int min = RAND_MAX;
    for (int i = 0; i < n - 1; i++) {
        if (pole[i] < min && pole[i] > posledni) {
            min = pole[i];
        }
    }

    if (min < RAND_MAX) {
        cout << "Ano, bylo nalezeno nejmensi cislo a to cislo: " << min << endl;
    }
    else {
        cout << "Nebylo nalezenou nejake nejmensi cislo" << endl;
    }
}
