---
title: "CSocket Class"
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
  - "CSocket"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WinSock CSocket class"
  - "CSocket class"
  - "SOCKET handle"
  - "sockets classes"
ms.assetid: 7f23c081-d24d-42e3-b511-8053ca53d729
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSocket Class
Derives from <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, inherits its encapsulation of the Windows Sockets API, and represents a higher level of abstraction than that of a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CSocket::CSocket](#csocket__csocket)|Constructs a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CSocket::Attach](#csocket__attach)|Attaches a **SOCKET** handle to a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.|  
|[CSocket::CancelBlockingCall](#csocket__cancelblockingcall)|Cancels a blocking call that is currently in progress.|  
|[CSocket::Create](#csocket__create)|Creates a socket.|  
|[CSocket::FromHandle](#csocket__fromhandle)|Returns a pointer to a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object, given a **SOCKET** handle.|  
|[CSocket::IsBlocking](#csocket__isblocking)|Determines whether a blocking call is in progress.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CSocket::OnMessagePending](#csocket__onmessagepending)|Called to process pending messages while waiting for a blocking call to complete.|  
  
## Remarks  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> works with classes <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to manage the sending and receiving of data.  
  
 A <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object also provides blocking, which is essential to the synchronous operation of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. Blocking functions, such as <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> (all inherited from <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>), do not return a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> error in <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. Instead, these functions wait until the operation completes. Additionally, the original call will terminate with the error <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is called while one of these functions is blocking.  
  
 To use a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object, call the constructor, then call <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> to create the underlying <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> handle (type <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>). The default parameters of <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> create a stream socket, but if you are not using the socket with a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object, you can specify a parameter to create a datagram socket instead, or bind to a specific port to create a server socket. Connect to a client socket using <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> on the client side and <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> on the server side. Then create a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object and associate it to the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object in the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> constructor. Next, create a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object for sending and one for receiving data (as needed), then associate them with the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object in the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> constructor. When communications are complete, destroy the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> objects. The <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> data type is described in the article [Windows Sockets: Background](../vs140/windows-sockets--background.md).  
  
 When you use <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, you might encounter a situation where <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> enters a loop (by <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>) waiting for the requested amount of bytes. This is because Windows sockets allow only one recv call per FD_READ notification, but <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> allow multiple recv calls per FD_READ. If you get an FD_READ when there is no data to read, the application hangs. If you never get another FD_READ, the application stops communicating over the socket.  
  
 You can resolve this problem as follows. In the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> method of your socket class, call <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> before you call the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> method of your message class when the expected data to be read from the socket exceeds the size of one TCP packet (maximum transmission unit of the network medium, usually at least 1096 bytes). If the size of the available data is less than needed, wait for all the data to be received and only then start the read operation.  
  
 In the following example, <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> is the approximate number of bytes that the user expects to receive. It is assumed that you declare it elsewhere in your code.  
  
 [!code[NVC_MFCSocketThread#4](../vs140/codesnippet/CPP/csocket-class_1.cpp)]  
  
> [!NOTE]
>  When using MFC sockets in secondary threads in a statically linked MFC application, you must call <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> in each thread that uses sockets to initialize the socket libraries. By default, <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> is called only in the primary thread.  
  
 For more information, see [Windows Sockets in MFC](../vs140/windows-sockets-in-mfc.md), [Windows Sockets: Using Sockets with Archives](../vs140/windows-sockets--using-sockets-with-archives.md), [Windows Sockets: How Sockets with Archives Work](../vs140/windows-sockets--how-sockets-with-archives-work.md), [Windows Sockets: Sequence of Operations](../vs140/windows-sockets--sequence-of-operations.md), [Windows Sockets: Example of Sockets Using Archives](../vs140/windows-sockets--example-of-sockets-using-archives.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CAsyncSocket](../vs140/casyncsocket-class.md)  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxsock.h  
  
##  \<a name="csocket__attach">\</a>  CSocket::Attach  
 Call this member function to attach the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> handle to a <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 Contains a handle to a socket.  
  
### Return Value  
 Nonzero if the function is successful.  
  
### Remarks  
 The **SOCKET** handle is stored in the object's [m_hSocket](../vs140/casyncsocket-class.md#casyncsocket__m_hsocket) data member.  
  
 For more information, see [Windows Sockets: Using Sockets with Archives](../vs140/windows-sockets--using-sockets-with-archives.md).  
  
### Example  
 [!code[NVC_MFCSocketThread#1](../vs140/codesnippet/CPP/csocket-class_2.h)]  
  
 [!code[NVC_MFCSocketThread#2](../vs140/codesnippet/CPP/csocket-class_3.cpp)]  
  
 [!code[NVC_MFCSocketThread#3](../vs140/codesnippet/CPP/csocket-class_4.cpp)]  
  
##  \<a name="csocket__cancelblockingcall">\</a>  CSocket::CancelBlockingCall  
 Call this member function to cancel a blocking call currently in progress.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 This function cancels any outstanding blocking operation for this socket. The original blocking call will terminate as soon as possible with the error **WSAEINTR**.  
  
 In the case of a blocking **Connect** operation, the Windows Sockets implementation will terminate the blocking call as soon as possible, but it may not be possible for the socket resources to be released until the connection has completed (and then been reset) or timed out. This is likely to be noticeable only if the application immediately tries to open a new socket (if no sockets are available), or to connect to the same peer.  
  
 Canceling any operation other than **Accept** can leave the socket in an indeterminate state. If an application cancels a blocking operation on a socket, the only operation that the application can depend on being able to perform on the socket is a call to **Close**, although other operations may work on some Windows Sockets implementations. If you desire maximum portability for your application, you must be careful not to depend on performing operations after a cancel.  
  
 For more information, see [Windows Sockets: Using Sockets with Archives](../vs140/windows-sockets--using-sockets-with-archives.md).  
  
##  \<a name="csocket__create">\</a>  CSocket::Create  
 Call the **Create** member function after constructing a socket object to create the Windows socket and attach it.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 A particular port to be used with the socket, or 0 if you want MFC to select a port.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 **SOCK_STREAM** or **SOCK_DGRAM**.  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 A pointer to a string containing the network address of the connected socket, a dotted number such as "128.56.22.8". Passing the **NULL** string for this parameter indicates the **CSocket** instance should listen for client activity on all network interfaces.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0, and a specific error code can be retrieved by calling <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>.  
  
### Remarks  
 **Create** then calls **Bind** to bind the socket to the specified address. The following socket types are supported:  
  
-   **SOCK_STREAM** Provides sequenced, reliable, two-way, connection-based byte streams. Uses Transmission Control Protocol (TCP) for the Internet address family.  
  
-   **SOCK_DGRAM** Supports datagrams, which are connectionless, unreliable buffers of a fixed (typically small) maximum length. Uses User Datagram Protocol (UDP) for the Internet address family. To use this option, you must not use the socket with a <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> object.  
  
    > [!NOTE]
    >  The **Accept** member function takes a reference to a new, empty <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> object as its parameter. You must construct this object before you call **Accept**. Keep in mind that if this socket object goes out of scope, the connection closes. Do not call **Create** for this new socket object.  
  
 For more information about stream and datagram sockets, see the articles [Windows Sockets: Background](../vs140/windows-sockets--background.md), [Windows Sockets: Ports and Socket Addresses](../vs140/windows-sockets--ports-and-socket-addresses.md), and [Windows Sockets: Using Sockets with Archives](../vs140/windows-sockets--using-sockets-with-archives.md).  
  
##  \<a name="csocket__csocket">\</a>  CSocket::CSocket  
 Constructs a <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 After construction, you must call the **Create** member function.  
  
 For more information, see [Windows Sockets: Using Sockets with Archives](../vs140/windows-sockets--using-sockets-with-archives.md).  
  
##  \<a name="csocket__fromhandle">\</a>  CSocket::FromHandle  
 Returns a pointer to a <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 Contains a handle to a socket.  
  
### Return Value  
 A pointer to a <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> object, or **NULL** if there is no <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> object attached to <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>.  
  
### Remarks  
 When given a **SOCKET** handle, if a <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> object is not attached to the handle, the member function returns **NULL** and does not create a temporary object.  
  
 For more information, see [Windows Sockets: Using Sockets with Archives](../vs140/windows-sockets--using-sockets-with-archives.md).  
  
##  \<a name="csocket__isblocking">\</a>  CSocket::IsBlocking  
 Call this member function to determine if a blocking call is in progress.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the socket is blocking; otherwise 0.  
  
### Remarks  
 For more information, see [Windows Sockets: Using Sockets with Archives](../vs140/windows-sockets--using-sockets-with-archives.md).  
  
##  \<a name="csocket__onmessagepending">\</a>  CSocket::OnMessagePending  
 Override this member function to look for particular messages from Windows and respond to them in your socket.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the message was handled; otherwise 0.  
  
### Remarks  
 This is an advanced overridable.  
  
 The framework calls <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> while the socket is pumping Windows messages to give you an opportunity to deal with messages of interest to your application. For examples of how you might use <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>, see the article [Windows Sockets: Deriving from Socket Classes](../vs140/windows-sockets--deriving-from-socket-classes.md).  
  
 For more information, see [Windows Sockets: Using Sockets with Archives](../vs140/windows-sockets--using-sockets-with-archives.md).  
  
## See Also  
 [Base Class](../vs140/casyncsocket-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket](../vs140/casyncsocket-class.md)   
 [CSocketFile](../vs140/csocketfile-class.md)