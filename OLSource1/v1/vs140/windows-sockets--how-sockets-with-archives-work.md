---
title: "Windows Sockets: How Sockets with Archives Work"
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
  - "Windows Sockets [C++], synchronous"
  - "sockets [C++], synchronous operation"
  - "sockets [C++], with archives"
  - "synchronous state socket"
  - "Windows Sockets [C++], with archives"
  - "two-state socket object"
ms.assetid: d8ae4039-391d-44f0-a19b-558817affcbb
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Windows Sockets: How Sockets with Archives Work
This article explains how a [CSocket](../vs140/csocket-class.md) object, a [CSocketFile](../vs140/csocketfile-class.md) object, and a [CArchive](../vs140/carchive-class.md) object are combined to simplify sending and receiving data through a Windows Socket.  
  
 The article [Windows Sockets: Example of Sockets Using Archives](../vs140/windows-sockets--example-of-sockets-using-archives.md) presents the **PacketSerialize** function. The archive object in the **PacketSerialize** example works much like an archive object passed to an MFC [Serialize](../vs140/cobject--serialize.md) function. The essential difference is that for sockets, the archive is attached not to a standard [CFile](../vs140/cfile-class.md) object (typically associated with a disk file) but to a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> object. Rather than connecting to a disk file, the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object connects to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object manages a buffer. When the buffer of a storing (sending) archive is full, an associated <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object writes out the buffer's contents. Flushing the buffer of an archive attached to a socket is equivalent to sending a message. When the buffer of a loading (receiving) archive is full, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object stops reading until the buffer is available again.  
  
 Class <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> derives from <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, but it does not support [CFile](../vs140/cfile-class.md) member functions such as the positioning functions (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, and so on), the locking functions (<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>), or the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function. All the [CSocketFile](../vs140/csocketfile-class.md) object must do is write or read sequences of bytes to or from the associated <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object. Because a file is not involved, operations such as <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> make no sense. <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is derived from <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, so it would normally inherit all of these member functions. To prevent this, the unsupported <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> member functions are overridden in <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to throw a [CNotSupportedException](../vs140/cnotsupportedexception-class.md).  
  
 The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object calls member functions of its <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object to send or receive data.  
  
 The following figure shows the relationships among these objects on both sides of the communication.  
  
 ![CArchive, CSocketFile, and CSocket](../vs140/media/vc38ia1.gif "vc38IA1")  
CArchive, CSocketFile, and CSocket  
  
 The purpose of this apparent complexity is to shield you from the necessity of managing the details of the socket yourself. You create the socket, the file, and the archive, and then begin sending or receiving data by inserting it to the archive or extracting it from the archive. [CArchive](../vs140/carchive-class.md), [CSocketFile](../vs140/csocketfile-class.md), and [CSocket](../vs140/csocket-class.md) manage the details behind the scenes.  
  
 A <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object is actually a two-state object: sometimes asynchronous (the usual state) and sometimes synchronous. In its asynchronous state, a socket can receive asynchronous notifications from the framework. However, during an operation such as receiving or sending data the socket becomes synchronous. This means the socket will receive no further asynchronous notifications until the synchronous operation has completed. Because it switches modes, you can, for example, do something like the following:  
  
 [!code[NVC_MFCSimpleSocket#2](../vs140/codesnippet/CPP/windows-sockets--how-sockets-with-archives-work_1.cpp)]  
  
 If <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> were not implemented as a two-state object, it might be possible to receive additional notifications for the same kind of event while you were processing a previous notification. For example, you might get an <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> notification while processing an <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. In the code fragment above, extracting <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> from the archive might lead to recursion. By switching states, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> prevents recursion by preventing additional notifications. The general rule is no notifications within notifications.  
  
> [!NOTE]
>  A <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> can also be used as a (limited) file without a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object. By default, the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> constructor's <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> parameter is **TRUE**. This specifies that the file object is for use with an archive. To use the file object without an archive, pass **FALSE** in the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> parameter.  
  
 In its "archive compatible" mode, a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object provides better performance and reduces the danger of a "deadlock." A deadlock occurs when both the sending and receiving sockets are waiting on each other, or waiting for a common resource. This situation might occur if the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object worked with the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> the way it does with a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object. With <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, the archive can assume that if it receives fewer bytes than it requested, the end of file has been reached. With <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, however, data is message based; the buffer can contain multiple messages, so receiving fewer than the number of bytes requested does not imply end of file. The application does not block in this case as it might with <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, and it can continue reading messages from the buffer until the buffer is empty. The [IsBufferEmpty](../vs140/carchive--isbufferempty.md) function in <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is useful for monitoring the state of the archive's buffer in such a case.  
  
 For more information, see [Windows Sockets: Using Sockets with Archives](../vs140/windows-sockets--using-sockets-with-archives.md)  
  
## See Also  
 [Windows Sockets in MFC](../vs140/windows-sockets-in-mfc.md)   
 [CObject::Serialize](../vs140/cobject--serialize.md)