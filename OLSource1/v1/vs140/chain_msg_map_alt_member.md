---
title: "CHAIN_MSG_MAP_ALT_MEMBER"
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
  - "CHAIN_MSG_MAP_ALT_MEMBER"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHAIN_MSG_MAP_ALT_MEMBER macro"
ms.assetid: f0c130ec-52fa-4a76-9a2c-5c217aaaea1a
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHAIN_MSG_MAP_ALT_MEMBER
Defines an entry in a message map.  
  
## Syntax  
  
```  
  
CHAIN_MSG_MAP_ALT_MEMBER( theChainMember, msgMapID )  
```  
  
#### Parameters  
 `theChainMember`  
 [in] The name of the data member containing the message map.  
  
 `msgMapID`  
 [in] The message map identifier.  
  
## Remarks  
 `CHAIN_MSG_MAP_ALT_MEMBER` directs messages to an alternate message map in a data member. You must have declared this alternate message map with [ALT_MSG_MAP(msgMapID)](../vs140/alt_msg_map.md). To direct messages to a data member's default message map (declared with [BEGIN_MSG_MAP](../vs140/begin_msg_map.md)), use `CHAIN_MSG_MAP_MEMBER`. For an example, see [CHAIN_MSG_MAP_MEMBER](../vs140/chain_msg_map_member.md).  
  
> [!NOTE]
>  Always begin a message map with `BEGIN_MSG_MAP`. You can then declare subsequent alternate message maps with `ALT_MSG_MAP`. The [END_MSG_MAP](../vs140/end_msg_map.md) macro marks the end of the message map. Every message map must have exactly one instance of `BEGIN_MSG_MAP` and `END_MSG_MAP`.  
  
 For more information about using message maps in ATL, see [Message Maps](../vs140/message-maps--atl-.md).  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [Message Map Macros](../vs140/message-map-macros--atl-.md)   
 [Macros](../vs140/atl-macros.md)   
 [CHAIN_MSG_MAP_ALT](../vs140/chain_msg_map_alt.md)