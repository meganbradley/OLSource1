---
title: "map::insert (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "map::insert (STL/CLR)"
f1_keywords: 
  - "cliext::map::insert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "insert member [STL/CLR]"
ms.assetid: 599c702e-7db0-45b8-8247-4ff041a3639c
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::insert (STL-CLR)
Adds elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 first  
 Beginning of range to insert.  
  
 last  
 End of range to insert.  
  
 right  
 Enumeration to insert.  
  
 val  
 Key value to insert.  
  
 where  
 Where in container to insert (hint only).  
  
## Remarks  
 Each of the member functions inserts a sequence specified by the remaining operands.  
  
 The first member function endeavors to insert an element with value <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, and returns a pair of values <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is true, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> designates the newly inserted element; otherwise <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> designates an element with equivalent ordering that already exists and no new element is inserted. You use it to insert a single element.  
  
 The second member function inserts an element with value <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, using <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> as a hint (to improve performance), and returns an iterator that designates the newly inserted element. You use it to insert a single element which might be adjacent to an element you know.  
  
 The third member function inserts the sequence <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. You use it to insert zero or more elements copied from another sequence.  
  
 The fourth member function inserts the sequence designated by the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. You use it to insert a sequence described by an enumerator.  
  
 Each element insertion takes time proportional to the logarithm of the number of elements in the controlled sequence. Insertion can occur in amortized constant time, however, given a hint that designates an element adjacent to the insertion point.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[a 1] [b 2] [c 3]**  
**insert([L'x' 24]) = [[x 24] True]**  
**insert([L'b' 2]) = [[b 2] False]**  
 **[a 1] [b 2] [c 3] [x 24]**  
**insert(begin(), [L'y' 25]) = [y 25]**  
 **[a 1] [b 2] [c 3] [x 24] [y 25]**  
 **[a 1] [b 2] [c 3] [x 24]**  
 **[a 1] [b 2] [c 3] [x 24] [y 25]**   
## Requirements  
 **Header:** \<cliext/map>  
  
 **Namespace:** cliext  
  
## See Also  
 [map](../vs140/map--stl-clr-.md)