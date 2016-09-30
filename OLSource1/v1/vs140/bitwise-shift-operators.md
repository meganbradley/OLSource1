---
title: "Bitwise Shift Operators"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "operators [C++], bitwise"
  - "shift operators, bitwise"
  - "bitwise-shift operators"
  - "operators [C++], shift"
ms.assetid: d0485785-5c72-47e1-a7c0-0adde03ade23
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Bitwise Shift Operators
The shift operators shift their first operand left (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) or right (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) by the number of positions the second operand specifies.  
  
## Syntax  
 *shift-expression*:  
 *additive-expression*  
  
 *shift-expression*  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  *additive-expression shift-expression*  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  *additive-expression*  
  
 Both operands must be integral values. These operators perform the usual arithmetic conversions; the type of the result is the type of the left operand after conversion.  
  
 For leftward shifts, the vacated right bits are set to 0. For rightward shifts, the vacated left bits are filled based on the type of the first operand after conversion. If the type is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, they are set to 0. Otherwise, they are filled with copies of the sign bit. For left-shift operators without overflow, the statement  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 is equivalent to multiplication by 2<sup>expr2\</sup>. For right-shift operators,  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 is equivalent to division by 2<sup>expr2\</sup> if <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is unsigned or has a nonnegative value.  
  
 The result of a shift operation is undefined if the second operand is negative, or if the right operand is greater than or equal to the width in bits of the promoted left operand.  
  
 Since the conversions performed by the shift operators do not provide for overflow or underflow conditions, information may be lost if the result of a shift operation cannot be represented in the type of the first operand after conversion.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 In this example, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is shifted left eight positions and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is shifted right eight positions. The shifted values are added, giving 0xAA55, and assigned to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 Shifting a negative value to the right yields half the original value, rounded down. For example, –253 (binary 11111111 00000011) shifted right one bit produces –127 (binary 11111111 10000001). A positive 253 shifts right to produce +126.  
  
 Right shifts preserve the sign bit. When a signed integer shifts right, the most-significant bit remains set. When an unsigned integer shifts right, the most-significant bit is cleared.  
  
## See Also  
 [Left Shift and Right Shift Operators (>> and <<)](../vs140/left-shift-and-right-shift-operators-----and----.md)