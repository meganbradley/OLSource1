---
title: "CAsyncSocket::ReceiveFrom"
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
  - "ReceiveFrom"
  - "CAsyncSocket::ReceiveFrom"
  - "CAsyncSocket.ReceiveFrom"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ReceiveFrom method"
ms.assetid: 852b4e36-c43c-45f3-b717-086fdbfd50e1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncSocket::ReceiveFrom
Call this member function to receive a datagram and store the source address in the [SOCKADDR](../vs140/sockaddr-structure.md) structure or in `rSocketAddress`.  
  
## Syntax  
  
```  
  
      int ReceiveFrom(  
   void* lpBuf,  
   int nBufLen,  
   CString& rSocketAddress,  
   UINT& rSocketPort,  
   int nFlags = 0   
);  
int ReceiveFrom(  
   void* lpBuf,  
   int nBufLen,  
   SOCKADDR* lpSockAddr,  
   int* lpSockAddrLen,  
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
  
 `lpSockAddr`  
 A pointer to a [SOCKADDR](../vs140/sockaddr-structure.md) structure that holds the source address upon return.  
  
 `lpSockAddrLen`  
 A pointer to the length of the source address in `lpSockAddr` in bytes.  
  
 `nFlags`  
 Specifies the way in which the call is made. The semantics of this function are determined by the socket options and the `nFlags` parameter. The latter is constructed by combining any of the following values with the C++ `OR` operator:  
  
-   **MSG_PEEK** Peek at the incoming data. The data is copied into the buffer but is not removed from the input queue.  
  
-   **MSG_OOB** Process out-of-band data.  
  
## Return Value  
 If no error occurs, `ReceiveFrom` returns the number of bytes received. If the connection has been closed, it returns 0. Otherwise, a value of **SOCKET_ERROR** is returned, and a specific error code can be retrieved by calling `GetLastError`. The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEFAULT** The `lpSockAddrLen` argument was invalid: the `lpSockAddr` buffer was too small to accommodate the peer address.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets operation is in progress.  
  
-   **WSAEINVAL** The socket has not been bound with **Bind**.  
  
-   **WSAENOTCONN** The socket is not connected (**SOCK_STREAM** only).  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
-   **WSAEOPNOTSUPP MSG_OOB** was specified, but the socket is not of type **SOCK_STREAM**.  
  
-   **WSAESHUTDOWN** The socket has been shut down; it is not possible to call `ReceiveFrom` on a socket after `ShutDown` has been invoked with `nHow` set to 0 or 2.  
  
-   **WSAEWOULDBLOCK** The socket is marked as nonblocking and the `ReceiveFrom` operation would block.  
  
-   **WSAEMSGSIZE** The datagram was too large to fit into the specified buffer and was truncated.  
  
-   **WSAECONNABORTED** The virtual circuit was aborted due to timeout or other failure.  
  
-   **WSAECONNRESET** The virtual circuit was reset by the remote side.  
  
## Remarks  
 This function is used to read incoming data on a (possibly connected) socket and capture the address from which the data was sent.  
  
 To handle IPv6 addresses, use [CAsyncSocket::ReceiveFromEx](../vs140/casyncsocket--receivefromex.md).  
  
 For sockets of type **SOCK_STREAM**, as much information as is currently available up to the size of the buffer supplied is returned. If the socket has been configured for in-line reception of out-of-band data (socket option **SO_OOBINLINE**) and out-of-band data is unread, only out-of-band data will be returned. The application can use the **IOCtl SIOCATMARK** option or `OnOutOfBandData` to determine whether any more out-of-band data remains to be read. The `lpSockAddr` and `lpSockAddrLen` parameters are ignored for **SOCK_STREAM** sockets.  
  
 For datagram sockets, data is extracted from the first enqueued datagram, up to the size of the buffer supplied. If the datagram is larger than the buffer supplied, the buffer is filled with the first part of the message, the excess data is lost, and `ReceiveFrom` returns a value of **SOCKET_ERROR** with the error code set to **WSAEMSGSIZE**.  
  
 If `lpSockAddr` is nonzero, and the socket is of type **SOCK_DGRAM**, the network address of the socket which sent the data is copied to the corresponding [SOCKADDR](../vs140/sockaddr-structure.md) structure. The value pointed to by `lpSockAddrLen` is initialized to the size of this structure, and is modified on return to indicate the actual size of the address stored there. If no incoming data is available at the socket, the `ReceiveFrom` call waits for data to arrive unless the socket is nonblocking. In this case, a value of **SOCKET_ERROR** is returned with the error code set to **WSAEWOULDBLOCK**. The `OnReceive` callback can be used to determine when more data arrives.  
  
 If the socket is of type **SOCK_STREAM** and the remote side has shut down the connection gracefully, a `ReceiveFrom` will complete immediately with 0 bytes received.  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::AsyncSelect](../vs140/casyncsocket--asyncselect.md)   
 [CAsyncSocket::Create](../vs140/casyncsocket--create.md)   
 [CAsyncSocket::Receive](../vs140/casyncsocket--receive.md)   
 [CAsyncSocket::Send](../vs140/casyncsocket--send.md)