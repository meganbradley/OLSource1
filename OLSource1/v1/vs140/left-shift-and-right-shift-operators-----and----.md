---
title: "Left Shift and Right Shift Operators (&gt;&gt; and &lt;&lt;)"
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
  - "<<"
  - ">>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "<< operator, with specific objects"
  - "left shift operators"
  - "right shift operators"
  - "bitwise-shift operators"
  - ">> operator"
  - "shift operators"
  - "operators [C++], shift"
ms.assetid: 25fa0cbb-5fdd-4657-8745-b35f7d8f1606
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Left Shift and Right Shift Operators (&gt;&gt; and &lt;&lt;)
The bitwise shift operators are the right-shift operator (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>), which moves the bits of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to the right, and the left-shift operator (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>), which moves the bits of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to the left. <sup>1\</sup>  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
  
> [!IMPORTANT]
>  The following descriptions and examples are valid on Windows for X86 and x64 architectures. The implementation of left-shift and right-shift operators is significantly different on Windows RT for ARM devices. For more information, see the "Shift Operators" section of the [Hello ARM](http://blogs.msdn.com/b/vcblog/archive/2012/10/25/hello-arm-exploring-undefined-unspecified-and-implementation-defined-behavior-in-c.aspx) blog post.  
  
## Left Shifts  
 The left-shift operator causes the bits in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to be shifted to the left by the number of positions specified by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The bit positions that have been vacated by the shift operation are zero-filled. A left shift is a logical shift (the bits that are shifted off the end are discarded, including the sign bit). For more information about the kinds of bitwise shifts, see [Bitwise shifts](http://en.wikipedia.org/wiki/Bitwise_shift).  
  
 The following example shows left-shift operations using unsigned numbers. The example shows what is happening to the bits by representing the value as a bitset. For more information, see [bitset](../vs140/bitset-class.md).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If you left-shift a signed number so that the sign bit is affected, the result is undefined. The following example shows what happens in Visual C++ when a 1 bit is left-shifted into the sign bit position.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Right Shifts  
 The right-shift operator causes the bit pattern in <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to be shifted to the right by the number of positions specified by <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. For unsigned numbers, the bit positions that have been vacated by the shift operation are zero-filled. For signed numbers, the sign bit is used to fill the vacated bit positions. In other words, if the number is positive, 0 is used, and if the number is negative, 1 is used.  
  
> [!IMPORTANT]
>  The result of a right-shift of a signed negative number is implementation-dependent. Although Visual C++ uses the sign bit to fill vacated bit positions, there is no guarantee that other implementations also do so.  
  
 This example shows right-shift operations using unsigned numbers:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The next example shows right-shift operations with positive signed numbers.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The next example shows right-shift operations with negative signed integers.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## Shifts and Promotions  
 The expressions on both sides of a shift operator must be integral types. Integral promotions are performed according to the rules described in [Integral Promotions](../vs140/integral-promotions.md). The type of the result is the same as the type of the promoted <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 In the following example, a variable of type <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is promoted to an <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## Additional Details  
 The result of a shift operation is undefined if <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is negative or if <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is greater than or equal to the number of bits in the (promoted) <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. No shift operation is performed if <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is 0.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
## Footnotes  
 1 The following is the description of the shift operators in the C++ ISO specification (INCITS/ISO/IEC 14882-2011[2012]), sections 5.8.2 and 5.8.3.  
  
 The value of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> left-shifted <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> bit positions; vacated bits are zero-filled. If <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> has an unsigned type, the value of the result is <CodeContentPlaceHolder>27\</CodeContentPlaceHolder><sup>E2\</sup>, reduced modulo one more than the maximum value representable in the result type. Otherwise, if <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> has a signed type and non-negative value, and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder><sup>E2\</sup> is representable in the corresponding unsigned type of the result type, then that value, converted to the result type, is the resulting value; otherwise, the behavior is undefined.  
  
 The value of <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> right-shifted <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> bit positions. If <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> has an unsigned type or if <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> has a signed type and a non-negative value, the value of the result is the integral part of the quotient of <CodeContentPlaceHolder>35\</CodeContentPlaceHolder><sup>E2\</sup>. If <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> has a signed type and a negative value, the resulting value is implementation-defined.  
  
## See Also  
 [Expressions with Binary Operators](../vs140/expressions-with-binary-operators.md)   
 [C++ Built-in Operators, Precedence and Associativity](../vs140/c---built-in-operators--precedence-and-associativity.md)