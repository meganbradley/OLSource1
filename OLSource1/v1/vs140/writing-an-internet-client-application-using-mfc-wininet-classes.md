---
title: "Writing an Internet Client Application Using MFC WinInet Classes"
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
  - "Internet client applications"
  - "WinInet classes, programming"
  - "Internet client applications, writing"
  - "Internet applications, WinInet"
  - "Internet applications, client applications"
  - "MFC, Internet applications"
ms.assetid: a2c4a40c-a94e-4b3e-9dbf-f8a8dc8e5428
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Writing an Internet Client Application Using MFC WinInet Classes
The basis of every Internet client application is the Internet session. MFC implements Internet sessions as objects of class [CInternetSession](../vs140/cinternetsession-class.md). Using this class, you can create one Internet session or several simultaneous sessions.  
  
 To communicate with a server, you need a [CInternetConnection](../vs140/cinternetconnection-class.md) object as well as a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>. You can create a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> by using [CInternetSession::GetFtpConnection](../vs140/cinternetsession--getftpconnection.md), [CInternetSession::GetHttpConnection](../vs140/cinternetsession--gethttpconnection.md), or [CInternetSession::GetGopherConnection](../vs140/cinternetsession--getgopherconnection.md). Each of these calls is specific to the protocol type. These calls do not open a file on the server for reading or writing. If you intend to read or write data, you must open the file as a separate step.  
  
 For most Internet sessions, the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object works hand-in-hand with a [CInternetFile](../vs140/cinternetfile-class.md) object:  
  
-   For an Internet session, you must create an instance of [CInternetSession](../vs140/cinternetsession-class.md).  
  
-   If your Internet session reads or writes data, you must create an instance of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> (or its subclasses, [CHttpFile](../vs140/chttpfile-class.md) or [CGopherFile](../vs140/cgopherfile-class.md)). The easiest way to read data is to call [CInternetSession::OpenURL](../vs140/cinternetsession--openurl.md). This function parses a Universal Resource Locator (URL) supplied by you, opens a connection to the server specified by the URL, and returns a read-only <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is not specific to one protocol type — the same call works for any FTP, HTTP, or gopher URL. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> even works with local files (returning a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> instead of a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>).  
  
-   If your Internet session does not read or write data, but performs other tasks, such as deleting a file in an FTP directory, you may not need to create an instance of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 There are two ways to create a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object:  
  
-   If you use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to establish your server connection, the call to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> returns a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
-   If use **CInternetSession::GetFtpConnection**, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to establish your server connection, you must call <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, or **CHttpConnection::OpenRequest,** respectively, to return a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, respectively.  
  
 The steps in implementing an Internet client application vary depending on whether you create a generic Internet client based on **OpenURL** or a protocol-specific client using one of the **GetConnection** functions.  
  
## What do you want to know more about?  
  
-   [How do I write an Internet client application that works generically with FTP, HTTP, and gopher?](../vs140/steps-in-a-typical-internet-client-application.md)  
  
-   [How do I write an FTP client application that opens a file?](../vs140/steps-in-a-typical-ftp-client-application.md)  
  
-   [How do I write an FTP client application that does not open a file but performs a directory operation, such as deleting a file?](../vs140/steps-in-a-typical-ftp-client-application-to-delete-a-file.md)  
  
-   [How do I write a gopher client application?](../vs140/steps-in-a-typical-gopher-client-application.md)  
  
-   [How do I write an HTTP client application?](../vs140/steps-in-a-typical-http-client-application.md)  
  
## See Also  
 [Win32 Internet Extensions (WinInet)](../vs140/win32-internet-extensions--wininet-.md)   
 [MFC Classes for Creating Internet Client Applications](../vs140/mfc-classes-for-creating-internet-client-applications.md)   
 [Prerequisites for Internet Client Classes](../vs140/prerequisites-for-internet-client-classes.md)