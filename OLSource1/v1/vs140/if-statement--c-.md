---
title: "if Statement (C)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "else"
  - "if"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "if keyword [C]"
  - "else clauses"
  - "else keyword [C]"
  - "if keyword [C], if statement syntax"
  - "nested statements"
ms.assetid: d7fc16a0-fdbc-4f39-b596-76e1ca4ad4a5
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# if Statement (C)
The **if** statement controls conditional branching. The body of an **if** statement is executed if the value of the expression is nonzero. The syntax for the **if** statement has two forms.  
  
## Syntax  
 *selection-statement*:  
 **if (**  *expression*  **)**  *statement*  
  
 **if (**  *expression*  **)**  *statement*  **else**  *statement*  
  
 In both forms of the **if** statement, the expressions, which can have any value except a structure, are evaluated, including all side effects.  
  
 In the first form of the syntax, if *expression* is true (nonzero), *statement* is executed. If *expression* is false, *statement* is ignored. In the second form of syntax, which uses **else**, the second *statement* is executed if *expression* is false. With both forms, control then passes from the **if** statement to the next statement in the program unless one of the statements contains a **break**, **continue**, or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 The following are examples of the **if** statement:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In this example, the statement <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is executed if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is greater than 0. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is less than or equal to 0, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is assigned to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is assigned to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. Note that the statement forming the **if** clause ends with a semicolon.  
  
 When nesting **if** statements and **else** clauses, use braces to group the statements and clauses into compound statements that clarify your intent. If no braces are present, the compiler resolves ambiguities by associating each **else** with the closest **if** that lacks an **else**.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The **else** clause is associated with the inner **if** statement in this example. If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is less than or equal to 0, no value is assigned to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The braces surrounding the inner **if** statement in this example make the **else** clause part of the outer **if** statement. If <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is less than or equal to 0, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is assigned to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## See Also  
 [if-else Statement (C++)](../vs140/if-else-statement--c---.md)