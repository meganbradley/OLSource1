---
title: "CAtlArray::FreeExtra"
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
  - "ATL::CAtlArray::FreeExtra"
  - "CAtlArray::FreeExtra"
  - "CAtlArray.FreeExtra"
  - "ATL.CAtlArray.FreeExtra"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FreeExtra method"
ms.assetid: ef490308-43a8-4660-ba25-96aee8f91581
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlArray::FreeExtra
Call this method to remove any empty elements from the array.  
  
## Syntax  
  
```  
  
void FreeExtra( ) throw( );  
  
```  
  
## Remarks  
 Any empty elements are removed, but the size and upper bound of the array remain unchanged.  
  
 In debug builds, an ATLASSERT will be raised if the CAtlArray object is not valid, or if the array would exceed its maximum size.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlArray Class](../vs140/catlarray-class.md)   
 [CAtlArray::RemoveAll](../vs140/catlarray--removeall.md)