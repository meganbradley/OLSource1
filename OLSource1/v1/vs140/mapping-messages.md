---
title: "Mapping Messages"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "message maps, about message maps"
  - "mappings, commands"
  - "commands, mapping"
  - "command mapping"
  - "message handling, connecting to handler functions"
  - "commands, connecting to handler functions"
  - "mappings, messages"
  - "messages, mapping"
ms.assetid: 996f0652-0698-4b8c-b893-cdaa836d9d0f
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Mapping Messages
Each framework class that can receive messages or commands has its own "message map." The framework uses message maps to connect messages and commands to their handler functions. Any class derived from class `CCmdTarget` can have a message map. Other articles explain message maps in detail and describe how to use them.  
  
 In spite of the name "message map," message maps handle both messages and commands — all three categories of messages listed in [Message Categories](../vs140/message-categories.md).  
  
## See Also  
 [Messages and Commands in the Framework](../vs140/messages-and-commands-in-the-framework.md)