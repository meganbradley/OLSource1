---
title: "CAsyncSocket::IOCtl"
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
  - "CAsyncSocket.IOCtl"
  - "CAsyncSocket::IOCtl"
  - "IOCtl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IOCtl method"
ms.assetid: a8c6c380-d874-49db-ba7c-f5e560a2fe1d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncSocket::IOCtl
Call this member function to control the mode of a socket.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The command to perform on the socket.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a parameter for <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0, and a specific error code can be retrieved by calling [GetLastError](../vs140/casyncsocket--getlasterror.md). The following errors apply to this member function:  
  
-   **WSANOTINITIALISED** A successful [AfxSocketInit](../vs140/afxsocketinit.md) must occur before using this API.  
  
-   **WSAENETDOWN** The Windows Sockets implementation detected that the network subsystem failed.  
  
-   **WSAEINVAL** <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is not a valid command, or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is not an acceptable parameter for <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, or the command is not applicable to the type of socket supplied.  
  
-   **WSAEINPROGRESS** A blocking Windows Sockets operation is in progress.  
  
-   **WSAENOTSOCK** The descriptor is not a socket.  
  
## Remarks  
 This routine can be used on any socket in any state. It is used to get or retrieve operating parameters associated with the socket, independent of the protocol and communications subsystem. The following commands are supported:  
  
-   **FIONBIO** Enable or disable nonblocking mode on the socket. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter points at a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, which is nonzero if nonblocking mode is to be enabled and zero if it is to be disabled. If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> has been issued on a socket, then any attempt to use **IOCtl** to set the socket back to blocking mode will fail with **WSAEINVAL**. To set the socket back to blocking mode and prevent the **WSAEINVAL** error, an application must first disable <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> by calling <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> with the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter equal to 0, then call **IOCtl**.  
  
-   **FIONREAD** Determine the maximum number of bytes that can be read with one **Receive** call from this socket. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter points at a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> in which **IOCtl** stores the result. If this socket is of type **SOCK_STREAM**, **FIONREAD** returns the total amount of data which can be read in a single **Receive**; this is normally the same as the total amount of data queued on the socket. If this socket is of type **SOCK_DGRAM**, **FIONREAD** returns the size of the first datagram queued on the socket.  
  
-   **SIOCATMARK** Determine whether all out-of-band data has been read. This applies only to a socket of type **SOCK_STREAM** which has been configured for in-line reception of any out-of-band data (**SO_OOBINLINE**). If no out-of-band data is waiting to be read, the operation returns nonzero. Otherwise it returns 0, and the next **Receive** or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> performed on the socket will retrieve some or all of the data preceding the "mark"; the application should use the **SIOCATMARK** operation to determine whether any data remains. If there is any normal data preceding the "urgent" (out-of-band) data, it will be received in order. (Note that a **Receive** or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> will never mix out-of-band and normal data in the same call.) The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> parameter points at a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> in which **IOCtl** stores the result.  
  
 This function is a subset of **ioctl()** as used in Berkeley sockets. In particular, there is no command which is equivalent to **FIOASYNC**, while **SIOCATMARK** is the only socket-level command which is supported.  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [CAsyncSocket Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket::AsyncSelect](../vs140/casyncsocket--asyncselect.md)   
 [CAsyncSocket::Create](../vs140/casyncsocket--create.md)   
 [CAsyncSocket::GetSockOpt](../vs140/casyncsocket--getsockopt.md)   
 [CAsyncSocket::SetSockOpt](../vs140/casyncsocket--setsockopt.md)