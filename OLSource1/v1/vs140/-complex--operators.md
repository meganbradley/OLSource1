---
title: "&lt;complex&gt; operators"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: aa282604-dcb9-46a2-bf1d-34c50aa6c4ba
caps.latest.revision: 11
---
# &lt;complex&gt; operators
||||  
|-|-|-|  
|[operator!=](#operator_neq)|[operator&gt;&gt;](#operator_gt__gt_)|[operator&lt;&lt;](#operator_lt__lt_)|  
|[operator*](#operator_star)|[operator+](#operator_add)|[operator-](#operator-)|  
|[operator/](#operator_)|[operator==](#operator_eq_eq)|  
  
##  \<a name="operator_neq">\</a>  operator!=  
 Tests for inequality between two complex numbers, one or both of which may belong to the subset of the type for the real and imaginary parts.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 A complex number or object of its parameter type to be tested for inequality.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 A complex number or object of its parameter type to be tested for inequality.  
  
### Return Value  
 **true** if the numbers are not equal;                         **false** if numbers are equal.  
  
### Remarks  
 Two complex numbers are equal if and only if their real parts are equal and their imaginary parts are equal. Otherwise, they are unequal.  
  
 The operation is overloaded so that comparison tests can be executed without the conversion of the data to a particular format.  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **The left-side complex number is cl1 = (2.59808,1.5)**  
**The 1st right-side complex number is cr1a = (2.59808,1.5)**  
**The 2nd right-side complex number is cr1b = (1,1.73205)**  
**The complex numbers cl1 & cr1a are equal.**  
**The complex numbers cl1 & cr1b are not equal.**  
**The 1st left-side complex number is cl2a = (3,4)**  
**The 1st right-side complex number is cr2a = 3**  
**The complex numbers cl2a & cr2a are not equal.**  
**The 2nd left-side complex number is cl2b = (5,0)**  
**The 2nd right-side complex number is cr2b = 5**  
**The complex numbers cl2b & cr2b are equal.**  
**The 1st left-side complex number is cl3a = 3**  
**The 1st right-side complex number is cr3a = (3,4)**  
**The complex numbers cl3a & cr3a are not equal.**  
**The 2nd left-side complex number is cl3b = 5**  
**The 2nd right-side complex number is cr3b = (5,0)**  
**The complex numbers cl3b & cr3b are equal.**    
##  \<a name="operator_star">\</a>  operator*  
 Multiplies two complex numbers, one or both of which may belong to the subset of the type for the real and imaginary parts.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The first of two complex numbers or a number that is of the parameter type for a complex number that is to be multiplied by the * operation.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The second of two complex numbers or a number that is of the parameter type for a complex number that is to be multiplied by the * operation.  
  
### Return Value  
 The complex number that results from the multiplication of the two numbers whose value and type are specified by the parameter inputs.  
  
### Remarks  
 The operation is overloaded so that simple arithmetic operations can be executed without the conversion of the data to a particular format.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="operator_add">\</a>  operator+  
 Adds two complex numbers, one or both of which may belong to the subset of the type for the real and imaginary parts.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The first of two complex numbers or a number that is of the parameter type for a complex number that is to be added by the + operation.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The second of two complex numbers or a number that is of the parameter type for a complex number that is to be added by the + operation.  
  
### Return Value  
 The complex number that results from the addition of the two numbers whose value and type are specified by the parameter inputs.  
  
### Remarks  
 The operation is overloaded so that simple arithmetic operations can be executed without the conversion of the data to a particular format. The unary operator returns                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **The left-side complex number is cl1 = (3,4)**  
**The right-side complex number is cr1 = (2,5)**  
**The sum of the two complex numbers is: cs1 = (5,9)**  
**The modulus of cs1 is: 10.2956**  
**The argument of cs1 is: 1.0637 radians, which is 60.9454 degrees.**  
**The left-side complex number is cl2 = (3,4)**  
**The right-side complex number is cr2 = 5**  
**The sum of the two complex numbers is: cs2 = (8,4)**  
**The modulus of cs2 is: 8.94427**  
**The argument of cs2 is: 0.463648 radians, which is 26.5651 degrees.**  
**The left-side complex number is cl3 = 5**  
**The right-side complex number is cr3 = (3,4)**  
**The sum of the two complex numbers is: cs3 = (8,4)**  
**The modulus of cs3 is: 8.94427**  
**The argument of cs3 is: 0.463648 radians, which is 26.5651 degrees.**  
**The right-side complex number is cr4 = (3,4)**  
**The result of the unary application of + to the right-side**  
 **complex number is: cs4 = (3,4)**  
**The modulus of cs4 is: 5**  
**The argument of cs4 is: 0.927295 radians, which is 53.1301 degrees.**    
##  \<a name="operator-">\</a>  operator-  
 Subtracts two complex numbers, one or both of which may belong to the subset of the type for the real and imaginary parts.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 The first of two complex numbers or a number that is of the parameter type for a complex number that is to be subtracted by the - operation.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 The second of two complex numbers or a number that is of the parameter type for a complex number that is to be subtracted by the - operation.  
  
### Return Value  
 The complex number that results from the subtraction of                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> from                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, the two numbers whose values are specified by the parameter inputs.  
  
### Remarks  
 The operation is overloaded so that simple arithmetic operations can be executed without the conversion of the data to a particular format.  
  
 The unary operator changes the sign of a complex number and returns a value whose real part is the negative of the real part of the number input and whose imaginary part is the negative of the imaginary part of the number input.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  **The left-side complex number is cl1 = (3,4)**  
**The right-side complex number is cr1 = (2,5)**  
**Difference of two complex numbers is: cs1 = (1,-1)**  
**The modulus of cs1 is: 1.41421**  
**The argument of cs1 is: -0.785398 radians, which is -45 degrees.**  
**The left-side complex number is cl2 = (3,4)**  
**The right-side complex number is cr2 = 5**  
**Difference of two complex numbers is: cs2 = (-2,4)**  
**The modulus of cs2 is: 4.47214**  
**The argument of cs2 is: 2.03444 radians, which is 116.565 degrees.**  
**The left-side complex number is cl3 = 5**  
**The right-side complex number is cr3 = (3,4)**  
**Difference of two complex numbers is: cs3 = (2,-4)**  
**The modulus of cs3 is: 4.47214**  
**The argument of cs3 is: -1.10715 radians, which is -63.4349 degrees.**  
**The right-side complex number is cr4 = (3,4)**  
**The result of the unary application of - to the right-side**  
 **complex number is: cs4 = (-3,-4)**  
**The modulus of cs4 is: 5**  
**The argument of cs4 is: -2.2143 radians, which is -126.87 degrees.**    
##  \<a name="operator_">\</a>  operator/  
 Divides two complex numbers, one or both of which may belong to the subset of the type for the real and imaginary parts.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 A complex number or a number that is of the parameter type for a complex number that is the numerator to be divided by the denominator with the / operation.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 A complex number or a number that is of the parameter type for a complex number that is the denominator to be used to divide the numerator with the / operation.  
  
### Return Value  
 The complex number that results from the division of the numerator by the denominator, the values of which are specified by the parameter inputs.  
  
### Remarks  
 The operation is overloaded so that simple arithmetic operations can be executed without the conversion of the data to a particular format.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  **The left-side complex number is cl1 = (2.59808,1.5)**  
**The right-side complex number is cr1 = (1,1.73205)**  
**The quotient of the two complex numbers is: cs1 = cl1 /cr1 = (1.29904,-0.75)**  
**The modulus of cs1 is: 1.5**  
**The argument of cs1 is: -0.523599 radians, which is -30 degrees.**  
**The left-side complex number is cl2 = (2.59808,1.5)**  
**The right-side complex number is cr2 = 5**  
**The quotient of the two complex numbers is: cs2 = cl2 /cr2 = (0.519615,0.3)**  
**The modulus of cs2 is: 0.6**  
**The argument of cs2 is: 0.523599 radians, which is 30 degrees.**  
**The left-side complex number is cl3 = 5**  
**The right-side complex number is cr3 = (2.59808,1.5)**  
**The quotient of the two complex numbers is: cs3 = cl3 /cr2 = (1.44338,-0.833333)**  
**The modulus of cs3 is: 1.66667**  
**The argument of cs3 is: -0.523599 radians, which is -30 degrees.**    
##  \<a name="operator_lt__lt_">\</a>  operator&lt;&lt;  
 Inserts a complex number specified into the output stream.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The output stream into which the complex number is being entered.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The complex number to be entered into the output stream  
  
### Return Value  
 Writes the value of the specified complex number to the                         <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> in a Cartesian format: (                         *real part, imaginary part* ).  
  
### Remarks  
 The output stream is overloaded so that it will accept any form of a complex number, and its default output format is the Cartesian format.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  **Complex number c1 = (3,4)**  
**Complex number c2 = (1.73205,1)**  
**The modulus of c2 is: 2**  
**The argument of c2 is: 0.523599 radians, which is 30 degrees.**    
##  \<a name="operator_eq_eq">\</a>  operator==  
 Tests for equality between two complex numbers, one or both of which may belong to the subset of the type for the real and imaginary parts.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 A complex number or object of its parameter type to be tested for inequality.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 A complex number or object of its parameter type to be tested for inequality.  
  
### Return Value  
 **true** if the numbers are equal;                         **false** if numbers are not equal.  
  
### Remarks  
 Two complex numbers are equal if and only if their real parts are equal and their imaginary parts are equal. Otherwise, they are unequal.  
  
 The operation is overloaded so that comparison tests can be executed without the conversion of the data to a particular format.  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  **The left-side complex number is cl1 = (2.59808,1.5)**  
**The 1st right-side complex number is cr1a = (2.59808,1.5)**  
**The 2nd right-side complex number is cr1b = (1,1.73205)**  
**The complex numbers cl1 & cr1a are equal.**  
**The complex numbers cl1 & cr1b are not equal.**  
**The 1st left-side complex number is cl2a = (3,4)**  
**The 1st right-side complex number is cr2a = 3**  
**The complex numbers cl2a & cr2a are not equal.**  
**The 2nd left-side complex number is cl2b = (5,0)**  
**The 2nd right-side complex number is cr2b = 5**  
**The complex numbers cl2b & cr2b are equal.**  
**The 1st left-side complex number is cl3a = 3**  
**The 1st right-side complex number is cr3a = (3,4)**  
**The complex numbers cl3a & cr3a are not equal.**  
**The 2nd left-side complex number is cl3b = 5**  
**The 2nd right-side complex number is cr3b = (5,0)**  
**The complex numbers cl3b & cr3b are equal.**    
##  \<a name="operator_gt__gt_">\</a>  operator&gt;&gt;  
 Extracts a complex value from the input stream.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 The input stream from which the complex number is being extracted.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The complex number that is being extracted from the input stream.  
  
### Return Value  
 Reads the value of the specified complex number from                         <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and returns it into                         <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
  
### Remarks  
 The valid input formats are  
  
-   *( real part, imaginary part )*  
  
-   *( real part )*  
  
-   *real part*  
  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
   **<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>**     
## See Also  
 [&lt;complex&gt;](../vs140/-complex-.md)