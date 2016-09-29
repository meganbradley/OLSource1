---
title: "CAsyncSocket::Create"
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
  - "CAsyncSocket.Create"
  - "CAsyncSocket::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method [C++]"
ms.assetid: bb1af7d9-f001-47e2-a303-0a878f798f18
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncSocket::Create
Call the **Create** member function after constructing a socket object to create the Windows socket and attach it.  
  
## Syntax  
  
```  
  
      BOOL Create(  
   UINT nSocketPort = 0,  
   int nSocketType = SOCK_STREAM,  
   long lEvent = FD_READ | FD_WRITE | FD_OOB | FD_ACCEPT | FD_CONNECT | FD_CLOSE,  
   LPCTSTR lpszSocketAddress = NULL   
);  
```  
  
#### Parameters  
 `nSocketPort`  
 A well-known port to be used with the socket, or 0 if you want Windows Sockets to select a port.  
  
 `nSocketType`  
 **SOCK_STREAM** or **SOCK_DGRAM**.  
  
 `lEvent`  
 A bitmask which specifies a combination of network events in which the application is interested.  
  
-   **FD_READ** Want to receive notification of readiness for reading.  
  
-   **FD_WRITE** Want to receive notification of readiness for writing.  
  
-   **FD_OOB** Want to receive notification of the arrival of out-of-band data.  
  
-   **FD_ACCEPT** Want to receive notification of incoming connections.  
  
-   **FD_CONNECT** Want to receive notification of completed connection.  
  
-   **FD_CLOSE** Want to receive notification of socket closure.  
  
 *lpszSockAddress*  
 A pointer to a string containing the network address of the connected socket, a dotted number such as "128.56.22.8".Passing the **NULL** string for this parameter indicates the **CAsyncSocket** instance should listen for client activity on all network interfaces.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0, and a specific error code can be retrieved by calling [GetLastError](../vs140/casyncsocket--getlasterror.md). The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEAFNOSUPPORT** The specified address family is not supported.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets operation is in progress.  
  
-   **WSAEMFILE** No more file descriptors are available.  
  
-   `WSAENOBUFS` No buffer space is available. The socket cannot be created.  
  
-   **WSAEPROTONOSUPPORT** The specified port is not supported.  
  
-   **WSAEPROTOTYPE** The specified port is the wrong type for this socket.  
  
-   **WSAESOCKTNOSUPPORT** The specified socket type is not supported in this address family.  
  
## Remarks  
 **Create** calls [Socket](../vs140/casyncsocket--socket.md) and if successful, it calls [Bind](../vs140/casyncsocket--bind.md) to bind the socket to the specified address. The following socket types are supported:  
  
-   **SOCK_STREAM** Provides sequenced, reliable, full-duplex, connection-based byte streams. Uses the Transmission Control Protocol (TCP) for the Internet address family.  
  
-   **SOCK_DGRAM** Supports datagrams, which are connectionless, unreliable packets of a fixed (typically small) maximum length. Uses the User Datagram Protocol (UDP) for the Internet address family.  
  
    > [!NOTE]
    >  The **Accept** member function takes a reference to a new, empty `CSocket` object as its parameter. You must construct this object before you call **Accept**. Keep in mind that if this socket object goes out of scope, the connection closes. Do not call **Create** for this new socket object.  
  
> [!IMPORTANT]
>  **Create** is **not** thread-safe.  If you are calling it in a multi-threaded environment where it could be invoked simultaneously by different threads, be sure to protect each call with a mutex or other synchronization lock.  
  
 For more information about stream and datagram sockets, see the articles [Windows Sockets: Background](../vs140/windows-sockets--background.md) and [Windows Sockets: Ports and Socket Addresses](../vs140/windows-sockets--ports-and-socket-addresses.md) and [Windows Sockets 2 API](http://msdn.microsoft.com/library/windows/desktop/ms740673).  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::Accept](../vs140/casyncsocket--accept.md)   
 [CAsyncSocket::Bind](../vs140/casyncsocket--bind.md)   
 [CAsyncSocket::Connect](../vs140/casyncsocket--connect.md)   
 [CAsyncSocket::GetSockName](../vs140/casyncsocket--getsockname.md)   
 [CAsyncSocket::IOCtl](../vs140/casyncsocket--ioctl.md)   
 [CAsyncSocket::Listen](../vs140/casyncsocket--listen.md)   
 [CAsyncSocket::Receive](../vs140/casyncsocket--receive.md)   
 [CAsyncSocket::Send](../vs140/casyncsocket--send.md)   
 [CAsyncSocket::ShutDown](../vs140/casyncsocket--shutdown.md)