---
title: "list::assign (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "list::assign (STL/CLR)"
f1_keywords: 
  - "cliext::list::assign"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "assign member [STL/CLR]"
ms.assetid: c5f2b131-d0e1-4188-9d4b-d617280e4032
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::assign (STL-CLR)
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
 **Header:** \<cliext/list>  
  
 **Namespace:** cliext  
  
## See Also  
 [list](../vs140/list--stl-clr-.md)   
 [operator=](../vs140/list--operator=--stl-clr-.md)