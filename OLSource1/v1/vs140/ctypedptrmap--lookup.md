---
title: "CTypedPtrMap::Lookup"
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
  - "CTypedPtrMap::Lookup"
  - "CTypedPtrMap.Lookup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Lookup method"
ms.assetid: 1c2d1497-de52-4a94-9de6-49c998c80517
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTypedPtrMap::Lookup
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder> uses a hashing algorithm to quickly find the map element with a key that matches exactly.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Template parameter specifying the base class of this map's class.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The key of the element to be looked up.  
  
 *VALUE*  
 Template parameter specifying the type of values stored in this map.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the returned value of the retrieved element.  
  
## Return Value  
 Nonzero if the element was found; otherwise 0.  
  
## Remarks  
 This inline function calls <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>**::Lookup**.  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CTypedPtrMap Class](../vs140/ctypedptrmap-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMapStringToOb::Lookup](../vs140/cmapstringtoob--lookup.md)