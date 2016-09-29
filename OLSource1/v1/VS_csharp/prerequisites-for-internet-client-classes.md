---
title: "Prerequisites for Internet Client Classes"
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
  - "Internet files [C++], writing to"
  - "Internet [C++], connections"
  - "FTP (File Transfer Protocol), MFC classes"
  - "Gopher prerequisites"
  - "files [C++], writing to"
  - "classes [C++], connections"
  - "HTTP, prerequisites for Internet clients"
  - "connections [C++], classes for"
  - "Internet client class prerequisites [C++]"
  - "files [C++], reading"
  - "URLs [C++], Internet client applications"
  - "prerequisites, Internet client classes"
  - "Gopher client applications"
ms.assetid: c51d1dfe-260c-4228-8100-e4efd90e9599
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Prerequisites for Internet Client Classes
Some actions taken by an Internet client (reading a file, for example) have prerequisite actions (in this case, establishing an Internet connection). The following tables list the prerequisites for some client actions.  
  
### General Internet URL (FTP, Gopher, or HTTP)  
  
|Action|Prerequisite|  
|------------|------------------|  
|Establish a connection.|Create a [CInternetSession](../VS_csharp/cinternetsession-class.md) to establish the basis of an Internet client application.|  
|Open a URL.|Establish a connection. Call [CInternetSession::OpenURL](../Topic/CInternetSession::OpenURL.md). The `OpenURL` function returns a read-only resource object.|  
|Read URL data.|Open the URL. Call [CInternetFile::Read](../Topic/CInternetFile::Read.md).|  
|Set an Internet option.|Establish a connection. Call [CInternetSession::SetOption](../Topic/CInternetSession::SetOption.md).|  
|Set a function to be called with status information.|Establish a connection. Call [CInternetSession::EnableStatusCallback](../Topic/CInternetSession::EnableStatusCallback.md). Override [CInternetSession::OnStatusCallback](../Topic/CInternetSession::OnStatusCallback.md) to handle calls.|  
  
### FTP  
  
|Action|Prerequisite|  
|------------|------------------|  
|Establish an FTP connection.|Create a [CInternetSession](../VS_csharp/cinternetsession-class.md) as the basis of this Internet client application. Call [CInternetSession::GetFtpConnection](../Topic/CInternetSession::GetFtpConnection.md) to create a [CFtpConnection](../VS_csharp/cftpconnection-class.md) object.|  
|Find the first resource.|Establish an FTP connection. Create a [CFtpFileFind](../VS_csharp/cftpfilefind-class.md) object. Call [CFtpFileFind::FindFile](../Topic/CFtpFileFind::FindFile.md).|  
|Enumerate all available resources.|Find the first file. Call [CFtpFileFind::FindNextFile](../Topic/CFtpFileFind::FindNextFile.md) until it returns FALSE.|  
|Open an FTP file.|Establish an FTP connection. Call [CFtpConnection::OpenFile](../Topic/CFtpConnection::OpenFile.md) to create and open a [CInternetFile](../VS_csharp/cinternetfile-class.md) object.|  
|Read an FTP file.|Open an FTP file with read access. Call [CInternetFile::Read](../Topic/CInternetFile::Read.md).|  
|Write to an FTP file.|Open an FTP file with write access. Call [CInternetFile::Write](../Topic/CInternetFile::Write.md).|  
|Change the client's directory on the server.|Establish an FTP connection. Call [CFtpConnection::SetCurrentDirectory](../Topic/CFtpConnection::SetCurrentDirectory.md).|  
|Retrieve the client's current directory on the server.|Establish an FTP connection. Call [CFtpConnection::GetCurrentDirectory](../Topic/CFtpConnection::GetCurrentDirectory.md).|  
  
### HTTP  
  
|Action|Prerequisite|  
|------------|------------------|  
|Establish an HTTP connection.|Create a [CInternetSession](../VS_csharp/cinternetsession-class.md) as the basis of this Internet client application. Call [CInternetSession::GetHttpConnection](../Topic/CInternetSession::GetHttpConnection.md) to create a [CHttpConnection](../VS_csharp/chttpconnection-class.md) object.|  
|Open an HTTP file.|Establish an HTTP connection. Call [CHttpConnection::OpenRequest](../Topic/CHttpConnection::OpenRequest.md) to create a [CHttpFile](../VS_csharp/chttpfile-class.md) object. Call [CHttpFile::AddRequestHeaders](../Topic/CHttpFile::AddRequestHeaders.md). Call [CHttpFile::SendRequest](../Topic/CHttpFile::SendRequest.md).|  
|Read an HTTP file.|Open an HTTP file. Call [CInternetFile::Read](../Topic/CInternetFile::Read.md).|  
|Get information about an HTTP request.|Establish an HTTP connection. Call [CHttpConnection::OpenRequest](../Topic/CHttpConnection::OpenRequest.md) to create a [CHttpFile](../VS_csharp/chttpfile-class.md) object. Call [CHttpFile::QueryInfo](../Topic/CHttpFile::QueryInfo.md).|  
  
### Gopher  
  
|Action|Prerequisite|  
|------------|------------------|  
|Establish a gopher connection.|Create a [CInternetSession](../VS_csharp/cinternetsession-class.md) as the basis of this Internet client application. Call [CInternetSession::GetGopherConnection](../Topic/CInternetSession::GetGopherConnection.md) to create a [CGopherConnection](../VS_csharp/cgopherconnection-class.md).|  
|Find the first file in the current directory.|Establish a gopher connection. Create a [CGopherFileFind](../VS_csharp/cgopherfilefind-class.md) object. Call [CGopherConnection::CreateLocator](../Topic/CGopherConnection::CreateLocator.md) to create a [CGopherLocator](../VS_csharp/cgopherlocator-class.md) object. Pass the locator to [CGopherFileFind::FindFile](../Topic/CGopherFileFind::FindFile.md). Call [CGopherFileFind::GetLocator](../Topic/CGopherFileFind::GetLocator.md) to get the locator of a file if you need it later.|  
|Enumerate all available files.|Find the first file. Call [CGopherFileFind::FindNextFile](../Topic/CGopherFileFind::FindNextFile.md) until it returns FALSE.|  
|Open a gopher file.|Establish a gopher connection. Create a gopher locator with [CGopherConnection::CreateLocator](../Topic/CGopherConnection::CreateLocator.md) or find a locator with [CGopherFileFind::GetLocator](../Topic/CGopherFileFind::GetLocator.md). Call [CGopherConnection::OpenFile](../Topic/CGopherConnection::OpenFile.md).|  
|Read a gopher file.|Open a gopher file. Use [CGopherFile](../VS_csharp/cgopherfile-class.md).|  
  
## See Also  
 [Win32 Internet Extensions (WinInet)](../VS_csharp/win32-internet-extensions--wininet-.md)   
 [MFC Classes for Creating Internet Client Applications](../VS_csharp/mfc-classes-for-creating-internet-client-applications.md)   
 [Writing an Internet Client Application Using MFC WinInet Classes](../VS_csharp/writing-an-internet-client-application-using-mfc-wininet-classes.md)