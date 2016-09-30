---
title: "vector::assign (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "vector::assign (STL/CLR)"
f1_keywords: 
  - "cliext::vector::assign"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "assign member [STL/CLR]"
ms.assetid: 945e2048-6c61-4701-b13c-8241cbee3fa1
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::assign (STL-CLR)
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
 **Header:** \<cliext/vector>  
  
 **Namespace:** cliext  
  
## See Also  
 [vector](../vs140/vector--stl-clr-.md)   
 [operator=](../vs140/vector--operator=--stl-clr-.md)