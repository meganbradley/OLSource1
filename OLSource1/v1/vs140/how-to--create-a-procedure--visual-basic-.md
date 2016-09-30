---
title: "How to: Create a Procedure (Visual Basic)"
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
  - "procedures, defining"
  - "Visual Basic code, procedures"
  - "Visual Basic code, reusing"
  - "procedure declarations"
  - "procedures, about procedures"
ms.assetid: 4f779247-0b50-47e8-9e5c-ab5cf39ac0d2
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create a Procedure (Visual Basic)
You enclose a procedure between a starting declaration statement (<CodeContentPlaceHolder>0\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>) and an ending declaration statement (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>). All the procedure's code lies between these statements.  
  
 A procedure cannot contain another procedure, so its starting and ending statements must be outside any other procedure.  
  
 If you have code that performs the same task in different places, you can write the task once as a procedure and then call it from different places in your code.  
  
### To create a procedure that does not return a value  
  
1.  Outside any other procedure, use a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement, followed by an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement.  
  
2.  In the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement, follow the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> keyword with the name of the procedure, then the parameter list in parentheses.  
  
3.  Place the procedure's code statements between the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statements.  
  
### To create a procedure that returns a value  
  
1.  Outside any other procedure, use a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> statement, followed by an <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> statement.  
  
2.  In the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> statement, follow the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> keyword with the name of the procedure, then the parameter list in parentheses, and then an <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> clause specifying the data type of the return value.  
  
3.  Place the procedure's code statements between the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> statements.  
  
4.  Use a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> statement to return the value to the calling code.  
  
### To connect your new procedure with the old, repetitive blocks of code  
  
1.  Make sure you define the new procedure in a place where the old code has access to it.  
  
2.  In your old, repetitive code block, replace the statements that perform the repetitive task with a single statement that calls the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> procedure.  
  
3.  If your procedure is a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> that returns a value, ensure that your calling statement performs an action with the returned value, such as storing it in a variable, or else the value will be lost.  
  
## Example  
 The following <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> procedure calculates the longest side, or hypotenuse, of a right triangle, given the values for the other two sides.  
  
 [!code[VbVbcnProcedures#1](../vs140/codesnippet/VisualBasic/how-to--create-a-procedure--visual-basic-_1.vb)]  
  
## See Also  
 [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md)   
 [Sub Procedures](../vs140/sub-procedures--visual-basic-.md)   
 [Function Procedures](../vs140/function-procedures--visual-basic-.md)   
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)   
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [Procedure Parameters and Arguments](../vs140/procedure-parameters-and-arguments--visual-basic-.md)   
 [Recursive Procedures](../vs140/recursive-procedures--visual-basic-.md)   
 [Procedure Overloading](../vs140/procedure-overloading--visual-basic-.md)   
 [Objects and Classes in Visual Basic](../vs140/objects-and-classes-in-visual-basic.md)   
 [Object-Oriented Programming with Managed Languages](../vs140/object-oriented-programming--csharp-and-visual-basic-.md)