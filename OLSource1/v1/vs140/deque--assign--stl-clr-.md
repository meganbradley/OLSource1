---
title: "deque::assign (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "deque::assign (STL/CLR)"
f1_keywords: 
  - "cliext::deque::assign"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "assign member [STL/CLR]"
ms.assetid: 03fafdbb-6b10-4464-b3dc-0cc5cb8ac980
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::assign (STL-CLR)
Replaces all elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 count  
 Number of elements to insert.  
  
 first  
 Beginning of range to insert.  
  
 last  
 End of range to insert.  
  
 right  
 Enumeration to insert.  
  
 val  
 Value of the element to insert.  
  
## Remarks  
 The first member function replaces the controlled sequence with a repetition of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> elements of value <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. You use it to fill the container with elements all having the same value.  
  
 If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is an integer type, the second member function behaves the same as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Otherwise, it replaces the controlled sequence with the sequence <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. You use it to make the controlled sequence a copy another sequence.  
  
 The third member function replaces the controlled sequence with the sequence designated by the enumerator <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. You use it to make the controlled sequence a copy of a sequence described by an enumerator.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **x x x x x x**  
 **a b**  
 **a b c**   
## Requirements  
 **Header:** \<cliext/deque>  
  
 **Namespace:** cliext  
  
## See Also  
 [deque](../vs140/deque--stl-clr-.md)   
 [operator=](../vs140/operator=--deque---stl-clr-.md)