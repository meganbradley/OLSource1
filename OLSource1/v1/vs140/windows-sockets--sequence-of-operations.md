---
title: "Windows Sockets: Sequence of Operations"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Windows Sockets [C++], operations"
  - "Windows Sockets [C++], stream sockets"
  - "sockets [C++], stream sockets"
  - "sockets [C++], operations"
  - "stream sockets [C++]"
ms.assetid: 43ce76f5-aad3-4247-b8a6-16cc7d012796
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Windows Sockets: Sequence of Operations
This article illustrates, side by side, the sequence of operations for a server socket and a client socket. Because the sockets use <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> objects, they are necessarily [stream sockets](../vs140/windows-sockets--stream-sockets.md).  
  
## Sequence of Operations for a Stream Socket Communication  
 Up to the point of constructing a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object, the following sequence is accurate (with a few parameter differences) for both <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. From that point on, the sequence is strictly for <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The following table illustrates the sequence of operations for setting up communication between a client and a server.  
  
### Setting Up Communication Between a Server and a Client  
  
|Server|Client|  
|------------|------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>1,2|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>2|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>||  
||<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>3,4|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> 5||  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>\<br />\<br /> -or-\<br />\<br /> <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>\<br />\<br /> – or Both –|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>\<br />\<br /> -or-\<br />\<br /> <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>\<br />\<br /> – or Both –|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>\<br />\<br /> -or-\<br />\<br /> <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>6|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>\<br />\<br /> -or-\<br />\<br /> <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>6|  
  
 1. Where <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is a port number. See [Windows Sockets: Ports and Socket Addresses](../vs140/windows-sockets--ports-and-socket-addresses.md) for details about ports.  
  
 2. The server must always specify a port so clients can connect. The **Create** call sometimes also specifies an address. On the client side, use the default parameters, which ask MFC to use any available port.  
  
 3. Where <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is a port number and *strAddr* is a machine address or an Internet Protocol (IP) address.  
  
 4. Machine addresses can take several forms: "ftp.microsoft.com", "microsoft.com". IP addresses use the "dotted number" form "127.54.67.32". The **Connect** function checks to see if the address is a dotted number (although it does not check to ensure the number is a valid machine on the network). If not, **Connect** assumes a machine name of one of the other forms.  
  
 5. When you call **Accept** on the server side, you pass a reference to a new socket object. You must construct this object first, but do not call **Create** for it. Keep in mind that if this socket object goes out of scope, the connection closes. MFC connects the new object to a **SOCKET** handle. You can construct the socket on the stack, as shown, or on the heap.  
  
 6. The archive and the socket file are closed when they go out of scope. The socket object's destructor also calls the [Close](../vs140/casyncsocket--close.md) member function for the socket object when the object goes out of scope or is deleted.  
  
## Additional Notes About the Sequence  
 The sequence of calls shown in the preceding table is for a stream socket. Datagram sockets, which are connectionless, do not require the [CAsyncSocket::Connect](../vs140/casyncsocket--connect.md), [Listen](../vs140/casyncsocket--listen.md), and [Accept](../vs140/casyncsocket--accept.md) calls (although you can optionally use **Connect**). Instead, if you are using class <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, datagram sockets use the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> member functions. (If you use **Connect** with a datagram socket, you use **Send** and **Receive**.) Because <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> does not work with datagrams, do not use <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> with an archive if the socket is a datagram.  
  
 [CSocketFile](../vs140/csocketfile-class.md) does not support all of <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>'s functionality; <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> members such as <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, which make no sense for a socket communication, are unavailable. Because of this, some default MFC <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> functions are not compatible with <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>. This is particularly true of the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> class. You should not try to serialize <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> data through a <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object attached to a <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object using <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>; use **CEditView::Serialize** instead (not documented). The [SerializeRaw](../vs140/ceditview--serializeraw.md) function expects the file object to have functions, such as <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, that <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> does not support.  
  
 For more information, see:  
  
-   [Windows Sockets: Using Sockets with Archives](../vs140/windows-sockets--using-sockets-with-archives.md)  
  
-   [Windows Sockets: Using Class CAsyncSocket](../vs140/windows-sockets--using-class-casyncsocket.md)  
  
-   [Windows Sockets: Ports and Socket Addresses](../vs140/windows-sockets--ports-and-socket-addresses.md)  
  
-   [Windows Sockets: Stream Sockets](../vs140/windows-sockets--stream-sockets.md)  
  
-   [Windows Sockets: Datagram Sockets](../vs140/windows-sockets--datagram-sockets.md)  
  
## See Also  
 [Windows Sockets in MFC](../vs140/windows-sockets-in-mfc.md)   
 [CSocket Class](../vs140/csocket-class.md)   
 [CAsyncSocket::Create](../vs140/casyncsocket--create.md)   
 [CAsyncSocket::Close](../vs140/casyncsocket--close.md)