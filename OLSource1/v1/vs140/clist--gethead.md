---
title: "CList::GetHead"
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
  - "CList::GetHead"
  - "CList.GetHead"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CList class, head/tail access"
  - "GetHead method"
ms.assetid: ff088b08-3d79-4753-a855-369388560452
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CList::GetHead
Gets the head element (or a reference to the head element) of this list.  
  
## Syntax  
  
```  
  
      const   
      TYPE  
      & GetHead( ) const;  
TYPE& GetHead( );  
```  
  
#### Parameters  
 *TYPE*  
 Template parameter specifying the type of object in the list.  
  
## Return Value  
 If the list is **const**, `GetHead` returns a copy of the element at the head of the list. This allows the function to be used only on the right side of an assignment statement and protects the list from modification.  
  
 If the list is not **const**, `GetHead` returns a reference to the element at the head of the list. This allows the function to be used on either side of an assignment statement and thus allows the list entries to be modified.  
  
## Remarks  
 You must ensure that the list is not empty before calling `GetHead`. If the list is empty, then the Debug version of the Microsoft Foundation Class Library asserts. Use [IsEmpty](../vs140/clist--isempty.md) to verify that the list contains elements.  
  
## Example  
 [!code[NVC_MFCCollections#41](../vs140/codesnippet/CPP/clist--gethead_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CList Class](../vs140/clist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CList::GetTail](../vs140/clist--gettail.md)   
 [CList::GetTailPosition](../vs140/clist--gettailposition.md)   
 [CList::AddHead](../vs140/clist--addhead.md)   
 [CList::RemoveHead](../vs140/clist--removehead.md)