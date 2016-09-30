---
title: "Range-based for Statement (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
ms.assetid: 5750ba1d-ba48-4236-a923-e32de8345c2d
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Range-based for Statement (C++)
Executes <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> repeatedly and sequentially for each element in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Use the range-based <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement to construct loops that must execute through a "range", which is defined as anything that you can iterate through—for example, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, or any other STL sequence whose range is defined by a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. The name that is declared in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> portion is local to the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statement and cannot be re-declared in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. Note that the [auto](../vs140/auto--c---.md) keyword is preferred in the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> portion of the statement.  
  
 This code shows how to use ranged <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> loops to iterate through an array and a vector:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Here is the output:  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
 A range-based <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> loop terminates when one of these in <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is executed: a [break](../vs140/break-statement--c---.md), [return](../vs140/return-statement--c---.md), or [goto](../vs140/goto-statement--c---.md) to a labeled statement outside the range-based **for** loop. A [continue](../vs140/continue-statement--c---.md) statement in a range-based <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> loop terminates only the current iteration.  
  
 Keep in mind these facts about range-based <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>:  
  
-   Automatically recognizes arrays.  
  
-   Recognizes containers that have <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
-   Uses argument-dependent lookup <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> for anything else.  
  
## See Also  
 [auto](../vs140/auto--c---.md)   
 [Iteration Statements](../vs140/iteration-statements--c---.md)   
 [Keywords](../vs140/keywords--c---.md)   
 [while Statement (C++)](../vs140/while-statement--c---.md)   
 [do-while Statement (C++)](../vs140/do-while-statement--c---.md)   
 [for](../vs140/for-statement--c---.md)