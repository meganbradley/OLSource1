---
title: "CAtlMap::RemoveAtPos"
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
  - "CAtlMap::RemoveAtPos"
  - "ATL.CAtlMap.RemoveAtPos"
  - "ATL::CAtlMap::RemoveAtPos"
  - "RemoveAtPos"
  - "CAtlMap.RemoveAtPos"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveAtPos method"
ms.assetid: c15fc734-4a39-4723-a1b6-65f7aa1de5ca
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlMap::RemoveAtPos
Call this method to remove the element at the given position in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The position counter, returned by a previous call to [CAtlMap::GetNextAssoc](../vs140/catlmap--getnextassoc.md) or [CAtlMap::GetStartPosition](../vs140/catlmap--getstartposition.md).  
  
## Remarks  
 Removes the key/value pair stored at the specified position. The memory used to store the element is freed. The POSITION referenced by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> becomes invalid, and while the POSITION of any other elements in the map remains valid, they do not necessarily retain the same order.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlMap Class](../vs140/catlmap-class.md)   
 [CAtlMap::RemoveKey](../vs140/catlmap--removekey.md)   
 [CAtlMap::RemoveAll](../vs140/catlmap--removeall.md)