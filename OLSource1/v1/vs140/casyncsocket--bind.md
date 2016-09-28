---
title: "CAsyncSocket::Bind"
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
  - "CAsyncSocket.Bind"
  - "CAsyncSocket::Bind"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Bind method"
ms.assetid: d54fc7c0-9952-4017-9ae7-73bb257ad0c3
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncSocket::Bind
Call this member function to associate a local address with the socket.  
  
## Syntax  
  
```  
  
      BOOL Bind(  
   UINT nSocketPort,  
   LPCTSTR lpszSocketAddress = NULL   
);  
BOOL Bind (  
   const SOCKADDR* lpSockAddr,  
   int nSockAddrLen   
);  
```  
  
#### Parameters  
 `nSocketPort`  
 The port identifying the socket application.  
  
 `lpszSocketAddress`  
 The network address, a dotted number such as "128.56.22.8". Passing the **NULL** string for this parameter indicates the **CAsyncSocket** instance should listen for client activity on all network interfaces.  
  
 `lpSockAddr`  
 A pointer to a [SOCKADDR](../vs140/sockaddr-structure.md) structure that contains the address to assign to this socket.  
  
 `nSockAddrLen`  
 The length of the address in `lpSockAddr` in bytes.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0, and a specific error code can be retrieved by calling [GetLastError](../vs140/casyncsocket--getlasterror.md). The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEADDRINUSE** The specified address is already in use. (See the **SO_REUSEADDR** socket option under [SetSockOpt](../vs140/casyncsocket--setsockopt.md).)  
  
-   **WSAEFAULT** The `nSockAddrLen` argument is too small (less than the size of a [SOCKADDR](../vs140/sockaddr-structure.md) structure).  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets call is in progress.  
  
-   **WSAEAFNOSUPPORT** The specified address family is not supported by this port.  
  
-   **WSAEINVAL** The socket is already bound to an address.  
  
-   `WSAENOBUFS` Not enough buffers available, too many connections.  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
## Remarks  
 This routine is used on an unconnected datagram or stream socket, before subsequent **Connect** or `Listen` calls. Before it can accept connection requests, a listening server socket must select a port number and make it known to Windows Sockets by calling **Bind**. **Bind** establishes the local association (host address/port number) of the socket by assigning a local name to an unnamed socket.  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::Connect](../vs140/casyncsocket--connect.md)   
 [CAsyncSocket::Listen](../vs140/casyncsocket--listen.md)   
 [CAsyncSocket::GetSockName](../vs140/casyncsocket--getsockname.md)   
 [CAsyncSocket::SetSockOpt](../vs140/casyncsocket--setsockopt.md)   
 [CAsyncSocket::Create](../vs140/casyncsocket--create.md)