---
title: "CSimpleMap::GetValueAt"
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
  - "GetValueAt"
  - "CSimpleMap::GetValueAt"
  - "CSimpleMap.GetValueAt"
  - "ATL.CSimpleMap.GetValueAt"
  - "ATL::CSimpleMap::GetValueAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetValueAt method"
ms.assetid: e7e8217d-fe1d-4b44-8cff-abe959162c2a
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleMap::GetValueAt
Retrieves the value at the specific index.  
  
## Syntax  
  
```  
  
      TVal& GetValueAt(  
   int nIndex   
) const;  
```  
  
#### Parameters  
 `nIndex`  
 The index of the value to return.  
  
## Return Value  
 Returns the value referenced by `nIndex`.  
  
## Remarks  
 The index passed by `nIndex` must be valid for the return value to be meaningful.  
  
## Requirements  
 **Header:** atlsimpcoll.h  
  
## See Also  
 [CSimpleMap Class](../vs140/csimplemap-class.md)   
 [CSimpleMap::GetKeyAt](../vs140/csimplemap--getkeyat.md)