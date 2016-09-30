---
title: "User-Defined Literals  (C++)"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
ms.assetid: ff4a5bec-f795-4705-a2c0-53788fd57609
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# User-Defined Literals  (C++)
There are five major categories of literals:  integer,  character,  floating-point,  string, boolean and pointer.  Starting in C++ 11 you can define your own literals based on these categories to provide syntactic shortcuts for common idioms and increase type safety. For example, let's say you have a Distance class. You could define a literal for kilometers and another one for miles, and encourage the user to be explicit about the units of measure by simply writing: auto d = 42.0_km or auto d = 42.0_mi. There is no performance advantage or disadvantage to user-defined literals; they are primarily for convenience or for compile-time type deduction. The Standard Library has user-defined literals for std:string, for std::complex, and for units in time and duration operations in the \<chrono> header:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## User-defined literal operator signatures  
 You implement a user-defined literal by defining an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> at namespace scope with one of the following forms:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The operator names in the previous example are placeholders for whatever name you provide; however, the leading underscore is required. (Only the Standard Library is allowed to define literals without the underscore.) The return type is where you customize the conversion or other operation that the literal performs. Also, any of these operators can be defined as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Cooked literals  
 In source code any literal whether user-defined or not is essentially a sequence of alphanumeric characters, such as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The compiler interprets the sequence as an integer, float, const char\* string, and so on. A user-defined literal that accepts as input whatever type the compiler assigned to the literal value is informally known as a *cooked literal*. All the operators above except <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> are cooked literals. For example, a literal <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> would bind to an operator named _km that had a signature similar to _b and the literal <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> would bind to an operator with a signature similar to _a.  
  
 The following example shows how user-defined literals can encourage callers to be explicit about their input. To construct a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, the user must explicitly specify kilometers or miles by using the appropriate user-defined literal. Of course you can also achieve the same result in other ways, but user-defined literals are less verbose than the alternatives.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Note that the literal number must use a decimal, otherwise the number would be interpreted as an integer and the type would not be compatible with the operator. Also note that for floating point input, the type must be <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, and for integral types it must be <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
## Raw literals  
 In a raw user-defined literal, the operator that you define accepts the literal as a sequence of char values and it is up to you to interpret that sequence as a number or string or other type. In the list of operators shown earlier in this page, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> can be used to define raw literals:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 You can use raw literals to provide a custom interpretation of an input sequence that is different than what the compiler would perform. For example, you could define a literal that converts the sequence <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> into a custom Decimal type instead of an IEEE 754 floating point type. Raw literals, like cooked literals, can also be used to perform compile-time validation of input sequences.  
  
### Example  
  
### Limitations of raw literals  
 The raw literal operator and literal operator template only work for integral and floating-point user-defined literals, as shown by the following example:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>