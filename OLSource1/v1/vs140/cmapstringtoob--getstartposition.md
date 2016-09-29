---
title: "CMapStringToOb::GetStartPosition"
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
  - "CMapStringToOb.GetStartPosition"
  - "CMapStringToOb::GetStartPosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetStartPosition method"
  - "CMapStringToOb class, operations"
ms.assetid: 49a6382a-6505-450b-941d-35a15655d170
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMapStringToOb::GetStartPosition
Starts a map iteration by returning a **POSITION** value that can be passed to a `GetNextAssoc` call.  
  
## Syntax  
  
```  
  
POSITION GetStartPosition( ) const;  
```  
  
## Return Value  
 A **POSITION** value that indicates a starting position for iterating the map; or **NULL** if the map is empty.  
  
## Remarks  
 The iteration sequence is not predictable; therefore, the "first element in the map" has no special significance.  
  
 The following table shows other member functions that are similar to `CMapStringToOb::GetStartPosition`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)|**POSITION GetStartPosition( ) const;**|  
|[CMapPtrToWord](../vs140/cmapptrtoword-class.md)|**POSITION GetStartPosition( ) const;**|  
|[CMapStringToPtr](../vs140/cmapstringtoptr-class.md)|**POSITION GetStartPosition( ) const;**|  
|[CMapStringToString](../vs140/cmapstringtostring-class.md)|**POSITION GetStartPosition( ) const;**|  
|[CMapWordToOb](../vs140/cmapwordtoob-class.md)|**POSITION GetStartPosition( ) const;**|  
|[CMapWordToPtr](../vs140/cmapwordtoptr-class.md)|**POSITION GetStartPosition( ) const;**|  
  
## Example  
 See the example for [CMapStringToOb::GetNextAssoc](../vs140/cmapstringtoob--getnextassoc.md).  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CMapStringToOb Class](../vs140/cmapstringtoob-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)