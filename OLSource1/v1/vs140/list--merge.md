---
title: "list::merge"
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
  - "merge"
  - "std::list::merge"
  - "list/std::list::merge"
  - "std.list.merge"
  - "list::merge"
  - "list.merge"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "merge method"
  - "merge method, merge function"
ms.assetid: 14bc887b-7f14-4986-9000-d180b521db05
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::merge
Removes the elements from the argument list, inserts them into the target list, and orders the new, combined set of elements in ascending order or in some other specified order.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The argument list to be merged with the target list.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The comparison operator used to order the elements of the target list.  
  
## Remarks  
 The argument list <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is merged with the target list.  
  
 Both argument and target lists must be ordered with the same comparison relation by which the resulting sequence is to be ordered. The default order for the first member function is ascending order. The second member function imposes the user-specified comparison operation <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> of class **Traits**.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **c1 = 3 6**  
**c2 = 2 4**  
**After merging c1 with c2 and sorting with >: c2 = 6 4 3 2**  
**c3 = 5 1**  
**After merging c3 with c2 according to the '>' comparison relation: c2 = 6 5 4 3 2 1**   
## Requirements  
 **Header:** \<list>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)