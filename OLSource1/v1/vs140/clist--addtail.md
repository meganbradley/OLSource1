---
title: "CList::AddTail"
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
  - "CList::AddTail"
  - "CList.AddTail"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CList class, operations"
  - "AddTail method"
ms.assetid: ca970fbf-5bf6-4273-ab0e-fecbc7123e41
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CList::AddTail
Adds a new element or list of elements to the tail of this list.  
  
## Syntax  
  
```  
  
      POSITION AddTail(  
   ARG_TYPE newElement   
);  
void AddTail(  
   CList* pNewList   
);  
```  
  
#### Parameters  
 `ARG_TYPE`  
 Template parameter specifying the type of the list element (can be a reference).  
  
 `newElement`  
 The element to be added to this list.  
  
 `pNewList`  
 A pointer to another `CList` list. The elements in `pNewList` will be added to this list.  
  
## Return Value  
 The first version returns the **POSITION** value of the newly inserted element.  
  
## Remarks  
 The list can be empty before the operation.  
  
## Example  
 [!code[NVC_MFCCollections#37](../vs140/codesnippet/CPP/clist--addtail_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CList Class](../vs140/clist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObList::GetTail](../vs140/coblist--gettail.md)   
 [CObList::RemoveTail](../vs140/coblist--removetail.md)