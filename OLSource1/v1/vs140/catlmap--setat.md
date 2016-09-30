---
title: "CAtlMap::SetAt"
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
  - "ATL.CAtlMap.SetAt"
  - "CAtlMap::SetAt"
  - "ATL::CAtlMap::SetAt"
  - "CAtlMap.SetAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAt method"
ms.assetid: c909fc7b-f6ea-4903-b536-2395dd6bed44
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlMap::SetAt
Call this method to insert an element pair into the map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The key value to add to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
 *value*  
 The value to add to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
## Return Value  
 Returns the position of the key/value element pair in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
## Remarks  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> replaces an existing element if a matching key is found. If the key is not found, a new key/value pair is created.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlMap Class](../vs140/catlmap-class.md)   
 [CAtlMap::SetValueAt](../vs140/catlmap--setvalueat.md)