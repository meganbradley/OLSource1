---
title: "Assignment Operators"
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
  - ">>="
  - "xor_eq"
  - "&="
  - "<<="
  - "-="
  - "and_eq"
  - "^="
  - "|="
  - "/="
  - "%="
  - "or_eq"
  - "+="
  - "*="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "or_eq operator"
  - "&= operator"
  - "operators [C++], assignment"
  - "assignment operators, C++"
  - "xor_eq operator"
  - "+= operator"
  - "and_eq operator"
  - ">>= operator"
  - "|= operator"
  - "operator>>="
  - "*= operator"
  - "%= operator"
  - "^= operator"
  - "operator >>="
  - "= operator"
  - "assignment operators"
  - "-= operator"
  - "/= operator"
  - "<<= operator"
ms.assetid: b028cf35-2ff1-4f14-9027-fd53ebec8aa0
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Assignment Operators
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Assignment operators store a value in the object designated by the left operand. There are two kinds of assignment operations: simple assignment, in which the value of the second operand is stored in the object specified by the first operand, and compound assignment, in which an arithmetic, shift, or bitwise operation is performed prior to storing the result. All assignment operators in the following table except the = operator are compound assignment operators.  
  
### Assignment Operators  
  
|Operator|Meaning|  
|--------------|-------------|  
|**=**|Store the value of the second operand in the object specified by the first operand (simple assignment).|  
|**\*=**|Multiply the value of the first operand by the value of the second operand; store the result in the object specified by the first operand.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Divide the value of the first operand by the value of the second operand; store the result in the object specified by the first operand.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Take modulus of the first operand specified by the value of the second operand; store the result in the object specified by the first operand.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Add the value of the second operand to the value of the first operand; store the result in the object specified by the first operand.|  
|**–=**|Subtract the value of the second operand from the value of the first operand; store the result in the object specified by the first operand.|  
|**<\<=**|Shift the value of the first operand left the number of bits specified by the value of the second operand; store the result in the object specified by the first operand.|  
|**>>=**|Shift the value of the first operand right the number of bits specified by the value of the second operand; store the result in the object specified by the first operand.|  
|**&=**|Obtain the bitwise AND of the first and second operands; store the result in the object specified by the first operand.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Obtain the bitwise exclusive OR of the first and second operands; store the result in the object specified by the first operand.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Obtain the bitwise inclusive OR of the first and second operands; store the result in the object specified by the first operand.|  
  
 **Operator Keywords**  
  
 Three of the compound assignment operators have text equivalents. They are:  
  
|Operator|Equivalent|  
|--------------|----------------|  
|**&=**|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|  
  
 There are two ways to access these operator keywords in your programs: include the header file <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, or compile with the [/Za](../vs140/-za---ze--disable-language-extensions-.md) (Disable language extensions) compiler option.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Simple assignment  
 The simple assignment operator (=) causes the value of the second operand to be stored in the object specified by the first operand. If both objects are of arithmetic types, the right operand is converted to the type of the left, prior to storing the value.  
  
 Objects of const and volatile types can be assigned to l-values of types that are just volatile or that are neither const nor volatile.  
  
 Assignment to objects of class type (struct, union, and class types) is performed by a function named operator=. The default behavior of this operator function is to perform a bitwise copy; however, this behavior can be modified using overloaded operators. (See [Overloaded Operators](../vs140/operator-overloading.md) for more information.)  
  
 An object of any unambiguously derived class from a given base class can be assigned to an object of the base class. The reverse is not true because there is an implicit conversion from derived class to base class but not from base class to derived class. For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Assignments to reference types behave as if the assignment were being made to the object to which the reference points.  
  
 For class-type objects, assignment is different from initialization. To illustrate how different assignment and initialization can be, consider the code  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The preceding code shows an initializer; it calls the constructor for <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> that takes an argument of type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. Given the code  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 the assignment statement  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 can have one of the following effects:  
  
-   Call the function operator= for <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, provided operator= is provided with a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> argument.  
  
-   Call the explicit conversion function <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, if such a function exists.  
  
-   Call a constructor <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, provided such a constructor exists, that takes a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> argument and copies the result.  
  
## Compound assignment  
 The compound assignment operators, shown in the table in [Assignment Operators](../vs140/assignment-operators.md), are specified in the form *e1* <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>= *e2*, where *e1* is a modifiable l-value not of const type and *e2* is one of the following:  
  
-   An arithmetic type  
  
-   A pointer, if <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is + or –  
  
 The *e1* <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>= *e2* form behaves as *e1* *= e1* <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> *e2*, but *e1* is evaluated only once.  
  
 Compound assignment to an enumerated type generates an error message. If the left operand is of a pointer type, the right operand must be of a pointer type or it must be a constant expression that evaluates to 0. If the left operand is of an integral type, the right operand must not be of a pointer type.  
  
## Result of assignment operators  
 The assignment operators return the value of the object specified by the left operand after the assignment. The resultant type is the type of the left operand. The result of an assignment expression is always an l-value. These operators have right-to-left associativity. The left operand must be a modifiable l-value.  
  
 In ANSI C, the result of an assignment expression is not an l-value. Therefore, the legal C++ expression <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is illegal in C.  
  
## See Also  
 [Expressions with Binary Operators](../vs140/expressions-with-binary-operators.md)   
 [C++ Operators](../vs140/c---operators.md)   
 [C++ Built-in Operators, Precedence and Associativity](../vs140/c---built-in-operators--precedence-and-associativity.md)   
 [C Assignment Operators](../vs140/c-assignment-operators.md)