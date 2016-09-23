---
title: "CObList::RemoveTail"
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
  - CObList::RemoveTail
  - RemoveTail
  - CObList.RemoveTail
dev_langs: 
  - C++
helpviewer_keywords: 
  - RemoveTail method
  - CObList class, operations
ms.assetid: cba5b5a3-1b6d-4c4e-af60-0074049705d3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CObList::RemoveTail
Removes the element from the tail of the list and returns a pointer to it.  
  
## Syntax  
  
```  
  
CObject* RemoveTail( );  
```  
  
## Return Value  
 A pointer to the object that was at the tail of the list.  
  
## Remarks  
 You must ensure that the list is not empty before calling `RemoveTail`. If the list is empty, then the Debug version of the Microsoft Foundation Class Library asserts. Use [IsEmpty](../vs140/coblist--isempty.md) to verify that the list contains elements.  
  
 The following table shows other member functions that are similar to `CObList::RemoveTail`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**void\* RemoveTail( );**|  
|[CStringList](../vs140/cstringlist-class.md)|**CString RemoveTail( );**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the `CAge` class.  
  
 [!code[NVC_MFCCollections#108](../vs140/codesnippet/CPP/coblist--removetail_1.cpp)]
  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObList Class](../vs140/coblist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObList::GetTail](../vs140/coblist--gettail.md)   
 [CObList::AddTail](../vs140/coblist--addtail.md)