using System;
using ClassDemo2021Exceptions.model;

namespace ClassDemo2021Exceptions
{
    internal class ExceptionWorker
    {
        public ExceptionWorker()
        {
        }

        public void Start()
        {
            try
            {
                Person p = new Person(3, "Peter", 23456789);


                // fejl dvs. exceptions kan opstå
                p.Phone = 1234567;

                Console.WriteLine(p);
            }
            catch (ArgumentException ae)
            {

                // behandling af fejl dvs. exception

                Console.WriteLine(ae.Message);
            }
            catch (PersonException pe)
            {
                Console.WriteLine("Min egen fejl besked");
                Console.WriteLine(pe.Message);
                Console.WriteLine(pe.Person);

            }

            Console.WriteLine("Efter try-catch");
        }
    }
}