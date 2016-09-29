---
title: "SDI Server Applications"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "SDI server applications"
  - "SDI server applications, debugging"
ms.assetid: 09713718-1376-4753-b119-26f36639693e
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SDI Server Applications
If you are debugging an SDI server application, you must specify `/Embedding` or `/Automation` in the **Command line arguments** property in the *Project* Property Pages dialog box for C/C++, C#, or Visual Basic projects.  
  
 With these command line arguments, the debugger can launch the server application as though it were launched from a container. Starting the container from Program Manager or File Manager will then cause the container to use the instance of the server started in the debugger.  
  
## Finding the Command Line Arguments Property  
 To access the *Project* Property Pages dialog box, right-click your project in Solution Explorer, and then choose Properties from the shortcut menu. To find the Command line arguments property, expand the Configuration Properties category and click the Debugging page.  
  
## See Also  
 [COM and ActiveX Debugging](../vs140/com-and-activex-debugging.md)   
 [How to: Debug COM Servers](../vs140/how-to--debug-com-servers.md)