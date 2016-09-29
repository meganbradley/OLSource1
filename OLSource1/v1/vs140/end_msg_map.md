---
title: "END_MSG_MAP"
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
  - "END_MSG_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "END_MSG_MAP macro"
ms.assetid: 5eaf5b69-6846-4c43-8e9c-be940ca13bee
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# END_MSG_MAP
Marks the end of a message map.  
  
## Syntax  
  
```  
  
END_MSG_MAP( )  
  
```  
  
## Remarks  
 Always use the [BEGIN_MSG_MAP](../vs140/begin_msg_map.md) macro to mark the beginning of a message map. Use [ALT_MSG_MAP](../vs140/alt_msg_map.md) to declare subsequent alternate message maps.  
  
 Note that there is always exactly one instance of `BEGIN_MSG_MAP` and `END_MSG_MAP`.  
  
 For more information about using message maps in ATL, see [Message Maps](../vs140/message-maps--atl-.md).  
  
## Example  
 The following example shows the default message map and one alternate message map, each containing one handler function:  
  
 [!code[NVC_ATL_Windowing#98](../vs140/codesnippet/CPP/end_msg_map_1.h)]  
  
 The next example shows two alternate message maps. The default message map is empty.  
  
 [!code[NVC_ATL_Windowing#99](../vs140/codesnippet/CPP/end_msg_map_2.h)]  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [Message Map Macros](../vs140/message-map-macros--atl-.md)   
 [Macros](../vs140/atl-macros.md)