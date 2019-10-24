using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Helpers.Builder
{
    public class Director
    {
        IBoardCreator builder;
        public Director(IBoardCreator builder)
        {
            this.builder = builder;
        }
        public void Construct()
        {
            //List<Row> rows = new List<Row>();
            //for (int i = 0; i < rowCount; i++)
            //{
            //    rows.Add(builder.CreateRow());
            //}
            builder.CreateRows();
            builder.AddCells();
            //rows.ForEach(r => {
            //    List<Cell> cells = new List<Cell>();
            //    for (int i = 0; i < rows.Count; i++)
            //    {
            //        cells.Add(builder.CreateCell(i));
            //    }
            //});
        }
        public List<Row> GetBoard => builder.Rows;
        
    }
}
