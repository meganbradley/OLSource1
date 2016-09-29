---
title: "DECLARE_EMPTY_MSG_MAP"
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
  - "DECLARE_EMPTY_MSG_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "empty message maps"
  - "DECLARE_EMPTY_MSG_MAP macro"
ms.assetid: fa78c82a-fb48-433c-85dc-a253e40ba07a
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DECLARE_EMPTY_MSG_MAP
Declares an empty message map.  
  
## Syntax  
  
```  
  
DECLARE_EMPTY_MSG_MAP( )  
  
```  
  
## Remarks  
 `DECLARE_EMPTY_MSG_MAP` is a convenience macro that calls the macros [BEGIN_MSG_MAP](../vs140/begin_msg_map.md) and [END_MSG_MAP](../vs140/end_msg_map.md) to create an empty message map:  
  
 [!code[NVC_ATL_Windowing#122](../vs140/codesnippet/CPP/declare_empty_msg_map_1.h)]  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [Message Map Macros](../vs140/message-map-macros--atl-.md)   
 [Macros](../vs140/atl-macros.md)