---
title: "CInternetSession::GetGopherConnection"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CInternetSession::GetGopherConnection
  - CInternetSession.GetGopherConnection
  - GetGopherConnection
dev_langs: 
  - C++
helpviewer_keywords: 
  - connections [C++], gopher
  - Internet protocols, gopher
  - gopher protocol connections
  - GetGopherConnection method
  - CInternetSession class, attributes
  - Internet connections, gopher
ms.assetid: e16cdf2b-c8d5-434f-b252-0e3f50e7e775
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CInternetSession::GetGopherConnection
Call this member function to establish a new gopher connection and get a pointer to a `CGopherConnection` object.  
  
## Syntax  
  
```  
  
      CGopherConnection* GetGopherConnection(  
   LPCTSTR pstrServer,  
   LPCTSTR pstrUserName = NULL,  
   LPCTSTR pstrPassword = NULL,  
   INTERNET_PORT nPort = INTERNET_INVALID_PORT_NUMBER   
);  
```  
  
#### Parameters  
 `pstrServer`  
 A pointer to a string containing the gopher server name.  
  
 `pstrUserName`  
 A pointer to a string containing the user name.  
  
 `pstrPassword`  
 A pointer to a string containing the access password.  
  
 `nPort`  
 A number that identifies the TCP/IP port to use on the server.  
  
## Return Value  
 A pointer to a [CGopherConnection](../vs140/cgopherconnection-class.md) object. If the call fails, determine the cause of the failure by examining the thrown [CInternetException](../vs140/cinternetexception-class.md) object.  
  
## Remarks  
 `GetGopherConnection` connects to a gopher server, and creates and returns a pointer to a `CGopherConnection` object. It does not perform any specific operation on the server. If you intend to read or write data, for example, you must perform those operations as separate steps. See the classes [CGopherConnection](../vs140/cgopherconnection-class.md), [CGopherFile](../vs140/cgopherfile-class.md), and [CGopherFileFind](../vs140/cgopherfilefind-class.md) for information about searching for files, opening files, and reading or writing to files. For information about browsing an FTP site, see the member function [OpenURL](../vs140/cinternetsession--openurl.md). See the article [Internet Programming with WinInet](../vs140/win32-internet-extensions--wininet-.md) for steps in performing common gopher connection tasks.  
  
## Exceptions  
 This method can throw exceptions of type `CInternetException*`.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CInternetSession Class](../vs140/cinternetsession-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CGopherConnection Class](../vs140/cgopherconnection-class.md)   
 [CInternetSession::GetFtpConnection](../vs140/cinternetsession--getftpconnection.md)   
 [CInternetSession::GetHttpConnection](../vs140/cinternetsession--gethttpconnection.md)   
 [CInternetSession::OpenURL](../vs140/cinternetsession--openurl.md)