---
title: "CAtlMap::SetOptimalLoad"
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
  - "SetOptimalLoad"
  - "ATL.CAtlMap.SetOptimalLoad"
  - "ATL::CAtlMap::SetOptimalLoad"
  - "CAtlMap::SetOptimalLoad"
  - "CAtlMap.SetOptimalLoad"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetOptimalLoad method"
ms.assetid: 1e110a1c-2b36-4753-b977-3cee25673b0b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlMap::SetOptimalLoad
Call this method to set the optimal load of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The optimal load ratio.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The lower threshold for the load ratio.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The upper threshold for the load ratio.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Flag indicating if the hash table should be recalculated.  
  
## Remarks  
 This method redefines the optimal load value for the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object. See [CAtlMap::CAtlMap](../vs140/catlmap--catlmap.md) for a discussion of the various parameters. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is true, and the number of elements is outside the minimum and maximum values, the hash table is recalculated.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlMap Class](../vs140/catlmap-class.md)