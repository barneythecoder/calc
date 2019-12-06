// Psuedo-code for a Calculator app. Backend Logic only

/*
NON-OBJECT-ORIENTED APPROACH
*/

//Standard global variables
private bool isAddition;
private bool isSubtraction;

public void main(){
    //listen to click events
}

//Fires when '+' button is pressed
public void plusButtonEvent(){
    isAddition = true;
    isSubtraction = false;
}
public void minusButtonEvent(){
    isAddition = false;
    isSubtraction = true;
}
//Function that gets fired when our imaginary '=' button is pressed
public int equalsButtonEvent(int num1, int num2){
    if(isAddition){
        return num1 + num2;
    }
    else if(isSubtraction){
        return num1 - num2;
    }
}
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



/*OBJECT-ORIENTED APPROACH */

//We make a class that handles all the computations, separate from the main app code (usually the UI)
public class Operation(){

    //We call this a member. This is only accessible here in this class and nowhere else. We'll use this to remember what operation we get from the UI
    private string _operation

    //Constructor: this gets called whenever an object of this type is instantiated
    //Takes a string parameter to determine what operation it will do later
    public Operation(string op){
        //set this member to the value the UI passed
        _operation = op;
    }

    //Function that does the actual computation. It determines what operation to use by checking the _operation string we got.
    public int doOperation(int num1, int num2){
        if(_operation == 'addition'){
            return num1+num2;
        }
        else if(_operation == 'subtraction'){
            return num1 - num2;
        }
    }
}

//Create our Operation object but not instantiate it yet
Operation op;
public void main(){
    //Listen to click events
    
}

public void plusButtonEvent(){
    //Instantiate the op object (calling the constructor) and set it accordingly
    op = new Operation('addition');
}
public void minusButtonEvent(){
    //same here, but subtraction instead
    op = new Operation('subtraction');
}
//Function that gets fired when our imaginary '=' button is pressed
public int equalsButtonEvent(int num1, int num2){
    //call the doOperation function. Note that we've set what operation it should do already.
   return op.doOperation(num1, num2);
}


