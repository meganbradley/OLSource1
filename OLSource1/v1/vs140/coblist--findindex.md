---
title: "CObList::FindIndex"
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
  - CObList.FindIndex
  - CObList::FindIndex
dev_langs: 
  - C++
helpviewer_keywords: 
  - CObList class, searching
  - FindIndex method
ms.assetid: 87549ed5-6d5e-457c-8d8b-4299205f7b81
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CObList::FindIndex
Uses the value of `nIndex` as an index into the list.  
  
## Syntax  
  
```  
  
      POSITION FindIndex(  
   INT_PTR nIndex   
) const;  
```  
  
#### Parameters  
 `nIndex`  
 The zero-based index of the list element to be found.  
  
## Return Value  
 A **POSITION** value that can be used for iteration or object pointer retrieval; **NULL** if `nIndex` is too large. (The framework generates an assertion if `nIndex` is negative.)  
  
## Remarks  
 It starts a sequential scan from the head of the list, stopping on the *n*th element.  
  
 The following table shows other member functions that are similar to `CObList::FindIndex`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**POSITION FindIndex( INT_PTR**  `nIndex`  **) const;**|  
|[CStringList](../vs140/cstringlist-class.md)|**POSITION FindIndex( INT_PTR**  `nIndex`  **) const;**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the `CAge` class.  
  
 [!code[NVC_MFCCollections#94](../vs140/codesnippet/CPP/coblist--findindex_1.cpp)]
  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObList Class](../vs140/coblist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObList::Find](../vs140/coblist--find.md)   
 [CObList::GetNext](../vs140/coblist--getnext.md)   
 [CObList::GetPrev](../vs140/coblist--getprev.md)