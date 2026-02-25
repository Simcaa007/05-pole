// 05.cpp : Tento soubor obsahuje funkci main. Provádění programu se tam zahajuje a ukončuje.
//

#include <iostream>
#include <ctime>
using namespace std;

int main()
{
	int n;
	cout << "Zadejte cele cislo n: "; cin >> n;

	int pole[30];
	srand(time(0));
	int max = 0;
	int min = RAND_MAX;
	int poziceMin = 0; int poziceMax = 0;

	for (int i = 0; i < n; i++) {
		int cislo = rand() % (251 - 50) + 50;
		pole[i] = cislo;
		if (cislo > max) {
			max = cislo;
			poziceMax = i;
		}
		if (cislo <= min) {
			min = cislo;
			poziceMin = i;
		}
		cout << cislo << endl;
	}

	int kybl = min;
	pole[poziceMin] = max;
	pole[poziceMax] = kybl;

	cout << endl;
	for (int i = 0; i < n; i++) {
		cout << pole[i] << endl;
	}
	
}