---
title: "list::insert (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "list::insert (STL/CLR)"
f1_keywords: 
  - "cliext::list::insert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "insert member [STL/CLR]"
ms.assetid: 399ed30f-6b76-41a8-b180-6070e3ca1c68
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::insert (STL-CLR)
Adds elements at a specified position.  
  
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
  
 where  
 Where in container to insert before.  
  
## Remarks  
 Each of the member functions inserts, before the element pointed to by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in the controlled sequence, a sequence specified by the remaining operands.  
  
 The first member function inserts an element with value <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and returns an iterator that designates the newly inserted element. You use it to insert a single element before a place designated by an iterator.  
  
 The second member function inserts a repetition of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> elements of value <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. You use it to insert zero or more contiguous elements which are all copies of the same value.  
  
 If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is an integer type, the third member function behaves the same as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Otherwise, it inserts the sequence <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. You use it to insert zero or more contiguous elements copied from another sequence.  
  
 The fourth member function inserts the sequence designated by the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. You use it to insert a sequence described by an enumerator.  
  
 When inserting a single element, the number of element copies is linear in the number of elements between the insertion point and the nearer end of the sequence. (When inserting one or more elements at either end of the sequence, no element copies occur.) If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is an input iterator, the third member function effectively performs a single insertion for each element in the sequence. Otherwise, when inserting <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> elements, the number of element copies is linear in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> plus the number of elements between the insertion point and the nearer end of the sequence.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
**insert(begin()+1, L'x') = x**  
 **a x b c**  
 **y y**  
 **y y a x b**  
 **a x b c y y a x b**   
## Requirements  
 **Header:** \<cliext/list>  
  
 **Namespace:** cliext  
  
## See Also  
 [list](../vs140/list--stl-clr-.md)   
 [assign](../vs140/list--assign--stl-clr-.md)