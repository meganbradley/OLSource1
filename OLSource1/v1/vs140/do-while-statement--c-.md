---
title: "do-while Statement (C)"
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
  - "do"
  - "while"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "do-while keyword [C]"
ms.assetid: f2ac20a6-10c7-4a08-b5e3-c3b3639dbeaf
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# do-while Statement (C)
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement lets you repeat a statement or compound statement until a specified expression becomes false.  
  
## Syntax  
 *iteration-statement*:  
 **do**  *statement*  **while (**  *expression*  **) ;**  
  
 The *expression* in a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement is evaluated after the body of the loop is executed. Therefore, the body of the loop is always executed at least once.  
  
 The *expression* must have arithmetic or pointer type. Execution proceeds as follows:  
  
1.  The statement body is executed.  
  
2.  Next, *expression* is evaluated. If *expression* is false, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement terminates and control passes to the next statement in the program. If *expression* is true (nonzero), the process is repeated, beginning with step 1.  
  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement can also terminate when a **break**, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement is executed within the statement body.  
  
 This is an example of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In this <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement, the two statements <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> are executed, regardless of the initial value of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. Then <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is evaluated. If <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is greater than 0, the statement body is executed again and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is reevaluated. The statement body is executed repeatedly as long as <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> remains greater than 0. Execution of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> statement terminates when <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> becomes 0 or negative. The body of the loop is executed at least once.  
  
## See Also  
 [do-while Statement (C++)](../vs140/do-while-statement--c---.md)