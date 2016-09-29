---
title: "CObList::RemoveHead"
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
  - "CObList.RemoveHead"
  - "CObList::RemoveHead"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CObList class, operations"
  - "RemoveHead method"
ms.assetid: e19830dc-4bd3-48f4-8bf0-851e5ebcd245
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObList::RemoveHead
Removes the element from the head of the list and returns a pointer to it.  
  
## Syntax  
  
```  
  
CObject* RemoveHead( );  
```  
  
## Return Value  
 The `CObject` pointer previously at the head of the list.  
  
## Remarks  
 You must ensure that the list is not empty before calling `RemoveHead`. If the list is empty, then the Debug version of the Microsoft Foundation Class Library asserts. Use [IsEmpty](../vs140/coblist--isempty.md) to verify that the list contains elements.  
  
 The following table shows other member functions that are similar to `CObList::RemoveHead`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**void\* RemoveHead( );**|  
|[CStringList](../vs140/cstringlist-class.md)|**CString RemoveHead( );**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the `CAge` class.  
  
 [!code[NVC_MFCCollections#107](../vs140/codesnippet/CPP/coblist--removehead_1.cpp)]  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObList Class](../vs140/coblist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObList::GetHead](../vs140/coblist--gethead.md)   
 [CObList::AddHead](../vs140/coblist--addhead.md)