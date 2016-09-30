---
title: "Windows Sockets in MFC"
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
  - "WINSOCK.DLL"
  - "sockets [C++], programming models"
  - "MFC [C++], Windows Sockets"
  - "Windows Sockets [C++], MFC support"
  - "Windows Sockets [C++], programming models"
  - "WSOCK32.DLL"
  - "sockets [C++], MFC"
ms.assetid: 1f3c476a-9c68-49fe-9a25-d22971a334d0
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Windows Sockets in MFC
> [!NOTE]
>  MFC supports Windows Sockets 1 but does not support [Windows Sockets 2](http://msdn.microsoft.com/library/windows/desktop/ms740673). Windows Sockets 2 first shipped with Windows 98 and is the version included with Windows 2000.  
  
 MFC supplies two models for writing network communications programs with Windows Sockets, embodied in two MFC classes. This article describes these models and further details MFC sockets support. A "socket" is an endpoint of communication: an object through which your application communicates with other Windows Sockets applications across a network.  
  
 For information on Windows Sockets, including an explanation of the socket concept, see [Windows Sockets: Background](../vs140/windows-sockets--background.md).  
  
##  \<a name="_core_sockets_programming_models">\</a> Sockets Programming Models  
 The two MFC Windows Sockets programming models are supported by the following classes:  
  
-   <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
  
     This class encapsulates the Windows Sockets API. [CAsyncSocket](../vs140/casyncsocket-class.md) is for programmers who know network programming and want the flexibility of programming directly to the sockets API but also want the convenience of callback functions for notification of network events. Other than packaging sockets in object-oriented form for use in C++, the only additional abstraction this class supplies is converting certain socket-related Windows messages into callbacks. For more information, see [Windows Sockets: Socket Notifications](../vs140/windows-sockets--socket-notifications.md).  
  
-   <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  
     This class, derived from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, supplies a higher level abstraction for working with sockets through an MFC [CArchive](../vs140/carchive-class.md) object. Using a socket with an archive greatly resembles using MFC's file serialization protocol. This makes it easier to use than the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> model. [CSocket](../vs140/csocket-class.md) inherits many member functions from <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> that encapsulate Windows Sockets APIs; you will have to use some of these functions and understand sockets programming generally. But <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> manages many aspects of the communication that you would have to do yourself using either the raw API or class <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Most importantly, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> provides blocking (with background processing of Windows messages), which is essential to the synchronous operation of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 Creating and using <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> objects is described in [Windows Sockets: Using Sockets with Archives](../vs140/windows-sockets--using-sockets-with-archives.md) and [Windows Sockets: Using Class CAsyncSocket](../vs140/windows-sockets--using-class-casyncsocket.md).  
  
##  \<a name="_core_mfc_socket_samples_and_windows_sockets_dlls">\</a> Windows Sockets DLLs  
 The Microsoft Windows operating systems supply the Windows Sockets dynamic-link libraries (DLL). Visual C++ supplies the appropriate header files and libraries and the Windows Sockets specification.  
  
> [!NOTE]
>  Under Windows NT and Windows 2000, Windows Sockets support for 16-bit applications is based on WINSOCK.DLL. For 32-bit applications, the support is in WSOCK32.DLL. The APIs provided are identical except that the 32-bit versions have parameters widened to 32 bits. Under Win32, thread safety is supplied.  
  
 For more information about Windows Sockets, see:  
  
-   [Windows Sockets: Stream Sockets](../vs140/windows-sockets--stream-sockets.md)  
  
-   [Windows Sockets: Datagram Sockets](../vs140/windows-sockets--datagram-sockets.md)  
  
-   [Windows Sockets: Using Sockets with Archives](../vs140/windows-sockets--using-sockets-with-archives.md)  
  
-   [Windows Sockets: Sequence of Operations](../vs140/windows-sockets--sequence-of-operations.md)  
  
-   [Windows Sockets: Example of Sockets Using Archives](../vs140/windows-sockets--example-of-sockets-using-archives.md)  
  
-   [Windows Sockets: How Sockets with Archives Work](../vs140/windows-sockets--how-sockets-with-archives-work.md)  
  
-   [Windows Sockets: Using Class CAsyncSocket](../vs140/windows-sockets--using-class-casyncsocket.md)  
  
-   [Windows Sockets: Deriving from Socket Classes](../vs140/windows-sockets--deriving-from-socket-classes.md)  
  
-   [Windows Sockets: Socket Notifications](../vs140/windows-sockets--socket-notifications.md)  
  
-   [Windows Sockets: Blocking](../vs140/windows-sockets--blocking.md)  
  
-   [Windows Sockets: Byte Ordering](../vs140/windows-sockets--byte-ordering.md)  
  
-   [Windows Sockets: Converting Strings](../vs140/windows-sockets--converting-strings.md)  
  
-   [Windows Sockets: Ports and Socket Addresses](../vs140/windows-sockets--ports-and-socket-addresses.md)  
  
## See Also  
 [Windows Sockets](../vs140/windows-sockets.md)