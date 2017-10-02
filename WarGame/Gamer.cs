﻿
using System;
using System.Collections.Generic;

namespace WarGame
{
	public class Gamer
	{
		public Deck playerDeck { get; set; }
		public string player { get; set; }
		public List<Gamer> gamers { get; set; }
		public Card CurrentCard { get; set; }

		public List<Gamer> NewGamer(List<Gamer> Gamers)
		{
			gamers = Gamers;
			GetName(gamers);
			return gamers;
		}
		

		public void Print()
		{
			foreach (Gamer g in gamers)
				Console.WriteLine(g.player);
		}

		public void PrintDeck(Deck PlayerDeck)
		{
			PlayerDeck.Print();
		}

		public List<Gamer> GetName(List<Gamer> Gamers)
		{
            int playersCount = gamers.Count + 1;
			if (playersCount <= 2)
			{
				Console.WriteLine("Player {0} ", playersCount);
				string nameValue = Console.ReadLine();
				var newdeck = new Deck();
				var aux = new Gamer() { player = nameValue, playerDeck=newdeck };
				gamers.Add(aux);

			}
			else
			{
				Console.WriteLine("You have two Players already");
			};
			return gamers;
		}
		public  Card TakeTurn()
		{
			
				var item = playerDeck.deck.Count - 1;
				CurrentCard = this.playerDeck.deck[item];
				Console.WriteLine("Trow a Card");
				Console.WriteLine(CurrentCard.display);
			    this.playerDeck.deck.Remove(CurrentCard);
			    

			return CurrentCard;
		}
		public Card TakeTurnWar(int n)
		{
			for (int i = n; i <= n; i++)
			{
				var item = playerDeck.deck.Count - 1;
				CurrentCard = this.playerDeck.deck[item];
				Console.WriteLine("Trow a Card");
				Console.WriteLine(CurrentCard.display);
				this.playerDeck.deck.Remove(CurrentCard);
			}
			return CurrentCard;
		}

	}


}