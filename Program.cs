using System;

namespace DiggersAndFlyers {
    class Program {
        static void Main (string[] args) {

            var ant = new Ant ();
            ant.name = "Bobby";
            var beta = new BettaFish ();
            var cop = new CopperheadSnake ();
            var earth = new Earthworm ();

            earth.name = "Jim";
            var fin = new Finch ();
            var gerb = new Gerbil ();
            var moo = new Mouse ();
            var para = new Parakeet ();
            var terra = new Terrapin ();
            var timb = new TimberRattlesnake ();
            // made a new instance of this class called digging container 
            var diggers = new DiggingContainer ();
            // . notation is used to acces the List property 
            diggers.container.Add (ant);
            diggers.container.Add (earth);

            var movers = new WalkingContainer ();

            movers.container.Add (cop);
            movers.container.Add (gerb);
            movers.container.Add (moo);
            movers.container.Add (timb);

            var swimmers = new SwimmingContainer ();

            swimmers.container.Add (beta);
            swimmers.container.Add (terra);

            var flyers = new FlyingContainer ();

            flyers.container.Add (fin);
            flyers.container.Add (para);

            foreach (var animal in diggers.container) {
                Console.WriteLine (animal.ToString ());
            }

        }
    }
}