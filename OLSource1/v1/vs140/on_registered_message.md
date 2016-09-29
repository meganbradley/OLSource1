---
title: "ON_REGISTERED_MESSAGE"
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
  - "ON_REGISTERED_MESSAGE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ON_REGISTERED_MESSAGE macro"
  - "message mapping macros"
ms.assetid: 93c1c068-ae8c-4e04-8a60-a603800ab57d
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ON_REGISTERED_MESSAGE
The Windows **RegisterWindowMessage** function is used to define a new window message that is guaranteed to be unique throughout the system.  
  
## Syntax  
  
```  
  
ON_REGISTERED_MESSAGE(  
nMessageVariable  
,   
memberFxn )  
```  
  
#### Parameters  
 `nMessageVariable`  
 The registered window-message ID variable.  
  
 `memberFxn`  
 The name of the message-handler function to which the message is mapped.  
  
## Remarks  
 This macro indicates which function will handle the registered message.  
  
 For more information and examples, see [Message Handling and Mapping Topics](../vs140/message-handling-and-mapping.md).  
  
## Example  
 [!code[NVC_MFCMessageMaps#8](../vs140/codesnippet/CPP/on_registered_message_1.h)]  
  
 [!code[NVC_MFCMessageMaps#15](../vs140/codesnippet/CPP/on_registered_message_2.cpp)]  
  
## Requirements  
 **Header:** afxmsg_.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [ON_MESSAGE](../vs140/on_message.md)   
 [ON_UPDATE_COMMAND_UI](../vs140/on_update_command_ui.md)   
 [ON_CONTROL](../vs140/on_control.md)   
 [ON_COMMAND](../vs140/on_command.md)   
 [RegisterWindowMessage](http://msdn.microsoft.com/library/windows/desktop/ms644947)   
 [User-Defined Handlers](../vs140/user-defined-handlers.md)