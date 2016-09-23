---
title: "OLE Background: Implementation Strategies"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - OLE [C++], development strategy
  - OLE applications [C++], implementing OLE
  - applications [OLE], implementing OLE
ms.assetid: 0875ddae-99df-488c-82c6-164074a81058
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# OLE Background: Implementation Strategies
Depending on your application, there are four possible implementation strategies for adding OLE support:  
  
-   You are writing a new application.  
  
     This situation usually requires the least work. You run the MFC Application Wizard and select either Advanced Features or Compound Document Support to create a skeleton application. For information on these options and what they do, see the article [Creating an MFC EXE Program](../vs140/mfc-application-wizard.md).  
  
-   You have a program written with the Microsoft Foundation Class Library version 2.0 or higher that does not support OLE.  
  
     Create a new application with the MFC Application Wizard as previously mentioned, and then copy and paste the code from the new application into your existing application. This will work for servers, containers, or automated applications. See the MFC [SCRIBBLE](../vs140/visual-c---samples.md) sample for an example of this strategy.  
  
-   You have a Microsoft Foundation Class Library program that implements OLE version 1.0 support.  
  
     See [MFC Technical Note 41](../vs140/tn041--mfc-ole1-migration-to-mfc-ole-2.md) for this conversion strategy.  
  
-   You have an application that was not written using the Microsoft Foundation Classes and that may or may not have implemented OLE support.  
  
     This situation requires the most work. One approach is to create a new application, as in the first strategy, and then copy and paste your existing code into it. If your existing code is written in C, then you may need to modify it so it can compile as C++ code. If your C code calls the Windows API, then you do not have to change it to use the Microsoft Foundation classes. This approach likely will require some restructuring of your program to support the document/view architecture used by versions 2.0 and higher of the Microsoft Foundation Classes. For more information on this architecture, see [Technical Note 25](../vs140/tn025--document--view--and-frame-creation.md).  
  
 Once you have decided on a strategy, you should either read the [Containers](../vs140/containers.md) or [Servers](../vs140/servers.md) articles (depending on the type of application you are writing) or examine the sample programs, or both. The MFC OLE samples [OCLIENT](../vs140/visual-c---samples.md) and [HIERSVR](../vs140/visual-c---samples.md) show how to implement the various aspects of containers and servers, respectively. At various points throughout these articles, you will be referred to certain functions in these samples as examples of the techniques being discussed.  
  
## See Also  
 [OLE Background](../vs140/ole-background.md)   
 [Containers: Implementing a Container](../vs140/containers--implementing-a-container.md)   
 [Servers: Implementing a Server](../vs140/servers--implementing-a-server.md)   
 [MFC Application Wizard](../vs140/mfc-application-wizard.md)