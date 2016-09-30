---
title: "One&#39;s Complement Operator: ~"
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
  - "~"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tilde (~) one's complement operator"
  - "one's complement operator"
  - "bitwise-complement operator"
  - "compl operator"
  - "~ operator, syntax"
ms.assetid: 4bf81967-34f7-4b4b-aade-fd03d5da0174
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# One&#39;s Complement Operator: ~
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The one's complement operator (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>), sometimes called the "bitwise complement" operator, yields a bitwise one's complement of its operand. That is, every bit that is 1 in the operand is 0 in the result. Conversely, every bit that is 0 in the operand is 1 in the result. The operand to the one's complement operator must be an integral type.  
  
## Operator Keyword for ~  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> operator is the text equivalent of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. There are two ways to access the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> operator in your programs: include the header file <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, or compile with [/Za](../vs140/-za---ze--disable-language-extensions-.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In this example, the new value assigned to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is the one's complement of the unsigned value 0xFFFF, or 0x0000.  
  
 Integral promotion is performed on integral operands, and the resultant type is the type to which the operand is promoted. See [Integral Promotions](../vs140/integral-promotions.md) for more information on how the promotion is done.  
  
## See Also  
 [Expressions with Unary Operators](../vs140/expressions-with-unary-operators.md)   
 [C++ Operators](../vs140/c---operators.md)   
 [C++ Built-in Operators, Precedence and Associativity](../vs140/c---built-in-operators--precedence-and-associativity.md)   
 [Unary Arithmetic Operators](../vs140/unary-arithmetic-operators.md)