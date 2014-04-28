using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Plight_of_the_Programmer
{
    class Level
    {
        /*----Variables-----*/
        private static string levelID = "w1s1";
        private static int levelHeight;
        private static int levelWidth;
        private static string levelDesign;

        /*-----Members-----*/
        private static TextureID[,] tileID = new TextureID[LevelWidth, LevelHeight];

        /*-----Get/Set-----*/
        public static string LevelID
        {
            get { return levelID; }
            set { levelID = value; }
        }
        public static int LevelHeight
        {
            get { return levelHeight; }
            set { levelHeight = value; }
        }
        public static int LevelWidth
        {
            get { return levelWidth; }
            set { levelWidth = value; }
        }
        public static string LevelDesign
        {
            get { return levelDesign; }
            set { levelDesign = value; }
        }
        public static TextureID[,] TileID
        {
            get { return tileID; }
            set { tileID = value; }
        }

        /*-----Functions-----*/
        public static void initLevel()
        {
            string levelFile = "Levels/" + LevelID.ToString() + ".txt";
            try 
            {
                using (StreamReader sr = new StreamReader(levelFile)) 
                {
                    LevelWidth = Convert.ToInt32(sr.ReadLine());
                    LevelHeight = Convert.ToInt32(sr.ReadLine());
                    LevelDesign = sr.ReadLine();
                    TileID = new TextureID[LevelWidth,LevelHeight];
                    string line;
                    for (int y = 0; y < LevelHeight; y++)
                    {
                        line = sr.ReadLine();
                        string[] row = line.Split(new Char[] { ',' });
                        for (int x = 0; x < LevelWidth; x++)
                        {
                            switch (Convert.ToInt32(row[x]))
                            {
                                case 1:
                                    TileID[x,y] = TextureID.wall;
                                    break;
                                case 2:
                                    TileID[x, y] = TextureID.platformC;
                                    break;
                                case 3:
                                    TileID[x, y] = TextureID.platformL;
                                    break;
                                case 4:
                                    TileID[x, y] = TextureID.platformR;
                                    break;
                                default:
                                    TileID[x, y] = TextureID.air;
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception e) 
            {
                // Let the user know what went wrong.
            }            
        }
    }
}
