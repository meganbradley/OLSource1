---
title: "Steps in a Typical Internet Client Application"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - Internet client applications, general table
  - WinInet classes, programming
  - Internet applications, client applications
ms.assetid: 7aba135c-7c15-4e2f-8c34-bbaf792c89a6
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Steps in a Typical Internet Client Application
The following table shows the steps you might perform in a typical Internet client application.  
  
|Your goal|Actions you take|Effects|  
|---------------|----------------------|-------------|  
|Begin an Internet session.|Create a [CInternetSession](../vs140/cinternetsession-class.md) object.|Initializes WinInet and connects to server.|  
|Set an Internet query option (time-out limit or number of retries, for example).|Use [CInternetSession::SetOption](../vs140/cinternetsession--setoption.md).|Returns FALSE if operation was unsuccessful.|  
|Establish a callback function to monitor the status of the session.|Use [CInternetSession::EnableStatusCallback](../vs140/cinternetsession--enablestatuscallback.md).|Establishes a callback to [CInternetSession::OnStatusCallback](../vs140/cinternetsession--onstatuscallback.md). Override `OnStatusCallback` to create your own callback routine.|  
|Connect to an Internet server, intranet server, or local file.|Use [CInternetSession::OpenURL](../vs140/cinternetsession--openurl.md).|Parses the URL and opens a connection to the specified server. Returns a [CStdioFile](../vs140/cstdiofile-class.md) (if you pass `OpenURL` a local file name). This is the object through which you access data retrieved from the server or file.|  
|Read from the file.|Use [CInternetFile::Read](../vs140/cinternetfile--read.md).|Reads the specified number of bytes using a buffer you supply.|  
|Handle exceptions.|Use the [CInternetException](../vs140/cinternetexception-class.md) class.|Handles all common Internet exception types.|  
|End the Internet session.|Dispose of the [CInternetSession](../vs140/cinternetsession-class.md) object.|Automatically cleans up open file handles and connections.|  
  
## See Also  
 [Win32 Internet Extensions (WinInet)](../vs140/win32-internet-extensions--wininet-.md)   
 [Prerequisites for Internet Client Classes](../vs140/prerequisites-for-internet-client-classes.md)   
 [Writing an Internet Client Application Using MFC WinInet Classes](../vs140/writing-an-internet-client-application-using-mfc-wininet-classes.md)