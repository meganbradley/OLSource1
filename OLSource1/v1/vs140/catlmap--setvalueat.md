---
title: "CAtlMap::SetValueAt"
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
  - "ATL::CAtlMap::SetValueAt"
  - "SetValueAt"
  - "ATL.CAtlMap.SetValueAt"
  - "CAtlMap.SetValueAt"
  - "CAtlMap::SetValueAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetValueAt method"
ms.assetid: 1360be45-f32c-4bda-a54a-6bd691e3c1ef
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlMap::SetValueAt
Call this method to change the value stored at a given position in the `CAtlMap` object.  
  
## Syntax  
  
```  
  
      void SetValueAt(  
   POSITION pos,  
   VINARGTYPE value   
);  
```  
  
#### Parameters  
 `pos`  
 The position counter, returned by a previous call to [CAtlMap::GetNextAssoc](../vs140/catlmap--getnextassoc.md) or [CAtlMap::GetStartPosition](../vs140/catlmap--getstartposition.md).  
  
 *value*  
 The value to add to the `CAtlMap` object.  
  
## Remarks  
 Changes the value element stored at the given position in the `CAtlMap` object.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlMap Class](../vs140/catlmap-class.md)   
 [CAtlMap::SetAt](../vs140/catlmap--setat.md)   
 [CAtlMap::GetKeyAt](../vs140/catlmap--getkeyat.md)