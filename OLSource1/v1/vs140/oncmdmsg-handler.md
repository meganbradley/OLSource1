---
title: "OnCmdMsg Handler"
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
  - "OnCmdMsg"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "messages, routing"
  - "handlers"
  - "command routing, OnCmdMsg handler"
  - "handlers, OnCmdMessage"
  - "OnCmdMessage method"
ms.assetid: 8df07024-506f-47e7-bba9-1c3bc5ad8ab6
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# OnCmdMsg Handler
To accomplish the routing of commands, each command target calls the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> member function of the next command target in the sequence. Command targets use <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to determine whether they can handle a command and to route it to another command target if they cannot handle it.  
  
 Each command-target class may override the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member function. The overrides let each class route commands to a particular next target. A frame window, for example, always routes commands to its current child window or view, as shown in the table [Standard Command Route](../vs140/command-routing.md).  
  
 The default <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> implementation of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> uses the message map of the command-target class to search for a handler function for each command message it receives — in the same way that standard messages are searched. If it finds a match, it calls the handler. Message-map searching is explained in [How the Framework Searches Message Maps](../vs140/how-the-framework-searches-message-maps.md).  
  
## See Also  
 [How the Framework Calls a Handler](../vs140/how-the-framework-calls-a-handler.md)