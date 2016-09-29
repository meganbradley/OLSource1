---
title: "ON_UPDATE_COMMAND_UI"
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
  - "ON_UPDATE_COMMAND_UI"
  - "AFXOLE/ON_UPDATE_COMMAND_UI"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ON_UPDATE_COMMAND_UI macro"
  - "message mapping macros"
ms.assetid: c4de3c21-2d2e-4b89-a4ce-d0c0e2d9edc4
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ON_UPDATE_COMMAND_UI
This macro indicates which function will handle a user-interface update command message.  
  
## Syntax  
  
```  
  
ON_UPDATE_COMMAND_UI(  
id  
,   
memberFxn )  
```  
  
#### Parameters  
 `id`  
 The message ID.  
  
 `memberFxn`  
 The name of the message-handler function to which the message is mapped.  
  
## Remarks  
 There should be exactly one `ON_UPDATE_COMMAND_UI` macro statement in your message map for every user-interface update command that must be mapped to a message-handler function.  
  
 For more information and examples, see [Message Handling and Mapping Topics](../VS_csharp/message-handling-and-mapping.md).  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [ON_MESSAGE](../VS_csharp/on_message.md)   
 [ON_REGISTERED_MESSAGE](../VS_csharp/on_registered_message.md)   
 [ON_CONTROL](../VS_csharp/on_control.md)   
 [ON_COMMAND](../VS_csharp/on_command.md)   
 [CCmdUI Class](../VS_csharp/ccmdui-class.md)