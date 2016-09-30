---
title: "CAsyncSocket::GetSockOpt"
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
  - "CAsyncSocket::GetSockOpt"
  - "GetSockOpt"
  - "CAsyncSocket.GetSockOpt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSockOpt method"
ms.assetid: 2d23f3cf-558f-4a61-a37e-1eb670562ca8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncSocket::GetSockOpt
Call this member function to retrieve a socket option.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The socket option for which the value is to be retrieved.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the buffer in which the value for the requested option is to be returned. The value associated with the selected option is returned in the buffer <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. The integer pointed to by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> should originally contain the size of this buffer in bytes; and on return, it will be set to the size of the value returned. For **SO_LINGER**, this will be the size of a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure; for all other options it will be the size of a **BOOL** or an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, depending on the option. See the list of options and their sizes in the Remarks section.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A pointer to the size of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> buffer in bytes.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The level at which the option is defined; the only supported levels are **SOL_SOCKET** and **IPPROTO_TCP**.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0, and a specific error code can be retrieved by calling [GetLastError](../vs140/casyncsocket--getlasterror.md). If an option was never set with <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, then <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> returns the default value for the option. The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEFAULT** The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> argument was invalid.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets operation is in progress.  
  
-   **WSAENOPROTOOPT** The option is unknown or unsupported. In particular, **SO_BROADCAST** is not supported on sockets of type **SOCK_STREAM**, while **SO_ACCEPTCONN**, **SO_DONTLINGER**, **SO_KEEPALIVE**, **SO_LINGER**, and **SO_OOBINLINE** are not supported on sockets of type **SOCK_DGRAM**.  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
## Remarks  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> retrieves the current value for a socket option associated with a socket of any type, in any state, and stores the result in <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. Options affect socket operations, such as the routing of packets, out-of-band data transfer, and so on.  
  
 The following options are supported for <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. The Type identifies the type of data addressed by <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. The **TCP_NODELAY** option uses level **IPPROTO_TCP**; all other options use level **SOL_SOCKET**.  
  
|Value|Type|Meaning|  
|-----------|----------|-------------|  
|**SO_ACCEPTCONN**|**BOOL**|Socket is listening.|  
|**SO_BROADCAST**|**BOOL**|Socket is configured for the transmission of broadcast messages.|  
|**SO_DEBUG**|**BOOL**|Debugging is enabled.|  
|**SO_DONTLINGER**|**BOOL**|If true, the **SO_LINGER** option is disabled.|  
|**SO_DONTROUTE**|**BOOL**|Routing is disabled.|  
|**SO_ERROR**|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Retrieve error status and clear.|  
|**SO_KEEPALIVE**|**BOOL**|Keep-alives are being sent.|  
|**SO_LINGER**|**struct LINGER**|Returns the current linger options.|  
|**SO_OOBINLINE**|**BOOL**|Out-of-band data is being received in the normal data stream.|  
|**SO_RCVBUF**|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Buffer size for receives.|  
|**SO_REUSEADDR**|**BOOL**|The socket can be bound to an address which is already in use.|  
|**SO_SNDBUF**|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Buffer size for sends.|  
|**SO_TYPE**|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|The type of the socket (for example, **SOCK_STREAM**).|  
|**TCP_NODELAY**|**BOOL**|Disables the Nagle algorithm for send coalescing.|  
  
 Berkeley Software Distribution (BSD) options not supported for <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> are:  
  
|Value|Type|Meaning|  
|-----------|----------|-------------|  
|**SO_RCVLOWAT**|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Receive low water mark.|  
|**SO_RCVTIMEO**|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Receive timeout.|  
|**SO_SNDLOWAT**|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Send low water mark.|  
|**SO_SNDTIMEO**|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|Send timeout.|  
|**IP_OPTIONS**||Get options in IP header.|  
|**TCP_MAXSEG**|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Get TCP maximum segment size.|  
  
 Calling <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> with an unsupported option will result in an error code of **WSAENOPROTOOPT** being returned from <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::SetSockOpt](../vs140/casyncsocket--setsockopt.md)