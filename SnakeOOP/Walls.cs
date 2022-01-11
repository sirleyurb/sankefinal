using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    internal class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();  
            HorizontalLine top = new HorizontalLine(0, 80, 0, '#');
            VerticalLine left = new VerticalLine(0, 25, 0, '#');
            HorizontalLine bottom = new HorizontalLine(0, 80, 25, '$');
            VerticalLine right = new VerticalLine(0, 25, 80, '$');

            VerticalLine obstacle = new VerticalLine(8, 15, 35, '%');
            VerticalLine obstacle1 = new VerticalLine(5, 10, 12, '¤');
            HorizontalLine obstacle2 = new HorizontalLine(8, 12, 10, '¤');
            

            wallList.Add (top); 
            wallList.Add (left);    
            wallList.Add (bottom);  
            wallList.Add (right);  
            wallList.Add (obstacle);
            wallList.Add(obstacle1);
            wallList.Add(obstacle2);
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }

        public bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if(wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
