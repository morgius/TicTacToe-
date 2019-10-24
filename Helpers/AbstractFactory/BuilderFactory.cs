using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacToe.Helpers.Builder;

namespace TicTacToe.Helpers.AbstractFactory
{
    public static class BuilderFactory
    {
        public static IBoardCreator GetBuilder(string name)
        {
            IBoardCreator resoult = null;
            switch (name)
            {
                case "small":
                    resoult = new SmallBoardBuilder();
                    break;
                case "medium":
                    resoult = new MediumBoardBuilder();
                    break;
                default:
                    throw new Exception("Invalid name");
            }
            return resoult;
        }
    }
}
