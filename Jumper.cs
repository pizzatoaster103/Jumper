
namespace jumping
{
    class Jumper
    {
        public List<string> parachute = new List<string>();
        ///<summary>
        ///Constructor for a new instance of the Jumper class
        ///</summary>
        public Jumper()
        {
            parachute.Add(@"   ___  ");
            parachute.Add(@"  /___\  ");
            parachute.Add(@"  \   /  ");
            parachute.Add(@"   \ /  ");
            parachute.Add(@"    O    ");
            parachute.Add(@"   /|\  ");
            parachute.Add(@"    |  ");
            parachute.Add(@"   / \  ");
            parachute.Add(@"~`~`~`~`~");
        }

        ///<summary>
        ///Draws the picture of jumper with the parachute
        ///</summary>
        public void DrawParachute()
        {
            foreach (string line in parachute)
            {
                TerminalService cucumber = new TerminalService();
                cucumber.WriteText(line);
            }
        }

        ///<summary>
        ///Takes a line off of the parachute
        ///</summary>
        public void EraseParachute()
        {
            parachute.RemoveAt(0);
        }

        public void GameOver()
        {
            parachute.Clear();
            parachute.Add(@"   X    ");
            parachute.Add(@"  \|/  ");
            parachute.Add(@"   |  ");
            parachute.Add(@"  / \  ");
        }
    }
}