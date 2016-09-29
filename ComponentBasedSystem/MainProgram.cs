using System;

namespace ComponentBasedSystem {

    public static class MainProgram {

        [STAThread]
        static void Main(string[] args) {

            using (var game = new MyGame()) {
                game.Run();
            }

        }
    }
}
