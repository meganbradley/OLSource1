---
title: "continue Statement (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "continue"
  - "continue_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "continue keyword [C++]"
ms.assetid: 3c94ee57-f732-4c1d-8537-d0ce5382bfd4
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# continue Statement (C++)
Forces transfer of control to the controlling expression of the smallest enclosing [do](../vs140/do-while-statement--c---.md), [for](../vs140/for-statement--c---.md), or [while](../vs140/while-statement--c---.md) loop.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Any remaining statements in the current iteration are not executed. The next iteration of the loop is determined as follows:  
  
-   In a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> loop, the next iteration starts by reevaluating the controlling expression of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement.  
  
-   In a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> loop (using the syntax <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>(<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>; <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>; <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>)), the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> clause is executed. Then the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> clause is reevaluated and, depending on the result, the loop either ends or another iteration occurs.  
  
 The following example shows how the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> statement can be used to bypass sections of code and begin the next iteration of a loop.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **before the continue**  
**before the continue**  
**before the continue**  
**after the do loop**   
## See Also  
 [Jump Statements](../vs140/jump-statements--c---.md)   
 [Keywords](../vs140/keywords--c---.md)