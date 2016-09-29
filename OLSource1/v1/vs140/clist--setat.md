---
title: "CList::SetAt"
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
  - "CList.SetAt"
  - "CList::SetAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CList class, retrieval/modification"
  - "SetAt method"
ms.assetid: 3b0554e6-0bcc-42f9-ba13-56603899143b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CList::SetAt
A variable of type **POSITION** is a key for the list.  
  
## Syntax  
  
```  
  
      void SetAt(  
   POSITION pos,  
   ARG_TYPE newElement   
);  
```  
  
#### Parameters  
 `pos`  
 The **POSITION** of the element to be set.  
  
 `ARG_TYPE`  
 Template parameter specifying the type of the list element (can be a reference).  
  
 `newElement`  
 The element to be added to the list.  
  
## Remarks  
 It is not the same as an index, and you cannot operate on a **POSITION** value yourself. `SetAt` writes the element to the specified position in the list.  
  
 You must ensure that your **POSITION** value represents a valid position in the list. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
## Example  
 [!code[NVC_MFCCollections#55](../vs140/codesnippet/CPP/clist--setat_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CList Class](../vs140/clist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CList::Find](../vs140/clist--find.md)   
 [CList::GetAt](../vs140/clist--getat.md)   
 [CList::GetNext](../vs140/clist--getnext.md)   
 [CList::GetPrev](../vs140/clist--getprev.md)