---
title: "Windows Sockets: Deriving from Socket Classes"
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
  - "derived classes, from socket classes"
  - "Windows Sockets [C++], deriving from socket classes"
  - "sockets [C++], deriving from socket classes"
ms.assetid: 3a26e67a-e323-433b-9b05-eca018799801
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Windows Sockets: Deriving from Socket Classes
This article describes some of the functionality you can gain by deriving your own class from one of the socket classes.  
  
 You can derive your own socket classes from either [CAsyncSocket](../vs140/casyncsocket-class.md) or [CSocket](../vs140/csocket-class.md) to add your own functionality. In particular, these classes supply a number of virtual member functions that you can override. These functions include [OnReceive](../vs140/casyncsocket--onreceive.md), [OnSend](../vs140/casyncsocket--onsend.md), [OnAccept](../vs140/casyncsocket--onaccept.md), [OnConnect](../vs140/casyncsocket--onconnect.md), and [OnClose](../vs140/casyncsocket--onclose.md). You can override the functions in your derived socket class to take advantage of the notifications they provide when network events occur. The framework calls these notification callback functions to notify you of important socket events, such as the receipt of data that you can begin reading. For more information about notification functions, see [Windows Sockets: Socket Notifications](../vs140/windows-sockets--socket-notifications.md).  
  
 Additionally, class <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> supplies the [OnMessagePending](../vs140/csocket--onmessagepending.md) member function (an advanced overridable). MFC calls this function while the socket is pumping Windows-based messages. You can override <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to look for particular messages from Windows and respond to them.  
  
 The default version of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> supplied in class <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> examines the message queue for <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> messages while waiting for a blocking call to complete. It dispatches paint messages to improve display quality. Aside from doing something useful, this illustrates one way you might override the function yourself. As another example, consider using <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> for the following task. Suppose you display a modeless dialog box while waiting for a network transaction to complete. The dialog box contains a Cancel button that the user can use to cancel blocking transactions that take too long. Your <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> override might pump messages related to this modeless dialog box.  
  
 In your <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> override, return either **TRUE** or the return from a call to the base-class version of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. Call the base-class version if it performs work that you still want done.  
  
 For more information, see:  
  
-   [Windows Sockets: Using Sockets with Archives](../vs140/windows-sockets--using-sockets-with-archives.md)  
  
-   [Windows Sockets: Using Class CAsyncSocket](../vs140/windows-sockets--using-class-casyncsocket.md)  
  
-   [Windows Sockets: Blocking](../vs140/windows-sockets--blocking.md)  
  
-   [Windows Sockets: Byte Ordering](../vs140/windows-sockets--byte-ordering.md)  
  
-   [Windows Sockets: Converting Strings](../vs140/windows-sockets--converting-strings.md)  
  
## See Also  
 [Windows Sockets in MFC](../vs140/windows-sockets-in-mfc.md)