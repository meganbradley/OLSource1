---
title: "Bitwise Operators (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "^^^ operator [F#]"
  - "bitwise operators [F#]"
  - "operators [F#], bitwise"
  - ">>> operator [F#]"
  - "&&& operator [F#]"
  - "<<< operator [F#]"
  - "||| operator [F#]"
  - "~~~ operator [F#]"
ms.assetid: ab3a2ada-39d2-4bce-a360-cac09f3f63d3
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Bitwise Operators (F#)
This topic describes bitwise operators that are available in the F# language.  
  
## Summary of Bitwise Operators  
 The following table describes the bitwise operators that are supported for unboxed integral types in the F# language.  
  
|Operator|Notes|  
|--------------|-----------|  
|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>|Bitwise AND operator. Bits in the result have the value 1 if and only if the corresponding bits in both source operands are 1.|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Bitwise OR operator. Bits in the result have the value 1 if either of the corresponding bits in the source operands are 1.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Bitwise exclusive OR operator. Bits in the result have the value 1 if and only if bits in the source operands have unequal values.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Bitwise negation operator. This is a unary operator and produces a result in which all 0 bits in the source operand are converted to 1 bits and all 1 bits are converted to 0 bits.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Bitwise left-shift operator. The result is the first operand with bits shifted left by the number of bits in the second operand. Bits shifted off the most significant position are not rotated into the least significant position. The least significant bits are padded with zeros. The type of the second argument is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Bitwise right-shift operator. The result is the first operand with bits shifted right by the number of bits in the second operand. Bits shifted off the least significant position are not rotated into the most significant position. For unsigned types, the most significant bits are padded with zeros. For signed types, the most significant bits are padded with ones. The type of the second argument is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
  
 The following types can be used with bitwise operators: <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
## See Also  
 [Symbol and Operator Reference](../vs140/symbol-and-operator-reference--fsharp-.md)   
 [Arithmetic Operators](../vs140/arithmetic-operators--fsharp-.md)   
 [Boolean Operators](../vs140/boolean-operators--fsharp-.md)