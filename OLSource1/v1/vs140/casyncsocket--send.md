---
title: "CAsyncSocket::Send"
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
  - "CAsyncSocket.Send"
  - "CAsyncSocket::Send"
  - "Send"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Send method"
ms.assetid: 401b16ee-4332-4bb2-b760-1bf9d0185e95
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncSocket::Send
Call this member function to send data on a connected socket.  
  
## Syntax  
  
```  
  
      virtual int Send(  
   const void* lpBuf,  
   int nBufLen,  
   int nFlags = 0   
);  
```  
  
#### Parameters  
 `lpBuf`  
 A buffer containing the data to be transmitted.  
  
 `nBufLen`  
 The length of the data in `lpBuf` in bytes.  
  
 `nFlags`  
 Specifies the way in which the call is made. The semantics of this function are determined by the socket options and the `nFlags` parameter. The latter is constructed by combining any of the following values with the C++ `OR` operator:  
  
-   **MSG_DONTROUTE** Specifies that the data should not be subject to routing. A Windows Sockets supplier can choose to ignore this flag.  
  
-   **MSG_OOB** Send out-of-band data (**SOCK_STREAM** only).  
  
## Return Value  
 If no error occurs, **Send** returns the total number of characters sent. (Note that this can be less than the number indicated by `nBufLen`.) Otherwise, a value of **SOCKET_ERROR** is returned, and a specific error code can be retrieved by calling [GetLastError](../vs140/casyncsocket--getlasterror.md). The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEACCES** The requested address is a broadcast address, but the appropriate flag was not set.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets operation is in progress.  
  
-   **WSAEFAULT** The `lpBuf` argument is not in a valid part of the user address space.  
  
-   **WSAENETRESET** The connection must be reset because the Windows Sockets implementation dropped it.  
  
-   `WSAENOBUFS` The Windows Sockets implementation reports a buffer deadlock.  
  
-   **WSAENOTCONN** The socket is not connected.  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
-   **WSAEOPNOTSUPP MSG_OOB** was specified, but the socket is not of type **SOCK_STREAM**.  
  
-   **WSAESHUTDOWN** The socket has been shut down; it is not possible to call **Send** on a socket after `ShutDown` has been invoked with `nHow` set to 1 or 2.  
  
-   **WSAEWOULDBLOCK** The socket is marked as nonblocking and the requested operation would block.  
  
-   **WSAEMSGSIZE** The socket is of type **SOCK_DGRAM**, and the datagram is larger than the maximum supported by the Windows Sockets implementation.  
  
-   **WSAEINVAL** The socket has not been bound with **Bind**.  
  
-   **WSAECONNABORTED** The virtual circuit was aborted due to timeout or other failure.  
  
-   **WSAECONNRESET** The virtual circuit was reset by the remote side.  
  
## Remarks  
 **Send** is used to write outgoing data on connected stream or datagram sockets. For datagram sockets, care must be taken not to exceed the maximum IP packet size of the underlying subnets, which is given by the **iMaxUdpDg** element in the [WSADATA](../vs140/wsadata-structure.md) structure returned by `AfxSocketInit`. If the data is too long to pass atomically through the underlying protocol, the error **WSAEMSGSIZE** is returned via `GetLastError`, and no data is transmitted.  
  
 Note that for a datagram socket the successful completion of a **Send** does not indicate that the data was successfully delivered.  
  
 On `CAsyncSocket` objects of type **SOCK_STREAM**, the number of bytes written can be between 1 and the requested length, depending on buffer availability on both the local and foreign hosts.  
  
## Example  
 See the example for [CAsyncSocket::OnSend](../vs140/casyncsocket--onsend.md).  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::Create](../vs140/casyncsocket--create.md)   
 [CAsyncSocket::Receive](../vs140/casyncsocket--receive.md)   
 [CAsyncSocket::ReceiveFrom](../vs140/casyncsocket--receivefrom.md)   
 [CAsyncSocket::SendTo](../vs140/casyncsocket--sendto.md)