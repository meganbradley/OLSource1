---
title: "CList::RemoveHead"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CList.RemoveHead"
  - "CList::RemoveHead"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CList class, operations"
  - "RemoveHead method"
ms.assetid: 4c9aafaa-fff5-4cf5-b951-7bef5fd2caef
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CList::RemoveHead
Removes the element from the head of the list and returns a pointer to it.  
  
## Syntax  
  
```  
  
TYPE RemoveHead( );  
```  
  
#### Parameters  
 *TYPE*  
 Template parameter specifying the type of elements in the list.  
  
## Return Value  
 The element previously at the head of the list.  
  
## Remarks  
 You must ensure that the list is not empty before calling `RemoveHead`. If the list is empty, then the Debug version of the Microsoft Foundation Class Library asserts. Use [IsEmpty](../vs140/clist--isempty.md) to verify that the list contains elements.  
  
## Example  
 [!code[NVC_MFCCollections#53](../vs140/codesnippet/CPP/clist--removehead_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CList Class](../vs140/clist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CList::GetHead](../vs140/clist--gethead.md)   
 [CList::AddHead](../vs140/clist--addhead.md)