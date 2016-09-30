---
title: "break Statement (C++)"
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
  - "break_cpp"
  - "break"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "break keyword [C++]"
ms.assetid: 63739928-8985-4b05-93ce-016322e6da3d
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# break Statement (C++)
The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement ends execution of the nearest enclosing loop or conditional statement in which it appears. Control passes to the statement that follows the end of the statement, if any.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement is used with the conditional [switch](../vs140/switch-statement--c---.md) statement and with the [do](../vs140/do-while-statement--c---.md), [for](../vs140/for-statement--c---.md), and [while](../vs140/while-statement--c---.md) loop statements.  
  
 In a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement, the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement causes the program to execute the next statement outside the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement. Without a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statement, every statement from the matched <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> label to the end of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> statement, including the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> clause, is executed.  
  
 In loops, the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> statement ends execution of the nearest enclosing <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> statement. Control passes to the statement that follows the ended statement, if any.  
  
 Within nested statements, the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> statement ends only the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> statement that immediately encloses it. You can use a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> statement to transfer control from more deeply nested structures.  
  
## Example  
 The following code shows how to use the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> statement in a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> loop.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **In each case:**   
**1**  
**2**  
**3** The following code shows how to use <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> in a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> loop and a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> loop.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **In each case:**  
**0123** The following code shows how to use <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> in a switch statement. You must use <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> in every case if you want to handle each case separately; if you do not use <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, the code execution falls through to the next case.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Jump Statements](../vs140/jump-statements--c---.md)   
 [Keywords](../vs140/keywords--c---.md)   
 [continue Statement](../vs140/continue-statement--c---.md)