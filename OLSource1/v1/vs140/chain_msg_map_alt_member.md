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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The name of the data member containing the message map.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The message map identifier.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> directs messages to an alternate message map in a data member. You must have declared this alternate message map with [ALT_MSG_MAP(msgMapID)](../vs140/alt_msg_map.md). To direct messages to a data member's default message map (declared with [BEGIN_MSG_MAP](../vs140/begin_msg_map.md)), use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. For an example, see [CHAIN_MSG_MAP_MEMBER](../vs140/chain_msg_map_member.md).  
  
> [!NOTE]
>  Always begin a message map with <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. You can then declare subsequent alternate message maps with <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The [END_MSG_MAP](../vs140/end_msg_map.md) macro marks the end of the message map. Every message map must have exactly one instance of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 For more information about using message maps in ATL, see [Message Maps](../vs140/message-maps--atl-.md).  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [Message Map Macros](../vs140/message-map-macros--atl-.md)   
 [Macros](../vs140/atl-macros.md)   
 [CHAIN_MSG_MAP_ALT](../vs140/chain_msg_map_alt.md)