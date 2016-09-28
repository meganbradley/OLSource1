---
title: "CTypedPtrList::GetTail"
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
  - "CTypedPtrList::GetTail"
  - "CTypedPtrList.GetTail"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTail method"
ms.assetid: 8384cb44-c5d4-46cd-8708-89aa21b34896
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTypedPtrList::GetTail
Gets the pointer that represents the head element of this list.  
  
## Syntax  
  
```  
  
      TYPE  
      & GetTail( );  
TYPE GetTail( ) const;  
```  
  
#### Parameters  
 *TYPE*  
 Template parameter specifying the type of elements stored in the list.  
  
## Return Value  
 If the list is accessed through a pointer to a **const CTypedPtrList**, then `GetTail` returns a pointer of the type specified by the template parameter *TYPE*. This allows the function to be used only on the right side of an assignment statement and thus protects the list from modification.  
  
 If the list is accessed directly or through a pointer to a `CTypedPtrList`, then `GetTail` returns a reference to a pointer of the type specified by the template parameter *TYPE*. This allows the function to be used on either side of an assignment statement and thus allows the list entries to be modified.  
  
## Remarks  
 You must ensure that the list is not empty before calling `GetTail`. If the list is empty, then the Debug version of the Microsoft Foundation Class Library asserts. Use [IsEmpty](../vs140/coblist--isempty.md) to verify that the list contains elements.  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CTypedPtrList Class](../vs140/ctypedptrlist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObList::IsEmpty](../vs140/coblist--isempty.md)   
 [CObList::Find](../vs140/coblist--find.md)   
 [CObList::GetTailPosition](../vs140/coblist--gettailposition.md)   
 [CObList::GetHeadPosition](../vs140/coblist--getheadposition.md)   
 [CTypedPtrList::GetPrev](../vs140/ctypedptrlist--getprev.md)   
 [CTypedPtrList::GetNext](../vs140/ctypedptrlist--getnext.md)   
 [CTypedPtrList::GetHead](../vs140/ctypedptrlist--gethead.md)