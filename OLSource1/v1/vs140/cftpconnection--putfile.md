---
title: "CFtpConnection::PutFile"
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
  - "PutFile"
  - "CFtpConnection.PutFile"
  - "CFtpConnection::PutFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PutFile method"
  - "CFtpConnection class, operations"
ms.assetid: c57ba2f6-b78a-47bd-a87b-c6d654624b8f
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFtpConnection::PutFile
Call this member function to store a file on an FTP server.  
  
## Syntax  
  
```  
  
      BOOL PutFile(  
   LPCTSTR pstrLocalFile,  
   LPCTSTR pstrRemoteFile,  
   DWORD dwFlags = FTP_TRANSFER_TYPE_BINARY,  
   DWORD_PTR dwContext = 1   
);  
```  
  
#### Parameters  
 `pstrLocalFile`  
 A pointer to a string containing the name of the file to send from the local system.  
  
 `pstrRemoteFile`  
 A pointer to a string containing the name of the file to create on the FTP server.  
  
 `dwFlags`  
 Specifies the conditions under which the transfer of the file occurs. Can be any of the FTP_TRANSFER_* constants described in [OpenFile](../vs140/cftpconnection--openfile.md).  
  
 `dwContext`  
 The context identifier for placing the file. See **Remarks** for more information about `dwContext`.  
  
## Return Value  
 Nonzero if successful; otherwise 0. If the call fails, the Win32 function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) may be called to determine the cause of the error.  
  
## Remarks  
 `PutFile` is a high-level routine that handles all of the operations associated with storing a file on an FTP server. Applications that only send data, or that require closer control over the file transfer, should use [OpenFile](../vs140/cftpconnection--openfile.md) and [CInternetFile::Write](../vs140/cinternetfile--write.md).  
  
 Override the `dwContext` default to set the context identifier to a value of your choosing. The context identifier is associated with this specific operation of the `CFtpConnection` object created by its [CInternetSession](../vs140/cinternetsession-class.md) object. The value is returned to [CInternetSession::OnStatusCallback](../vs140/cinternetsession--onstatuscallback.md) to provide status on the operation with which it is identified. See the article [Internet First Steps: WinInet](../vs140/wininet-basics.md) for more information about the context identifier.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CFtpConnection Class](../vs140/cftpconnection-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetConnection Class](../vs140/cinternetconnection-class.md)