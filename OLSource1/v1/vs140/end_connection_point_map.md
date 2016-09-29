---
title: "END_CONNECTION_POINT_MAP"
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
  - "END_CONNECTION_POINT_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "END_CONNECTION_POINT_MAP macro"
ms.assetid: 807c5233-b58c-49a2-a34f-3b5f4a7b1b82
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# END_CONNECTION_POINT_MAP
Marks the end of the connection point map entries.  
  
## Syntax  
  
```  
  
END_CONNECTION_POINT_MAP( )  
  
```  
  
## Remarks  
 Start your connection point map with the [BEGIN_CONNECTION_POINT_MAP](../vs140/begin_connection_point_map.md) macro, add entries for each of your connection points with the [CONNECTION_POINT_ENTRY](../vs140/connection_point_entry.md) macro, and complete the map with the `END_CONNECTION_POINT_MAP` macro.  
  
 For more information about connection points in ATL, see the article [Connection Points](../vs140/atl-connection-points.md).  
  
## Example  
 [!code[NVC_ATL_Windowing#128](../vs140/codesnippet/CPP/end_connection_point_map_1.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Connection Point Macros](../vs140/connection-point-macros.md)   
 [Macros](../vs140/atl-macros.md)