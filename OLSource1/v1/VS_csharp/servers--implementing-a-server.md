---
title: "Servers: Implementing a Server"
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
  - "servers, implementing"
  - "OLE server applications, implementing OLE servers"
ms.assetid: 5bd57e8e-3b23-4f23-9597-496fac2d24b5
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Servers: Implementing a Server
This article explains the code the MFC Application Wizard creates for a visual editing server application. If you are not using the application wizard, this article lists the areas where you must write code to implement a server application.  
  
 If you are using the application wizard to create a new server application, it provides a significant amount of server-specific code for you. If you are adding visual editing server functionality to an existing application, you must duplicate the code that the application wizard would have provided before adding the rest of the necessary server code.  
  
 The server code that the application wizard provides falls into several categories:  
  
-   Defining server resources:  
  
    -   The menu resource used when the server is editing an embedded item in its own window.  
  
    -   The menu and toolbar resources used when the server is active in place.  
  
     For more information on these resources, see [Menus and Resources: Server Additions](../VS_csharp/menus-and-resources--server-additions.md).  
  
-   Defining an item class derived from `COleServerItem`. For further details on server items, see [Servers: Server Items](../VS_csharp/servers--server-items.md).  
  
-   Changing the base class of the document class to `COleServerDoc`. For further details, see [Servers: Implementing Server Documents](../VS_csharp/servers--implementing-server-documents.md).  
  
-   Defining a frame-window class derived from `COleIPFrameWnd`. For further details, see [Servers: Implementing In-Place Frame Windows](../VS_csharp/servers--implementing-in-place-frame-windows.md).  
  
-   Creating an entry for the server application in the Windows registration database and registering the new instance of the server with the OLE system. For information on this topic, see [Registration](../VS_csharp/registration.md).  
  
-   Initializing and launching the server application. For information on this topic, see [Registration](../VS_csharp/registration.md).  
  
 For more information, see [COleServerItem](../VS_csharp/coleserveritem-class.md), [COleServerDoc](../VS_csharp/coleserverdoc-class.md), and [COleIPFrameWnd](../VS_csharp/coleipframewnd-class.md) in the *Class Library Reference*.  
  
## See Also  
 [Servers](../VS_csharp/servers.md)   
 [Containers](../VS_csharp/containers.md)   
 [Menus and Resources (OLE)](../VS_csharp/menus-and-resources--ole-.md)   
 [Registration](../VS_csharp/registration.md)