using System;

namespace SimpleGame
{
    public class Game
    {
        public int Blt_Load, blt_Spin, total_blt = 6;
        public int win = 0, lose = 0, shootaway_blt = 2;
        
        public void Shoot() // Shoot function will shoot the bullet
        {
            if (total_blt == 0)
            {
                lose = 1;
            }
            else
            {
                if (Blt_Load == blt_Spin)// if load bullet is equal to spin then we will loose the game.
                {
                    lose = 1;
                }
                else
                {
                    blt_Spin = shoot_fire(blt_Spin);
                }
                total_blt--;
            }
        }

        public int shoot_fire(int blt_Spin)
        {
            if (blt_Spin == 6)
            {
                blt_Spin = 1;
            }
            else
            {
                blt_Spin++;
            }
            return blt_Spin;
        }

        public void ShootAway() // Shoot Away function will save the player
        {
            if (total_blt == 0 || shootaway_blt == 0)
            {
                lose = 1;
            }
            else
            {
                shootaway_blt--;
                total_blt--;
                if (Blt_Load == blt_Spin)
                {
                    win = 1;
                }
                else if (blt_Spin == 6)
                {
                    blt_Spin = 1;
                    if (shootaway_blt == 0)
                    {
                        lose = 1;
                    }
                }
                else
                {
                    blt_Spin++;
                    if (shootaway_blt == 0)
                    {
                        lose = 1;
                    }
                }
            }
        }
    }
}
