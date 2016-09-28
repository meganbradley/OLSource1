---
title: "ON_COMMAND"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "ON_COMMAND"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ON_COMMAND macro"
  - "message mapping macros"
ms.assetid: f24f8bda-2cf4-49d5-aa3d-6f2e6bb003f2
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ON_COMMAND
This macro maps a command message to a member function.  
  
## Syntax  
  
```  
  
ON_COMMAND(  
id  
,   
memberFxn )  
```  
  
#### Parameters  
 `id`  
 The command ID.  
  
 `memberFxn`  
 The name of the message-handler function to which the command is mapped.  
  
## Remarks  
 It indicates which function will handle a command message from a command user-interface object such as a menu item or toolbar button.  
  
 When a command-target object receives a Windows **WM_COMMAND** message with the specified ID, `ON_COMMAND` will call the member function `memberFxn` to handle the message.  
  
 Use `ON_COMMAND` to map a single command to a member function. Use [ON_COMMAND_RANGE](../vs140/on_command_range.md) to map a range of command ids to one member function. Only one message-map entry can match a given command id. That is, you can't map a command to more than one handler. For more information and examples, see [Message Handling and Mapping Topics](../vs140/message-handling-and-mapping.md).  
  
## Example  
 [!code[NVC_MFCListView#11](../vs140/codesnippet/CPP/on_command_1.cpp)]  
  
## Requirements  
 **Header:** afxmsg_.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [ON_UPDATE_COMMAND_UI](../vs140/on_update_command_ui.md)