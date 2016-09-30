---
title: "break Statement (C)"
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
  - "break"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "break keyword [C]"
ms.assetid: 015627c7-0924-49b2-a4d1-c77edf5eae6a
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# break Statement (C)
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement terminates the execution of the nearest enclosing <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement in which it appears. Control passes to the statement that follows the terminated statement.  
  
## Syntax  
 *jump-statement*:  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement is frequently used to terminate the processing of a particular case within a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement. Lack of an enclosing iterative or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statement generates an error.  
  
 Within nested statements, the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> statement terminates only the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> statement that immediately encloses it. You can use a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> statement to transfer control elsewhere out of the nested structure.  
  
 This example illustrates the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> statement:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [break Statement](../vs140/break-statement--c---.md)