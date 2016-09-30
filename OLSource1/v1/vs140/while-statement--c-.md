---
title: "while Statement (C)"
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
  - "while"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "while keyword [C]"
  - "while keyword [C], syntax"
ms.assetid: d0c970b8-12a9-4827-afb2-a051111834b7
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# while Statement (C)
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement lets you repeat a statement until a specified expression becomes false.  
  
## Syntax  
 *iteration-statement*:  
 **while (**  *expression*  **)**  *statement*  
  
 The *expression* must have arithmetic or pointer type. Execution proceeds as follows:  
  
1.  The *expression* is evaluated.  
  
2.  If *expression* is initially false, the body of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement is never executed, and control passes from the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement to the next statement in the program.  
  
     If *expression* is true (nonzero), the body of the statement is executed and the process is repeated beginning at step 1.  
  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement can also terminate when a **break**, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> within the statement body is executed. Use the **continue** statement to terminate an iteration without exiting the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> loop. The **continue** statement passes control to the next iteration of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement.  
  
 This is an example of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statement:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example copies characters from <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is greater than or equal to 0, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is assigned to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is decremented. When <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> reaches or falls below 0, execution of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> statement terminates.  
  
## See Also  
 [while Statement (C++)](../vs140/while-statement--c---.md)