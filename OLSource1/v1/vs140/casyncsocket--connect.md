---
title: "CAsyncSocket::Connect"
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
  - "CAsyncSocket::Connect"
  - "Connect"
  - "CAsyncSocket.Connect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Connect method"
ms.assetid: 7fcca186-4774-4306-8361-41a730b32a2b
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncSocket::Connect
Call this member function to establish a connection to an unconnected stream or datagram socket.  
  
## Syntax  
  
```  
  
      BOOL Connect(  
   LPCTSTR lpszHostAddress,  
   UINT nHostPort   
);  
BOOL Connect(  
   const SOCKADDR* lpSockAddr,  
   int nSockAddrLen   
);  
```  
  
#### Parameters  
 `lpszHostAddress`  
 The network address of the socket to which this object is connected: a machine name such as "ftp.microsoft.com", or a dotted number such as "128.56.22.8".  
  
 `nHostPort`  
 The port identifying the socket application.  
  
 `lpSockAddr`  
 A pointer to a [SOCKADDR](../vs140/sockaddr-structure.md) structure that contains the address of the connected socket.  
  
 `nSockAddrLen`  
 The length of the address in `lpSockAddr` in bytes.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0, and a specific error code can be retrieved by calling [GetLastError](../vs140/casyncsocket--getlasterror.md). If this indicates an error code of **WSAEWOULDBLOCK**, and your application is using the overridable callbacks, your application will receive an `OnConnect` message when the connect operation is complete. The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEADDRINUSE** The specified address is already in use.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets call is in progress.  
  
-   **WSAEADDRNOTAVAIL** The specified address is not available from the local machine.  
  
-   **WSAEAFNOSUPPORT** Addresses in the specified family cannot be used with this socket.  
  
-   **WSAECONNREFUSED** The attempt to connect was rejected.  
  
-   **WSAEDESTADDRREQ** A destination address is required.  
  
-   **WSAEFAULT** The `nSockAddrLen` argument is incorrect.  
  
-   **WSAEINVAL** Invalid host address.  
  
-   **WSAEISCONN** The socket is already connected.  
  
-   **WSAEMFILE** No more file descriptors are available.  
  
-   **WSAENETUNREACH** The network cannot be reached from this host at this time.  
  
-   `WSAENOBUFS` No buffer space is available. The socket cannot be connected.  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
-   **WSAETIMEDOUT** Attempt to connect timed out without establishing a connection.  
  
-   **WSAEWOULDBLOCK** The socket is marked as nonblocking and the connection cannot be completed immediately.  
  
## Remarks  
 If the socket is unbound, unique values are assigned to the local association by the system, and the socket is marked as bound. Note that if the address field of the name structure is all zeroes, **Connect** will return zero. To get extended error information, call the `GetLastError` member function.  
  
 For stream sockets (type **SOCK_STREAM**), an active connection is initiated to the foreign host. When the socket call completes successfully, the socket is ready to send/receive data.  
  
 For a datagram socket (type **SOCK_DGRAM**), a default destination is set, which will be used on subsequent **Send** and **Receive** calls.  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::Accept](../vs140/casyncsocket--accept.md)   
 [CAsyncSocket::Bind](../vs140/casyncsocket--bind.md)   
 [CAsyncSocket::GetSockName](../vs140/casyncsocket--getsockname.md)   
 [CAsyncSocket::Create](../vs140/casyncsocket--create.md)   
 [CAsyncSocket::AsyncSelect](../vs140/casyncsocket--asyncselect.md)