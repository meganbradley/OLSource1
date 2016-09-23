---
title: "CObList::RemoveAll"
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
  - CObList.RemoveAll
  - CObList::RemoveAll
dev_langs: 
  - C++
helpviewer_keywords: 
  - CObList class, operations
  - RemoveAll method
ms.assetid: 04504a2a-d654-4ee6-9f8f-e6745e2b8440
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CObList::RemoveAll
Removes all the elements from this list and frees the associated `CObList` memory.  
  
## Syntax  
  
```  
  
void RemoveAll( );  
```  
  
## Remarks  
 No error is generated if the list is already empty.  
  
 When you remove elements from a `CObList`, you remove the object pointers from the list. It is your responsibility to delete the objects themselves.  
  
 The following table shows other member functions that are similar to `CObList::RemoveAll`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**void RemoveAll( );**|  
|[CStringList](../vs140/cstringlist-class.md)|**void RemoveAll( );**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the `CAge` class.  
  
 [!code[NVC_MFCCollections#105](../vs140/codesnippet/CPP/coblist--removeall_1.cpp)]
  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObList Class](../vs140/coblist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)