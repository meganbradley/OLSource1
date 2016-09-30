---
title: "Servers: Implementing In-Place Frame Windows"
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
  - "frame windows, implementing"
  - "OLE server applications, frame windows"
  - "servers, in-place frame windows"
  - "frame windows, in-place"
  - "in-place frame windows"
ms.assetid: 09bde4d8-15e2-4fba-8d14-9b954d926b92
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Servers: Implementing In-Place Frame Windows
This article explains what you must do to implement in-place frame windows in your visual editing server application if you do not use the application wizard to create your server application. In place of following the procedure outlined in this article, you could use an existing in-place frame-window class from either an application wizard–generated application or a sample provided with Visual C++.  
  
#### To declare an in-place frame-window class  
  
1.  Derive an in-place frame-window class from <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>.  
  
    -   Use the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> macro in your class header file.  
  
    -   Use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> macro in your class implementation (.cpp) file. This allows objects of this class to be created by the framework.  
  
2.  Declare a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member in the frame-window class. This is needed if you want to support in-place resizing in server applications.  
  
     Declare an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> message handler (using the **Properties** window), and call **Create** for your <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> member, if you've defined it.  
  
3.  If you have a toolbar, declare a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> member in the frame-window class.  
  
     Override the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> member function to create a toolbar when the server is active in place. For example:  
  
     [!code[NVC_MFCOleServer#1](../vs140/codesnippet/CPP/servers--implementing-in-place-frame-windows_1.cpp)]  
  
     See the discussion of this code following step 5.  
  
4.  Include the header file for this in-place frame-window class in your main .cpp file.  
  
5.  In <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> for your application class, call the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function of the document template object to specify the resources and in-place frame window to be used in open and in-place editing.  
  
 The series of function calls in the **if** statement creates the toolbar from the resources the server provided. At this point, the toolbar is part of the container's window hierarchy. Because this toolbar is derived from <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, it will pass its messages to its owner, the container application's frame window, unless you change the owner. That is why the call to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is necessary. This call changes the window where commands are sent to be the server's in-place frame window, causing the messages to be passed to the server. This allows the server to react to operations on the toolbar that it provides.  
  
 The ID for the toolbar bitmap should be the same as the other in-place resources defined in your server application. See [Menus and Resources: Server Additions](../vs140/menus-and-resources--server-additions.md) for details.  
  
 For more information, see [COleIPFrameWnd](../vs140/coleipframewnd-class.md), [COleResizeBar](../vs140/coleresizebar-class.md), and [CDocTemplate::SetServerInfo](../vs140/cdoctemplate--setserverinfo.md) in the *Class Library Reference*.  
  
## See Also  
 [Servers](../vs140/servers.md)   
 [Servers: Implementing a Server](../vs140/servers--implementing-a-server.md)   
 [Servers: Implementing Server Documents](../vs140/servers--implementing-server-documents.md)   
 [Servers: Server Items](../vs140/servers--server-items.md)