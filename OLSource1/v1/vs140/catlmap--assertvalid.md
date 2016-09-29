---
title: "CAtlMap::AssertValid"
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
  - "CAtlMap::AssertValid"
  - "ATL::CAtlMap::AssertValid"
  - "ATL.CAtlMap.AssertValid"
  - "CAtlMap.AssertValid"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AssertValid method"
ms.assetid: 5f5d251d-6b50-4519-807f-86b128be7b8a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlMap::AssertValid
Call this method to cause an ASSERT if the `CAtlMap` object is not valid.  
  
## Syntax  
  
```  
  
void AssertValid( ) const;  
  
```  
  
## Remarks  
 In debug builds, this method will cause an ASSERT if the `CAtlMap` object is not valid.  
  
## Example  
 See the example for [CAtlMap::CAtlMap](../vs140/catlmap--catlmap.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlMap Class](../vs140/catlmap-class.md)   
 [CAtlMap::IsEmpty](../vs140/catlmap--isempty.md)