---
title: "list::unique"
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
  - "list.unique"
  - "std::list::unique"
  - "std.list.unique"
  - "list::unique"
  - "list/std::list::unique"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unique method"
ms.assetid: 12527583-6d1a-4d8b-bee4-ef1deabc4b79
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::unique
Removes adjacent duplicate elements or adjacent elements that satisfy some other binary predicate from a list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The binary predicate used to compare successive elements.  
  
## Remarks  
 This function assumes that the list is sorted, so that all duplicate elements are adjacent. Duplicates that are not adjacent will not be deleted.  
  
 The first member function removes every element that compares equal to its preceding element.  
  
 The second member function removes every element that satisfies the predicate function <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> when compared with its preceding element. You can use any of the binary function objects declared in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>header for the argument _Pred or you can create your own.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The initial list is c1 = -10 10 10 20 20 -10**  
**After removing successive duplicate elements, c2 = -10 10 20 -10**  
**After removing successive unequal elements, c3 = -10 -10**   
## Requirements  
 **Header:** \<list>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)