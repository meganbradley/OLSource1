---
title: "ON_MESSAGE"
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
  - "ON_MESSAGE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ON_MESSAGE macro"
  - "message mapping macros"
ms.assetid: e2faeb13-9f6e-4c0d-9f6d-b2e141a0db1e
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ON_MESSAGE
Indicates which function will handle a user-defined message.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The message ID.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The name of the message-handler function to which the message is mapped.  
  
 The type of the function must be <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 User-defined messages are any messages that are not standard Windows <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> messages. When selecting a message ID, you must use values within the range of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> (0x0400) to 0x7FFF or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> (0x8000) to 0xBFFF. For more information regarding message IDs, see [WM_APP](http://msdn.microsoft.com/library/windows/desktop/ms644930).  
  
 There should be exactly one <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> macro statement in your message map for every user-defined message that must be mapped to a message-handler function.  
  
> [!NOTE]
>  In addition to user-defined messages, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> handles less common Windows messages. For more information, see Knowledge Base article [99848: INFO: Use ON_MESSAGE() Macro to Map Less-Common Messages](http://go.microsoft.com/fwlink/?linkId=192022).  
  
 For more information and examples, see [Message Handling and Mapping Topics](../vs140/message-handling-and-mapping.md) and [User-Defined Handlers](../vs140/user-defined-handlers.md)  
  
## Example  
 [!code[NVC_MFCMessageMaps#4](../vs140/codesnippet/CPP/on_message_1.h)]  
  
 [!code[NVC_MFCMessageMaps#5](../vs140/codesnippet/CPP/on_message_2.cpp)]  
  
 [!code[NVC_MFCMessageMaps#3](../vs140/codesnippet/CPP/on_message_3.h)]  
  
 [!code[NVC_MFCMessageMaps#14](../vs140/codesnippet/CPP/on_message_4.cpp)]  
  
## Requirements  
 **Header:** afxmsg_.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [ON_UPDATE_COMMAND_UI](../vs140/on_update_command_ui.md)   
 [ON_CONTROL](../vs140/on_control.md)   
 [ON_REGISTERED_MESSAGE](../vs140/on_registered_message.md)   
 [ON_COMMAND](../vs140/on_command.md)