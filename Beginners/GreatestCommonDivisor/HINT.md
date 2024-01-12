### Pseudocode for CalculateGCD
```vbnet
Function CalculateGCD
    Input: two integers a and b
    Output: the greatest common divisor of a and b

    Begin
        While b is not equal to 0
            Set temp to b
            Set b to the remainder of a divided by b
            Set a to temp
        End While

        Return a
    End
```