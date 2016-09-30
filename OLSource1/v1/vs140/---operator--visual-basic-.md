---
title: "&gt;&gt; Operator (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.>>"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "operator>>"
  - ">> operator [Visual Basic]"
  - "bit shift operators"
  - "operator >>"
  - "right shift operators"
ms.assetid: 054dc6a6-47d9-47ef-82da-cfa2b59fbf8f
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &gt;&gt; Operator (Visual Basic)
Performs an arithmetic right shift on a bit pattern.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Required. Integral numeric value. The result of shifting the bit pattern. The data type is the same as that of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Required. Integral numeric expression. The bit pattern to be shifted. The data type must be an integral type (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Required. Numeric expression. The number of bits to shift the bit pattern. The data type must be <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or widen to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Remarks  
 Arithmetic shifts are not circular, which means the bits shifted off one end of the result are not reintroduced at the other end. In an arithmetic right shift, the bits shifted beyond the rightmost bit position are discarded, and the leftmost (sign) bit is propagated into the bit positions vacated at the left. This means that if <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> has a negative value, the vacated positions are set to one; otherwise they are set to zero.  
  
 Note that the data types <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> are unsigned, so there is no sign bit to propagate. If <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is of any unsigned type, the vacated positions are always set to zero.  
  
 To prevent shifting by more bits than the result can hold, Visual Basic masks the value of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> with a size mask corresponding to the data type of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. The binary AND of these values is used for the shift amount. The size masks are as follows:  
  
|Data type of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Size mask (decimal)|Size mask (hexadecimal)|  
|----------------------------|---------------------------|-------------------------------|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|7|&H00000007|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|15|&H0000000F|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|31|&H0000001F|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|63|&H0000003F|  
  
 If <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is zero, the value of <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is identical to the value of <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is negative, it is taken as an unsigned value and masked with the appropriate size mask.  
  
 Arithmetic shifts never generate overflow exceptions.  
  
## Overloading  
 The <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> operator can be *overloaded*, which means that a class or structure can redefine its behavior when an operand has the type of that class or structure. If your code uses this operator on such a class or structure, be sure you understand its redefined behavior. For more information, see [Operator Procedures](../vs140/operator-procedures--visual-basic-.md).  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> operator to perform arithmetic right shifts on integral values. The result always has the same data type as that of the expression being shifted.  
  
 [!code[VbVbalrOperators#14](../vs140/codesnippet/VisualBasic/---operator--visual-basic-_1.vb)]  
  
 The results of the preceding example are as follows:  
  
-   <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is 2560 (0000 1010 0000 0000).  
  
-   <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is 160 (0000 0000 1010 0000).  
  
-   <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is 2 (0000 0000 0000 0010).  
  
-   <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is 640 (0000 0010 1000 0000).  
  
-   <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is 0 (shifted 15 places to the right).  
  
 The shift amount for <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is calculated as 18 AND 15, which equals 2.  
  
 The following example shows arithmetic shifts on a negative value.  
  
 [!code[VbVbalrOperators#55](../vs140/codesnippet/VisualBasic/---operator--visual-basic-_2.vb)]  
  
 The results of the preceding example are as follows:  
  
-   <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is -512 (1111 1110 0000 0000).  
  
-   <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> is -1 (the sign bit is propagated).  
  
## See Also  
 [Bit Shift Operators](../vs140/bit-shift-operators--visual-basic-.md)   
 [Assignment Operators](../vs140/assignment-operators--visual-basic-.md)   
 [>>= Operator](../vs140/--=-operator--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../vs140/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../vs140/operators-listed-by-functionality--visual-basic-.md)   
 [Arithmetic Operators in Visual Basic](../vs140/arithmetic-operators-in-visual-basic.md)