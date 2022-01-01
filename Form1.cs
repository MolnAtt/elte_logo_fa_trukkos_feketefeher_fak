using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
		/* Függvények */


		/* Függvények vége */
		void FELADAT()
		{
			// using (new Frissítés(false))
			// Fa1(12, 100);
			defaultkaresz.varakozas = 10;
			
			using (new Vastagság(5))
			balFa2(4, 100);
			
		}
		int vált(int szint) => 2 * (szint % 2) - 1;
		void balFa2(int szint, double méret)
		{
			using (new Vékonyít(.7))
			{
				if (szint > 0)
				{
					using (new Szín(Color.Red))
					{
						Előre(méret / 2);
						erre_jobbFa2(60, szint - 1, méret / 2);
						Előre(méret / 2);
						erre_jobbFa2(45, szint - 1, méret / 2);
						erre_balFa2(-45, szint - 1, méret / 2);
						Hátra(méret);
					}
				}
			}
		}
		void jobbFa2(int szint, double méret)
		{
			using (new Vékonyít(.7))
			{
				if (szint > 0)
				{
					using (new Szín(Color.Blue))
					{
						Előre(méret / 2);
						erre_balFa2(-60, szint - 1, méret / 2);
						Előre(méret / 2);
						erre_jobbFa2(45, szint - 1, méret / 2);
						erre_balFa2(-45, szint - 1, méret / 2);
						Hátra(méret);
					}
				}
			}
		}

		void Fa1(int szint, double méret)
		{
			if (szint > 0)
			{
				Előre(méret / 2);
				erre_Fa1(60, szint - 2, méret / 2);
				Előre(méret / 2);
				erre_Fa1(45, szint - 1, méret / 2);
				erre_Fa1(-45, szint - 1, méret / 2);
				Hátra(méret);
			}
		}
		void erre_Fa1(int fok, int szint, double méret)
		{
			Balra(fok);
			Fa1(szint, méret);
			Jobbra(fok);
		}
		void erre_balFa2(int fok, int szint, double méret)
		{
			Balra(fok);
			balFa2(szint, méret);
			Jobbra(fok);
		}

		void erre_jobbFa2(int fok, int szint, double méret)
		{
			Balra(fok);
			jobbFa2(szint, méret);
			Jobbra(fok);
		}




	}
}
