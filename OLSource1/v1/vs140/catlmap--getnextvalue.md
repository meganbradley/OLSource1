---
title: "CAtlMap::GetNextValue"
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
  - "CAtlMap::GetNextValue"
  - "ATL.CAtlMap.GetNextValue"
  - "GetNextValue"
  - "ATL::CAtlMap::GetNextValue"
  - "CAtlMap.GetNextValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNextValue method"
ms.assetid: 9efeb96b-52a7-45aa-97ab-03ad3773b53e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlMap::GetNextValue
Call this method to get the next value from the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The position counter, returned by a previous call to [CAtlMap::GetNextAssoc](../vs140/catlmap--getnextassoc.md) or [CAtlMap::GetStartPosition](../vs140/catlmap--getstartposition.md).  
  
## Return Value  
 Returns a reference to the next value in the map.  
  
## Remarks  
 Updates the current position counter, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. If there are no more entries in the map, the position counter is set to NULL.  
  
## Example  
 See the example for [CAtlMap::CAtlMap](../vs140/catlmap--catlmap.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlMap Class](../vs140/catlmap-class.md)   
 [CAtlMap::GetNext](../vs140/catlmap--getnext.md)   
 [CAtlMap::GetNextKey](../vs140/catlmap--getnextkey.md)   
 [CAtlMap::GetNextAssoc](../vs140/catlmap--getnextassoc.md)