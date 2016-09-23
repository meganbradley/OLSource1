---
title: "CJumpList::AddKnownCategory"
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
  - AddKnownCategory
  - afxadv/CJumpList::AddKnownCategory
dev_langs: 
  - C++
helpviewer_keywords: 
  - AddKnownCategory
ms.assetid: 76ac24d3-914e-45b6-8a04-cfc2452abb3e
caps.latest.revision: 10
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CJumpList::AddKnownCategory
Appends a Known Category to the list.  
  
## Syntax  
  
```  
BOOL AddKnownCategory(  
   KNOWNDESTCATEGORY category  
);  
```  
  
#### Parameters  
 `category`  
 Specifies a known category type. Can be either `KDC_RECENT`, or `KDC_KNOWN`.  
  
## Return Value  
  
## Remarks  
 Known Categories are the Frequent and Recent categories that we will automatically calculate for every application that utilizes `SHAddToRecentDocs` (or indirectly uses it as the shell will call it on the application's behalf in some scenarios).  
  
## Requirements  
 **Header:** afxadv.h  
  
## See Also  
 [CJumpList](../vs140/cjumplist-class.md)