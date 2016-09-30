---
title: "CSocketFile Class"
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
  - "CSocketFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "networks [C++], archive"
  - "serialization [C++], network"
  - "networks [C++], serializing to"
  - "CSocketFile class"
  - "archives [C++], network"
  - "SOCKET handle"
ms.assetid: 7924c098-5f72-40d6-989d-42800a47958f
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSocketFile Class
A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object used for sending and receiving data across a network via Windows Sockets.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CSocketFile::CSocketFile](#csocketfile__csocketfile)|Constructs a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 You can attach the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object to a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object for this purpose. You also can, and usually do, attach the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object to a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object to simplify sending and receiving data using MFC serialization.  
  
 To serialize (send) data, you insert it into the archive, which calls <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> member functions to write data to the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object. To deserialize (receive) data, you extract from the archive. This causes the archive to call <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> member functions to read data from the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.  
  
> [!TIP]
>  Besides using <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> as described here, you can use it as a stand-alone file object, just as you can with <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, its base class. You can also use <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> with any archive-based MFC serialization functions. Because <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> does not support all of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>'s functionality, some default MFC serialize functions are not compatible with <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. This is particularly true of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> class. You should not try to serialize <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> data through a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object attached to a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object using <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>; use **CEditView::Serialize** instead. The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> function expects the file object to have functions, such as <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, that <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> does not have.  
  
 When you use <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, you might encounter a situation where **CSocket::Receive** enters a loop (by **PumpMessages(FD_READ)**) waiting for the requested amount of bytes. This is because Windows sockets allow only one recv call per FD_READ notification, but <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> allow multiple recv calls per FD_READ. If you get an FD_READ when there is no data to read, the application hangs. If you never get another FD_READ, the application stops communicating over the socket.  
  
 You can resolve this problem as follows. In the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> method of your socket class, call **CAsyncSocket::IOCtl(FIONREAD, ...)** before you call the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> method of your message class when the expected data to be read from the socket exceeds the size of one TCP packet (maximum transmission unit of the network medium, usually at least 1096 bytes). If the size of the available data is less than needed, wait for all the data to be received and only then start the read operation.  
  
 In the following example, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is the approximate number of bytes that the user expects to receive. It is assumed that you declare it elsewhere in your code.  
  
 [!code[NVC_MFCSocketThread#4](../vs140/codesnippet/CPP/csocketfile-class_1.cpp)]  
  
 For more information, see [Windows Sockets in MFC](../vs140/windows-sockets-in-mfc.md), [Windows Sockets: Using Sockets with Archives](../vs140/windows-sockets--using-sockets-with-archives.md), as well as                 [Windows Sockets 2 API](http://msdn.microsoft.com/library/windows/desktop/ms740673).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CFile](../vs140/cfile-class.md)  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxsock.h  
  
##  \<a name="csocketfile__csocketfile">\</a>  CSocketFile::CSocketFile  
 Constructs a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The socket to attach to the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Specifies whether the file object is for use with a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object. Pass **FALSE** only if you want to use the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object in a stand-alone manner as you would a stand-alone <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object, with certain limitations. This flag changes how the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object attached to the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object manages its buffer for reading.  
  
### Remarks  
 The object's destructor disassociates itself from the socket object when the object goes out of scope or is deleted.  
  
> [!NOTE]
>  A <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> can also be used as a (limited) file without a <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object. By default, the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> constructor's <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> parameter is **TRUE**. This specifies that the file object is for use with an archive. To use the file object without an archive, pass **FALSE** in the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> parameter.  
  
 In its "archive compatible" mode, a <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object provides better performance and reduces the danger of a "deadlock." A deadlock occurs when both the sending and receiving sockets are waiting on each other, or for a common resource. This situation might occur if the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object worked with the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> the way it does with a <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object. With <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, the archive can assume that if it receives fewer bytes than it requested, the end of file has been reached.  
  
 With <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, however, data is message based; the buffer can contain multiple messages, so receiving fewer than the number of bytes requested does not imply end of file. The application does not block in this case as it might with <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, and it can continue reading messages from the buffer until the buffer is empty. The [CArchive::IsBufferEmpty](../vs140/carchive-class.md#carchive__isbufferempty) function is useful for monitoring the state of the archive's buffer in such a case.  
  
 For more information on the use of <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, see the articles [Windows Sockets: Using Sockets with Archives](../vs140/windows-sockets--using-sockets-with-archives.md) and [Windows Sockets: Example of Sockets Using Archives](../vs140/windows-sockets--example-of-sockets-using-archives.md).  
  
## See Also  
 [Base Class](../vs140/cfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncSocket](../vs140/casyncsocket-class.md)   
 [CSocket](../vs140/csocket-class.md)