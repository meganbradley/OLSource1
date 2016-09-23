---
title: "CAsyncSocket::ReceiveFromEx"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ATL::CAsyncSocket::ReceiveFromEx
  - ATL.CAsyncSocket.ReceiveFromEx
  - ReceiveFromEx
  - CAsyncSocket.ReceiveFromEx
  - CAsyncSocket::ReceiveFromEx
dev_langs: 
  - C++
helpviewer_keywords: 
  - ReceiveFromEx method
ms.assetid: 398777b8-c0cf-4645-bc0e-7ba01eb2139e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAsyncSocket::ReceiveFromEx
Call this member function to receive a datagram and store the source address in the [SOCKADDR](../vs140/sockaddr-structure.md) structure or in `rSocketAddress` (handles IPv6 addresses).  
  
## Syntax  
  
```  
  
      int ReceiveFromEx(  
   void* lpBuf,  
   int nBufLen,  
   CString& rSocketAddress,  
   UINT& rSocketPort,  
   int nFlags = 0   
);  
```  
  
#### Parameters  
 `lpBuf`  
 A buffer for the incoming data.  
  
 `nBufLen`  
 The length of `lpBuf` in bytes.  
  
 `rSocketAddress`  
 Reference to a `CString` object that receives a dotted number IP address.  
  
 `rSocketPort`  
 Reference to a **UINT** that stores a port.  
  
 `nFlags`  
 Specifies the way in which the call is made. The semantics of this function are determined by the socket options and the `nFlags` parameter. The latter is constructed by combining any of the following values with the C++ `OR` operator:  
  
-   **MSG_PEEK** Peek at the incoming data. The data is copied into the buffer but is not removed from the input queue.  
  
-   **MSG_OOB** Process out-of-band data.  
  
## Return Value  
 If no error occurs, `ReceiveFromEx` returns the number of bytes received. If the connection has been closed, it returns 0. Otherwise, a value of **SOCKET_ERROR** is returned, and a specific error code can be retrieved by calling `GetLastError`. The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEFAULT** The `lpSockAddrLen` argument was invalid: the `lpSockAddr` buffer was too small to accommodate the peer address.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets operation is in progress.  
  
-   **WSAEINVAL** The socket has not been bound with **Bind**.  
  
-   **WSAENOTCONN** The socket is not connected (**SOCK_STREAM** only).  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
-   **WSAEOPNOTSUPP MSG_OOB** was specified, but the socket is not of type **SOCK_STREAM**.  
  
-   **WSAESHUTDOWN** The socket has been shut down; it is not possible to call `ReceiveFromEx` on a socket after `ShutDown` has been invoked with `nHow` set to 0 or 2.  
  
-   **WSAEWOULDBLOCK** The socket is marked as nonblocking and the `ReceiveFromEx` operation would block.  
  
-   **WSAEMSGSIZE** The datagram was too large to fit into the specified buffer and was truncated.  
  
-   **WSAECONNABORTED** The virtual circuit was aborted due to timeout or other failure.  
  
-   **WSAECONNRESET** The virtual circuit was reset by the remote side.  
  
## Remarks  
 This function is used to read incoming data on a (possibly connected) socket and capture the address from which the data was sent.  
  
 This function is the same as [CAsyncSocket::ReceiveFrom](../vs140/casyncsocket--receivefrom.md) except that it handles IPv6 addresses as well as older protocols.  
  
 For sockets of type **SOCK_STREAM**, as much information as is currently available up to the size of the buffer supplied is returned. If the socket has been configured for in-line reception of out-of-band data (socket option **SO_OOBINLINE**) and out-of-band data is unread, only out-of-band data will be returned. The application can use the **IOCtl SIOCATMARK** option or `OnOutOfBandData` to determine whether any more out-of-band data remains to be read. The `lpSockAddr` and `lpSockAddrLen` parameters are ignored for **SOCK_STREAM** sockets.  
  
 For datagram sockets, data is extracted from the first enqueued datagram, up to the size of the buffer supplied. If the datagram is larger than the buffer supplied, the buffer is filled with the first part of the message, the excess data is lost, and `ReceiveFromEx` returns a value of **SOCKET_ERROR** with the error code set to **WSAEMSGSIZE**.  
  
 If `lpSockAddr` is nonzero, and the socket is of type **SOCK_DGRAM**, the network address of the socket which sent the data is copied to the corresponding [SOCKADDR](../vs140/sockaddr-structure.md) structure. The value pointed to by `lpSockAddrLen` is initialized to the size of this structure, and is modified on return to indicate the actual size of the address stored there. If no incoming data is available at the socket, the `ReceiveFromEx` call waits for data to arrive unless the socket is nonblocking. In this case, a value of **SOCKET_ERROR** is returned with the error code set to **WSAEWOULDBLOCK**. The `OnReceive` callback can be used to determine when more data arrives.  
  
 If the socket is of type **SOCK_STREAM** and the remote side has shut down the connection gracefully, a `ReceiveFromEx` will complete immediately with 0 bytes received.  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::AsyncSelect](../vs140/casyncsocket--asyncselect.md)   
 [CAsyncSocket::Create](../vs140/casyncsocket--create.md)   
 [CAsyncSocket::Receive](../vs140/casyncsocket--receive.md)   
 [CAsyncSocket::Send](../vs140/casyncsocket--send.md)