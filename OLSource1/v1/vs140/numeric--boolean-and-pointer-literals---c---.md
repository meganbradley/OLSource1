---
title: "Numeric, Boolean and Pointer Literals  (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "literals, C++"
  - "constants, literals"
  - "literals"
ms.assetid: 17c09fc3-3ad7-47e2-8b48-ba8ae994edc8
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Numeric, Boolean and Pointer Literals  (C++)
A literal is a program element that directly represents a value. This article covers literals of type integer, floating-point, boolean and pointer. For information about string and character literals, see [String and Character Literals  (C++)](../vs140/string-and-character-literals---c---.md). You can also define your own literals based on any of these categories; for more information see [User-Defined Literals  (C++)](../vs140/user-defined-literals---c---.md)  
  
 . You can use literals in many contexts, but most commonly to initialize named variables and to pass arguments to functions:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Sometimes it's important to tell the compiler how to interpret a literal, or what specific type to give to it. You do this by appending prefixes or suffixes to the literal. For example, the  prefix 0x tells the compiler to interpret the number that follows it as a hexadecimal value, for example 0x35. The ULL suffix tells the compiler to treat the value as an <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> type, as in 5894345ULL. See the following sections for the complete list of prefixes and suffixes for each literal type.  
  
## Syntax  
  
## Integer literals  
 Integer literals begin with a digit and have no fractional parts or exponents. You can specify integer literals in decimal, octal, or hexadecimal form. They can specify signed or unsigned types and long or short types.  
  
 When no prefix or suffix is present, the compiler will give an integral literal value type <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> (32 bits), if the value will fit, otherwise it will give it type <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> (64 bits).  
  
 To specify a decimal integral literal, begin the specification with a nonzero digit. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 To specify an octal integral literal, begin the specification with 0, followed by a sequence of digits in the range 0 through 7. The digits 8 and 9 are errors in specifying an octal literal. For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 To specify a hexadecimal integral literal, begin the specification with <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> (the case of the "x" does not matter), followed by a sequence of digits in the range <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> through <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> (or <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>) through <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> (or <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>). Hexadecimal digits <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> (or <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>) through <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> (or <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>) represent values in the range 10 through 15. For example:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 To specify an unsigned type, use either the **u** or **U** suffix. To specify a long type, use either the **l** or **L** suffix. To specify a 64-bit integral type, use the LL, or ll suffix. The i64 suffix is still supported but should be avoided because it is specific to Microsoft and is not portable. For example:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 **Digit separators**: You can use the single-quote character (apostrophe) to separate place values in larger numbers to make them easier for humans to read. Separators have no effect on compilation.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## Floating point literals  
 Floating-point literals specify values that must have a fractional part. These values contain decimal points (**.**) and can contain exponents.  
  
 Floating-point literals have a "mantissa," which specifies the value of the number, an "exponent," which specifies the magnitude of the number, and an optional suffix that specifies the literal's type. The mantissa is specified as a sequence of digits followed by a period, followed by an optional sequence of digits representing the fractional part of the number. For example:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The exponent, if present, specifies the magnitude of the number as a power of 10, as shown in the following example:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The exponent may be specified using **e** or **E**, which have the same meaning, followed by an optional sign (+ or -) and a sequence of digits.  If an exponent is present, the trailing decimal point is unnecessary in whole numbers such as <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
 Floating-point literals default to type **double**. By using the suffixes **f** or **l** (or **F** or **L** — the suffix is not case sensitive), the literal can be specified as **float** or <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, respectively.  
  
 Although <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and **double** have the same representation, they are not the same type. For example, you can have overloaded functions like  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 and  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
## Boolean literals  
 The boolean literals are <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
## Pointer literal (C++11)  
 C++ introduces the [nullptr](../vs140/nullptr.md) literal to specify a zero-initialized pointer. In portable code, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> should be used instead of integral-type zero or macros such as NULL.  
  
## Binary literals (C++14)  
 A binary literal can be specified by the use of the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> prefix, followed by a sequence of 1's and 0's:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
## Avoid using literals as "magic constants"  
 You can use literals directly in expressions and statements although it's not always good programming practice:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 In the previous example, it might be better to use a named constant that conveys a clear meaning, for example "MAXIMUM_ERROR_THRESHOLD". And if the return value "Success" is seen by end users, then it might be better to use a named string constant that can be stored in a single location in a file from where it can be localized into other languages. Using named constants helps others as well as yourself to understand the intent of the code.  
  
## See Also  
 [Lexical Conventions](../vs140/lexical-conventions.md)   
 [C++ Integer Constants](assetId:///1f3b58a4-8346-4533-ba6e-df26d76f8dcf)   
 [C++ Character Literals](assetId:///a7901c61-524d-47c6-beb6-d9dacc2e72ed)   
 [C++ Floating-Point Constants](assetId:///f6273f24-a876-4484-a7a2-e82275692ad3)   
 [C++ String Literals](../vs140/string-and-character-literals---c---.md)   
 [C++ User-Defined Literals](../vs140/user-defined-literals---c---.md)