---
title: "CSocket::Create"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CSocket.Create"
  - "CSocket::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method [C++]"
ms.assetid: 1f64e6da-ba77-43a5-9606-d7c65536a2b8
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSocket::Create
Call the **Create** member function after constructing a socket object to create the Windows socket and attach it.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A particular port to be used with the socket, or 0 if you want MFC to select a port.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **SOCK_STREAM** or **SOCK_DGRAM**.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to a string containing the network address of the connected socket, a dotted number such as "128.56.22.8". Passing the **NULL** string for this parameter indicates the **CSocket** instance should listen for client activity on all network interfaces.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0, and a specific error code can be retrieved by calling <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 **Create** then calls **Bind** to bind the socket to the specified address. The following socket types are supported:  
  
-   **SOCK_STREAM** Provides sequenced, reliable, two-way, connection-based byte streams. Uses Transmission Control Protocol (TCP) for the Internet address family.  
  
-   **SOCK_DGRAM** Supports datagrams, which are connectionless, unreliable buffers of a fixed (typically small) maximum length. Uses User Datagram Protocol (UDP) for the Internet address family. To use this option, you must not use the socket with a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
    > [!NOTE]
    >  The **Accept** member function takes a reference to a new, empty <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object as its parameter. You must construct this object before you call **Accept**. Keep in mind that if this socket object goes out of scope, the connection closes. Do not call **Create** for this new socket object.  
  
 For more information about stream and datagram sockets, see the articles [Windows Sockets: Background](../vs140/windows-sockets--background.md), [Windows Sockets: Ports and Socket Addresses](../vs140/windows-sockets--ports-and-socket-addresses.md), and [Windows Sockets: Using Sockets with Archives](../vs140/windows-sockets--using-sockets-with-archives.md).  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CSocket Class](../vs140/csocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::Create](../vs140/casyncsocket--create.md)   
 [CAsyncSocket::Bind](../vs140/casyncsocket--bind.md)