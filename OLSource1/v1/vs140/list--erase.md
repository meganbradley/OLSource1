---
title: "list::erase"
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
  - "list/std::list::erase"
  - "erase"
  - "list::erase"
  - "std::list::erase"
  - "Erase"
  - "list.erase"
  - "std.list.erase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "erase method"
ms.assetid: 45d5440e-a3e2-45ff-b5de-a9906288bfec
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::erase
Removes an element or a range of elements in a list from specified positions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Position of the element to be removed from the list.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Position of the first element removed from the list.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Position just beyond the last element removed from the list.  
  
## Return Value  
 A bidirectional iterator that designates the first element remaining beyond any elements removed, or a pointer to the end of the list if no such element exists.  
  
## Remarks  
 No reallocation occurs, so iterators and references become invalid only for the erased elements.  
  
 **erase** never throws an exception.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The initial list is: 10 20 30 40 50**  
**After erasing the first element, the list becomes: 20 30 40 50**  
**After erasing all elements but the first, the list becomes:  20**   
## Requirements  
 **Header:** \<list>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)