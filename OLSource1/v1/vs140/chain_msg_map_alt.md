---
title: "CHAIN_MSG_MAP_ALT"
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
  - "CHAIN_MSG_MAP_ALT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHAIN_MSG_MAP_ALT macro"
ms.assetid: a181f51e-481d-4edb-984a-c710ac6a8bbb
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHAIN_MSG_MAP_ALT
Defines an entry in a message map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The name of the base class containing the message map.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The message map identifier.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> directs messages to an alternate message map in a base class. You must have declared this alternate message map with [ALT_MSG_MAP(msgMapID)](../vs140/alt_msg_map.md). To direct messages to a base class's default message map (declared with [BEGIN_MSG_MAP](../vs140/begin_msg_map.md)), use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. For an example, see [CHAIN_MSG_MAP](../vs140/chain_msg_map.md).  
  
> [!NOTE]
>  Always begin a message map with <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. You can then declare subsequent alternate message maps with <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The [END_MSG_MAP](../vs140/end_msg_map.md) macro marks the end of the message map. Every message map must have exactly one instance of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 For more information about using message maps in ATL, see [Message Maps](../vs140/message-maps--atl-.md).  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [Message Map Macros](../vs140/message-map-macros--atl-.md)   
 [Macros](../vs140/atl-macros.md)   
 [CHAIN_MSG_MAP_ALT_MEMBER](../vs140/chain_msg_map_alt_member.md)