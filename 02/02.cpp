// 02.cpp : Tento soubor obsahuje funkci main. Provádění programu se tam zahajuje a ukončuje.
//

#include <iostream>

using namespace std;

int main()
{
    int n;
    cout << "Zadejte cele cislo n: "; cin >> n;

    char pole[50];
    cout << "Zadavejte prvky (znaky) posloupnosti: " << endl;
    for (int i = 0; i < n; i++) {
        char znak;
        cin >> znak;
        pole[i] = znak;
    }

    bool rovnaji = false;
    int i = 0;
    while (i < n && !rovnaji) {
        char znak = pole[i];
        for (int j = 0; j < n && j != i; j++) {

            if (pole[j] == znak) {
                rovnaji = true;
            }
        }
        i++;
    }

    if (rovnaji) cout << "Ano, nektere prvni jsou si rovny" << endl;
    else cout << "Ne, zadne prvky rovny si nejsou" << endl;
}
