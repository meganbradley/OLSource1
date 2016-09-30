---
title: "CAtlMap::Lookup"
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
  - "ATL::CAtlMap::Lookup"
  - "ATL.CAtlMap.Lookup"
  - "CAtlMap::Lookup"
  - "CAtlMap.Lookup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Lookup method"
ms.assetid: d864f785-1a96-4c5d-b345-7cb60d176ca9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlMap::Lookup
Call this method to look up keys or values in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the key that identifies the element to be looked up.  
  
 *value*  
 Variable that receives the looked-up value.  
  
## Return Value  
 The first form of the method returns true if the key is found, otherwise false. The second and third forms return a pointer to a [CPair](../vs140/catlmap--cpair-class.md) which can be used as a position for calls to [CAtlMap::GetNext](../vs140/catlmap--getnext.md) and so on.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> uses a hashing algorithm to quickly find the map element containing a key that exactly matches the given key parameter.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlMap Class](../vs140/catlmap-class.md)