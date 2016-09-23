---
title: "CObList::GetSize"
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
  - CObList.GetSize
  - CObList::GetSize
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetSize method
ms.assetid: e2cdbb42-5b5b-482c-8d7c-08b474bc5ec2
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CObList::GetSize
Returns the number of list elements.  
  
## Syntax  
  
```  
  
INT_PTR GetSize( ) const;  
```  
  
## Return Value  
 The number of items in the list.  
  
## Remarks  
 Call this method to retrieve the number of elements in the list.  
  
 The following table shows other member functions that are similar to `CObList::GetSize`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**INT_PTR GetSize( ) const;**|  
|[CStringList](../vs140/cstringlist-class.md)|**INT_PTR GetSize( ) const;**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the `CAge` class.  
  
 [!code[NVC_MFCCollections#100](../vs140/codesnippet/CPP/coblist--getsize_1.cpp)]
  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObList Class](../vs140/coblist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObList::GetCount](../vs140/coblist--getcount.md)