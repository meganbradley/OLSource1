---
title: "continue Statement (C)"
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
  - "continue"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "loop structures, continue keyword"
  - "continue keyword [C]"
ms.assetid: 969f293a-45fe-48a7-b4c6-287ba27a631d
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# continue Statement (C)
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement passes control to the next iteration of the nearest enclosing <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement in which it appears, bypassing any remaining statements in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement body.  
  
## Syntax  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>:  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 The next iteration of a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> statement is determined as follows:  
  
-   Within a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> statement, the next iteration starts by reevaluating the expression of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> statement.  
  
-   A <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> statement in a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> statement causes the loop expression of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> statement to be evaluated. Then the compiler reevaluates the conditional expression and, depending on the result, either terminates or iterates the statement body. See [The for Statement](../vs140/for-statement--c-.md) for more information on the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> statement and its nonterminals.  
  
 This is an example of the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> statement:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In this example, the statement body is executed while <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is greater than 0. First <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is assigned to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>; then, if <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is equal to 1, the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> statement is executed. The rest of the statements in the body are ignored, and execution resumes at the top of the loop with the evaluation of the loop's test.  
  
## See Also  
 [continue Statement](../vs140/continue-statement--c---.md)