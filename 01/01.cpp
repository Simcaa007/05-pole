// 01.cpp : Tento soubor obsahuje funkci main. Provádění programu se tam zahajuje a ukončuje.
//

#include <iostream>

using namespace std;

int main()
{
    int n;
    cout << "Zadejte cele cislo n pro n-prvkovou posloupnost: "; cin >> n;

    int pole[100];
    bool rostouci = true;

    if (n > 100) {
        cout << "Byl prekrocen limit pro velikost posloupnosti." << endl;
    }
    else {
        cout << "A ted zadejte posloupnost prvku:" << endl;
        for (int i = 0; i < n; i++) {
            int cislo;
            cin >> cislo;
            pole[i] = cislo;
            if (pole[i] < pole[i - 1]) rostouci = false;
        }
    }

    if (rostouci) {
        cout << "Ano, posloupnost prvku je rostouci" << endl;
    }
    else {
        cout << "Tato posloupnost prvku NENI rostouci" << endl;
    }

}
