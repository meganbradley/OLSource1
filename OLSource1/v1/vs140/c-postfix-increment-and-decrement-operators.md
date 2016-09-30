---
title: "C Postfix Increment and Decrement Operators"
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
  - "increment operators, syntax"
  - "scalar operators"
  - "types [C], scalar"
ms.assetid: 56ba218d-65f9-405f-8684-caccc0ca33aa
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# C Postfix Increment and Decrement Operators
Operands of the postfix increment and decrement operators are scalar types that are modifiable l-values.  
  
## Syntax  
 *postfix-expression*:  
 *postfix-expression*  **++**  
  
 *postfix-expression*  **––**  
  
 The result of the postfix increment or decrement operation is the value of the operand. After the result is obtained, the value of the operand is incremented (or decremented). The following code illustrates the postfix increment operator.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In this example, the variable <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is compared to 0, then incremented. If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> was positive before being incremented, the next statement is executed. First, the value of the object pointed to by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is assigned to the object pointed to by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Then, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> are incremented.  
  
## See Also  
 [Postfix Increment and Decrement Operators: ++ and --](../vs140/postfix-increment-and-decrement-operators-----and---.md)