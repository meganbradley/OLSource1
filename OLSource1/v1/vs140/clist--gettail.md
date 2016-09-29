---
title: "CList::GetTail"
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
  - "GetTail"
  - "CList::GetTail"
  - "CList.GetTail"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTail method"
  - "CList class, head/tail access"
ms.assetid: 7aa81545-8a0d-4a20-8537-6ca2ecd3ef2a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CList::GetTail
Gets the `CObject` pointer that represents the tail element of this list.  
  
## Syntax  
  
```  
  
      TYPE  
      & GetTail( );  
const TYPE& GetTail() const;  
```  
  
#### Parameters  
 *TYPE*  
 Template parameter specifying the type of elements in the list.  
  
## Return Value  
 See the return value description for [GetHead](../vs140/coblist--gethead.md).  
  
## Remarks  
 You must ensure that the list is not empty before calling `GetTail`. If the list is empty, then the Debug version of the Microsoft Foundation Class Library asserts. Use [IsEmpty](../vs140/coblist--isempty.md) to verify that the list contains elements.  
  
## Example  
 [!code[NVC_MFCCollections#46](../vs140/codesnippet/CPP/clist--gettail_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CList Class](../vs140/clist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CList::AddTail](../vs140/clist--addtail.md)   
 [CList::AddHead](../vs140/clist--addhead.md)   
 [CList::RemoveHead](../vs140/clist--removehead.md)   
 [CList::GetHead](../vs140/clist--gethead.md)