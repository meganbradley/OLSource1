---
title: "CHAIN_MSG_MAP"
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
  - "CHAIN_MSG_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHAIN_MSG_MAP macro"
ms.assetid: 2dd5af87-e12c-4730-8c9f-dcd4ef77dbdb
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHAIN_MSG_MAP
Defines an entry in a message map.  
  
## Syntax  
  
```  
  
CHAIN_MSG_MAP( theChainClass )  
```  
  
#### Parameters  
 `theChainClass`  
 [in] The name of the base class containing the message map.  
  
## Remarks  
 `CHAIN_MSG_MAP` directs messages to a base class's default message map (declared with [BEGIN_MSG_MAP](../vs140/begin_msg_map.md)). To direct messages to a base class's alternate message map (declared with [ALT_MSG_MAP](../vs140/alt_msg_map.md)), use [CHAIN_MSG_MAP_ALT](../vs140/chain_msg_map_alt.md).  
  
> [!NOTE]
>  Always begin a message map with `BEGIN_MSG_MAP`. You can then declare subsequent alternate message maps with `ALT_MSG_MAP`. The [END_MSG_MAP](../vs140/end_msg_map.md) macro marks the end of the message map. Every message map must have exactly one instance of `BEGIN_MSG_MAP` and `END_MSG_MAP`.  
  
 For more information about using message maps in ATL, see [Message Maps](../vs140/message-maps--atl-.md).  
  
## Example  
 [!code[NVC_ATL_Windowing#107](../vs140/codesnippet/CPP/chain_msg_map_1.h)]  
  
 This example illustrates the following:  
  
-   If a window procedure is using `CMyClass`'s default message map and `OnPaint` does not handle a message, the message is directed to `CMyBaseClass`'s default message map for processing.  
  
-   If a window procedure is using the first alternate message map in `CMyClass`, all messages are directed to `CMyBaseClass`'s default message map.  
  
-   If a window procedure is using `CMyClass`'s second alternate message map and `OnChar` does not handle a message, the message is directed to the specified alternate message map in `CMyBaseClass`. `CMyBaseClass` must have declared this message map with `ALT_MSG_MAP(1)`.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [Message Map Macros](../vs140/message-map-macros--atl-.md)   
 [Macros](../vs140/atl-macros.md)   
 [CHAIN_MSG_MAP_MEMBER](../vs140/chain_msg_map_member.md)   
 [CHAIN_MSG_MAP_DYNAMIC](../vs140/chain_msg_map_dynamic.md)   
 [MESSAGE_HANDLER](../vs140/message_handler.md)