---
title: "Operator Overloading"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "operator_cpp"
  - "operator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "redefinable operators"
  - "non-redefinable operators"
  - "operator keyword [C++]"
  - "operators [C++], overloading"
  - "operator overloading"
ms.assetid: 56ad4c4f-dd0c-45e0-adaa-08fe98cb1f8e
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operator Overloading
The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword declares a function specifying what <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> means when applied to instances of a class. This gives the operator more than one meaning, or "overloads" it. The compiler distinguishes between the different meanings of an operator by examining the types of its operands.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 You can redefine the function of most built-in operators globally or on a class-by-class basis. Overloaded operators are implemented as functions.  
  
 The name of an overloaded operator is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is the operator as it appears in the following table. For example, to overload the addition operator, you define a function called <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. Similarly, to overload the addition/assignment operator, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, define a function called <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
### Redefinable Operators  
  
|Operator|Name|Type|  
|--------------|----------|----------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Comma|Binary|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Logical NOT|Unary|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Inequality|Binary|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Modulus|Binary|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Modulus assignment|Binary|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Bitwise AND|Binary|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Address-of|Unary|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Logical AND|Binary|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Bitwise AND assignment|Binary|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Function call|—|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Cast Operator|Unary|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Multiplication|Binary|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Pointer dereference|Unary|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Multiplication assignment|Binary|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|Addition|Binary|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Unary Plus|Unary|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|Increment <sup>1\</sup>|Unary|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Addition assignment|Binary|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Subtraction|Binary|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|Unary negation|Unary|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|Decrement <sup>1\</sup>|Unary|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Subtraction assignment|Binary|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|Member selection|Binary|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|Pointer-to-member selection|Binary|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|Division|Binary|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|Division assignment|Binary|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|Less than|Binary|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|Left shift|Binary|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|Left shift assignment|Binary|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|Less than or equal to|Binary|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|Assignment|Binary|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|Equality|Binary|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|Greater than|Binary|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|Greater than or equal to|Binary|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|Right shift|Binary|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|Right shift assignment|Binary|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|Array subscript|—|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|Exclusive OR|Binary|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|Exclusive OR assignment|Binary|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|Bitwise inclusive OR|Binary|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|Bitwise inclusive OR assignment|Binary|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|Logical OR|Binary|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|One's complement|Unary|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|—|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|—|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|conversion operators|Unary|  
  
 1   Two versions of the unary increment and decrement operators exist: preincrement and postincrement.  
  
 See [General Rules for Operator Overloading](../vs140/general-rules-for-operator-overloading.md) for more information. The constraints on the various categories of overloaded operators are described in the following topics:  
  
-   [Unary Operators](../vs140/overloading-unary-operators.md)  
  
-   [Binary Operators](../vs140/binary-operators.md)  
  
-   [Assignment](../vs140/assignment.md)  
  
-   [Function Call](../vs140/function-call--c---.md)  
  
-   [Subscripting](../vs140/subscripting.md)  
  
-   [Class-Member Access](../vs140/member-access.md)  
  
-   [Increment and Decrement](../vs140/increment-and-decrement-operator-overloading--c---.md).  
  
-   [Conversions](../vs140/user-defined-type-conversions--c---.md)  
  
 The operators shown in the following table cannot be overloaded. The table includes the preprocessor symbols <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>.  
  
### Nonredefinable Operators  
  
|||  
|-|-|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|Member selection|  
|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|Pointer-to-member selection|  
|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|Scope resolution|  
|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|Conditional|  
|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|Preprocessor convert to string|  
|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|Preprocessor concatenate|  
  
 Although overloaded operators are usually called implicitly by the compiler when they are encountered in code, they can be invoked explicitly the same way as any member or nonmember function is called:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following example overloads the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> operator to add two complex numbers and returns the result.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## In this section  
  
1.  [General Rules for Operator Overloading](../vs140/general-rules-for-operator-overloading.md)  
  
2.  [Overloading Unary Operators](../vs140/overloading-unary-operators.md)  
  
3.  [Binary Operators](../vs140/binary-operators.md)  
  
4.  [Assignment](../vs140/assignment.md)  
  
5.  [Function Call (C++)](../vs140/function-call--c---.md)  
  
6.  [Subscripting](../vs140/subscripting.md)  
  
7.  [Member Access](../vs140/member-access.md)  
  
## See Also  
 [C++ Operators](../vs140/c---operators.md)   
 [Keywords](../vs140/keywords--c---.md)