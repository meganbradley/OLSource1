---
title: "CObList::IsEmpty"
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
  - CObList::IsEmpty
  - CObList.IsEmpty
dev_langs: 
  - C++
helpviewer_keywords: 
  - CObList class, status
  - IsEmpty method
ms.assetid: b5a3462d-2e96-450f-b1cd-3e6d87612595
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CObList::IsEmpty
Indicates whether this list contains no elements.  
  
## Syntax  
  
```  
  
BOOL IsEmpty( ) const;  
```  
  
## Return Value  
 Nonzero if this list is empty; otherwise 0.  
  
 The following table shows other member functions that are similar to `CObList::IsEmpty`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**BOOL IsEmpty( ) const;**|  
|[CStringList](../vs140/cstringlist-class.md)|**BOOL IsEmpty( ) const;**|  
  
## Example  
 See the example for [RemoveAll](../vs140/coblist--removeall.md).  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObList Class](../vs140/coblist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObList::GetCount](../vs140/coblist--getcount.md)