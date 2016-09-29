---
title: "Message Handlers"
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
  - "message handlers"
  - "command handling, message handlers"
  - "handlers"
  - "message handling, message handler functions"
  - "handlers, command"
  - "handlers, message"
ms.assetid: 51bc4e76-dbe3-4cc2-b026-3199d56b2fa9
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Message Handlers
In MFC, a dedicated *handler* function processes each separate message. Message-handler functions are member functions of a class. This documentation uses the terms *message-handler member function*, *message-handler function*, *message handler*, and *handler* interchangeably. Some kinds of message handlers are also called "command handlers."  
  
 Writing message handlers accounts for a large proportion of your work in writing a framework application. This article family describes how the message-processing mechanism works.  
  
 What does the handler for a message do? It does whatever you want done in response to that message. You can create the handlers by using the Properties window of the class, and then fill in the handler's code using the source code editor.  
  
 You can use all of the facilities of Microsoft Visual C++ and MFC to write your handlers. For a list of all classes, see [Class Library Overview](../VS_csharp/class-library-overview.md) in the *MFC Reference*.  
  
## See Also  
 [Messages and Commands in the Framework](../VS_csharp/messages-and-commands-in-the-framework.md)