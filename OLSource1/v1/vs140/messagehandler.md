---
title: "MessageHandler"
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
  - "MessageHandler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MessageHandler function"
ms.assetid: 8a0acf97-1b0d-4226-91b9-75446634a03c
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MessageHandler
**MessageHandler** is the name of the function identified by the second parameter of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> macro in your message map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the message.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Additional message-specific information.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Additional message-specific information.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The message map sets <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to **TRUE** before <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is called. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> does not fully handle the message, it should set <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to **FALSE** to indicate the message needs further processing.  
  
## Return Value  
 The result of message processing. 0 if successful.  
  
## Remarks  
 For an example of using this message handler in a message map, see [MESSAGE_HANDLER](../vs140/message_handler.md).  
  
## See Also  
 [Implementing a Window](../vs140/implementing-a-window.md)   
 [Message Maps](../vs140/message-maps--atl-.md)   
 [WM_NOTIFY](http://msdn.microsoft.com/library/windows/desktop/bb775583)