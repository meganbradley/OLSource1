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
MFC provides the following classes and global functions for writing Internet client applications. Indentation indicates a class is derived from the unindented class above it. <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> derive from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, for example. These classes and global functions are declared in AFXINET.H, except <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, which is declared in AFX.H.  
  
## Classes  
  
-   [CInternetSession](../vs140/cinternetsession-class.md)  
  
-   [CInternetConnection](../vs140/cinternetconnection-class.md)  
  
    -   [CFtpConnection](../vs140/cftpconnection-class.md)  
  
    -   [CGopherConnection](../vs140/cgopherconnection-class.md)  
  
    -   [CHttpConnection](../vs140/chttpconnection-class.md)  
  
-   [CInternetFile](../vs140/cinternetfile-class.md)  
  
    -   [CGopherFile](../vs140/cgopherfile-class.md)  
  
    -   [CHttpFile](../vs140/chttpfile-class.md)  
  
-   [CFileFind](../vs140/cfilefind-class.md)  
  
    -   [CFtpFileFind](../vs140/cftpfilefind-class.md)  
  
    -   [CGopherFileFind](../vs140/cgopherfilefind-class.md)  
  
-   [CGopherLocator](../vs140/cgopherlocator-class.md)  
  
-   [CInternetException](../vs140/cinternetexception-class.md)  
  
## Global Functions  
  
-   [AfxParseURL](../vs140/afxparseurl.md)  
  
-   [AfxGetInternetHandleType](../vs140/afxgetinternethandletype.md)  
  
-   [AfxThrowInternetException](../vs140/afxthrowinternetexception.md)  
  
## See Also  
 [Win32 Internet Extensions (WinInet)](../vs140/win32-internet-extensions--wininet-.md)   
 [Prerequisites for Internet Client Classes](../vs140/prerequisites-for-internet-client-classes.md)   
 [Writing an Internet Client Application Using MFC WinInet Classes](../vs140/writing-an-internet-client-application-using-mfc-wininet-classes.md)