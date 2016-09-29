---
title: "Steps in a Typical FTP Client Application to Delete a File"
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
  - "Internet client applications, FTP delete"
  - "WinInet classes, FTP"
  - "FTP (File Transfer Protocol), client applications"
  - "Internet applications, FTP client applications"
ms.assetid: 2c347a96-c0a4-4827-98fe-668406e552bc
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Steps in a Typical FTP Client Application to Delete a File
The following table shows the steps you might perform in a typical FTP client application that deletes a file.  
  
|Your goal|Actions you take|Effects|  
|---------------|----------------------|-------------|  
|Begin an FTP session.|Create a [CInternetSession](../VS_csharp/cinternetsession-class.md) object.|Initializes WinInet and connects to server.|  
|Connect to an FTP server.|Use [CInternetSession::GetFtpConnection](../Topic/CInternetSession::GetFtpConnection.md).|Returns a [CFtpConnection](../VS_csharp/cftpconnection-class.md) object.|  
|Check to make sure you're in the right directory on the FTP server.|Use [CFtpConnection::GetCurrentDirectory](../Topic/CFtpConnection::GetCurrentDirectory.md) or [CFtpConnection::GetCurrentDirectoryAsURL](../Topic/CFtpConnection::GetCurrentDirectoryAsURL.md).|Returns the name or URL of the directory you are currently connected to on the server, depending on the member function selected.|  
|Change to a new FTP directory on the server.|Use [CFtpConnection::SetCurrentDirectory](../Topic/CFtpConnection::SetCurrentDirectory.md).|Changes the directory you are currently connected to on the server.|  
|Find the first file in the FTP directory.|Use [CFtpFileFind::FindFile](../Topic/CFtpFileFind::FindFile.md).|Finds the first file. Returns FALSE if no files are found.|  
|Find the next file in the FTP directory.|Use [CFtpFileFind::FindNextFile](../Topic/CFtpFileFind::FindNextFile.md).|Finds the next file. Returns FALSE if the file is not found.|  
|Delete the file found by **FindFile** or `FindNextFile`.|Use [CFtpConnection::Remove](../Topic/CFtpConnection::Remove.md), using the file name returned by **FindFile** or `FindNextFile`.|Deletes the file on the server for reading or writing.|  
|Handle exceptions.|Use the [CInternetException](../VS_csharp/cinternetexception-class.md) class.|Handles all common Internet exception types.|  
|End the FTP session.|Dispose of the [CInternetSession](../VS_csharp/cinternetsession-class.md) object.|Automatically cleans up open file handles and connections.|  
  
## See Also  
 [Win32 Internet Extensions (WinInet)](../VS_csharp/win32-internet-extensions--wininet-.md)   
 [Prerequisites for Internet Client Classes](../VS_csharp/prerequisites-for-internet-client-classes.md)   
 [Writing an Internet Client Application Using MFC WinInet Classes](../VS_csharp/writing-an-internet-client-application-using-mfc-wininet-classes.md)