---
title: "Bitwise Inclusive OR Operator: |"
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
  - "bitor"
  - "|"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OR operator, bitwise inclusive"
  - "bitwise operators, OR operator"
  - "inclusive OR operator"
  - "| operator"
ms.assetid: 4c8a6a68-d828-447d-875a-aedb4ce3aa9a
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Bitwise Inclusive OR Operator: |
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The bitwise inclusive OR operator (**&#124;**) compares each bit of its first operand to the corresponding bit of its second operand. If either bit is 1, the corresponding result bit is set to 1. Otherwise, the corresponding result bit is set to 0.  
  
 Both operands to the bitwise inclusive OR operator must be of integral types. The usual arithmetic conversions covered in [Arithmetic Conversions](../vs140/arithmetic-conversions.md) are applied to the operands.  
  
## Operator Keyword for &#124;  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> operator is the text equivalent of **&#124;**. There are two ways to access the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> operator in your programs: include the header file <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, or compile with the [/Za](../vs140/-za---ze--disable-language-extensions-.md) (Disable language extensions) compiler option.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [C++ Bitwise Operators](../vs140/c---bitwise-operators.md)   
 [C++ Operators](../vs140/c---operators.md)   
 [C++ Built-in Operators, Precedence and Associativity](../vs140/c---built-in-operators--precedence-and-associativity.md)   
 [C Bitwise Operators](../vs140/c-bitwise-operators.md)