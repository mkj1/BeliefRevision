using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeliefRevisionAssignment
{
    class Input
    {
        public List<Literal> ReadLiteral()
        {
            Console.WriteLine("Enter negated clause of literals seperated by comma, fx. !q,r,!s and press enter:");
            string[] values = Console.ReadLine().Split(',').Select(sValue => sValue.Trim()).ToArray();

            var Literals = new List<Literal>();

            foreach (var x in values)
            {
                Literal Lit;

                if (x[0] == '!')
                {
                    Lit = new Literal(x.Substring(1), false);
                }

                else
                {
                    Lit = new Literal(x, true);
                }

                Literals.Add(Lit);
            }

            return Literals;
        }
    }
}
