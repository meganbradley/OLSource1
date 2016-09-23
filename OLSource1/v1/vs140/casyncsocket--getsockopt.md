---
title: "CAsyncSocket::GetSockOpt"
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
  - CAsyncSocket::GetSockOpt
  - GetSockOpt
  - CAsyncSocket.GetSockOpt
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetSockOpt method
ms.assetid: 2d23f3cf-558f-4a61-a37e-1eb670562ca8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAsyncSocket::GetSockOpt
Call this member function to retrieve a socket option.  
  
## Syntax  
  
```  
  
      BOOL GetSockOpt(  
   int nOptionName,  
   void* lpOptionValue,  
   int* lpOptionLen,  
   int nLevel = SOL_SOCKET   
);  
```  
  
#### Parameters  
 `nOptionName`  
 The socket option for which the value is to be retrieved.  
  
 `lpOptionValue`  
 A pointer to the buffer in which the value for the requested option is to be returned. The value associated with the selected option is returned in the buffer `lpOptionValue`. The integer pointed to by `lpOptionLen` should originally contain the size of this buffer in bytes; and on return, it will be set to the size of the value returned. For **SO_LINGER**, this will be the size of a `LINGER` structure; for all other options it will be the size of a **BOOL** or an `int`, depending on the option. See the list of options and their sizes in the Remarks section.  
  
 `lpOptionLen`  
 A pointer to the size of the `lpOptionValue` buffer in bytes.  
  
 `nLevel`  
 The level at which the option is defined; the only supported levels are **SOL_SOCKET** and **IPPROTO_TCP**.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0, and a specific error code can be retrieved by calling [GetLastError](../vs140/casyncsocket--getlasterror.md). If an option was never set with `SetSockOpt`, then `GetSockOpt` returns the default value for the option. The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEFAULT** The `lpOptionLen` argument was invalid.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets operation is in progress.  
  
-   **WSAENOPROTOOPT** The option is unknown or unsupported. In particular, **SO_BROADCAST** is not supported on sockets of type **SOCK_STREAM**, while **SO_ACCEPTCONN**, **SO_DONTLINGER**, **SO_KEEPALIVE**, **SO_LINGER**, and **SO_OOBINLINE** are not supported on sockets of type **SOCK_DGRAM**.  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
## Remarks  
 `GetSockOpt` retrieves the current value for a socket option associated with a socket of any type, in any state, and stores the result in `lpOptionValue`. Options affect socket operations, such as the routing of packets, out-of-band data transfer, and so on.  
  
 The following options are supported for `GetSockOpt`. The Type identifies the type of data addressed by `lpOptionValue`. The **TCP_NODELAY** option uses level **IPPROTO_TCP**; all other options use level **SOL_SOCKET**.  
  
|Value|Type|Meaning|  
|-----------|----------|-------------|  
|**SO_ACCEPTCONN**|**BOOL**|Socket is listening.|  
|**SO_BROADCAST**|**BOOL**|Socket is configured for the transmission of broadcast messages.|  
|**SO_DEBUG**|**BOOL**|Debugging is enabled.|  
|**SO_DONTLINGER**|**BOOL**|If true, the **SO_LINGER** option is disabled.|  
|**SO_DONTROUTE**|**BOOL**|Routing is disabled.|  
|**SO_ERROR**|`int`|Retrieve error status and clear.|  
|**SO_KEEPALIVE**|**BOOL**|Keep-alives are being sent.|  
|**SO_LINGER**|**struct LINGER**|Returns the current linger options.|  
|**SO_OOBINLINE**|**BOOL**|Out-of-band data is being received in the normal data stream.|  
|**SO_RCVBUF**|`int`|Buffer size for receives.|  
|**SO_REUSEADDR**|**BOOL**|The socket can be bound to an address which is already in use.|  
|**SO_SNDBUF**|`int`|Buffer size for sends.|  
|**SO_TYPE**|`int`|The type of the socket (for example, **SOCK_STREAM**).|  
|**TCP_NODELAY**|**BOOL**|Disables the Nagle algorithm for send coalescing.|  
  
 Berkeley Software Distribution (BSD) options not supported for `GetSockOpt` are:  
  
|Value|Type|Meaning|  
|-----------|----------|-------------|  
|**SO_RCVLOWAT**|`int`|Receive low water mark.|  
|**SO_RCVTIMEO**|`int`|Receive timeout.|  
|**SO_SNDLOWAT**|`int`|Send low water mark.|  
|**SO_SNDTIMEO**|`int`|Send timeout.|  
|**IP_OPTIONS**||Get options in IP header.|  
|**TCP_MAXSEG**|`int`|Get TCP maximum segment size.|  
  
 Calling `GetSockOpt` with an unsupported option will result in an error code of **WSAENOPROTOOPT** being returned from `GetLastError`.  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::SetSockOpt](../vs140/casyncsocket--setsockopt.md)