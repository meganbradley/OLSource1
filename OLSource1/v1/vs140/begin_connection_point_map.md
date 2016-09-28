---
title: "BEGIN_CONNECTION_POINT_MAP"
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
  - "ATL.BEGIN_CONNECTION_POINT_MAP"
  - "BEGIN_CONNECTION_POINT_MAP"
  - "ATL::BEGIN_CONNECTION_POINT_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BEGIN_CONNECTION_POINT_MAP macro"
  - "connection point maps [C++]"
ms.assetid: 3896cda6-a8e2-4ed1-ac38-befbe2352034
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BEGIN_CONNECTION_POINT_MAP
Marks the beginning of the connection point map entries.  
  
## Syntax  
  
```  
  
BEGIN_CONNECTION_POINT_MAP( x )  
```  
  
#### Parameters  
 *x*  
 [in] The name of the class containing the connection points.  
  
## Remarks  
 Start your connection point map with the `BEGIN_CONNECTION_POINT_MAP` macro, add entries for each of your connection points with the [CONNECTION_POINT_ENTRY](../vs140/connection_point_entry.md) macro, and complete the map with the [END_CONNECTION_POINT_MAP](../vs140/end_connection_point_map.md) macro.  
  
 For more information about connection points in ATL, see the article [Connection Points](../vs140/atl-connection-points.md).  
  
## Example  
 [!code[NVC_ATL_Windowing#101](../vs140/codesnippet/CPP/begin_connection_point_map_1.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Connection Point Macros](../vs140/connection-point-macros.md)   
 [Macros](../vs140/atl-macros.md)