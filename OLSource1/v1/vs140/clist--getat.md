---
title: "CList::GetAt"
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
  - "CList.GetAt"
  - "CList::GetAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CList class, retrieval/modification"
  - "GetAt method [MFC]"
ms.assetid: 91512b78-be98-4d4e-ba18-cdc6ef9bb90f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CList::GetAt
Gets the list element at a given position.  
  
## Syntax  
  
```  
  
      TYPE  
      & GetAt(  
   POSITION position   
);  
const TYPE& GetAt(  
   POSITION position   
) const;  
```  
  
#### Parameters  
 *TYPE*  
 Template parameter specifying the type of object in the list.  
  
 *position*  
 The position in the list of the element to get.  
  
## Return Value  
 See the return value description for `GetHead`.  
  
## Remarks  
 `GetAt` returns the element (or a reference to the element) associated with a given position. It is not the same as an index, and you cannot operate on a **POSITION** value yourself. A variable of type **POSITION** is a key for the list.  
  
 You must ensure that your **POSITION** value represents a valid position in the list. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
## Example  
 See the example for [CList::GetHeadPosition](../vs140/clist--getheadposition.md).  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CList Class](../vs140/clist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CList::Find](../vs140/clist--find.md)   
 [CList::SetAt](../vs140/clist--setat.md)   
 [CList::GetNext](../vs140/clist--getnext.md)   
 [CList::GetPrev](../vs140/clist--getprev.md)   
 [CList::GetHead](../vs140/clist--gethead.md)