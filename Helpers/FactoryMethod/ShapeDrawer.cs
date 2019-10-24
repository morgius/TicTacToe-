using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Helpers.FactoryMethod
{
    public static class ShapeDrawer
    {
        public static Shape Draw(string name)
        {
            Shape shape = null;
            switch (name)
            {
                case "circle":
                    shape = new Circle().CreateShape();
                    break;
                default:
            }
        }
    }
    
}
