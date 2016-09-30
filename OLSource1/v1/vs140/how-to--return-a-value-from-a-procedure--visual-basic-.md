---
title: "How to: Return a Value from a Procedure (Visual Basic)"
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
  - "Visual Basic code, procedures"
  - "procedures, returning from"
  - "procedures, returning a value"
ms.assetid: 4bcc4724-2b4e-4df8-9b4b-16054607f87d
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Return a Value from a Procedure (Visual Basic)
A <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> procedure returns a value to the calling code either by executing a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement or by encountering an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement.  
  
### To return a value using the Return statement  
  
1.  Put a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement at the point where the procedure's task is completed.  
  
2.  Follow the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> keyword with an expression that yields the value you want to return to the calling code.  
  
3.  You can have more than one <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement in the same procedure.  
  
     The following <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> procedure calculates the longest side, or hypotenuse, of a right triangle, and returns it to the calling code.  
  
     [!code[VbVbcnProcedures#1](../vs140/codesnippet/VisualBasic/how-to--return-a-value-from-a-procedure--visual-basic-_1.vb)]  
  
     The following example shows a typical call to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, which stores the returned value.  
  
     [!code[VbVbcnProcedures#6](../vs140/codesnippet/VisualBasic/how-to--return-a-value-from-a-procedure--visual-basic-_2.vb)]  
  
### To return a value using Exit Function or End Function  
  
1.  In at least one place in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> procedure, assign a value to the procedure's name.  
  
2.  When you execute an <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> statement, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] returns the value most recently assigned to the procedure's name.  
  
3.  You can have more than one <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> statement in the same procedure, and you can mix <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> statements in the same procedure.  
  
4.  You can have only one <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> statement in a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> procedure.  
  
     For more information and an example, see "Return Value" in [Function Statement (Visual Basic)](../vs140/function-statement--visual-basic-.md).  
  
## See Also  
 [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md)   
 [Sub Procedures](../vs140/sub-procedures--visual-basic-.md)   
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)   
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [Procedure Parameters and Arguments](../vs140/procedure-parameters-and-arguments--visual-basic-.md)   
 [Function Statement](../vs140/function-statement--visual-basic-.md)   
 [Return Statement (Visual Basic)](../vs140/return-statement--visual-basic-.md)   
 [How to: Create a Procedure that Returns a Value](../vs140/how-to--create-a-procedure-that-returns-a-value--visual-basic-.md)   
 [How to: Call a Procedure that Returns a Value](../vs140/how-to--call-a-procedure-that-returns-a-value--visual-basic-.md)