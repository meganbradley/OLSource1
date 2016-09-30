---
title: "Recursive Procedures (Visual Basic)"
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
  - "procedures, that call themselves"
  - "procedures, recursive"
  - "procedures, calling"
  - "recursive procedures"
  - "functions [Visual Basic], calling recursively"
  - "recursion"
ms.assetid: ba1d3962-b4c3-48d3-875e-96fdb4198327
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Recursive Procedures (Visual Basic)
A *recursive* procedure is one that calls itself. In general, this is not the most effective way to write [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] code.  
  
 The following procedure uses recursion to calculate the factorial of its original argument.  
  
 [!code[VbVbcnProcedures#51](../vs140/codesnippet/VisualBasic/recursive-procedures--visual-basic-_1.vb)]  
  
## Considerations with Recursive Procedures  
 **Limiting Conditions**. You must design a recursive procedure to test for at least one condition that can terminate the recursion, and you must also handle the case where no such condition is satisfied within a reasonable number of recursive calls. Without at least one condition that can be met without fail, your procedure runs a high risk of executing in an infinite loop.  
  
 **Memory Usage**. Your application has a limited amount of space for local variables. Each time a procedure calls itself, it uses more of that space for additional copies of its local variables. If this process continues indefinitely, it eventually causes a \<xref:System.StackOverflowException*> error.  
  
 **Efficiency**. You can almost always substitute a loop for recursion. A loop does not have the overhead of passing arguments, initializing additional storage, and returning values. Your performance can be much better without recursive calls.  
  
 **Mutual Recursion**. You might observe very poor performance, or even an infinite loop, if two procedures call each other. Such a design presents the same problems as a single recursive procedure, but can be harder to detect and debug.  
  
 **Calling with Parentheses**. When a `Function` procedure calls itself recursively, you must follow the procedure name with parentheses, even if there is no argument list. Otherwise, the function name is taken as representing the return value of the function.  
  
 **Testing**. If you write a recursive procedure, you should test it very carefully to make sure it always meets some limiting condition. You should also ensure that you cannot run out of memory due to having too many recursive calls.  
  
## See Also  
 \<xref:System.StackOverflowException*>   
 [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md)   
 [Sub Procedures](../vs140/sub-procedures--visual-basic-.md)   
 [Function Procedures](../vs140/function-procedures--visual-basic-.md)   
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)   
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [Procedure Parameters and Arguments](../vs140/procedure-parameters-and-arguments--visual-basic-.md)   
 [Procedure Overloading](../vs140/procedure-overloading--visual-basic-.md)   
 [Troubleshooting Procedures](../vs140/troubleshooting-procedures--visual-basic-.md)   
 [Loop Structures](../vs140/loop-structures--visual-basic-.md)   
 [Troubleshooting Exceptions: System.StackOverflowException](../vs140/troubleshooting-exceptions--system.stackoverflowexception.md)