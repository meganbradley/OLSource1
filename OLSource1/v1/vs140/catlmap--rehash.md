---
title: "CAtlMap::Rehash"
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
  - "ATL::CAtlMap::Rehash"
  - "ATL.CAtlMap.Rehash"
  - "Rehash"
  - "CAtlMap.Rehash"
  - "CAtlMap::Rehash"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Rehash method"
ms.assetid: 05dc2957-a10e-444c-8617-22cd2892142c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlMap::Rehash
Call this method to rehash the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The new number of bins to use in the hash table. See [CAtlMap::CAtlMap](../vs140/catlmap--catlmap.md) for an explanation.  
  
## Remarks  
 If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is 0, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> calculates a reasonable number based on the number of elements in the map and the optimal load setting. Normally the rehashing process is automatic, but if [CAtlMap::DisableAutoRehash](../vs140/catlmap--disableautorehash.md) has been called, this method will perform the necessary resizing.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlMap Class](../vs140/catlmap-class.md)