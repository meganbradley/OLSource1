---
title: "CArray::GetCount"
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
  - CArray::GetCount
  - CArray.GetCount
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetCount method [MFC]
ms.assetid: 15824ec1-8d10-4fc6-8221-bdfa43e54bdb
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CArray::GetCount
Returns the number of array elements.  
  
## Syntax  
  
```  
  
INT_PTR GetCount( ) const;  
```  
  
## Return Value  
 The number of items in the array.  
  
## Remarks  
 Call this method to retrieve the number of elements in the array. Because indexes are zero-based, the size is 1 greater than the largest index. Calling this method will generate the same result as the [CArray::GetSize](../vs140/carray--getsize.md) method.  
  
## Example  
 [!code[NVC_MFCCollections#27](../vs140/codesnippet/CPP/carray--getcount_1.cpp)]
  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CArray Class](../vs140/carray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArray::GetUpperBound](../vs140/carray--getupperbound.md)   
 [CArray::SetSize](../vs140/carray--setsize.md)   
 [CArray::GetSize](../vs140/carray--getsize.md)