﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeliefRevisionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            // test 
            Literal q = new Literal("q", true);
            Literal notq = new Literal("q", false);
            Literal B = new Literal("B", true);
            Literal notB = new Literal("B", false);
            Literal p = new Literal("p", true);
            Literal notp = new Literal("p", false);

            Clause c1 = new Clause();
            c1.addLiteral(notq);
            c1.addLiteral(B);

            Clause c2 = new Clause();
            c2.addLiteral(notB);
            c2.addLiteral(p);
            c2.addLiteral(q);

            Clause c3 = new Clause();
            c3.addLiteral(notp);
            c3.addLiteral(B);

            Clause c4 = new Clause();
            c4.addLiteral(notB);

            Clause c5 = new Clause();
            c5.addLiteral(p);

            Clause c6 = new Clause();
            c6.addLiteral(notp);

            //test fra bogen
            BeliefBase Bbase = new BeliefBase();
            Bbase.addClause(c1);
            Bbase.addClause(c2);
            Bbase.addClause(c3);
            Bbase.addClause(c4);

            //var InputClause = new Clause();

            //var input = new Input();
            //var listOfLiterals = input.ReadLiteral();

            //foreach(var l in listOfLiterals)
            //{
            //    InputClause.addLiteral(l);
            //}
            Console.WriteLine("Initial belief base:");
            Console.WriteLine(Bbase.ToString());

            Console.WriteLine("Calculating entailment for " + c5.ToString());
            Console.WriteLine("Entails? " + Bbase.entails(c5));
            Console.WriteLine();

            Console.WriteLine("Contracting " + q.ToString() +"," + notB.ToString() +  "from belief base...");
            Bbase.Contract(q);
            Bbase.Contract(notB);

            Console.WriteLine("Resulting belief base:");
            Console.WriteLine(Bbase.ToString());
            //Console.WriteLine(Bbase.entails(InputClause));



            while (true) { }

            




        }
    }
}
