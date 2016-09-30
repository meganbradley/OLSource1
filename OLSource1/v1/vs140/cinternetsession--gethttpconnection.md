---
title: "CInternetSession::GetHttpConnection"
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
  - "GetHttpConnection"
  - "CInternetSession::GetHttpConnection"
  - "CInternetSession.GetHttpConnection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Internet protocols, HTTP"
  - "HTTP connections"
  - "GetHttpConnection method"
  - "CInternetSession class, attributes"
  - "Internet connections, HTTP"
  - "HTTP protocol"
  - "connections [C++], HTTP"
ms.assetid: b54a4477-315e-42bc-af49-1bcbd412e0a5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInternetSession::GetHttpConnection
Call this member function to establish an HTTP connection and get a pointer to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a string containing the HTTP server name.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A number that identifies the TCP/IP port to use on the server.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to a string containing the user name.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to a string containing the access password.  
  
 *dwflags*  
 Any combination of the **INTERNET_ FLAG_\*** flags. See the table in the **Remarks** section of [CHttpConnection::OpenRequest](../vs140/chttpconnection--openrequest.md) for a description of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> values.  
  
## Return Value  
 A pointer to a [CHttpConnection](../vs140/chttpconnection-class.md) object. If the call fails, determine the cause of the failure by examining the thrown [CInternetException](../vs140/cinternetexception-class.md) object.  
  
## Remarks  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> connects to an HTTP server, and creates and returns a pointer to a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object. It does not perform any specific operation on the server. If you intend to query an HTTP header, for example, you must perform this operation as a separate step. See the classes [CHttpConnection](../vs140/chttpconnection-class.md) and [CHttpFile](../vs140/chttpfile-class.md) for information about operations you can perform by using a connection to an HTTP server. For information about browsing an HTTP site, see the member function [OpenURL](../vs140/cinternetsession--openurl.md). See the article [Internet Programming with WinInet](../vs140/win32-internet-extensions--wininet-.md) for steps in performing common HTTP connection tasks.  
  
## Exceptions  
 This method can throw exceptions of type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CInternetSession Class](../vs140/cinternetsession-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHttpConnection Class](../vs140/chttpconnection-class.md)   
 [CInternetSession::GetGopherConnection](../vs140/cinternetsession--getgopherconnection.md)   
 [CInternetSession::GetFtpConnection](../vs140/cinternetsession--getftpconnection.md)   
 [CInternetSession::OpenURL](../vs140/cinternetsession--openurl.md)