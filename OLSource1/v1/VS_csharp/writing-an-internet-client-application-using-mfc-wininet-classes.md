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
The basis of every Internet client application is the Internet session. MFC implements Internet sessions as objects of class [CInternetSession](../VS_csharp/cinternetsession-class.md). Using this class, you can create one Internet session or several simultaneous sessions.  
  
 To communicate with a server, you need a [CInternetConnection](../VS_csharp/cinternetconnection-class.md) object as well as a `CInternetSession`. You can create a `CInternetConnection` by using [CInternetSession::GetFtpConnection](../Topic/CInternetSession::GetFtpConnection.md), [CInternetSession::GetHttpConnection](../Topic/CInternetSession::GetHttpConnection.md), or [CInternetSession::GetGopherConnection](../Topic/CInternetSession::GetGopherConnection.md). Each of these calls is specific to the protocol type. These calls do not open a file on the server for reading or writing. If you intend to read or write data, you must open the file as a separate step.  
  
 For most Internet sessions, the `CInternetSession` object works hand-in-hand with a [CInternetFile](../VS_csharp/cinternetfile-class.md) object:  
  
-   For an Internet session, you must create an instance of [CInternetSession](../VS_csharp/cinternetsession-class.md).  
  
-   If your Internet session reads or writes data, you must create an instance of `CInternetFile` (or its subclasses, [CHttpFile](../VS_csharp/chttpfile-class.md) or [CGopherFile](../VS_csharp/cgopherfile-class.md)). The easiest way to read data is to call [CInternetSession::OpenURL](../Topic/CInternetSession::OpenURL.md). This function parses a Universal Resource Locator (URL) supplied by you, opens a connection to the server specified by the URL, and returns a read-only `CInternetFile` object. `CInternetSession::OpenURL` is not specific to one protocol type — the same call works for any FTP, HTTP, or gopher URL. `CInternetSession::OpenURL` even works with local files (returning a `CStdioFile` instead of a `CInternetFile`).  
  
-   If your Internet session does not read or write data, but performs other tasks, such as deleting a file in an FTP directory, you may not need to create an instance of `CInternetFile`.  
  
 There are two ways to create a `CInternetFile` object:  
  
-   If you use `CInternetSession::OpenURL` to establish your server connection, the call to `OpenURL` returns a `CStdioFile`.  
  
-   If use **CInternetSession::GetFtpConnection**, `GetGopherConnection`, or `GetHttpConnection` to establish your server connection, you must call `CFtpConnection::OpenFile`, `CGopherConnection::OpenFile`, or **CHttpConnection::OpenRequest,** respectively, to return a `CInternetFile`, `CGopherFile`, or `CHttpFile`, respectively.  
  
 The steps in implementing an Internet client application vary depending on whether you create a generic Internet client based on **OpenURL** or a protocol-specific client using one of the **GetConnection** functions.  
  
## What do you want to know more about?  
  
-   [How do I write an Internet client application that works generically with FTP, HTTP, and gopher?](../VS_csharp/steps-in-a-typical-internet-client-application.md)  
  
-   [How do I write an FTP client application that opens a file?](../VS_csharp/steps-in-a-typical-ftp-client-application.md)  
  
-   [How do I write an FTP client application that does not open a file but performs a directory operation, such as deleting a file?](../VS_csharp/steps-in-a-typical-ftp-client-application-to-delete-a-file.md)  
  
-   [How do I write a gopher client application?](../VS_csharp/steps-in-a-typical-gopher-client-application.md)  
  
-   [How do I write an HTTP client application?](../VS_csharp/steps-in-a-typical-http-client-application.md)  
  
## See Also  
 [Win32 Internet Extensions (WinInet)](../VS_csharp/win32-internet-extensions--wininet-.md)   
 [MFC Classes for Creating Internet Client Applications](../VS_csharp/mfc-classes-for-creating-internet-client-applications.md)   
 [Prerequisites for Internet Client Classes](../VS_csharp/prerequisites-for-internet-client-classes.md)