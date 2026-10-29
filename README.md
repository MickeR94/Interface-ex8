# Interface Exercise
This is a very small excerise that serves as an introduction to interfaces.
The assignment consists of Program1 and Program2 which implements interfaces. 

Program1 implements both the Igreeting interface, and the IStart interface. The result is a short greeting when the program starts - "--- Välkommen ---" and "Nu kör vi program 1".
From the IGreeting interface, it uses a Greeting-method to print the greeting, and from IStart it uses the Start-method.

Program2 implements IStart, and thus also uses the Start-method. However, the printout here is instead "Nu kör vi program 2".
