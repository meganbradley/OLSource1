---
title: "CFtpConnection::SetCurrentDirectory"
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
  - "CFtpConnection::SetCurrentDirectory"
  - "SetCurrentDirectory"
  - "CFtpConnection.SetCurrentDirectory"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FTP (File Transfer Protocol), setting current directory"
  - "CFtpConnection class, operations"
  - "SetCurrentDirectory method"
ms.assetid: a9abbd43-3853-4012-9e89-4f4c96b76a23
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFtpConnection::SetCurrentDirectory
Call this member function to change to a different directory on the FTP server.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a string containing the name of the directory.  
  
## Return Value  
 Nonzero if successful; otherwise 0. If the call fails, the Win32 function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) may be called to determine the cause of the error.  
  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter can be either a partially or fully qualified filename relative to the current directory. A backslash (\\) or forward slash (/) can be used as the directory separator for either name. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> translates the directory name separators to the appropriate characters before they are used.  
  
 Use [GetCurrentDirectory](../vs140/cftpconnection--getcurrentdirectory.md) to determine an FTP server's current working directory. Do not assume that the remote system has connected you to the root directory.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CFtpConnection Class](../vs140/cftpconnection-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetConnection Class](../vs140/cinternetconnection-class.md)