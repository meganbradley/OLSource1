---
title: "CAsyncSocket::SetSockOpt"
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
  - "CAsyncSocket.SetSockOpt"
  - "CAsyncSocket::SetSockOpt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetSockOpt method"
ms.assetid: 0514f7d1-efec-4ed5-9e78-0aa0ec5ee9f2
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncSocket::SetSockOpt
Call this member function to set a socket option.  
  
## Syntax  
  
```  
  
      BOOL SetSockOpt(  
   int nOptionName,  
   const void* lpOptionValue,  
   int nOptionLen,  
   int nLevel = SOL_SOCKET   
);  
```  
  
#### Parameters  
 `nOptionName`  
 The socket option for which the value is to be set.  
  
 `lpOptionValue`  
 A pointer to the buffer in which the value for the requested option is supplied.  
  
 `nOptionLen`  
 The size of the `lpOptionValue` buffer in bytes.  
  
 `nLevel`  
 The level at which the option is defined; the only supported levels are **SOL_SOCKET** and **IPPROTO_TCP**.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0, and a specific error code can be retrieved by calling [GetLastError](../vs140/casyncsocket--getlasterror.md). The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEFAULT** `lpOptionValue` is not in a valid part of the process address space.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets operation is in progress.  
  
-   **WSAEINVAL** `nLevel` is not valid, or the information in `lpOptionValue` is not valid.  
  
-   **WSAENETRESET** Connection has timed out when **SO_KEEPALIVE** is set.  
  
-   **WSAENOPROTOOPT** The option is unknown or unsupported. In particular, **SO_BROADCAST** is not supported on sockets of type **SOCK_STREAM**, while **SO_DONTLINGER**, **SO_KEEPALIVE**, **SO_LINGER**, and **SO_OOBINLINE** are not supported on sockets of type **SOCK_DGRAM**.  
  
-   **WSAENOTCONN** Connection has been reset when **SO_KEEPALIVE** is set.  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
## Remarks  
 `SetSockOpt` sets the current value for a socket option associated with a socket of any type, in any state. Although options can exist at multiple protocol levels, this specification only defines options that exist at the uppermost "socket" level. Options affect socket operations, such as whether expedited data is received in the normal data stream, whether broadcast messages can be sent on the socket, and so on.  
  
 There are two types of socket options: Boolean options that enable or disable a feature or behavior, and options which require an integer value or structure. To enable a Boolean option, `lpOptionValue` points to a nonzero integer. To disable the option `lpOptionValue` points to an integer equal to zero. `nOptionLen` should be equal to **sizeof(BOOL)** for Boolean options. For other options, `lpOptionValue` points to the integer or structure that contains the desired value for the option, and `nOptionLen` is the length of the integer or structure.  
  
 **SO_LINGER** controls the action taken when unsent data is queued on a socket and the **Close** function is called to close the socket.  
  
 By default, a socket cannot be bound (see [Bind](../vs140/casyncsocket--bind.md)) to a local address which is already in use. On occasion, however, it may be desirable to "reuse" an address in this way. Since every connection is uniquely identified by the combination of local and remote addresses, there is no problem with having two sockets bound to the same local address as long as the remote addresses are different.  
  
 To inform the Windows Sockets implementation that a **Bind** call on a socket should not be disallowed because the desired address is already in use by another socket, the application should set the **SO_REUSEADDR** socket option for the socket before issuing the **Bind** call. Note that the option is interpreted only at the time of the **Bind** call: it is therefore unnecessary (but harmless) to set the option on a socket which is not to be bound to an existing address, and setting or resetting the option after the **Bind** call has no effect on this or any other socket.  
  
 An application can request that the Windows Sockets implementation enable the use of "keep-alive" packets on Transmission Control Protocol (TCP) connections by turning on the **SO_KEEPALIVE** socket option. A Windows Sockets implementation need not support the use of keep-alives: if it does, the precise semantics are implementation-specific but should conform to section 4.2.3.6 of RFC 1122: "Requirements for Internet Hosts — Communication Layers." If a connection is dropped as the result of "keep-alives" the error code **WSAENETRESET** is returned to any calls in progress on the socket, and any subsequent calls will fail with **WSAENOTCONN**.  
  
 The **TCP_NODELAY** option disables the Nagle algorithm. The Nagle algorithm is used to reduce the number of small packets sent by a host by buffering unacknowledged send data until a full-size packet can be sent. However, for some applications this algorithm can impede performance, and **TCP_NODELAY** can be used to turn it off. Application writers should not set **TCP_NODELAY** unless the impact of doing so is well-understood and desired, since setting **TCP_NODELAY** can have a significant negative impact on network performance. **TCP_NODELAY** is the only supported socket option which uses level **IPPROTO_TCP**; all other options use level **SOL_SOCKET**.  
  
 Some implementations of Windows Sockets supply output debug information if the **SO_DEBUG** option is set by an application.  
  
 The following options are supported for `SetSockOpt`. The Type identifies the type of data addressed by `lpOptionValue`.  
  
|Value|Type|Meaning|  
|-----------|----------|-------------|  
|**SO_BROADCAST**|**BOOL**|Allow transmission of broadcast messages on the socket.|  
|**SO_DEBUG**|**BOOL**|Record debugging information.|  
|**SO_DONTLINGER**|**BOOL**|Don't block **Close** waiting for unsent data to be sent. Setting this option is equivalent to setting **SO_LINGER** with **l_onoff** set to zero.|  
|**SO_DONTROUTE**|**BOOL**|Don't route: send directly to interface.|  
|**SO_KEEPALIVE**|**BOOL**|Send keep-alives.|  
|**SO_LINGER**|**struct LINGER**|Linger on **Close** if unsent data is present.|  
|**SO_OOBINLINE**|**BOOL**|Receive out-of-band data in the normal data stream.|  
|**SO_RCVBUF**|`int`|Specify buffer size for receives.|  
|**SO_REUSEADDR**|**BOOL**|Allow the socket to be bound to an address which is already in use. (See [Bind](../vs140/casyncsocket--bind.md).)|  
|**SO_SNDBUF**|`int`|Specify buffer size for sends.|  
|**TCP_NODELAY**|**BOOL**|Disables the Nagle algorithm for send coalescing.|  
  
 Berkeley Software Distribution (BSD) options not supported for `SetSockOpt` are:  
  
|Value|Type|Meaning|  
|-----------|----------|-------------|  
|**SO_ACCEPTCONN**|**BOOL**|Socket is listening|  
|**SO_ERROR**|`int`|Get error status and clear.|  
|**SO_RCVLOWAT**|`int`|Receive low water mark.|  
|**SO_RCVTIMEO**|`int`|Receive timeout|  
|**SO_SNDLOWAT**|`int`|Send low water mark.|  
|**SO_SNDTIMEO**|`int`|Send timeout.|  
|**SO_TYPE**|`int`|Type of the socket.|  
|**IP_OPTIONS**||Set options field in IP header.|  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::AsyncSelect](../vs140/casyncsocket--asyncselect.md)   
 [CAsyncSocket::Bind](../vs140/casyncsocket--bind.md)   
 [CAsyncSocket::Create](../vs140/casyncsocket--create.md)   
 [CAsyncSocket::GetSockOpt](../vs140/casyncsocket--getsockopt.md)   
 [CAsyncSocket::IOCtl](../vs140/casyncsocket--ioctl.md)