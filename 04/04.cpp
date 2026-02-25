// 04.cpp : Tento soubor obsahuje funkci main. Provádění programu se tam zahajuje a ukončuje.
//

#include <iostream>
#include <ctime>

using namespace std;

int main()
{
	int n;
	cout << "Zadejce cele cislo n: "; cin >> n;
	srand(time(0));
	char pole[50];
	for (int i = 0; i < n; i++) {
		int znak = rand() % (90 - 65) + 65;
		char z = (char)znak;
		pole[i] = z;
		cout << z << " - tento znak je " << i + 1 << ". " << endl;
	}

	int prvni = (int)pole[0];
	int posledni = (int)pole[n - 1];
	bool vyhovuje = false;

	for (int i = 1; i < n - 1; i++) {
		int z = (int)pole[i];
		if (z > prvni && z < posledni) {
			vyhovuje = true;
			cout << (char)z << " tento prvek vyhovuje a je to " << i + 1 << ". prvek";
		}
	}

	if (!vyhovuje) cout << "Nebyl naleznut zadny prvek, ktery by vohovoval podminkam" << endl;
}
