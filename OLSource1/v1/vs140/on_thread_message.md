---
title: "ON_THREAD_MESSAGE"
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
  - "ON_THREAD_MESSAGE"
  - "AFXOLE/ON_THREAD_MESSAGE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ON_THREAD_MESSAGE macro"
ms.assetid: f718f47a-d5b1-4514-914b-e3fe2d919003
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ON_THREAD_MESSAGE
Indicates which function will handle a user-defined message.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The message ID.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The name of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>-message-handler function to which the message is mapped.  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> must be used instead of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> when you have a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> class. User-defined messages are any messages that are not standard Windows **WM_MESSAGE** messages. There should be exactly one <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> macro statement in your message map for every user-defined message that must be mapped to a message-handler function.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [ON_MESSAGE](../vs140/on_message.md)   
 [ON_REGISTERED_THREAD_MESSAGE](../vs140/on_registered_thread_message.md)   
 [CWinThread Class](../vs140/cwinthread-class.md)