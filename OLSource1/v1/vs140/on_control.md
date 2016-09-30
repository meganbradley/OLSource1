---
title: "ON_CONTROL"
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
  - "ON_CONTROL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ON_CONTROL macro"
  - "message mapping macros"
ms.assetid: 2cb7ebdf-296b-4606-b191-3449835003db
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ON_CONTROL
Indicates which function will handle a custom-control notification message.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The notification code of the control.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The command ID.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The name of the message-handler function to which the command is mapped.  
  
## Remarks  
 Control notification messages are those sent from a control to its parent window.  
  
 There should be exactly one <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> macro statement in your message map for every control notification message that must be mapped to a message-handler function.  
  
 For more information and examples, see [Message Handling and Mapping Topics](../vs140/message-handling-and-mapping.md).  
  
## Requirements  
 **Header:** afxmsg_.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [ON_MESSAGE](../vs140/on_message.md)   
 [ON_REGISTERED_MESSAGE](../vs140/on_registered_message.md)