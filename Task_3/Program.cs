/*
 State machine representation.
 
 * "waitingForOne"
 *   if 1: "hasOne"
 *   if 0: "waitingForOne"
 * 
 * "hasOne"
 *   if 1: "hasOne"
 *   if 0: "hasZero"
 
 *  "hasZero"
 *      if 1: "hasOne", numberOfBinaryWholes++
 *      if 0: "hasZero"
 */

const string binaryString = "001001000000010101";
var binaryHoles = 0;

// Possible states
const string waitingForOne = "waitingForOne";
const string hasOne = "hasOne";
const string hasZero = "hasZero";

var currentState = waitingForOne;

foreach (var currentDigit in binaryString)
{
    switch (currentState)
    {
        case waitingForOne when currentDigit == '1':
            currentState = hasOne;
            break;
        case hasOne when currentDigit == '0':
            currentState = hasZero;
            break;
        case hasZero when currentDigit == '1':
            currentState = hasOne;
            binaryHoles++;
            break;
    }
}

Console.WriteLine($"Number of binary holes: {binaryHoles}");

