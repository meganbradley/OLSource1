---
title: "Overriding the Standard Command Routing"
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
  - "MFC, command routing"
  - "command routing, overriding"
  - "command handling, routing commands"
  - "overriding, standard command routing"
ms.assetid: 872b698a-7432-40c4-9008-68721e8effa5
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Overriding the Standard Command Routing
In rare cases when you must implement some variation of the standard framework routing, you can override it. The idea is to change the routing in one or more classes by overriding `OnCmdMsg` in those classes. Do so:  
  
-   In the class that breaks the order to pass to a nondefault object.  
  
-   In the new nondefault object or in command targets it might in turn pass commands to.  
  
 If you insert some new object into the routing, its class must be a command-target class. In your overriding versions of `OnCmdMsg`, be sure to call the version that you're overriding. See the [OnCmdMsg](../vs140/ccmdtarget--oncmdmsg.md) member function of class `CCmdTarget` in the *MFC Reference* and the versions in such classes as `CView` and **CDocument** in the supplied source code for examples.  
  
## See Also  
 [How the Framework Calls a Handler](../vs140/how-the-framework-calls-a-handler.md)