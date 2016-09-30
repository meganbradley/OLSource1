---
title: "C Compound Assignment"
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
  - "operators [C], assignment"
  - "compound assignment operators"
  - "assignment operators, compound"
ms.assetid: db7b5893-cd56-4f1c-9981-5a024200ab63
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# C Compound Assignment
The compound-assignment operators combine the simple-assignment operator with another binary operator. Compound-assignment operators perform the operation specified by the additional operator, then assign the result to the left operand. For example, a compound-assignment expression such as  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 can be understood as  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 However, the compound-assignment expression is not equivalent to the expanded version because the compound-assignment expression evaluates *expression1* only once, while the expanded version evaluates *expression1* twice: in the addition operation and in the assignment operation.  
  
 The operands of a compound-assignment operator must be of integral or floating type. Each compound-assignment operator performs the conversions that the corresponding binary operator performs and restricts the types of its operands accordingly. The addition-assignment (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) and subtraction-assignment (**–=**) operators can also have a left operand of pointer type, in which case the right-hand operand must be of integral type. The result of a compound-assignment operation has the value and type of the left operand.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 In this example, a bitwise-inclusive-AND operation is performed on <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and the result is assigned to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The manifest constant <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is defined with a [#define](../vs140/sharpdefine-directive--c-c---.md) preprocessor directive.  
  
## See Also  
 [C Assignment Operators](../vs140/c-assignment-operators.md)