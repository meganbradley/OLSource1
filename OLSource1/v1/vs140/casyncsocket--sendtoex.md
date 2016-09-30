---
title: "CAsyncSocket::SendToEx"
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
  - "CAsyncSocket.SendToEx"
  - "CAsyncSocket::SendToEx"
  - "ATL::CAsyncSocket::SendToEx"
  - "SendToEx"
  - "ATL.CAsyncSocket.SendToEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SendToEx method"
ms.assetid: 0073a3cd-94fb-48a9-ad4a-fbf71f2f9304
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncSocket::SendToEx
Call this member function to send data to a specific destination (handles IPv6 addresses).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A buffer containing the data to be transmitted.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The length of the data in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in bytes.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The port identifying the socket application.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The network address of the socket to which this object is connected: a machine name such as "ftp.microsoft.com," or a dotted number such as "128.56.22.8".  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the way in which the call is made. The semantics of this function are determined by the socket options and the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter. The latter is constructed by combining any of the following values with the C++ <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> operator:  
  
-   **MSG_DONTROUTE** Specifies that the data should not be subject to routing. A Windows Sockets supplier can choose to ignore this flag.  
  
-   **MSG_OOB** Send out-of-band data (**SOCK_STREAM** only).  
  
## Return Value  
 If no error occurs, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> returns the total number of characters sent. (Note that this can be less than the number indicated by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.) Otherwise, a value of **SOCKET_ERROR** is returned, and a specific error code can be retrieved by calling [GetLastError](../vs140/casyncsocket--getlasterror.md). The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEACCES** The requested address is a broadcast address, but the appropriate flag was not set.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets operation is in progress.  
  
-   **WSAEFAULT** The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameters are not part of the user address space, or the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> argument is too small (less than the size of a [SOCKADDR](../vs140/sockaddr-structure.md) structure).  
  
-   **WSAEINVAL** The host name is invalid.  
  
-   **WSAENETRESET** The connection must be reset because the Windows Sockets implementation dropped it.  
  
-   <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> The Windows Sockets implementation reports a buffer deadlock.  
  
-   **WSAENOTCONN** The socket is not connected (**SOCK_STREAM** only).  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
-   **WSAEOPNOTSUPP MSG_OOB** was specified, but the socket is not of type **SOCK_STREAM**.  
  
-   **WSAESHUTDOWN** The socket has been shut down; it is not possible to call <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> on a socket after <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> has been invoked with <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> set to 1 or 2.  
  
-   **WSAEWOULDBLOCK** The socket is marked as nonblocking and the requested operation would block.  
  
-   **WSAEMSGSIZE** The socket is of type **SOCK_DGRAM**, and the datagram is larger than the maximum supported by the Windows Sockets implementation.  
  
-   **WSAECONNABORTED** The virtual circuit was aborted due to timeout or other failure.  
  
-   **WSAECONNRESET** The virtual circuit was reset by the remote side.  
  
-   **WSAEADDRNOTAVAIL** The specified address is not available from the local machine.  
  
-   **WSAEAFNOSUPPORT** Addresses in the specified family cannot be used with this socket.  
  
-   **WSAEDESTADDRREQ** A destination address is required.  
  
-   **WSAENETUNREACH** The network cannot be reached from this host at this time.  
  
## Remarks  
 This method is the same as [CAsyncSocket::SendTo](../vs140/casyncsocket--sendto.md) except that it handles IPv6 addresses as well as older protocols.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is used on datagram or stream sockets and is used to write outgoing data on a socket. For datagram sockets, care must be taken not to exceed the maximum IP packet size of the underlying subnets, which is given by the **iMaxUdpDg** element in the [WSADATA](../vs140/wsadata-structure.md) structure filled out by [AfxSocketInit](../vs140/afxsocketinit.md). If the data is too long to pass atomically through the underlying protocol, the error **WSAEMSGSIZE** is returned, and no data is transmitted.  
  
 Note that the successful completion of a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> does not indicate that the data was successfully delivered.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is only used on a **SOCK_DGRAM** socket to send a datagram to a specific socket identified by the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> parameter.  
  
 To send a broadcast (on a **SOCK_DGRAM** only), the address in the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> parameter should be constructed using the special IP address **INADDR_BROADCAST** (defined in the Windows Sockets header file WINSOCK.H) together with the intended port number. Or, if the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> parameter is **NULL**, the socket is configured for broadcast. It is generally inadvisable for a broadcast datagram to exceed the size at which fragmentation can occur, which implies that the data portion of the datagram (excluding headers) should not exceed 512 bytes.  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::Create](../vs140/casyncsocket--create.md)   
 [CAsyncSocket::Receive](../vs140/casyncsocket--receive.md)   
 [CAsyncSocket::ReceiveFrom](../vs140/casyncsocket--receivefrom.md)   
 [CAsyncSocket::Send](../vs140/casyncsocket--send.md)