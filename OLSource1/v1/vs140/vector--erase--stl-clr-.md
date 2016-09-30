---
title: "vector::erase (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "vector::erase (STL/CLR)"
f1_keywords: 
  - "cliext::vector::erase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "erase member [STL/CLR]"
ms.assetid: 624905eb-83c0-499b-a07a-c10aebd7acc3
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::erase (STL-CLR)
Removes elements at specified positions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 first  
 Beginning of range to erase.  
  
 last  
 End of range to erase.  
  
 where  
 Element to erase.  
  
## Remarks  
 The first member function removes the element of the controlled sequence pointed to by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. You use it to remove a single element.  
  
 The second member function removes the elements of the controlled sequence in the range <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You use it to remove zero or more contiguous elements.  
  
 Both member functions return an iterator that designates the first element remaining beyond any elements removed, or [end](../vs140/vector--end--stl-clr-.md)<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if no such element exists.  
  
 When erasing elements, the number of element copies is linear in the number of elements between the end of the erasure and the nearer end of the sequence. (When erasing one or more elements at either end of the sequence, no element copies occur.)  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
**erase(begin()) = b**  
 **b c d e**  
**erase(begin(), end()-1) = e**  
**size() = 1**   
## Requirements  
 **Header:** \<cliext/vector>  
  
 **Namespace:** cliext  
  
## See Also  
 [vector](../vs140/vector--stl-clr-.md)   
 [clear](../vs140/vector--clear--stl-clr-.md)