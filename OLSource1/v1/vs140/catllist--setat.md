---
title: "CAtlList::SetAt"
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
  - "CAtlList.SetAt"
  - "CAtlList::SetAt"
  - "ATL.CAtlList.SetAt"
  - "ATL::CAtlList::SetAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAt method"
ms.assetid: b0ad9dd9-d0f7-4adb-8fe5-d8af43f1442d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlList::SetAt
Call this method to set the value of the element at a given position in the list.  
  
## Syntax  
  
```  
  
      void SetAt(  
   POSITION pos,  
   INARGTYPE element   
);  
```  
  
#### Parameters  
 `pos`  
 The POSITION value corresponding to the element to change.  
  
 `element`  
 The new element value.  
  
## Remarks  
 Replaces the existing value with `element`. In debug builds, an assertion failure will occur if `pos` is equal to NULL.  
  
## Example  
 [!code[NVC_ATL_Utilities#30](../vs140/codesnippet/CPP/catllist--setat_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlList Class](../vs140/catllist-class.md)   
 [CAtlList::RemoveAt](../vs140/catllist--removeat.md)