---
title: "hash_set::insert (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_set::insert (STL/CLR)"
f1_keywords: 
  - "cliext::hash_set::insert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "insert member [STL/CLR]"
ms.assetid: 0a9bc9aa-012e-4101-9e8c-f1f4b6b76af7
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::insert (STL-CLR)
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
  **a b c**  
**insert(L'x') = [x True]**  
**insert(L'b') = [b False]**  
 **a b c x**  
**insert(begin(), L'y') = y**  
 **a b c x y**  
 **a b c x**  
 **a b c x y**   
## Requirements  
 **Header:** \<cliext/hash_set>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_set](../vs140/hash_set--stl-clr-.md)