---
title: "Steps in a Typical HTTP Client Application"
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
  - "HTTP client applications"
  - "client applications [C++], HTTP"
  - "Internet applications [C++], HTTP client applications"
  - "applications [MFC], HTTP client"
  - "Internet client applications [C++], HTTP table"
  - "WinInet classes, HTTP"
ms.assetid: f86552e8-8acd-4b23-bdc5-0c3a247ebd74
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Steps in a Typical HTTP Client Application
The following table shows the steps you might perform in a typical HTTP client application:  
  
|Your goal|Actions you take|Effects|  
|---------------|----------------------|-------------|  
|Begin an HTTP session.|Create a [CInternetSession](../VS_csharp/cinternetsession-class.md) object.|Initializes WinInet and connects to server.|  
|Connect to an HTTP server.|Use [CInternetSession::GetHttpConnection](../Topic/CInternetSession::GetHttpConnection.md).|Returns a [CHttpConnection](../VS_csharp/chttpconnection-class.md) object.|  
|Open an HTTP request.|Use [CHttpConnection::OpenRequest](../Topic/CHttpConnection::OpenRequest.md).|Returns a [CHttpFile](../VS_csharp/chttpfile-class.md) object.|  
|Send an HTTP request.|Use [CHttpFile::AddRequestHeaders](../Topic/CHttpFile::AddRequestHeaders.md) and [CHttpFile::SendRequest](../Topic/CHttpFile::SendRequest.md).|Finds the file. Returns FALSE if the file is not found.|  
|Read from the file.|Use [CHttpFile](../VS_csharp/chttpfile-class.md).|Reads the specified number of bytes using a buffer you supply.|  
|Handle exceptions.|Use the [CInternetException](../VS_csharp/cinternetexception-class.md) class.|Handles all common Internet exception types.|  
|End the HTTP session.|Dispose of the [CInternetSession](../VS_csharp/cinternetsession-class.md) object.|Automatically cleans up open file handles and connections.|  
  
## See Also  
 [Win32 Internet Extensions (WinInet)](../VS_csharp/win32-internet-extensions--wininet-.md)   
 [Prerequisites for Internet Client Classes](../VS_csharp/prerequisites-for-internet-client-classes.md)   
 [Writing an Internet Client Application Using MFC WinInet Classes](../VS_csharp/writing-an-internet-client-application-using-mfc-wininet-classes.md)