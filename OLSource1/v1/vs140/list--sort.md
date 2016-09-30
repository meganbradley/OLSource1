---
title: "list::sort"
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
  - "list/std::list::sort"
  - "sort"
  - "list.sort"
  - "list::sort"
  - "std::list::sort"
  - "std.list.sort"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sort method"
ms.assetid: 6155dcdd-1fd7-40b3-bf8a-64013ff6a873
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# list::sort
Arranges the elements of a list in ascending order or with respect to some other user-specified order.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The comparison operator used to order successive elements.  
  
## Remarks  
 The first member function puts the elements in ascending order by default.  
  
 The member template function orders the elements according to the user-specified comparison operation <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> of class **Traits**.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Before sorting: c1 = 20 10 30**  
**After sorting c1 = 10 20 30**  
**After sorting with 'greater than' operation, c1 = 30 20 10**   
## Requirements  
 **Header:** \<list>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)