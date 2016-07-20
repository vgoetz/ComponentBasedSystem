﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
