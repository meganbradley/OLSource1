---
title: "CSimpleMap::SetAtIndex"
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
  - "CSimpleMap.SetAtIndex"
  - "ATL.CSimpleMap.SetAtIndex"
  - "ATL::CSimpleMap::SetAtIndex"
  - "CSimpleMap::SetAtIndex"
  - "SetAtIndex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAtIndex method"
ms.assetid: 53fd21f0-9c70-429c-98d0-bf7bbce66e84
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleMap::SetAtIndex
Sets the key and value at a specified index.  
  
## Syntax  
  
```  
  
      BOOL SetAtIndex(  
   int nIndex,  
   const TKey& key,  
   const TVal& val   
);  
```  
  
#### Parameters  
 `nIndex`  
 The index, referencing the key and value pairing to change.  
  
 `key`  
 The new key.  
  
 *val*  
 The new value.  
  
## Return Value  
 Returns TRUE if successful, FALSE if the index was not valid.  
  
## Remarks  
 Updates both the key and value pointed to by `nIndex`.  
  
## Requirements  
 **Header:** atlsimpcoll.h  
  
## See Also  
 [CSimpleMap Class](../vs140/csimplemap-class.md)   
 [CSimpleMap::SetAt](../vs140/csimplemap--setat.md)