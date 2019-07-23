using System;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] StudentArrayNames = new string[] { "Dakota Slabbekoorn", "Joshua Bultsma", "Tommy Waalkes", "James Dockery", "Maricela Rivera", "KimVy Nguyen", "Sam Thomson", "Cody Shanley", "Flaka Mahmuti", "Mahruchi Rhee", "Manik Nath", "Moise Ingabire", "Liz Hitches", "Jason Speet" };
            string[] StudentArrayFood = new string[] { "Pho", "Cheese Tortellini", "Indian Style Chicken Curry", "Cheeseburgers/FrenchFries", "Tacos", "Sushi", "Tacos", "Potato soup", "Thai", "Chicken Wings", "Spicy Beef Curry", "Lasagna", "Smoked Salmon", "Burgers" };
            string[] StudentArrayHometown = new string[] { "Kent City", "Grand Rapids", "Raleigh NC", "Grand Rapids, MI", "Morelia, Mex.", "Grand Rapids", "Grand Rapids", "Lawton, MI", " Pristina", "Teaneck, New Jersey", "CoxsBazar, Bangladesh", " Grand Rapids", "Planet Earth", "Holland" };
            int number;
            bool con = true;
            string checkifYorN;
            while (con)
            {
                Console.WriteLine("Welcome to our c# class.Which student would you like to learn more about?Enter a number 1-14");
                while (con)
                {
                    try
                    {
                        int input = int.Parse(Console.ReadLine());
                        int input1 = input - 1;
                        string[] StudentFirstName = StudentArrayNames[input1].Split();
                        bool parsed = int.TryParse(StudentArrayNames[input1], out number);
                        if (parsed == true)
                        {
                            throw new System.ArgumentException("I'm sorry that was not a number");
                        }
                        else
                        {
                            while (con)
                            {
                                try
                                {



                                    Console.WriteLine("Student at " + input + " is " + StudentArrayNames[input1] + ".What would you like to know about " + StudentFirstName[0] + " ?.Enter hometown or favorite food");
                                    string knowabout = Console.ReadLine();
                                    knowabout = knowabout.ToLower();




                                    if (knowabout.Contains("hometown"))
                                    {
                                        Console.WriteLine(StudentFirstName[0] + " is from " + StudentArrayHometown[input1] + ".Would you like to know more? Please enter Y or N");
                                        checkifYorN = Console.ReadLine();
                                        if (checkifYorN == "y" || checkifYorN == "Y")
                                        {
                                            con = true;

                                        }
                                        else if (checkifYorN == "n" || checkifYorN == "N")
                                        {
                                            con = false;
                                            Console.WriteLine("Thank you");
                                        }
                                        else
                                        {
                                            throw new System.FormatException("That data is invalid.  Please try again. (enter or “Y” or “N”):");

                                        }


                                    }

                                    else if (knowabout.Contains("favorite food"))
                                    {
                                        Console.WriteLine(StudentFirstName[0] + "favorite food is " + StudentArrayFood[input1] + ".Would you like to know more?Enter Y or N");

                                        checkifYorN = Console.ReadLine();

                                        if (checkifYorN == "y" || checkifYorN == "Y")
                                        {
                                            con = true;

                                        }
                                        else if (checkifYorN == "n" || checkifYorN == "N")
                                        {
                                            con = false;
                                            Console.WriteLine("Thank you");
                                        }
                                        else
                                        {
                                            throw new System.FormatException("That data is invalid.  Please try again. (enter or “Y” or “N”):");
                                        }

                                    }
                                    else
                                     {
                                       throw new System.FormatException("That data is invalid.  Please try again. (enter or “hometown” or “favorite food”):");
                                     }


                                }
                                catch (FormatException e)
                                {
                                    Console.WriteLine("That data is invalid.Please try again. (enter or “hometown” or “favorite food”):");
                                    //Console.WriteLine(e);
                                }
                                catch (Exception e)
                                {
                                  //  Console.WriteLine(e);
                                    Console.WriteLine(e.Message);
                                }
                            }
                        }
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine(" That student does not exist.Please try again. (enter a number 1 - 14): ");
                    }


                    catch
                    {
                        Console.WriteLine("That is not a number");
                    }
                }
                
                    Console.WriteLine("Do you want to know more about any other students?");
                    checkifYorN = Console.ReadLine();
                    try
                    {
                        if (checkifYorN == "y" || checkifYorN == "Y")
                        {
                            con = true;

                        }
                        else if (checkifYorN == "n" || checkifYorN == "N")
                        {
                            con = false;
                            Console.WriteLine("Thank you");
                        }
                        else
                        {
                            throw new System.FormatException("That data is invalid.  Please try again. Enter Y or N:");
                        }
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("That data is invalid.Please try again. (Enter Y or N”):");
                       // Console.WriteLine(e);
                        checkifYorN=Console.ReadLine();
                    if (checkifYorN == "y" || checkifYorN == "Y")
                    {
                        con = true;

                    }
                    else if (checkifYorN == "n" || checkifYorN == "N")
                    {
                        con = false;
                        Console.WriteLine("Thank you");
                    }
                }
                
            
            }
        }
    }
}
        
