---
title: "How to: Create a Variable that Does Not Change in Value (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "variables [Visual Basic], read-only"
  - "variables [Visual Basic], constant value"
ms.assetid: 86b59266-25df-4635-ae15-9b59c411d036
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create a Variable that Does Not Change in Value (Visual Basic)
The notion of a variable that does not change its value might appear to be contradictory. But there are situations when a constant is not feasible and it is useful to have a variable with a fixed value. In such a case you can define a member variable with the [ReadOnly (Visual Basic)](../vs140/readonly--visual-basic-.md) keyword.  
  
 You cannot use the [Const Statement (Visual Basic)](../vs140/const-statement--visual-basic-.md) to declare and assign a constant value in the following circumstances:  
  
-   The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement does not accept the data type you want to use  
  
-   You do not know the value at compile time  
  
-   You are unable to compute the constant value at compile time  
  
### To create a variable that does not change in value  
  
1.  At module level, declare a member variable with the [Dim Statement (Visual Basic)](../vs140/dim-statement--visual-basic-.md), and include the [ReadOnly (Visual Basic)](../vs140/readonly--visual-basic-.md) keyword.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     You can specify <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> only on a member variable. This means you must define the variable at module level, outside of any procedure.  
  
2.  If you can compute the value in a single statement at compile time, use an initialization clause in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement. Follow the [As](../vs140/as-clause--visual-basic-.md) clause with an equal sign (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>), followed by an expression. Be sure the compiler can evaluate this expression to a constant value.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     You can assign a value to a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> variable only once. Once you do so, no code can ever change its value.  
  
     If you do not know the value at compile time, or cannot compute it at compile time in a single statement, you can still assign it at run time in a constructor. To do this, you must declare the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> variable at class or structure level. In the constructor for that class or structure, compute the variable's fixed value, and assign it to the variable before returning from the constructor.  
  
## See Also  
 [WriteOnly](../vs140/writeonly--visual-basic-.md)   
 [Const Statement (Visual Basic)](../vs140/const-statement--visual-basic-.md)