---
title: "CList::InsertBefore"
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
  - CList::InsertBefore
  - InsertBefore
  - CList.InsertBefore
dev_langs: 
  - C++
helpviewer_keywords: 
  - CList class, insertion
  - InsertBefore method
ms.assetid: 079eb330-5095-48d2-9f07-45ea338781ad
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CList::InsertBefore
Adds an element to this list before the element at the specified position.  
  
## Syntax  
  
```  
  
      POSITION InsertBefore(  
   POSITION position,  
   ARG_TYPE newElement   
);  
```  
  
#### Parameters  
 *position*  
 A **POSITION** value returned by a previous `GetNext`, `GetPrev`, or **Find** member function call.  
  
 `ARG_TYPE`  
 Template parameter specifying the type of the list element (can be a reference).  
  
 `newElement`  
 The element to be added to this list.  
  
## Return Value  
 A **POSITION** value that can be used for iteration or list element retrieval.  
  
## Remarks  
 If *position* is **NULL**, the element is inserted at the head of the list.  
  
## Example  
 [!code[NVC_MFCCollections#49](../vs140/codesnippet/CPP/clist--insertbefore_1.cpp)]
  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CList Class](../vs140/clist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CList::Find](../vs140/clist--find.md)   
 [CList::InsertAfter](../vs140/clist--insertafter.md)