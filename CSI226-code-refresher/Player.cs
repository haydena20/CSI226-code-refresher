using System;

namespace CSI226_code_refresher
{
	public class Player
	{
		private string PlayerName;
		private int PlayerNumber;

		public Player(string PlayerName, int PlayerNumber)
		{
			this.PlayerName = PlayerName;
            this.PlayerNumber = PlayerNumber;
		}

		public string playerName
		{ get { return PlayerName; } }

		public int playerNumber
		{ get { return PlayerNumber; } }

		
		public override string ToString() 
		{ return $"{PlayerNumber} - {PlayerName}"; }
	}
}