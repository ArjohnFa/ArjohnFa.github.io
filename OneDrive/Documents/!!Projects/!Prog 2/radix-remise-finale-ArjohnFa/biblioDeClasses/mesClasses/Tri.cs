namespace biblioDeClasses.mesClasses
{

    public class Tri
    {
        /// <summary>
        /// methode qui va trouver le plus grand nomrbe d'un tableau
        /// </summary>
        /// <param name="tab">un tableau</param>
        /// <returns>le plus grand nombre de ce tableau</returns>
        public static int PlusGrdNb(List<int> liste)
        {
            //selectionner le plus grand nombre dans le tableau
            int plusGrdNb = 0;
            for (int i = 1; i < liste.Count; i++)
            {
                if (liste[i--] > liste[i])
                {
                    plusGrdNb = liste[i--];
                }
            }
            return plusGrdNb;
        }

       /// <summary>
       /// methode qui va compter combien de chiffres il y a dans le plus grand nnombre du tableau
       /// </summary>
       /// <param name="nb"></param>
       /// <returns></returns>
        public static int NbTrnes(int nb)
        {
            int nbTrn = 0;

            while (nb > 0)
            {
                if (nb < 100000000)
                {
                    nb /= 100000000;
                    nbTrn++;
                }
                else if (nb < 10000000)
                {
                    nb /= 10000000;
                    nbTrn++;
                }
                else if (nb < 1000000)
                {
                    nb /= 1000000;
                    nbTrn++;
                }
                else if (nb < 100000)
                {
                    nb /= 100000;
                    nbTrn++;
                }
                else if (nb < 10000)
                {
                    nb /= 10000;
                    nbTrn++;
                }
                else if (nb < 1000)
                {
                    nb /= 1000;
                    nbTrn++;
                }
                else if (nb < 100)
                {
                    nb /= 100;
                    nbTrn++;
                }
                else if (nb < 10)
                {
                    nb /= 10;
                    nbTrn++;
                }
            }

            return nbTrn;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nb">chiffre de tab[index]</param>
        /// <param name="nB">tab[index]</param>
        /// <param name="tab">tableau</param>
        /// <param name="bucket">les tableaux cff#</param>
        /// <param name="position">index</param>
        public static void MetNb(int nb, int nB, int[] tab, int position)
        {
            Queue<int> q0 = new Queue<int> ();
            Queue<int> q1 = new Queue<int> ();
            Queue<int> q2 = new Queue<int> ();
            Queue<int> q3 = new Queue<int> ();
            Queue<int> q4 = new Queue<int> ();
            Queue<int> q5 = new Queue<int> ();
            Queue<int> q6 = new Queue<int> ();
            Queue<int> q7 = new Queue<int> ();
            Queue<int> q8 = new Queue<int> ();
            Queue<int> q9 = new Queue<int> ();
            // double nb = tab[position] % diviseur; **]

            //place element dans leur bucket respectif

            if (nb == 0)
            {
                cff0.Append(nb);
            }
            else if (nb == 1)
            {
                cff1.Append(tab[j]);
            }
            else if (nb == 2)
            {
                cff2.Append(tab[j]);
            }
            else if (nb == 3)
            {
                cff3.Append(tab[j]);
            }
            else if (nb == 4)
            {
                cff4.Append(tab[j]);
            }
            else if (nb == 5)
            {
                cff5.Append(tab[j]);
            }
            else if (nb == 6)
            {
                cff6.Append(tab[j]);
            }
            else if (nb == 7)
            {
                cff7.Append(tab[j]);
            }
            else if (nb == 8)
            {
                cff8.Append(tab[j]);
            }
            else if (nb == 9)
            {
                cff9.Append(tab[j]);
            }
        }
        
        
        
        /// <summary>
        /// Trier avec le methode Radix
        /// </summary>
        /// <param name="tab">tableau qui devrait etre trier avec le methode Radix</param>
        public static void Radix(int[] tab)
        {
            //tableau pour mettre les nombres trie
            int[] ints = new int[tab.Length];

            

            //nombre de tournes
            //pour chaque chiffre du plus grand nombre, on le divise et ajouter un tourne pour chaque division
            

            //creer 10 buckets pour chaque chiffre ( 0 a 9 )
            int[] cff0 = new int[5];
            int[] cff1 = new int[5];
            int[] cff2 = new int[5];
            int[] cff3 = new int[5];
            int[] cff4 = new int[5];
            int[] cff5 = new int[5];
            int[] cff6 = new int[5];
            int[] cff7 = new int[5];
            int[] cff8 = new int[5];
            int[] cff9 = new int[5];


            // ========== debut de tri ========== //

            //pour chaque placement de chiffre
            for (int i = nbTrn + 1; i > 0; i--)
            {
                double diviseur = Math.Pow(1, i);

                //pour chaque element dans la liste
                for (int j = 0; j < tab.Length; j++)
                {
                    double chiffre = tab[j] % diviseur;
                    //place element dans leur bucket respectif

                    if(chiffre == 0)
                    {
                        cff0.Append(tab[j]);
                    }
                    else if(chiffre == 1)
                    {
                        cff1.Append(tab[j]);
                    }
                    else if(chiffre == 2)
                    {
                        cff2.Append(tab[j]);
                    }
                    else if (chiffre == 3)
                    {
                        cff3.Append(tab[j]);
                    }
                    else if (chiffre == 4)
                    {
                        cff4.Append(tab[j]);
                    }
                    else if (chiffre == 5)
                    {
                        cff5.Append(tab[j]);
                    }
                    else if (chiffre == 6)
                    {
                        cff6.Append(tab[j]);
                    }
                    else if (chiffre == 7)
                    {
                        cff7.Append(tab[j]);
                    }
                    else if (chiffre == 8)
                    {
                        cff8.Append(tab[j]);
                    }
                    else if (chiffre == 9)
                    {
                        cff9.Append(tab[j]);
                    }
                }

                //while bucket nest pas vide
                //retourne element dans la liste precedent
                for (int h = 0; h < cff0.Length; h++)
                {
                    if(cff0[h] != 0)
                    {
                        ints.Append(cff0[h]);
                        cff0[h] = 0;
                    }
                }
                for (int h = 0; h < cff1.Length; h++)
                {
                    if (cff1[h] != 0)
                    {
                        ints.Append(cff1[h]);
                        cff1[h] = 0;
                    }
                }
                for (int h = 0; h < cff2.Length; h++)
                {   
                    if (cff2[h] != 0)
                    {
                        ints.Append(cff2[h]);
                        cff2[h] = 0;
                    }
                }
                for (int h = 0; h < cff3.Length; h++)
                {
                    if (cff3[h] != 0)
                    {
                        ints.Append(cff3[h]);
                        cff3[h] = 0;
                    }
                }
                for (int h = 0; h < cff4.Length; h++)
                {
                    if (cff4[h] != 0)
                    {
                        ints.Append(cff4[h]);
                        cff4[h] = 0;
                    }
                }
                for (int h = 0; h < cff5.Length; h++)
                {
                    if (cff5[h] != 0)
                    {
                        ints.Append(cff5[h]);
                        cff5[h] = 0;
                    }
                }
                for (int h = 0; h < cff6.Length; h++)
                {
                    if (cff6[h] != 0)
                    {
                        ints.Append(cff6[h]);
                        cff6[h] = 0;
                    }
                }
                for (int h = 0; h < cff7.Length; h++)
                {
                    if (cff7[h] != 0)
                    {
                        ints.Append(cff7[h]);
                        cff7[h] = 0;
                    }
                }
                for (int h = 0; h < cff8.Length; h++)
                {
                    if (cff8[h] != 0)
                    {
                        ints.Append(cff8[h]);
                        cff8[h] = 0;
                    }
                }
                for (int h = 0; h < cff9.Length; h++)
                {
                    if (cff9[h] != 0)
                    {
                        ints.Append(cff9[h]);
                        cff9[h] = 0;
                    }
                }
            }
        }
    }
}