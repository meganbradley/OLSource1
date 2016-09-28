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
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Prerequisites for Internet Client Classes
Some actions taken by an Internet client (reading a file, for example) have prerequisite actions (in this case, establishing an Internet connection). The following tables list the prerequisites for some client actions.  
  
### General Internet URL (FTP, Gopher, or HTTP)  
  
|Action|Prerequisite|  
|------------|------------------|  
|Establish a connection.|Create a [CInternetSession](../vs140/cinternetsession-class.md) to establish the basis of an Internet client application.|  
|Open a URL.|Establish a connection. Call [CInternetSession::OpenURL](../vs140/cinternetsession--openurl.md). The `OpenURL` function returns a read-only resource object.|  
|Read URL data.|Open the URL. Call [CInternetFile::Read](../vs140/cinternetfile--read.md).|  
|Set an Internet option.|Establish a connection. Call [CInternetSession::SetOption](../vs140/cinternetsession--setoption.md).|  
|Set a function to be called with status information.|Establish a connection. Call [CInternetSession::EnableStatusCallback](../vs140/cinternetsession--enablestatuscallback.md). Override [CInternetSession::OnStatusCallback](../vs140/cinternetsession--onstatuscallback.md) to handle calls.|  
  
### FTP  
  
|Action|Prerequisite|  
|------------|------------------|  
|Establish an FTP connection.|Create a [CInternetSession](../vs140/cinternetsession-class.md) as the basis of this Internet client application. Call [CInternetSession::GetFtpConnection](../vs140/cinternetsession--getftpconnection.md) to create a [CFtpConnection](../vs140/cftpconnection-class.md) object.|  
|Find the first resource.|Establish an FTP connection. Create a [CFtpFileFind](../vs140/cftpfilefind-class.md) object. Call [CFtpFileFind::FindFile](../vs140/cftpfilefind--findfile.md).|  
|Enumerate all available resources.|Find the first file. Call [CFtpFileFind::FindNextFile](../vs140/cftpfilefind--findnextfile.md) until it returns FALSE.|  
|Open an FTP file.|Establish an FTP connection. Call [CFtpConnection::OpenFile](../vs140/cftpconnection--openfile.md) to create and open a [CInternetFile](../vs140/cinternetfile-class.md) object.|  
|Read an FTP file.|Open an FTP file with read access. Call [CInternetFile::Read](../vs140/cinternetfile--read.md).|  
|Write to an FTP file.|Open an FTP file with write access. Call [CInternetFile::Write](../vs140/cinternetfile--write.md).|  
|Change the client's directory on the server.|Establish an FTP connection. Call [CFtpConnection::SetCurrentDirectory](../vs140/cftpconnection--setcurrentdirectory.md).|  
|Retrieve the client's current directory on the server.|Establish an FTP connection. Call [CFtpConnection::GetCurrentDirectory](../vs140/cftpconnection--getcurrentdirectory.md).|  
  
### HTTP  
  
|Action|Prerequisite|  
|------------|------------------|  
|Establish an HTTP connection.|Create a [CInternetSession](../vs140/cinternetsession-class.md) as the basis of this Internet client application. Call [CInternetSession::GetHttpConnection](../vs140/cinternetsession--gethttpconnection.md) to create a [CHttpConnection](../vs140/chttpconnection-class.md) object.|  
|Open an HTTP file.|Establish an HTTP connection. Call [CHttpConnection::OpenRequest](../vs140/chttpconnection--openrequest.md) to create a [CHttpFile](../vs140/chttpfile-class.md) object. Call [CHttpFile::AddRequestHeaders](../vs140/chttpfile--addrequestheaders.md). Call [CHttpFile::SendRequest](../vs140/chttpfile--sendrequest.md).|  
|Read an HTTP file.|Open an HTTP file. Call [CInternetFile::Read](../vs140/cinternetfile--read.md).|  
|Get information about an HTTP request.|Establish an HTTP connection. Call [CHttpConnection::OpenRequest](../vs140/chttpconnection--openrequest.md) to create a [CHttpFile](../vs140/chttpfile-class.md) object. Call [CHttpFile::QueryInfo](../vs140/chttpfile--queryinfo.md).|  
  
### Gopher  
  
|Action|Prerequisite|  
|------------|------------------|  
|Establish a gopher connection.|Create a [CInternetSession](../vs140/cinternetsession-class.md) as the basis of this Internet client application. Call [CInternetSession::GetGopherConnection](../vs140/cinternetsession--getgopherconnection.md) to create a [CGopherConnection](../vs140/cgopherconnection-class.md).|  
|Find the first file in the current directory.|Establish a gopher connection. Create a [CGopherFileFind](../vs140/cgopherfilefind-class.md) object. Call [CGopherConnection::CreateLocator](../vs140/cgopherconnection--createlocator.md) to create a [CGopherLocator](../vs140/cgopherlocator-class.md) object. Pass the locator to [CGopherFileFind::FindFile](../vs140/cgopherfilefind--findfile.md). Call [CGopherFileFind::GetLocator](../vs140/cgopherfilefind--getlocator.md) to get the locator of a file if you need it later.|  
|Enumerate all available files.|Find the first file. Call [CGopherFileFind::FindNextFile](../vs140/cgopherfilefind--findnextfile.md) until it returns FALSE.|  
|Open a gopher file.|Establish a gopher connection. Create a gopher locator with [CGopherConnection::CreateLocator](../vs140/cgopherconnection--createlocator.md) or find a locator with [CGopherFileFind::GetLocator](../vs140/cgopherfilefind--getlocator.md). Call [CGopherConnection::OpenFile](../vs140/cgopherconnection--openfile.md).|  
|Read a gopher file.|Open a gopher file. Use [CGopherFile](../vs140/cgopherfile-class.md).|  
  
## See Also  
 [Win32 Internet Extensions (WinInet)](../vs140/win32-internet-extensions--wininet-.md)   
 [MFC Classes for Creating Internet Client Applications](../vs140/mfc-classes-for-creating-internet-client-applications.md)   
 [Writing an Internet Client Application Using MFC WinInet Classes](../vs140/writing-an-internet-client-application-using-mfc-wininet-classes.md)