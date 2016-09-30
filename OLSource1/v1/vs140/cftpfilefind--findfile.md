---
title: "CFtpFileFind::FindFile"
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
  - "CFtpFileFind.FindFile"
  - "CFtpFileFind::FindFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "INTERNET_OPEN_FLAG_RAW_DATA"
  - "INTERNET_OPEN_FLAG_USE_EXISTING"
  - "INTERNET_FLAG_RELOAD"
  - "CFtpFileFind class, operations"
  - "FindFile method"
  - "INTERNET_FLAG_SECURE"
  - "INTERNET_FLAG_DONT_CACHE"
ms.assetid: 6024590c-465a-4880-bb93-094acaf53375
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFtpFileFind::FindFile
Call this member function to find an FTP file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a string containing the name of the file to find. If **NULL**, the call will perform a wildcard search (*).  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The flags describing how to handle this session. These flags can be combined with the bitwise OR operator (&#124;) and are as follows:  
  
-   INTERNET_FLAG_RELOAD   Get the data from the wire even if it is locally cached. This is the default flag.  
  
-   INTERNET_FLAG_DONT_CACHE   Do not cache the data, either locally or in any gateways.  
  
-   INTERNET_FLAG_RAW_DATA   Override the default to return the raw data ([WIN32_FIND_DATA](http://msdn.microsoft.com/library/windows/desktop/aa365740) structures for FTP).  
  
-   INTERNET_FLAG_SECURE   Secures transactions on the wire with Secure Sockets Layer or PCT. This flag is applicable to HTTP requests only.  
  
-   INTERNET_FLAG_EXISTING_CONNECT   If possible, reuse the existing connections to the server for new **FindFile** requests instead of creating a new session for each request.  
  
## Return Value  
 Nonzero if successful; otherwise 0. To get extended error information, call the Win32 function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360).  
  
## Remarks  
 After calling **FindFile** to retrieve the first FTP file, you can call [FindNextFile](../vs140/cftpfilefind--findnextfile.md) to retrieve subsequent FTP files.  
  
## Example  
 See the example in the [CFtpFileFind](../vs140/cftpfilefind-class.md) class overview.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CFtpFileFind Class](../vs140/cftpfilefind-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFtpFileFind::FindNextFile](../vs140/cftpfilefind--findnextfile.md)   
 [CFileFind Class](../vs140/cfilefind-class.md)