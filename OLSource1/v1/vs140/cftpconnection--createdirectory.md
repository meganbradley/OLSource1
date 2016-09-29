---
title: "CFtpConnection::CreateDirectory"
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
  - "CFtpConnection::CreateDirectory"
  - "CreateDirectory"
  - "CFtpConnection.CreateDirectory"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateDirectory method"
  - "directories [C++], creating"
  - "CFtpConnection class, operations"
ms.assetid: 11ff7cca-d053-42c7-ab27-a57d4ac4c018
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFtpConnection::CreateDirectory
Call this member function to create a directory on the connected server.  
  
## Syntax  
  
```  
  
      BOOL CreateDirectory(  
   LPCTSTR pstrDirName   
);  
```  
  
#### Parameters  
 `pstrDirName`  
 A pointer to a string containing the name of the directory to create.  
  
## Return Value  
 Nonzero if successful; otherwise 0. If the call fails, the Windows function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) may be called to determine the cause of the error.  
  
## Remarks  
 Use `GetCurrentDirectory` to determine the current working directory for this connection to the server. Do not assume that the remote system has connected you to the root directory.  
  
 The `pstrDirName` parameter can be either a partially or a fully qualified filename relative to the current directory. A backslash (\\) or forward slash (/) can be used as the directory separator for either name. `CreateDirectory` translates the directory name separators to the appropriate characters before they are used.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CFtpConnection Class](../vs140/cftpconnection-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetConnection Class](../vs140/cinternetconnection-class.md)