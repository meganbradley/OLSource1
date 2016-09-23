---
title: "CTypedPtrList::RemoveHead"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CTypedPtrList.RemoveHead
  - CTypedPtrList::RemoveHead
dev_langs: 
  - C++
helpviewer_keywords: 
  - RemoveHead method
ms.assetid: b998cd6f-5332-44ba-859e-68370c1337b4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTypedPtrList::RemoveHead
Removes the element from the head of the list and returns it.  
  
## Syntax  
  
```  
  
TYPE RemoveHead( );  
```  
  
#### Parameters  
 *TYPE*  
 Template parameter specifying the type of elements stored in the list.  
  
## Return Value  
 The pointer previously at the head of the list. This pointer is of the type specified by the template parameter *TYPE*.  
  
## Remarks  
 You must ensure that the list is not empty before calling `RemoveHead`. If the list is empty, then the Debug version of the Microsoft Foundation Class Library asserts. Use [IsEmpty](../vs140/coblist--isempty.md) to verify that the list contains elements.  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CTypedPtrList Class](../vs140/ctypedptrlist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTypedPtrList::RemoveTail](../vs140/ctypedptrlist--removetail.md)   
 [CObList::IsEmpty](../vs140/coblist--isempty.md)   
 [CObList::GetHead](../vs140/coblist--gethead.md)   
 [CObList::AddHead](../vs140/coblist--addhead.md)