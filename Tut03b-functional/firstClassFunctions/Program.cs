/*

clone of python to illustrate functional programming first class function
objects in c#

python:
#-------------------------------------------------------------------------------
# Illustrates functions are first class objects:
# functions are first class objects in a language when they
#  are treated like any other variable:
# 1) functions can be passed as arguments to other functions
# 2) can be reurned as a value by another function
# 3) can be assigned to a variable
#-------------------------------------------------------------------------------

def sayHi(name:str)->None:
    print(f"Hello {name}")

def bigUp(name:str)->None:
    print(f"{name} is awesome!")

#3 Use function as a variable value
L = [sayHi]
L.append(bigUp)

print(L[0])
print(L[1])

#calls
L[0]("Bob")
L[1]("Sue")

#1 Used as parameters
def greeter(funk:callable,name:str)->None:
    funk(name)

greeter(sayHi,"Fran")
greeter(bigUp,"Taiwo")

#2 returned by functions
def chooser(L:list,index:int)->callable:
    return L[index]

for i in range(len(L)):
    greeter(chooser(L,i),str(i))



*/

using System.Runtime.Versioning;

//type defined with delegate at end of code ... wierd???
GreeterDelegate sayHi = (string name) =>
{
    Console.WriteLine($"Hello {name}");
};

GreeterDelegate bigUp = (string name) => {
    Console.WriteLine($"{name} is awesome!");
};

void greeter(GreeterDelegate funk,string name)
// #1a function as a parameter
{
    funk(name);
}

//#1b calls with function arguments
greeter(sayHi, "Fran");
greeter(bigUp, "Taiwo");

//#3 create variables assigned to functions
// We use a list 
var L = new List<GreeterDelegate>();
L.Add(sayHi);
L.Add(bigUp);

// #3a function returns a function
GreeterDelegate chooser(List<GreeterDelegate> L,int index)
{
    return L[index];
};

//3b - calls chooser() to set the GreeterDelegate :)
for (int i=0; i < L.Count; i++)
{
    greeter(chooser(L, i), i.ToString());
};

// top level statements must be above type declarations or error cs8803
// Define the delegate type
public delegate void GreeterDelegate(string name);
