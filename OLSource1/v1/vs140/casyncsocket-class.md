---
title: "CAsyncSocket Class"
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
  - "CAsyncSocket"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "network communications"
  - "asynchronous Windows Sockets"
  - "CAsyncSocket class"
  - "Windows Sockets [C++], asynchronous"
  - "communications [C++], network"
  - "sockets [C++], Windows"
ms.assetid: cca4d5a1-aa0f-48bd-843e-ef0e2d7fc00b
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncSocket Class
Represents a Windows Socket — an endpoint of network communication.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CAsyncSocket::CAsyncSocket](#casyncsocket__casyncsocket)|Constructs a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAsyncSocket::Accept](#casyncsocket__accept)|Accepts a connection on the socket.|  
|[CAsyncSocket::AsyncSelect](#casyncsocket__asyncselect)|Requests event notification for the socket.|  
|[CAsyncSocket::Attach](#casyncsocket__attach)|Attaches a socket handle to a <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object.|  
|[CAsyncSocket::Bind](#casyncsocket__bind)|Associates a local address with the socket.|  
|[CAsyncSocket::Close](#casyncsocket__close)|Closes the socket.|  
|[CAsyncSocket::Connect](#casyncsocket__connect)|Establishes a connection to a peer socket.|  
|[CAsyncSocket::Create](#casyncsocket__create)|Creates a socket.|  
|[CAsyncSocket::Detach](#casyncsocket__detach)|Detaches a socket handle from a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object.|  
|[CAsyncSocket::FromHandle](#casyncsocket__fromhandle)|Returns a pointer to a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object, given a socket handle.|  
|[CAsyncSocket::GetLastError](#casyncsocket__getlasterror)|Gets the error status for the last operation that failed.|  
|[CAsyncSocket::GetPeerName](#casyncsocket__getpeername)|Gets the address of the peer socket to which the socket is connected.|  
|[CAsyncSocket::GetPeerNameEx](#casyncsocket__getpeernameex)|Gets the address of the peer socket to which the socket is connected (handles IPv6 addresses).|  
|[CAsyncSocket::GetSockName](#casyncsocket__getsockname)|Gets the local name for a socket.|  
|[CAsyncSocket::GetSockNameEx](#casyncsocket__getsocknameex)|Gets the local name for a socket (handles IPv6 addresses).|  
|[CAsyncSocket::GetSockOpt](#casyncsocket__getsockopt)|Retrieves a socket option.|  
|[CAsyncSocket::IOCtl](#casyncsocket__ioctl)|Controls the mode of the socket.|  
|[CAsyncSocket::Listen](#casyncsocket__listen)|Establishes a socket to listen for incoming connection requests.|  
|[CAsyncSocket::Receive](#casyncsocket__receive)|Receives data from the socket.|  
|[CAsyncSocket::ReceiveFrom](#casyncsocket__receivefrom)|Receives a datagram and stores the source address.|  
|[CAsyncSocket::ReceiveFromEx](#casyncsocket__receivefromex)|Receives a datagram and stores the source address (handles IPv6 addresses).|  
|[CAsyncSocket::Send](#casyncsocket__send)|Sends data to a connected socket.|  
|[CAsyncSocket::SendTo](#casyncsocket__sendto)|Sends data to a specific destination.|  
|[CAsyncSocket::SendToEx](#casyncsocket__sendtoex)|Sends data to a specific destination (handles IPv6 addresses).|  
|[CAsyncSocket::SetSockOpt](#casyncsocket__setsockopt)|Sets a socket option.|  
|[CAsyncSocket::ShutDown](#casyncsocket__shutdown)|Disables **Send** and/or **Receive** calls on the socket.|  
|[CAsyncSocket::Socket](#casyncsocket__socket)|Allocates a socket handle.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAsyncSocket::OnAccept](#casyncsocket__onaccept)|Notifies a listening socket that it can accept pending connection requests by calling **Accept**.|  
|[CAsyncSocket::OnClose](#casyncsocket__onclose)|Notifies a socket that the socket connected to it has closed.|  
|[CAsyncSocket::OnConnect](#casyncsocket__onconnect)|Notifies a connecting socket that the connection attempt is complete, whether successfully or in error.|  
|[CAsyncSocket::OnOutOfBandData](#casyncsocket__onoutofbanddata)|Notifies a receiving socket that there is out-of-band data to be read on the socket, usually an urgent message.|  
|[CAsyncSocket::OnReceive](#casyncsocket__onreceive)|Notifies a listening socket that there is data to be retrieved by calling **Receive**.|  
|[CAsyncSocket::OnSend](#casyncsocket__onsend)|Notifies a socket that it can send data by calling **Send**.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CAsyncSocket::operator =](#casyncsocket__operator__eq)|Assigns a new value to a <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object.|  
|[CAsyncSocket::operator SOCKET](#casyncsocket__operator_socket)|Use this operator to retrieve the **SOCKET** handle of the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CAsyncSocket::m_hSocket](#casyncsocket__m_hsocket)|Indicates the **SOCKET** handle attached to this <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 Class <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> encapsulates the Windows Socket Functions API, providing an object-oriented abstraction for programmers who want to use Windows Sockets in conjunction with MFC.  
  
 This class is based on the assumption that you understand network communications. You are responsible for handling blocking, byte-order differences, and conversions between Unicode and multibyte character set (MBCS) strings. If you want a more convenient interface that manages these issues for you, see class [CSocket](../vs140/csocket-class.md).  
  
 To use a <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object, call its constructor, then call the [Create](#casyncsocket__create) function to create the underlying socket handle (type <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>), except on accepted sockets. For a server socket call the [Listen](#casyncsocket__listen) member function, and for a client socket call the [Connect](#casyncsocket__connect) member function. The server socket should call the [Accept](#casyncsocket__accept) function upon receiving a connection request. Use the remaining <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> functions to carry out communications between sockets. Upon completion, destroy the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object if it was created on the heap; the destructor automatically calls the [Close](#casyncsocket__close) function. The <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> data type is described in the article [Windows Sockets: Background](../vs140/windows-sockets--background.md).  
  
> [!NOTE]
>  When using MFC sockets in secondary threads in a statically linked MFC application, you must call <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> in each thread that uses sockets to initialize the socket libraries. By default, <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> is called only in the primary thread.  
  
 For more information, see [Windows Sockets: Using Class CAsyncSocket](../vs140/windows-sockets--using-class-casyncsocket.md) and related articles., as well as                 [Windows Sockets 2 API](http://msdn.microsoft.com/library/windows/desktop/ms740673).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxsock.h  
  
##  \<a name="casyncsocket__accept">\</a>  CAsyncSocket::Accept  
 Call this member function to accept a connection on a socket.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 A reference identifying a new socket that is available for connection.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 A pointer to a [SOCKADDR](../vs140/sockaddr-structure.md) structure that receives the address of the connecting socket, as known on the network. The exact format of the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> argument is determined by the address family established when the socket was created. If <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> and/or <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> are equal to **NULL**, then no information about the remote address of the accepted socket is returned.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 A pointer to the length of the address in <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> in bytes. The <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> is a value-result parameter: it should initially contain the amount of space pointed to by <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>; on return it will contain the actual length (in bytes) of the address returned.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0, and a specific error code can be retrieved by calling [GetLastError](#casyncsocket__getlasterror). The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEFAULT** The <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> argument is too small (less than the size of a [SOCKADDR](../vs140/sockaddr-structure.md) structure).  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets call is in progress.  
  
-   **WSAEINVAL** <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> was not invoked prior to accept.  
  
-   **WSAEMFILE** The queue is empty upon entry to accept and there are no descriptors available.  
  
-   <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> No buffer space is available.  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
-   **WSAEOPNOTSUPP** The referenced socket is not a type that supports connection-oriented service.  
  
-   **WSAEWOULDBLOCK** The socket is marked as nonblocking and no connections are present to be accepted.  
  
### Remarks  
 This routine extracts the first connection in the queue of pending connections, creates a new socket with the same properties as this socket, and attaches it to <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>. If no pending connections are present on the queue, **Accept** returns zero and <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> returns an error. The accepted socket (                        *rConnectedSocket)* cannot be used to accept more connections. The original socket remains open and listening.  
  
 The argument <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> is a result parameter that is filled in with the address of the connecting socket, as known to the communications layer. **Accept** is used with connection-based socket types such as **SOCK_STREAM**.  
  
##  \<a name="casyncsocket__asyncselect">\</a>  CAsyncSocket::AsyncSelect  
 Call this member function to request event notification for a socket.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 A bitmask which specifies a combination of network events in which the application is interested.  
  
-   **FD_READ** Want to receive notification of readiness for reading.  
  
-   **FD_WRITE** Want to receive notification when data is available to be read.  
  
-   **FD_OOB** Want to receive notification of the arrival of out-of-band data.  
  
-   **FD_ACCEPT** Want to receive notification of incoming connections.  
  
-   **FD_CONNECT** Want to receive notification of connection results.  
  
-   **FD_CLOSE** Want to receive notification when a socket has been closed by a peer.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0, and a specific error code can be retrieved by calling [GetLastError](#casyncsocket__getlasterror). The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEINVAL** Indicates that one of the specified parameters was invalid.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets operation is in progress.  
  
### Remarks  
 This function is used to specify which MFC callback notification functions will be called for the socket. <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> automatically sets this socket to nonblocking mode. For more information, see the article [Windows Sockets: Socket Notifications](../vs140/windows-sockets--socket-notifications.md).  
  
##  \<a name="casyncsocket__attach">\</a>  CAsyncSocket::Attach  
 Call this member function to attach the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> handle to an <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 Contains a handle to a socket.  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 A bitmask which specifies a combination of network events in which the application is interested.  
  
-   **FD_READ** Want to receive notification of readiness for reading.  
  
-   **FD_WRITE** Want to receive notification when data is available to be read.  
  
-   **FD_OOB** Want to receive notification of the arrival of out-of-band data.  
  
-   **FD_ACCEPT** Want to receive notification of incoming connections.  
  
-   **FD_CONNECT** Want to receive notification of connection results.  
  
-   **FD_CLOSE** Want to receive notification when a socket has been closed by a peer.  
  
### Return Value  
 Nonzero if the function is successful.  
  
### Remarks  
 The **SOCKET** handle is stored in the object's [m_hSocket](#casyncsocket__m_hsocket) data member.  
  
##  \<a name="casyncsocket__bind">\</a>  CAsyncSocket::Bind  
 Call this member function to associate a local address with the socket.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 The port identifying the socket application.  
  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 The network address, a dotted number such as "128.56.22.8". Passing the **NULL** string for this parameter indicates the **CAsyncSocket** instance should listen for client activity on all network interfaces.  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 A pointer to a [SOCKADDR](../vs140/sockaddr-structure.md) structure that contains the address to assign to this socket.  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 The length of the address in <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> in bytes.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0, and a specific error code can be retrieved by calling [GetLastError](#casyncsocket__getlasterror). The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEADDRINUSE** The specified address is already in use. (See the **SO_REUSEADDR** socket option under [SetSockOpt](#casyncsocket__setsockopt).)  
  
-   **WSAEFAULT** The <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> argument is too small (less than the size of a [SOCKADDR](../vs140/sockaddr-structure.md) structure).  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets call is in progress.  
  
-   **WSAEAFNOSUPPORT** The specified address family is not supported by this port.  
  
-   **WSAEINVAL** The socket is already bound to an address.  
  
-   <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> Not enough buffers available, too many connections.  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
### Remarks  
 This routine is used on an unconnected datagram or stream socket, before subsequent **Connect** or <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> calls. Before it can accept connection requests, a listening server socket must select a port number and make it known to Windows Sockets by calling **Bind**. **Bind** establishes the local association (host address/port number) of the socket by assigning a local name to an unnamed socket.  
  
##  \<a name="casyncsocket__casyncsocket">\</a>  CAsyncSocket::CAsyncSocket  
 Constructs a blank socket object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 After constructing the object, you must call its **Create** member function to create the **SOCKET** data structure and bind its address. (On the server side of a Windows Sockets communication, when the listening socket creates a socket to use in the **Accept** call, you do not call **Create** for that socket.)  
  
##  \<a name="casyncsocket__close">\</a>  CAsyncSocket::Close  
 Closes the socket.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 This function releases the socket descriptor so that further references to it will fail with the error **WSAENOTSOCK**. If this is the last reference to the underlying socket, the associated naming information and queued data are discarded. The socket object's destructor calls **Close** for you.  
  
 For <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, but not for <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>, the semantics of **Close** are affected by the socket options **SO_LINGER** and **SO_DONTLINGER**. For further information, see member function <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.  
  
##  \<a name="casyncsocket__connect">\</a>  CAsyncSocket::Connect  
 Call this member function to establish a connection to an unconnected stream or datagram socket.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 The network address of the socket to which this object is connected: a machine name such as "ftp.microsoft.com", or a dotted number such as "128.56.22.8".  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 The port identifying the socket application.  
  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 A pointer to a [SOCKADDR](../vs140/sockaddr-structure.md) structure that contains the address of the connected socket.  
  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 The length of the address in <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> in bytes.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0, and a specific error code can be retrieved by calling [GetLastError](#casyncsocket__getlasterror). If this indicates an error code of **WSAEWOULDBLOCK**, and your application is using the overridable callbacks, your application will receive an <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> message when the connect operation is complete. The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEADDRINUSE** The specified address is already in use.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets call is in progress.  
  
-   **WSAEADDRNOTAVAIL** The specified address is not available from the local machine.  
  
-   **WSAEAFNOSUPPORT** Addresses in the specified family cannot be used with this socket.  
  
-   **WSAECONNREFUSED** The attempt to connect was rejected.  
  
-   **WSAEDESTADDRREQ** A destination address is required.  
  
-   **WSAEFAULT** The <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> argument is incorrect.  
  
-   **WSAEINVAL** Invalid host address.  
  
-   **WSAEISCONN** The socket is already connected.  
  
-   **WSAEMFILE** No more file descriptors are available.  
  
-   **WSAENETUNREACH** The network cannot be reached from this host at this time.  
  
-   <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> No buffer space is available. The socket cannot be connected.  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
-   **WSAETIMEDOUT** Attempt to connect timed out without establishing a connection.  
  
-   **WSAEWOULDBLOCK** The socket is marked as nonblocking and the connection cannot be completed immediately.  
  
### Remarks  
 If the socket is unbound, unique values are assigned to the local association by the system, and the socket is marked as bound. Note that if the address field of the name structure is all zeroes, **Connect** will return zero. To get extended error information, call the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> member function.  
  
 For stream sockets (type **SOCK_STREAM**), an active connection is initiated to the foreign host. When the socket call completes successfully, the socket is ready to send/receive data.  
  
 For a datagram socket (type **SOCK_DGRAM**), a default destination is set, which will be used on subsequent **Send** and **Receive** calls.  
  
##  \<a name="casyncsocket__create">\</a>  CAsyncSocket::Create  
 Call the **Create** member function after constructing a socket object to create the Windows socket and attach it.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 A well-known port to be used with the socket, or 0 if you want Windows Sockets to select a port.  
  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 **SOCK_STREAM** or **SOCK_DGRAM**.  
  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 A bitmask which specifies a combination of network events in which the application is interested.  
  
-   **FD_READ** Want to receive notification of readiness for reading.  
  
-   **FD_WRITE** Want to receive notification of readiness for writing.  
  
-   **FD_OOB** Want to receive notification of the arrival of out-of-band data.  
  
-   **FD_ACCEPT** Want to receive notification of incoming connections.  
  
-   **FD_CONNECT** Want to receive notification of completed connection.  
  
-   **FD_CLOSE** Want to receive notification of socket closure.  
  
 *lpszSockAddress*  
 A pointer to a string containing the network address of the connected socket, a dotted number such as "128.56.22.8".Passing the **NULL** string for this parameter indicates the **CAsyncSocket** instance should listen for client activity on all network interfaces.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0, and a specific error code can be retrieved by calling [GetLastError](#casyncsocket__getlasterror). The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEAFNOSUPPORT** The specified address family is not supported.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets operation is in progress.  
  
-   **WSAEMFILE** No more file descriptors are available.  
  
-   <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> No buffer space is available. The socket cannot be created.  
  
-   **WSAEPROTONOSUPPORT** The specified port is not supported.  
  
-   **WSAEPROTOTYPE** The specified port is the wrong type for this socket.  
  
-   **WSAESOCKTNOSUPPORT** The specified socket type is not supported in this address family.  
  
### Remarks  
 **Create** calls [Socket](#casyncsocket__socket) and if successful, it calls [Bind](#casyncsocket__bind) to bind the socket to the specified address. The following socket types are supported:  
  
-   **SOCK_STREAM** Provides sequenced, reliable, full-duplex, connection-based byte streams. Uses the Transmission Control Protocol (TCP) for the Internet address family.  
  
-   **SOCK_DGRAM** Supports datagrams, which are connectionless, unreliable packets of a fixed (typically small) maximum length. Uses the User Datagram Protocol (UDP) for the Internet address family.  
  
    > [!NOTE]
    >  The **Accept** member function takes a reference to a new, empty <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> object as its parameter. You must construct this object before you call **Accept**. Keep in mind that if this socket object goes out of scope, the connection closes. Do not call **Create** for this new socket object.  
  
> [!IMPORTANT]
>  **Create** is **not** thread-safe.  If you are calling it in a multi-threaded environment where it could be invoked simultaneously by different threads, be sure to protect each call with a mutex or other synchronization lock.  
  
 For more information about stream and datagram sockets, see the articles [Windows Sockets: Background](../vs140/windows-sockets--background.md) and [Windows Sockets: Ports and Socket Addresses](../vs140/windows-sockets--ports-and-socket-addresses.md) and                         [Windows Sockets 2 API](http://msdn.microsoft.com/library/windows/desktop/ms740673).  
  
##  \<a name="casyncsocket__detach">\</a>  CAsyncSocket::Detach  
 Call this member function to detach the **SOCKET** handle in the <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> data member from the <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> object and set <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> to **NULL**.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="casyncsocket__fromhandle">\</a>  CAsyncSocket::FromHandle  
 Returns a pointer to a <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 Contains a handle to a socket.  
  
### Return Value  
 A pointer to an <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> object, or **NULL** if there is no <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> object attached to <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>.  
  
### Remarks  
 When given a **SOCKET** handle, if a <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> object is not attached to the handle, the member function returns **NULL**.  
  
##  \<a name="casyncsocket__getlasterror">\</a>  CAsyncSocket::GetLastError  
 Call this member function to get the error status for the last operation that failed.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 The return value indicates the error code for the last Windows Sockets API routine performed by this thread.  
  
### Remarks  
 When a particular member function indicates that an error has occurred, <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> should be called to retrieve the appropriate error code. See the individual member function descriptions for a list of applicable error codes.  
  
 For more information about the error codes, see                         [Windows Sockets 2 API](http://msdn.microsoft.com/library/windows/desktop/ms740673).  
  
##  \<a name="casyncsocket__getpeername">\</a>  CAsyncSocket::GetPeerName  
 Call this member function to get the address of the peer socket to which this socket is connected.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 Reference to a <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> object that receives a dotted number IP address.  
  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 Reference to a **UINT** that stores a port.  
  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 A pointer to the [SOCKADDR](../vs140/sockaddr-structure.md) structure that receives the name of the peer socket.  
  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 A pointer to the length of the address in <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> in bytes. On return, the <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> argument contains the actual size of <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> returned in bytes.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0, and a specific error code can be retrieved by calling [GetLastError](#casyncsocket__getlasterror). The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEFAULT** The <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> argument is not large enough.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets call is in progress.  
  
-   **WSAENOTCONN** The socket is not connected.  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
### Remarks  
 To handle IPv6 addresses, use [CAsyncSocket::GetPeerNameEx](#casyncsocket__getpeernameex).  
  
##  \<a name="casyncsocket__getpeernameex">\</a>  CAsyncSocket::GetPeerNameEx  
 Call this member function to get the address of the peer socket to which this socket is connected (handles IPv6 addresses).  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 Reference to a <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> object that receives a dotted number IP address.  
  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 Reference to a **UINT** that stores a port.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0, and a specific error code can be retrieved by calling [GetLastError](#casyncsocket__getlasterror). The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEFAULT** The <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> argument is not large enough.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets call is in progress.  
  
-   **WSAENOTCONN** The socket is not connected.  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
### Remarks  
 This function is the same as [CAsyncSocket::GetPeerName](#casyncsocket__getpeername) except that it handles IPv6 addresses as well as older protocols.  
  
##  \<a name="casyncsocket__getsockname">\</a>  CAsyncSocket::GetSockName  
 Call this member function to get the local name for a socket.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 Reference to a <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> object that receives a dotted number IP address.  
  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 Reference to a **UINT** that stores a port.  
  
 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
 A pointer to a [SOCKADDR](../vs140/sockaddr-structure.md) structure that receives the address of the socket.  
  
 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 A pointer to the length of the address in <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> in bytes.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0, and a specific error code can be retrieved by calling [GetLastError](#casyncsocket__getlasterror). The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEFAULT** The <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> argument is not large enough.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets operation is in progress.  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
-   **WSAEINVAL** The socket has not been bound to an address with **Bind**.  
  
### Remarks  
 This call is especially useful when a **Connect** call has been made without doing a **Bind** first; this call provides the only means by which you can determine the local association which has been set by the system.  
  
 To handle IPv6 addresses, use [CAsyncSocket::GetSockNameEx](#casyncsocket__getsocknameex)  
  
##  \<a name="casyncsocket__getsocknameex">\</a>  CAsyncSocket::GetSockNameEx  
 Call this member function to get the local name for a socket (handles IPv6 addresses).  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 Reference to a <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> object that receives a dotted number IP address.  
  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 Reference to a **UINT** that stores a port.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0, and a specific error code can be retrieved by calling [GetLastError](#casyncsocket__getlasterror). The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEFAULT** The <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> argument is not large enough.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets operation is in progress.  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
-   **WSAEINVAL** The socket has not been bound to an address with **Bind**.  
  
### Remarks  
 This call is the same as [CAsyncSocket::GetSockName](#casyncsocket__getsockname) except that it handles IPv6 addresses as well as older protocols.  
  
 This call is especially useful when a **Connect** call has been made without doing a **Bind** first; this call provides the only means by which you can determine the local association which has been set by the system.  
  
##  \<a name="casyncsocket__getsockopt">\</a>  CAsyncSocket::GetSockOpt  
 Call this member function to retrieve a socket option.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 The socket option for which the value is to be retrieved.  
  
 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
 A pointer to the buffer in which the value for the requested option is to be returned. The value associated with the selected option is returned in the buffer <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>. The integer pointed to by <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> should originally contain the size of this buffer in bytes; and on return, it will be set to the size of the value returned. For **SO_LINGER**, this will be the size of a <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> structure; for all other options it will be the size of a **BOOL** or an <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>, depending on the option. See the list of options and their sizes in the Remarks section.  
  
 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
 A pointer to the size of the <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> buffer in bytes.  
  
 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 The level at which the option is defined; the only supported levels are **SOL_SOCKET** and **IPPROTO_TCP**.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0, and a specific error code can be retrieved by calling [GetLastError](#casyncsocket__getlasterror). If an option was never set with <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>, then <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> returns the default value for the option. The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEFAULT** The <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> argument was invalid.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets operation is in progress.  
  
-   **WSAENOPROTOOPT** The option is unknown or unsupported. In particular, **SO_BROADCAST** is not supported on sockets of type **SOCK_STREAM**, while **SO_ACCEPTCONN**, **SO_DONTLINGER**, **SO_KEEPALIVE**, **SO_LINGER**, and **SO_OOBINLINE** are not supported on sockets of type **SOCK_DGRAM**.  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
### Remarks  
 <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> retrieves the current value for a socket option associated with a socket of any type, in any state, and stores the result in <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>. Options affect socket operations, such as the routing of packets, out-of-band data transfer, and so on.  
  
 The following options are supported for <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>. The Type identifies the type of data addressed by <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>. The **TCP_NODELAY** option uses level **IPPROTO_TCP**; all other options use level **SOL_SOCKET**.  
  
|Value|Type|Meaning|  
|-----------|----------|-------------|  
|**SO_ACCEPTCONN**|**BOOL**|Socket is listening.|  
|**SO_BROADCAST**|**BOOL**|Socket is configured for the transmission of broadcast messages.|  
|**SO_DEBUG**|**BOOL**|Debugging is enabled.|  
|**SO_DONTLINGER**|**BOOL**|If true, the **SO_LINGER** option is disabled.|  
|**SO_DONTROUTE**|**BOOL**|Routing is disabled.|  
|**SO_ERROR**|<CodeContentPlaceHolder>149\</CodeContentPlaceHolder>|Retrieve error status and clear.|  
|**SO_KEEPALIVE**|**BOOL**|Keep-alives are being sent.|  
|**SO_LINGER**|**struct LINGER**|Returns the current linger options.|  
|**SO_OOBINLINE**|**BOOL**|Out-of-band data is being received in the normal data stream.|  
|**SO_RCVBUF**|<CodeContentPlaceHolder>150\</CodeContentPlaceHolder>|Buffer size for receives.|  
|**SO_REUSEADDR**|**BOOL**|The socket can be bound to an address which is already in use.|  
|**SO_SNDBUF**|<CodeContentPlaceHolder>151\</CodeContentPlaceHolder>|Buffer size for sends.|  
|**SO_TYPE**|<CodeContentPlaceHolder>152\</CodeContentPlaceHolder>|The type of the socket (for example, **SOCK_STREAM**).|  
|**TCP_NODELAY**|**BOOL**|Disables the Nagle algorithm for send coalescing.|  
  
 Berkeley Software Distribution (BSD) options not supported for <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> are:  
  
|Value|Type|Meaning|  
|-----------|----------|-------------|  
|**SO_RCVLOWAT**|<CodeContentPlaceHolder>154\</CodeContentPlaceHolder>|Receive low water mark.|  
|**SO_RCVTIMEO**|<CodeContentPlaceHolder>155\</CodeContentPlaceHolder>|Receive timeout.|  
|**SO_SNDLOWAT**|<CodeContentPlaceHolder>156\</CodeContentPlaceHolder>|Send low water mark.|  
|**SO_SNDTIMEO**|<CodeContentPlaceHolder>157\</CodeContentPlaceHolder>|Send timeout.|  
|**IP_OPTIONS**||Get options in IP header.|  
|**TCP_MAXSEG**|<CodeContentPlaceHolder>158\</CodeContentPlaceHolder>|Get TCP maximum segment size.|  
  
 Calling <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> with an unsupported option will result in an error code of **WSAENOPROTOOPT** being returned from <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>.  
  
##  \<a name="casyncsocket__ioctl">\</a>  CAsyncSocket::IOCtl  
 Call this member function to control the mode of a socket.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
 The command to perform on the socket.  
  
 <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>  
 A pointer to a parameter for <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0, and a specific error code can be retrieved by calling [GetLastError](#casyncsocket__getlasterror). The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEINVAL** <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> is not a valid command, or <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> is not an acceptable parameter for <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>, or the command is not applicable to the type of socket supplied.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets operation is in progress.  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
### Remarks  
 This routine can be used on any socket in any state. It is used to get or retrieve operating parameters associated with the socket, independent of the protocol and communications subsystem. The following commands are supported:  
  
-   **FIONBIO** Enable or disable nonblocking mode on the socket. The <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> parameter points at a <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>, which is nonzero if nonblocking mode is to be enabled and zero if it is to be disabled. If <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> has been issued on a socket, then any attempt to use **IOCtl** to set the socket back to blocking mode will fail with **WSAEINVAL**. To set the socket back to blocking mode and prevent the **WSAEINVAL** error, an application must first disable <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> by calling <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> with the <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> parameter equal to 0, then call **IOCtl**.  
  
-   **FIONREAD** Determine the maximum number of bytes that can be read with one **Receive** call from this socket. The <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> parameter points at a <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> in which **IOCtl** stores the result. If this socket is of type **SOCK_STREAM**, **FIONREAD** returns the total amount of data which can be read in a single **Receive**; this is normally the same as the total amount of data queued on the socket. If this socket is of type **SOCK_DGRAM**, **FIONREAD** returns the size of the first datagram queued on the socket.  
  
-   **SIOCATMARK** Determine whether all out-of-band data has been read. This applies only to a socket of type **SOCK_STREAM** which has been configured for in-line reception of any out-of-band data ( **SO_OOBINLINE**). If no out-of-band data is waiting to be read, the operation returns nonzero. Otherwise it returns 0, and the next **Receive** or <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> performed on the socket will retrieve some or all of the data preceding the "mark"; the application should use the **SIOCATMARK** operation to determine whether any data remains. If there is any normal data preceding the "urgent" (out-of-band) data, it will be received in order. (Note that a **Receive** or <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> will never mix out-of-band and normal data in the same call.) The <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> parameter points at a <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> in which **IOCtl** stores the result.  
  
 This function is a subset of **ioctl()** as used in Berkeley sockets. In particular, there is no command which is equivalent to **FIOASYNC**, while **SIOCATMARK** is the only socket-level command which is supported.  
  
##  \<a name="casyncsocket__listen">\</a>  CAsyncSocket::Listen  
 Call this member function to listen for incoming connection requests.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 *nConnectionBacklog*  
 The maximum length to which the queue of pending connections can grow. Valid range is from 1 to 5.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0, and a specific error code can be retrieved by calling [GetLastError](#casyncsocket__getlasterror). The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEADDRINUSE** An attempt has been made to listen on an address in use.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets operation is in progress.  
  
-   **WSAEINVAL** The socket has not been bound with **Bind** or is already connected.  
  
-   **WSAEISCONN** The socket is already connected.  
  
-   **WSAEMFILE** No more file descriptors are available.  
  
-   <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> No buffer space is available.  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
-   **WSAEOPNOTSUPP** The referenced socket is not of a type that supports the <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> operation.  
  
### Remarks  
 To accept connections, the socket is first created with **Create**, a backlog for incoming connections is specified with <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>, and then the connections are accepted with **Accept**. <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> applies only to sockets that support connections, that is, those of type **SOCK_STREAM**. This socket is put into "passive" mode where incoming connections are acknowledged and queued pending acceptance by the process.  
  
 This function is typically used by servers (or any application that wants to accept connections) that could have more than one connection request at a time: if a connection request arrives with the queue full, the client will receive an error with an indication of **WSAECONNREFUSED**.  
  
 <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> attempts to continue to function rationally when there are no available ports (descriptors). It will accept connections until the queue is emptied. If ports become available, a later call to <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> or **Accept** will refill the queue to the current or most recent "backlog," if possible, and resume listening for incoming connections.  
  
##  \<a name="casyncsocket__m_hsocket">\</a>  CAsyncSocket::m_hSocket  
 Contains the **SOCKET** handle for the socket encapsulated by this <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
##  \<a name="casyncsocket__onaccept">\</a>  CAsyncSocket::OnAccept  
 Called by the framework to notify a listening socket that it can accept pending connection requests by calling the [Accept](#casyncsocket__accept) member function.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>  
 The most recent error on a socket. The following error codes applies to the <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> member function:  
  
-   **0** The function executed successfully.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
### Remarks  
 For more information, see [Windows Sockets: Socket Notifications](../vs140/windows-sockets--socket-notifications.md).  
  
##  \<a name="casyncsocket__onclose">\</a>  CAsyncSocket::OnClose  
 Called by the framework to notify this socket that the connected socket is closed by its process.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>  
 The most recent error on a socket. The following error codes apply to the <CodeContentPlaceHolder>189\</CodeContentPlaceHolder> member function:  
  
-   **0** The function executed successfully.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAECONNRESET** The connection was reset by the remote side.  
  
-   **WSAECONNABORTED** The connection was aborted due to timeout or other failure.  
  
### Remarks  
 For more information, see [Windows Sockets: Socket Notifications](../vs140/windows-sockets--socket-notifications.md).  
  
##  \<a name="casyncsocket__onconnect">\</a>  CAsyncSocket::OnConnect  
 Called by the framework to notify this connecting socket that its connection attempt is completed, whether successfully or in error.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  
 The most recent error on a socket. The following error codes apply to the <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> member function:  
  
-   **0** The function executed successfully.  
  
-   **WSAEADDRINUSE** The specified address is already in use.  
  
-   **WSAEADDRNOTAVAIL** The specified address is not available from the local machine.  
  
-   **WSAEAFNOSUPPORT** Addresses in the specified family cannot be used with this socket.  
  
-   **WSAECONNREFUSED** The attempt to connect was forcefully rejected.  
  
-   **WSAEDESTADDRREQ** A destination address is required.  
  
-   **WSAEFAULT** The <CodeContentPlaceHolder>192\</CodeContentPlaceHolder> argument is incorrect.  
  
-   **WSAEINVAL** The socket is already bound to an address.  
  
-   **WSAEISCONN** The socket is already connected.  
  
-   **WSAEMFILE** No more file descriptors are available.  
  
-   **WSAENETUNREACH** The network cannot be reached from this host at this time.  
  
-   <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> No buffer space is available. The socket cannot be connected.  
  
-   **WSAENOTCONN** The socket is not connected.  
  
-   **WSAENOTSOCK** The descriptor is a file, not a socket.  
  
-   **WSAETIMEDOUT** The attempt to connect timed out without establishing a connection.  
  
### Remarks  
  
> [!NOTE]
>  In [CSocket](../vs140/csocket-class.md), the <CodeContentPlaceHolder>194\</CodeContentPlaceHolder> notification function is never called. For connections, you simply call **Connect**, which will return when the connection is completed (either successfully or in error). How connection notifications are handled is an MFC implementation detail.  
  
 For more information, see [Windows Sockets: Socket Notifications](../vs140/windows-sockets--socket-notifications.md).  
  
### Example  
 [!code[NVC_MFCAsyncSocket#1](../vs140/codesnippet/CPP/casyncsocket-class_1.cpp)]  
  
##  \<a name="casyncsocket__onoutofbanddata">\</a>  CAsyncSocket::OnOutOfBandData  
 Called by the framework to notify the receiving socket that the sending socket has out-of-band data to send.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>  
 The most recent error on a socket. The following error codes apply to the <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> member function:  
  
-   **0** The function executed successfully.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
### Remarks  
 Out-of-band data is a logically independent channel that is associated with each pair of connected sockets of type **SOCK_STREAM**. The channel is generally used to send urgent data.  
  
 MFC supports out-of-band data, but users of class <CodeContentPlaceHolder>197\</CodeContentPlaceHolder> are discouraged from using it. The easier way is to create a second socket for passing such data. For more information about out-of-band data, see [Windows Sockets: Socket Notifications](../vs140/windows-sockets--socket-notifications.md).  
  
##  \<a name="casyncsocket__onreceive">\</a>  CAsyncSocket::OnReceive  
 Called by the framework to notify this socket that there is data in the buffer that can be retrieved by calling the **Receive** member function.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>  
 The most recent error on a socket. The following error codes apply to the <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> member function:  
  
-   **0** The function executed successfully.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
### Remarks  
 For more information, see [Windows Sockets: Socket Notifications](../vs140/windows-sockets--socket-notifications.md).  
  
### Example  
 [!code[NVC_MFCAsyncSocket#2](../vs140/codesnippet/CPP/casyncsocket-class_2.cpp)]  
  
##  \<a name="casyncsocket__onsend">\</a>  CAsyncSocket::OnSend  
 Called by the framework to notify the socket that it can now send data by calling the **Send** member function.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>  
 The most recent error on a socket. The following error codes apply to the <CodeContentPlaceHolder>201\</CodeContentPlaceHolder> member function:  
  
-   **0** The function executed successfully.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
### Remarks  
 For more information, see [Windows Sockets: Socket Notifications](../vs140/windows-sockets--socket-notifications.md).  
  
### Example  
 [!code[NVC_MFCAsyncSocket#3](../vs140/codesnippet/CPP/casyncsocket-class_3.cpp)]  
  
##  \<a name="casyncsocket__operator__eq">\</a>  CAsyncSocket::operator =  
 Assigns a new value to a <CodeContentPlaceHolder>202\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>  
 A reference to an existing <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> object.  
  
### Remarks  
 Call this function to copy an existing <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> object to another <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> object.  
  
##  \<a name="casyncsocket__operator_socket">\</a>  CAsyncSocket::operator SOCKET  
 Use this operator to retrieve the **SOCKET** handle of the <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
 If successful, the handle of the **SOCKET** object; otherwise, **NULL**.  
  
### Remarks  
 You can use the handle to call Windows APIs directly.  
  
##  \<a name="casyncsocket__receive">\</a>  CAsyncSocket::Receive  
 Call this member function to receive data from a socket.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>  
 A buffer for the incoming data.  
  
 <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>  
 The length of <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> in bytes.  
  
 <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>  
 Specifies the way in which the call is made. The semantics of this function are determined by the socket options and the <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> parameter. The latter is constructed by combining any of the following values with the C++ <CodeContentPlaceHolder>213\</CodeContentPlaceHolder> operator:  
  
-   **MSG_PEEK** Peek at the incoming data. The data is copied into the buffer but is not removed from the input queue.  
  
-   **MSG_OOB** Process out-of-band data.  
  
### Return Value  
 If no error occurs, **Receive** returns the number of bytes received. If the connection has been closed, it returns 0. Otherwise, a value of **SOCKET_ERROR** is returned, and a specific error code can be retrieved by calling [GetLastError](#casyncsocket__getlasterror). The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAENOTCONN** The socket is not connected.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets operation is in progress.  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
-   **WSAEOPNOTSUPP MSG_OOB** was specified, but the socket is not of type **SOCK_STREAM**.  
  
-   **WSAESHUTDOWN** The socket has been shut down; it is not possible to call **Receive** on a socket after <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> has been invoked with <CodeContentPlaceHolder>215\</CodeContentPlaceHolder> set to 0 or 2.  
  
-   **WSAEWOULDBLOCK** The socket is marked as nonblocking and the **Receive** operation would block.  
  
-   **WSAEMSGSIZE** The datagram was too large to fit into the specified buffer and was truncated.  
  
-   **WSAEINVAL** The socket has not been bound with **Bind**.  
  
-   **WSAECONNABORTED** The virtual circuit was aborted due to timeout or other failure.  
  
-   **WSAECONNRESET** The virtual circuit was reset by the remote side.  
  
### Remarks  
 This function is used for connected stream or datagram sockets and is used to read incoming data.  
  
 For sockets of type **SOCK_STREAM**, as much information as is currently available up to the size of the buffer supplied is returned. If the socket has been configured for in-line reception of out-of-band data (socket option **SO_OOBINLINE**) and out-of-band data is unread, only out-of-band data will be returned. The application can use the **IOCtlSIOCATMARK** option or [OnOutOfBandData](#casyncsocket__onoutofbanddata) to determine whether any more out-of-band data remains to be read.  
  
 For datagram sockets, data is extracted from the first enqueued datagram, up to the size of the buffer supplied. If the datagram is larger than the buffer supplied, the buffer is filled with the first part of the datagram, the excess data is lost, and **Receive** returns a value of **SOCKET_ERROR** with the error code set to **WSAEMSGSIZE**. If no incoming data is available at the socket, a value of **SOCKET_ERROR** is returned with the error code set to **WSAEWOULDBLOCK**. The [OnReceive](#casyncsocket__onreceive) callback function can be used to determine when more data arrives.  
  
 If the socket is of type **SOCK_STREAM** and the remote side has shut down the connection gracefully, a **Receive** will complete immediately with 0 bytes received. If the connection has been reset, a **Receive** will fail with the error **WSAECONNRESET**.  
  
 **Receive** should be called only once for each time [CAsyncSocket::OnReceive](#casyncsocket__onreceive) is called.  
  
### Example  
  See the example for [CAsyncSocket::OnReceive](#casyncsocket__onreceive).  
  
##  \<a name="casyncsocket__receivefrom">\</a>  CAsyncSocket::ReceiveFrom  
 Call this member function to receive a datagram and store the source address in the [SOCKADDR](../vs140/sockaddr-structure.md) structure or in <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>  
 A buffer for the incoming data.  
  
 <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>  
 The length of <CodeContentPlaceHolder>219\</CodeContentPlaceHolder> in bytes.  
  
 <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>  
 Reference to a <CodeContentPlaceHolder>221\</CodeContentPlaceHolder> object that receives a dotted number IP address.  
  
 <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>  
 Reference to a **UINT** that stores a port.  
  
 <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>  
 A pointer to a [SOCKADDR](../vs140/sockaddr-structure.md) structure that holds the source address upon return.  
  
 <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>  
 A pointer to the length of the source address in <CodeContentPlaceHolder>225\</CodeContentPlaceHolder> in bytes.  
  
 <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>  
 Specifies the way in which the call is made. The semantics of this function are determined by the socket options and the <CodeContentPlaceHolder>227\</CodeContentPlaceHolder> parameter. The latter is constructed by combining any of the following values with the C++ <CodeContentPlaceHolder>228\</CodeContentPlaceHolder> operator:  
  
-   **MSG_PEEK** Peek at the incoming data. The data is copied into the buffer but is not removed from the input queue.  
  
-   **MSG_OOB** Process out-of-band data.  
  
### Return Value  
 If no error occurs, <CodeContentPlaceHolder>229\</CodeContentPlaceHolder> returns the number of bytes received. If the connection has been closed, it returns 0. Otherwise, a value of **SOCKET_ERROR** is returned, and a specific error code can be retrieved by calling <CodeContentPlaceHolder>230\</CodeContentPlaceHolder>. The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEFAULT** The <CodeContentPlaceHolder>231\</CodeContentPlaceHolder> argument was invalid: the <CodeContentPlaceHolder>232\</CodeContentPlaceHolder> buffer was too small to accommodate the peer address.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets operation is in progress.  
  
-   **WSAEINVAL** The socket has not been bound with **Bind**.  
  
-   **WSAENOTCONN** The socket is not connected ( **SOCK_STREAM** only).  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
-   **WSAEOPNOTSUPP MSG_OOB** was specified, but the socket is not of type **SOCK_STREAM**.  
  
-   **WSAESHUTDOWN** The socket has been shut down; it is not possible to call <CodeContentPlaceHolder>233\</CodeContentPlaceHolder> on a socket after <CodeContentPlaceHolder>234\</CodeContentPlaceHolder> has been invoked with <CodeContentPlaceHolder>235\</CodeContentPlaceHolder> set to 0 or 2.  
  
-   **WSAEWOULDBLOCK** The socket is marked as nonblocking and the <CodeContentPlaceHolder>236\</CodeContentPlaceHolder> operation would block.  
  
-   **WSAEMSGSIZE** The datagram was too large to fit into the specified buffer and was truncated.  
  
-   **WSAECONNABORTED** The virtual circuit was aborted due to timeout or other failure.  
  
-   **WSAECONNRESET** The virtual circuit was reset by the remote side.  
  
### Remarks  
 This function is used to read incoming data on a (possibly connected) socket and capture the address from which the data was sent.  
  
 To handle IPv6 addresses, use [CAsyncSocket::ReceiveFromEx](#casyncsocket__receivefromex).  
  
 For sockets of type **SOCK_STREAM**, as much information as is currently available up to the size of the buffer supplied is returned. If the socket has been configured for in-line reception of out-of-band data (socket option **SO_OOBINLINE**) and out-of-band data is unread, only out-of-band data will be returned. The application can use the **IOCtlSIOCATMARK** option or <CodeContentPlaceHolder>237\</CodeContentPlaceHolder> to determine whether any more out-of-band data remains to be read. The <CodeContentPlaceHolder>238\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>239\</CodeContentPlaceHolder> parameters are ignored for **SOCK_STREAM** sockets.  
  
 For datagram sockets, data is extracted from the first enqueued datagram, up to the size of the buffer supplied. If the datagram is larger than the buffer supplied, the buffer is filled with the first part of the message, the excess data is lost, and <CodeContentPlaceHolder>240\</CodeContentPlaceHolder> returns a value of **SOCKET_ERROR** with the error code set to **WSAEMSGSIZE**.  
  
 If <CodeContentPlaceHolder>241\</CodeContentPlaceHolder> is nonzero, and the socket is of type **SOCK_DGRAM**, the network address of the socket which sent the data is copied to the corresponding [SOCKADDR](../vs140/sockaddr-structure.md) structure. The value pointed to by <CodeContentPlaceHolder>242\</CodeContentPlaceHolder> is initialized to the size of this structure, and is modified on return to indicate the actual size of the address stored there. If no incoming data is available at the socket, the <CodeContentPlaceHolder>243\</CodeContentPlaceHolder> call waits for data to arrive unless the socket is nonblocking. In this case, a value of **SOCKET_ERROR** is returned with the error code set to **WSAEWOULDBLOCK**. The <CodeContentPlaceHolder>244\</CodeContentPlaceHolder> callback can be used to determine when more data arrives.  
  
 If the socket is of type **SOCK_STREAM** and the remote side has shut down the connection gracefully, a <CodeContentPlaceHolder>245\</CodeContentPlaceHolder> will complete immediately with 0 bytes received.  
  
##  \<a name="casyncsocket__receivefromex">\</a>  CAsyncSocket::ReceiveFromEx  
 Call this member function to receive a datagram and store the source address in the [SOCKADDR](../vs140/sockaddr-structure.md) structure or in <CodeContentPlaceHolder>246\</CodeContentPlaceHolder> (handles IPv6 addresses).  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>  
 A buffer for the incoming data.  
  
 <CodeContentPlaceHolder>248\</CodeContentPlaceHolder>  
 The length of <CodeContentPlaceHolder>249\</CodeContentPlaceHolder> in bytes.  
  
 <CodeContentPlaceHolder>250\</CodeContentPlaceHolder>  
 Reference to a <CodeContentPlaceHolder>251\</CodeContentPlaceHolder> object that receives a dotted number IP address.  
  
 <CodeContentPlaceHolder>252\</CodeContentPlaceHolder>  
 Reference to a **UINT** that stores a port.  
  
 <CodeContentPlaceHolder>253\</CodeContentPlaceHolder>  
 Specifies the way in which the call is made. The semantics of this function are determined by the socket options and the <CodeContentPlaceHolder>254\</CodeContentPlaceHolder> parameter. The latter is constructed by combining any of the following values with the C++ <CodeContentPlaceHolder>255\</CodeContentPlaceHolder> operator:  
  
-   **MSG_PEEK** Peek at the incoming data. The data is copied into the buffer but is not removed from the input queue.  
  
-   **MSG_OOB** Process out-of-band data.  
  
### Return Value  
 If no error occurs, <CodeContentPlaceHolder>256\</CodeContentPlaceHolder> returns the number of bytes received. If the connection has been closed, it returns 0. Otherwise, a value of **SOCKET_ERROR** is returned, and a specific error code can be retrieved by calling <CodeContentPlaceHolder>257\</CodeContentPlaceHolder>. The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEFAULT** The <CodeContentPlaceHolder>258\</CodeContentPlaceHolder> argument was invalid: the <CodeContentPlaceHolder>259\</CodeContentPlaceHolder> buffer was too small to accommodate the peer address.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets operation is in progress.  
  
-   **WSAEINVAL** The socket has not been bound with **Bind**.  
  
-   **WSAENOTCONN** The socket is not connected ( **SOCK_STREAM** only).  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
-   **WSAEOPNOTSUPP MSG_OOB** was specified, but the socket is not of type **SOCK_STREAM**.  
  
-   **WSAESHUTDOWN** The socket has been shut down; it is not possible to call <CodeContentPlaceHolder>260\</CodeContentPlaceHolder> on a socket after <CodeContentPlaceHolder>261\</CodeContentPlaceHolder> has been invoked with <CodeContentPlaceHolder>262\</CodeContentPlaceHolder> set to 0 or 2.  
  
-   **WSAEWOULDBLOCK** The socket is marked as nonblocking and the <CodeContentPlaceHolder>263\</CodeContentPlaceHolder> operation would block.  
  
-   **WSAEMSGSIZE** The datagram was too large to fit into the specified buffer and was truncated.  
  
-   **WSAECONNABORTED** The virtual circuit was aborted due to timeout or other failure.  
  
-   **WSAECONNRESET** The virtual circuit was reset by the remote side.  
  
### Remarks  
 This function is used to read incoming data on a (possibly connected) socket and capture the address from which the data was sent.  
  
 This function is the same as [CAsyncSocket::ReceiveFrom](#casyncsocket__receivefrom) except that it handles IPv6 addresses as well as older protocols.  
  
 For sockets of type **SOCK_STREAM**, as much information as is currently available up to the size of the buffer supplied is returned. If the socket has been configured for in-line reception of out-of-band data (socket option **SO_OOBINLINE**) and out-of-band data is unread, only out-of-band data will be returned. The application can use the **IOCtlSIOCATMARK** option or <CodeContentPlaceHolder>264\</CodeContentPlaceHolder> to determine whether any more out-of-band data remains to be read. The <CodeContentPlaceHolder>265\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>266\</CodeContentPlaceHolder> parameters are ignored for **SOCK_STREAM** sockets.  
  
 For datagram sockets, data is extracted from the first enqueued datagram, up to the size of the buffer supplied. If the datagram is larger than the buffer supplied, the buffer is filled with the first part of the message, the excess data is lost, and <CodeContentPlaceHolder>267\</CodeContentPlaceHolder> returns a value of **SOCKET_ERROR** with the error code set to **WSAEMSGSIZE**.  
  
 If <CodeContentPlaceHolder>268\</CodeContentPlaceHolder> is nonzero, and the socket is of type **SOCK_DGRAM**, the network address of the socket which sent the data is copied to the corresponding [SOCKADDR](../vs140/sockaddr-structure.md) structure. The value pointed to by <CodeContentPlaceHolder>269\</CodeContentPlaceHolder> is initialized to the size of this structure, and is modified on return to indicate the actual size of the address stored there. If no incoming data is available at the socket, the <CodeContentPlaceHolder>270\</CodeContentPlaceHolder> call waits for data to arrive unless the socket is nonblocking. In this case, a value of **SOCKET_ERROR** is returned with the error code set to **WSAEWOULDBLOCK**. The <CodeContentPlaceHolder>271\</CodeContentPlaceHolder> callback can be used to determine when more data arrives.  
  
 If the socket is of type **SOCK_STREAM** and the remote side has shut down the connection gracefully, a <CodeContentPlaceHolder>272\</CodeContentPlaceHolder> will complete immediately with 0 bytes received.  
  
##  \<a name="casyncsocket__send">\</a>  CAsyncSocket::Send  
 Call this member function to send data on a connected socket.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>273\</CodeContentPlaceHolder>  
 A buffer containing the data to be transmitted.  
  
 <CodeContentPlaceHolder>274\</CodeContentPlaceHolder>  
 The length of the data in <CodeContentPlaceHolder>275\</CodeContentPlaceHolder> in bytes.  
  
 <CodeContentPlaceHolder>276\</CodeContentPlaceHolder>  
 Specifies the way in which the call is made. The semantics of this function are determined by the socket options and the <CodeContentPlaceHolder>277\</CodeContentPlaceHolder> parameter. The latter is constructed by combining any of the following values with the C++ <CodeContentPlaceHolder>278\</CodeContentPlaceHolder> operator:  
  
-   **MSG_DONTROUTE** Specifies that the data should not be subject to routing. A Windows Sockets supplier can choose to ignore this flag.  
  
-   **MSG_OOB** Send out-of-band data ( **SOCK_STREAM** only).  
  
### Return Value  
 If no error occurs, **Send** returns the total number of characters sent. (Note that this can be less than the number indicated by <CodeContentPlaceHolder>279\</CodeContentPlaceHolder>.) Otherwise, a value of **SOCKET_ERROR** is returned, and a specific error code can be retrieved by calling [GetLastError](#casyncsocket__getlasterror). The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEACCES** The requested address is a broadcast address, but the appropriate flag was not set.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets operation is in progress.  
  
-   **WSAEFAULT** The <CodeContentPlaceHolder>280\</CodeContentPlaceHolder> argument is not in a valid part of the user address space.  
  
-   **WSAENETRESET** The connection must be reset because the Windows Sockets implementation dropped it.  
  
-   <CodeContentPlaceHolder>281\</CodeContentPlaceHolder> The Windows Sockets implementation reports a buffer deadlock.  
  
-   **WSAENOTCONN** The socket is not connected.  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
-   **WSAEOPNOTSUPP MSG_OOB** was specified, but the socket is not of type **SOCK_STREAM**.  
  
-   **WSAESHUTDOWN** The socket has been shut down; it is not possible to call **Send** on a socket after <CodeContentPlaceHolder>282\</CodeContentPlaceHolder> has been invoked with <CodeContentPlaceHolder>283\</CodeContentPlaceHolder> set to 1 or 2.  
  
-   **WSAEWOULDBLOCK** The socket is marked as nonblocking and the requested operation would block.  
  
-   **WSAEMSGSIZE** The socket is of type **SOCK_DGRAM**, and the datagram is larger than the maximum supported by the Windows Sockets implementation.  
  
-   **WSAEINVAL** The socket has not been bound with **Bind**.  
  
-   **WSAECONNABORTED** The virtual circuit was aborted due to timeout or other failure.  
  
-   **WSAECONNRESET** The virtual circuit was reset by the remote side.  
  
### Remarks  
 **Send** is used to write outgoing data on connected stream or datagram sockets. For datagram sockets, care must be taken not to exceed the maximum IP packet size of the underlying subnets, which is given by the **iMaxUdpDg** element in the [WSADATA](../vs140/wsadata-structure.md) structure returned by <CodeContentPlaceHolder>284\</CodeContentPlaceHolder>. If the data is too long to pass atomically through the underlying protocol, the error **WSAEMSGSIZE** is returned via <CodeContentPlaceHolder>285\</CodeContentPlaceHolder>, and no data is transmitted.  
  
 Note that for a datagram socket the successful completion of a **Send** does not indicate that the data was successfully delivered.  
  
 On <CodeContentPlaceHolder>286\</CodeContentPlaceHolder> objects of type **SOCK_STREAM**, the number of bytes written can be between 1 and the requested length, depending on buffer availability on both the local and foreign hosts.  
  
### Example  
  See the example for [CAsyncSocket::OnSend](#casyncsocket__onsend).  
  
##  \<a name="casyncsocket__sendto">\</a>  CAsyncSocket::SendTo  
 Call this member function to send data to a specific destination.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>287\</CodeContentPlaceHolder>  
 A buffer containing the data to be transmitted.  
  
 <CodeContentPlaceHolder>288\</CodeContentPlaceHolder>  
 The length of the data in <CodeContentPlaceHolder>289\</CodeContentPlaceHolder> in bytes.  
  
 <CodeContentPlaceHolder>290\</CodeContentPlaceHolder>  
 The port identifying the socket application.  
  
 <CodeContentPlaceHolder>291\</CodeContentPlaceHolder>  
 The network address of the socket to which this object is connected: a machine name such as "ftp.microsoft.com," or a dotted number such as "128.56.22.8".  
  
 <CodeContentPlaceHolder>292\</CodeContentPlaceHolder>  
 Specifies the way in which the call is made. The semantics of this function are determined by the socket options and the <CodeContentPlaceHolder>293\</CodeContentPlaceHolder> parameter. The latter is constructed by combining any of the following values with the C++ <CodeContentPlaceHolder>294\</CodeContentPlaceHolder> operator:  
  
-   **MSG_DONTROUTE** Specifies that the data should not be subject to routing. A Windows Sockets supplier can choose to ignore this flag.  
  
-   **MSG_OOB** Send out-of-band data ( **SOCK_STREAM** only).  
  
 <CodeContentPlaceHolder>295\</CodeContentPlaceHolder>  
 A pointer to a [SOCKADDR](../vs140/sockaddr-structure.md) structure that contains the address of the target socket.  
  
 <CodeContentPlaceHolder>296\</CodeContentPlaceHolder>  
 The length of the address in <CodeContentPlaceHolder>297\</CodeContentPlaceHolder> in bytes.  
  
### Return Value  
 If no error occurs, <CodeContentPlaceHolder>298\</CodeContentPlaceHolder> returns the total number of characters sent. (Note that this can be less than the number indicated by <CodeContentPlaceHolder>299\</CodeContentPlaceHolder>.) Otherwise, a value of **SOCKET_ERROR** is returned, and a specific error code can be retrieved by calling [GetLastError](#casyncsocket__getlasterror). The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEACCES** The requested address is a broadcast address, but the appropriate flag was not set.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets operation is in progress.  
  
-   **WSAEFAULT** The <CodeContentPlaceHolder>300\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>301\</CodeContentPlaceHolder> parameters are not part of the user address space, or the <CodeContentPlaceHolder>302\</CodeContentPlaceHolder> argument is too small (less than the size of a [SOCKADDR](../vs140/sockaddr-structure.md) structure).  
  
-   **WSAEINVAL** The host name is invalid.  
  
-   **WSAENETRESET** The connection must be reset because the Windows Sockets implementation dropped it.  
  
-   <CodeContentPlaceHolder>303\</CodeContentPlaceHolder> The Windows Sockets implementation reports a buffer deadlock.  
  
-   **WSAENOTCONN** The socket is not connected ( **SOCK_STREAM** only).  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
-   **WSAEOPNOTSUPP MSG_OOB** was specified, but the socket is not of type **SOCK_STREAM**.  
  
-   **WSAESHUTDOWN** The socket has been shut down; it is not possible to call <CodeContentPlaceHolder>304\</CodeContentPlaceHolder> on a socket after <CodeContentPlaceHolder>305\</CodeContentPlaceHolder> has been invoked with <CodeContentPlaceHolder>306\</CodeContentPlaceHolder> set to 1 or 2.  
  
-   **WSAEWOULDBLOCK** The socket is marked as nonblocking and the requested operation would block.  
  
-   **WSAEMSGSIZE** The socket is of type **SOCK_DGRAM**, and the datagram is larger than the maximum supported by the Windows Sockets implementation.  
  
-   **WSAECONNABORTED** The virtual circuit was aborted due to timeout or other failure.  
  
-   **WSAECONNRESET** The virtual circuit was reset by the remote side.  
  
-   **WSAEADDRNOTAVAIL** The specified address is not available from the local machine.  
  
-   **WSAEAFNOSUPPORT** Addresses in the specified family cannot be used with this socket.  
  
-   **WSAEDESTADDRREQ** A destination address is required.  
  
-   **WSAENETUNREACH** The network cannot be reached from this host at this time.  
  
### Remarks  
 <CodeContentPlaceHolder>307\</CodeContentPlaceHolder> is used on datagram or stream sockets and is used to write outgoing data on a socket. For datagram sockets, care must be taken not to exceed the maximum IP packet size of the underlying subnets, which is given by the **iMaxUdpDg** element in the [WSADATA](../vs140/wsadata-structure.md) structure filled out by [AfxSocketInit](../vs140/afxsocketinit.md). If the data is too long to pass atomically through the underlying protocol, the error **WSAEMSGSIZE** is returned, and no data is transmitted.  
  
 Note that the successful completion of a <CodeContentPlaceHolder>308\</CodeContentPlaceHolder> does not indicate that the data was successfully delivered.  
  
 <CodeContentPlaceHolder>309\</CodeContentPlaceHolder> is only used on a **SOCK_DGRAM** socket to send a datagram to a specific socket identified by the <CodeContentPlaceHolder>310\</CodeContentPlaceHolder> parameter.  
  
 To send a broadcast (on a **SOCK_DGRAM** only), the address in the <CodeContentPlaceHolder>311\</CodeContentPlaceHolder> parameter should be constructed using the special IP address **INADDR_BROADCAST** (defined in the Windows Sockets header file WINSOCK.H) together with the intended port number. Or, if the <CodeContentPlaceHolder>312\</CodeContentPlaceHolder> parameter is **NULL**, the socket is configured for broadcast. It is generally inadvisable for a broadcast datagram to exceed the size at which fragmentation can occur, which implies that the data portion of the datagram (excluding headers) should not exceed 512 bytes.  
  
 To handle IPv6 addresses, use [CAsyncSocket::SendToEx](#casyncsocket__sendtoex).  
  
##  \<a name="casyncsocket__sendtoex">\</a>  CAsyncSocket::SendToEx  
 Call this member function to send data to a specific destination (handles IPv6 addresses).  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>313\</CodeContentPlaceHolder>  
 A buffer containing the data to be transmitted.  
  
 <CodeContentPlaceHolder>314\</CodeContentPlaceHolder>  
 The length of the data in <CodeContentPlaceHolder>315\</CodeContentPlaceHolder> in bytes.  
  
 <CodeContentPlaceHolder>316\</CodeContentPlaceHolder>  
 The port identifying the socket application.  
  
 <CodeContentPlaceHolder>317\</CodeContentPlaceHolder>  
 The network address of the socket to which this object is connected: a machine name such as "ftp.microsoft.com," or a dotted number such as "128.56.22.8".  
  
 <CodeContentPlaceHolder>318\</CodeContentPlaceHolder>  
 Specifies the way in which the call is made. The semantics of this function are determined by the socket options and the <CodeContentPlaceHolder>319\</CodeContentPlaceHolder> parameter. The latter is constructed by combining any of the following values with the C++ <CodeContentPlaceHolder>320\</CodeContentPlaceHolder> operator:  
  
-   **MSG_DONTROUTE** Specifies that the data should not be subject to routing. A Windows Sockets supplier can choose to ignore this flag.  
  
-   **MSG_OOB** Send out-of-band data ( **SOCK_STREAM** only).  
  
### Return Value  
 If no error occurs, <CodeContentPlaceHolder>321\</CodeContentPlaceHolder> returns the total number of characters sent. (Note that this can be less than the number indicated by <CodeContentPlaceHolder>322\</CodeContentPlaceHolder>.) Otherwise, a value of **SOCKET_ERROR** is returned, and a specific error code can be retrieved by calling [GetLastError](#casyncsocket__getlasterror). The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEACCES** The requested address is a broadcast address, but the appropriate flag was not set.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets operation is in progress.  
  
-   **WSAEFAULT** The <CodeContentPlaceHolder>323\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>324\</CodeContentPlaceHolder> parameters are not part of the user address space, or the <CodeContentPlaceHolder>325\</CodeContentPlaceHolder> argument is too small (less than the size of a [SOCKADDR](../vs140/sockaddr-structure.md) structure).  
  
-   **WSAEINVAL** The host name is invalid.  
  
-   **WSAENETRESET** The connection must be reset because the Windows Sockets implementation dropped it.  
  
-   <CodeContentPlaceHolder>326\</CodeContentPlaceHolder> The Windows Sockets implementation reports a buffer deadlock.  
  
-   **WSAENOTCONN** The socket is not connected ( **SOCK_STREAM** only).  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
-   **WSAEOPNOTSUPP MSG_OOB** was specified, but the socket is not of type **SOCK_STREAM**.  
  
-   **WSAESHUTDOWN** The socket has been shut down; it is not possible to call <CodeContentPlaceHolder>327\</CodeContentPlaceHolder> on a socket after <CodeContentPlaceHolder>328\</CodeContentPlaceHolder> has been invoked with <CodeContentPlaceHolder>329\</CodeContentPlaceHolder> set to 1 or 2.  
  
-   **WSAEWOULDBLOCK** The socket is marked as nonblocking and the requested operation would block.  
  
-   **WSAEMSGSIZE** The socket is of type **SOCK_DGRAM**, and the datagram is larger than the maximum supported by the Windows Sockets implementation.  
  
-   **WSAECONNABORTED** The virtual circuit was aborted due to timeout or other failure.  
  
-   **WSAECONNRESET** The virtual circuit was reset by the remote side.  
  
-   **WSAEADDRNOTAVAIL** The specified address is not available from the local machine.  
  
-   **WSAEAFNOSUPPORT** Addresses in the specified family cannot be used with this socket.  
  
-   **WSAEDESTADDRREQ** A destination address is required.  
  
-   **WSAENETUNREACH** The network cannot be reached from this host at this time.  
  
### Remarks  
 This method is the same as [CAsyncSocket::SendTo](#casyncsocket__sendto) except that it handles IPv6 addresses as well as older protocols.  
  
 <CodeContentPlaceHolder>330\</CodeContentPlaceHolder> is used on datagram or stream sockets and is used to write outgoing data on a socket. For datagram sockets, care must be taken not to exceed the maximum IP packet size of the underlying subnets, which is given by the **iMaxUdpDg** element in the [WSADATA](../vs140/wsadata-structure.md) structure filled out by [AfxSocketInit](../vs140/afxsocketinit.md). If the data is too long to pass atomically through the underlying protocol, the error **WSAEMSGSIZE** is returned, and no data is transmitted.  
  
 Note that the successful completion of a <CodeContentPlaceHolder>331\</CodeContentPlaceHolder> does not indicate that the data was successfully delivered.  
  
 <CodeContentPlaceHolder>332\</CodeContentPlaceHolder> is only used on a **SOCK_DGRAM** socket to send a datagram to a specific socket identified by the <CodeContentPlaceHolder>333\</CodeContentPlaceHolder> parameter.  
  
 To send a broadcast (on a **SOCK_DGRAM** only), the address in the <CodeContentPlaceHolder>334\</CodeContentPlaceHolder> parameter should be constructed using the special IP address **INADDR_BROADCAST** (defined in the Windows Sockets header file WINSOCK.H) together with the intended port number. Or, if the <CodeContentPlaceHolder>335\</CodeContentPlaceHolder> parameter is **NULL**, the socket is configured for broadcast. It is generally inadvisable for a broadcast datagram to exceed the size at which fragmentation can occur, which implies that the data portion of the datagram (excluding headers) should not exceed 512 bytes.  
  
##  \<a name="casyncsocket__setsockopt">\</a>  CAsyncSocket::SetSockOpt  
 Call this member function to set a socket option.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>336\</CodeContentPlaceHolder>  
 The socket option for which the value is to be set.  
  
 <CodeContentPlaceHolder>337\</CodeContentPlaceHolder>  
 A pointer to the buffer in which the value for the requested option is supplied.  
  
 <CodeContentPlaceHolder>338\</CodeContentPlaceHolder>  
 The size of the <CodeContentPlaceHolder>339\</CodeContentPlaceHolder> buffer in bytes.  
  
 <CodeContentPlaceHolder>340\</CodeContentPlaceHolder>  
 The level at which the option is defined; the only supported levels are **SOL_SOCKET** and **IPPROTO_TCP**.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0, and a specific error code can be retrieved by calling [GetLastError](#casyncsocket__getlasterror). The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEFAULT** <CodeContentPlaceHolder>341\</CodeContentPlaceHolder> is not in a valid part of the process address space.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets operation is in progress.  
  
-   **WSAEINVAL** <CodeContentPlaceHolder>342\</CodeContentPlaceHolder> is not valid, or the information in <CodeContentPlaceHolder>343\</CodeContentPlaceHolder> is not valid.  
  
-   **WSAENETRESET** Connection has timed out when **SO_KEEPALIVE** is set.  
  
-   **WSAENOPROTOOPT** The option is unknown or unsupported. In particular, **SO_BROADCAST** is not supported on sockets of type **SOCK_STREAM**, while **SO_DONTLINGER**, **SO_KEEPALIVE**, **SO_LINGER**, and **SO_OOBINLINE** are not supported on sockets of type **SOCK_DGRAM**.  
  
-   **WSAENOTCONN** Connection has been reset when **SO_KEEPALIVE** is set.  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
### Remarks  
 <CodeContentPlaceHolder>344\</CodeContentPlaceHolder> sets the current value for a socket option associated with a socket of any type, in any state. Although options can exist at multiple protocol levels, this specification only defines options that exist at the uppermost "socket" level. Options affect socket operations, such as whether expedited data is received in the normal data stream, whether broadcast messages can be sent on the socket, and so on.  
  
 There are two types of socket options: Boolean options that enable or disable a feature or behavior, and options which require an integer value or structure. To enable a Boolean option, <CodeContentPlaceHolder>345\</CodeContentPlaceHolder> points to a nonzero integer. To disable the option <CodeContentPlaceHolder>346\</CodeContentPlaceHolder> points to an integer equal to zero. <CodeContentPlaceHolder>347\</CodeContentPlaceHolder> should be equal to **sizeof(BOOL)** for Boolean options. For other options, <CodeContentPlaceHolder>348\</CodeContentPlaceHolder> points to the integer or structure that contains the desired value for the option, and <CodeContentPlaceHolder>349\</CodeContentPlaceHolder> is the length of the integer or structure.  
  
 **SO_LINGER** controls the action taken when unsent data is queued on a socket and the **Close** function is called to close the socket.  
  
 By default, a socket cannot be bound (see [Bind](#casyncsocket__bind)) to a local address which is already in use. On occasion, however, it may be desirable to "reuse" an address in this way. Since every connection is uniquely identified by the combination of local and remote addresses, there is no problem with having two sockets bound to the same local address as long as the remote addresses are different.  
  
 To inform the Windows Sockets implementation that a **Bind** call on a socket should not be disallowed because the desired address is already in use by another socket, the application should set the **SO_REUSEADDR** socket option for the socket before issuing the **Bind** call. Note that the option is interpreted only at the time of the **Bind** call: it is therefore unnecessary (but harmless) to set the option on a socket which is not to be bound to an existing address, and setting or resetting the option after the **Bind** call has no effect on this or any other socket.  
  
 An application can request that the Windows Sockets implementation enable the use of "keep-alive" packets on Transmission Control Protocol (TCP) connections by turning on the **SO_KEEPALIVE** socket option. A Windows Sockets implementation need not support the use of keep-alives: if it does, the precise semantics are implementation-specific but should conform to section 4.2.3.6 of RFC 1122: "Requirements for Internet Hosts — Communication Layers." If a connection is dropped as the result of "keep-alives" the error code **WSAENETRESET** is returned to any calls in progress on the socket, and any subsequent calls will fail with **WSAENOTCONN**.  
  
 The **TCP_NODELAY** option disables the Nagle algorithm. The Nagle algorithm is used to reduce the number of small packets sent by a host by buffering unacknowledged send data until a full-size packet can be sent. However, for some applications this algorithm can impede performance, and **TCP_NODELAY** can be used to turn it off. Application writers should not set **TCP_NODELAY** unless the impact of doing so is well-understood and desired, since setting **TCP_NODELAY** can have a significant negative impact on network performance. **TCP_NODELAY** is the only supported socket option which uses level **IPPROTO_TCP**; all other options use level **SOL_SOCKET**.  
  
 Some implementations of Windows Sockets supply output debug information if the **SO_DEBUG** option is set by an application.  
  
 The following options are supported for <CodeContentPlaceHolder>350\</CodeContentPlaceHolder>. The Type identifies the type of data addressed by <CodeContentPlaceHolder>351\</CodeContentPlaceHolder>.  
  
|Value|Type|Meaning|  
|-----------|----------|-------------|  
|**SO_BROADCAST**|**BOOL**|Allow transmission of broadcast messages on the socket.|  
|**SO_DEBUG**|**BOOL**|Record debugging information.|  
|**SO_DONTLINGER**|**BOOL**|Don't block **Close** waiting for unsent data to be sent. Setting this option is equivalent to setting **SO_LINGER** with **l_onoff** set to zero.|  
|**SO_DONTROUTE**|**BOOL**|Don't route: send directly to interface.|  
|**SO_KEEPALIVE**|**BOOL**|Send keep-alives.|  
|**SO_LINGER**|**struct LINGER**|Linger on **Close** if unsent data is present.|  
|**SO_OOBINLINE**|**BOOL**|Receive out-of-band data in the normal data stream.|  
|**SO_RCVBUF**|<CodeContentPlaceHolder>352\</CodeContentPlaceHolder>|Specify buffer size for receives.|  
|**SO_REUSEADDR**|**BOOL**|Allow the socket to be bound to an address which is already in use. (See [Bind](#casyncsocket__bind).)|  
|**SO_SNDBUF**|<CodeContentPlaceHolder>353\</CodeContentPlaceHolder>|Specify buffer size for sends.|  
|**TCP_NODELAY**|**BOOL**|Disables the Nagle algorithm for send coalescing.|  
  
 Berkeley Software Distribution (BSD) options not supported for <CodeContentPlaceHolder>354\</CodeContentPlaceHolder> are:  
  
|Value|Type|Meaning|  
|-----------|----------|-------------|  
|**SO_ACCEPTCONN**|**BOOL**|Socket is listening|  
|**SO_ERROR**|<CodeContentPlaceHolder>355\</CodeContentPlaceHolder>|Get error status and clear.|  
|**SO_RCVLOWAT**|<CodeContentPlaceHolder>356\</CodeContentPlaceHolder>|Receive low water mark.|  
|**SO_RCVTIMEO**|<CodeContentPlaceHolder>357\</CodeContentPlaceHolder>|Receive timeout|  
|**SO_SNDLOWAT**|<CodeContentPlaceHolder>358\</CodeContentPlaceHolder>|Send low water mark.|  
|**SO_SNDTIMEO**|<CodeContentPlaceHolder>359\</CodeContentPlaceHolder>|Send timeout.|  
|**SO_TYPE**|<CodeContentPlaceHolder>360\</CodeContentPlaceHolder>|Type of the socket.|  
|**IP_OPTIONS**||Set options field in IP header.|  
  
##  \<a name="casyncsocket__shutdown">\</a>  CAsyncSocket::ShutDown  
 Call this member function to disable sends, receives, or both on the socket.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>361\</CodeContentPlaceHolder>  
 A flag that describes what types of operation will no longer be allowed, using the following enumerated values:  
  
-   **receives = 0**  
  
-   **sends = 1**  
  
-   **both = 2**  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0, and a specific error code can be retrieved by calling [GetLastError](#casyncsocket__getlasterror). The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEINVAL** <CodeContentPlaceHolder>362\</CodeContentPlaceHolder> is not valid.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets operation is in progress.  
  
-   **WSAENOTCONN** The socket is not connected ( **SOCK_STREAM** only).  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
### Remarks  
 <CodeContentPlaceHolder>363\</CodeContentPlaceHolder> is used on all types of sockets to disable reception, transmission, or both. If <CodeContentPlaceHolder>364\</CodeContentPlaceHolder> is 0, subsequent receives on the socket will be disallowed. This has no effect on the lower protocol layers.  
  
 For Transmission Control Protocol (TCP), the TCP window is not changed and incoming data will be accepted (but not acknowledged) until the window is exhausted. For User Datagram Protocol (UDP), incoming datagrams are accepted and queued. In no case will an ICMP error packet be generated. If <CodeContentPlaceHolder>365\</CodeContentPlaceHolder> is 1, subsequent sends are disallowed. For TCP sockets, a FIN will be sent. Setting <CodeContentPlaceHolder>366\</CodeContentPlaceHolder> to 2 disables both sends and receives as described above.  
  
 Note that <CodeContentPlaceHolder>367\</CodeContentPlaceHolder> does not close the socket, and resources attached to the socket will not be freed until **Close** is called. An application should not rely on being able to reuse a socket after it has been shut down. In particular, a Windows Sockets implementation is not required to support the use of **Connect** on such a socket.  
  
### Example  
  See the example for [CAsyncSocket::OnReceive](#casyncsocket__onreceive).  
  
##  \<a name="casyncsocket__socket">\</a>  CASyncSocket::Socket  
 Allocates a socket handle.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>368\</CodeContentPlaceHolder>  
 Specifies <CodeContentPlaceHolder>369\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>370\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>371\</CodeContentPlaceHolder>  
 A bitmask that specifies a combination of network events in which the application is interested.  
  
-   <CodeContentPlaceHolder>372\</CodeContentPlaceHolder>: Want to receive notification of readiness for reading.  
  
-   <CodeContentPlaceHolder>373\</CodeContentPlaceHolder>: Want to receive notification of readiness for writing.  
  
-   <CodeContentPlaceHolder>374\</CodeContentPlaceHolder>: Want to receive notification of the arrival of out-of-band data.  
  
-   <CodeContentPlaceHolder>375\</CodeContentPlaceHolder>: Want to receive notification of incoming connections.  
  
-   <CodeContentPlaceHolder>376\</CodeContentPlaceHolder>: Want to receive notification of completed connection.  
  
-   <CodeContentPlaceHolder>377\</CodeContentPlaceHolder>: Want to receive notification of socket closure.  
  
 <CodeContentPlaceHolder>378\</CodeContentPlaceHolder>  
 Protocol to be used with the socket that is specific to the indicated address family.  
  
 <CodeContentPlaceHolder>379\</CodeContentPlaceHolder>  
 Address family specification.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>380\</CodeContentPlaceHolder> on success, <CodeContentPlaceHolder>381\</CodeContentPlaceHolder> on failure.  
  
### Remarks  
 This method allocates a socket handle. It does not call [Bind](#casyncsocket__bind) to bind the socket to a specified address, so you need to call <CodeContentPlaceHolder>382\</CodeContentPlaceHolder> later to bind the socket to a specified address. You can use [SetSockOpt](#casyncsocket__setsockopt) to set the socket option before it is bound.  
  
## See Also  
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSocket](../vs140/csocket-class.md)   
 [CSocketFile](../vs140/csocketfile-class.md)