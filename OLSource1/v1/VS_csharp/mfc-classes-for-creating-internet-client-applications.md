---
title: "MFC Classes for Creating Internet Client Applications"
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
  - "MFC, WinInet classes"
  - "WinInet classes, classes"
  - "classes [C++], MFC"
  - "Internet client applications, MFC"
  - "Internet applications, MFC"
ms.assetid: 67d34117-9839-4f4b-8bb8-0e4a9471c606
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MFC Classes for Creating Internet Client Applications
MFC provides the following classes and global functions for writing Internet client applications. Indentation indicates a class is derived from the unindented class above it. `CGopherFile` and `CHttpFile` derive from `CInternetFile`, for example. These classes and global functions are declared in AFXINET.H, except `CFileFind`, which is declared in AFX.H.  
  
## Classes  
  
-   [CInternetSession](../VS_csharp/cinternetsession-class.md)  
  
-   [CInternetConnection](../VS_csharp/cinternetconnection-class.md)  
  
    -   [CFtpConnection](../VS_csharp/cftpconnection-class.md)  
  
    -   [CGopherConnection](../VS_csharp/cgopherconnection-class.md)  
  
    -   [CHttpConnection](../VS_csharp/chttpconnection-class.md)  
  
-   [CInternetFile](../VS_csharp/cinternetfile-class.md)  
  
    -   [CGopherFile](../VS_csharp/cgopherfile-class.md)  
  
    -   [CHttpFile](../VS_csharp/chttpfile-class.md)  
  
-   [CFileFind](../VS_csharp/cfilefind-class.md)  
  
    -   [CFtpFileFind](../VS_csharp/cftpfilefind-class.md)  
  
    -   [CGopherFileFind](../VS_csharp/cgopherfilefind-class.md)  
  
-   [CGopherLocator](../VS_csharp/cgopherlocator-class.md)  
  
-   [CInternetException](../VS_csharp/cinternetexception-class.md)  
  
## Global Functions  
  
-   [AfxParseURL](../VS_csharp/afxparseurl.md)  
  
-   [AfxGetInternetHandleType](../VS_csharp/afxgetinternethandletype.md)  
  
-   [AfxThrowInternetException](../VS_csharp/afxthrowinternetexception.md)  
  
## See Also  
 [Win32 Internet Extensions (WinInet)](../VS_csharp/win32-internet-extensions--wininet-.md)   
 [Prerequisites for Internet Client Classes](../VS_csharp/prerequisites-for-internet-client-classes.md)   
 [Writing an Internet Client Application Using MFC WinInet Classes](../VS_csharp/writing-an-internet-client-application-using-mfc-wininet-classes.md)