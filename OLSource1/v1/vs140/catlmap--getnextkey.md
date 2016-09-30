---
title: "CAtlMap::GetNextKey"
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
  - "ATL.CAtlMap.GetNextKey"
  - "GetNextKey"
  - "CAtlMap.GetNextKey"
  - "ATL::CAtlMap::GetNextKey"
  - "CAtlMap::GetNextKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNextKey method"
ms.assetid: 5d7146ce-c526-4095-b5c9-c2ee7cfff87a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlMap::GetNextKey
Call this method to retrieve the next key from the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The position counter, returned by a previous call to [CAtlMap::GetNextAssoc](../vs140/catlmap--getnextassoc.md) or [CAtlMap::GetStartPosition](../vs140/catlmap--getstartposition.md).  
  
## Return Value  
 Returns a reference to the next key in the map.  
  
## Remarks  
 Updates the current position counter, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. If there are no more entries in the map, the position counter is set to NULL.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlMap Class](../vs140/catlmap-class.md)   
 [CAtlMap::GetNextValue](../vs140/catlmap--getnextvalue.md)   
 [CAtlMap::GetNext](../vs140/catlmap--getnext.md)   
 [CAtlMap::GetNextAssoc](../vs140/catlmap--getnextassoc.md)