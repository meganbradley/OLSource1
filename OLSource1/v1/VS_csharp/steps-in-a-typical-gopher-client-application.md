---
title: "Steps in a Typical Gopher Client Application"
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
  - "WinInet classes, gopher"
  - "Internet applications, gopher client applications"
  - "Gopher client applications"
  - "Internet client applications, gopher table"
ms.assetid: 3e4e1869-5da0-453d-8ba9-b648c894bb90
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Steps in a Typical Gopher Client Application
The following table shows the steps you might perform in a typical gopher client application.  
  
|Your goal|Actions you take|Effects|  
|---------------|----------------------|-------------|  
|Begin a gopher session.|Create a [CInternetSession](../VS_csharp/cinternetsession-class.md) object.|Initializes WinInet and connects to server.|  
|Connect to a gopher server.|Use [CInternetSession::GetGopherConnection](../Topic/CInternetSession::GetGopherConnection.md).|Returns a [CGopherConnection](../VS_csharp/cgopherconnection-class.md) object.|  
|Find the first resource in the gopher.|Use [CGopherFileFind::FindFile](../Topic/CGopherFileFind::FindFile.md).|Finds the first file. Returns FALSE if no files are found.|  
|Find the next resource in the gopher.|Use [CGopherFileFind::FindNextFile](../Topic/CGopherFileFind::FindNextFile.md).|Finds the next file. Returns FALSE if the file is not found.|  
|Open the file found by **FindFile** or `FindNextFile` for reading.|Get a gopher locator using [CGopherFileFind::GetLocator](../Topic/CGopherFileFind::GetLocator.md). Use [CGopherConnection::OpenFile](../Topic/CGopherConnection::OpenFile.md).|Opens the file specified by the locator. `OpenFile` returns a [CGopherFile](../VS_csharp/cgopherfile-class.md) object.|  
|Open a file using a gopher locator you supply.|Create a gopher locator using [CGopherConnection::CreateLocator](../Topic/CGopherConnection::CreateLocator.md). Use [CGopherConnection::OpenFile](../Topic/CGopherConnection::OpenFile.md).|Opens the file specified by the locator. `OpenFile` returns a [CGopherFile](../VS_csharp/cgopherfile-class.md) object.|  
|Read from the file.|Use [CGopherFile](../VS_csharp/cgopherfile-class.md).|Reads the specified number of bytes, using a buffer you supply.|  
|Handle exceptions.|Use the [CInternetException](../VS_csharp/cinternetexception-class.md) class.|Handles all common Internet exception types.|  
|End the gopher session.|Dispose of the [CInternetSession](../VS_csharp/cinternetsession-class.md) object.|Automatically cleans up open file handles and connections.|  
  
## See Also  
 [Win32 Internet Extensions (WinInet)](../VS_csharp/win32-internet-extensions--wininet-.md)   
 [Prerequisites for Internet Client Classes](../VS_csharp/prerequisites-for-internet-client-classes.md)   
 [Writing an Internet Client Application Using MFC WinInet Classes](../VS_csharp/writing-an-internet-client-application-using-mfc-wininet-classes.md)