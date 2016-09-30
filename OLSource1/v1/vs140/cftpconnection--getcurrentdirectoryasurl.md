---
title: "CFtpConnection::GetCurrentDirectoryAsURL"
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
  - "GetCurrentDirectoryAsURL"
  - "CFtpConnection::GetCurrentDirectoryAsURL"
  - "CFtpConnection.GetCurrentDirectoryAsURL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCurrentDirectoryAsURL method"
  - "CFtpConnection class, attributes"
ms.assetid: 9d8f4278-2458-4d4a-8643-def20f14f6ea
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFtpConnection::GetCurrentDirectoryAsURL
Call this member function to get the current directory's name as a URL.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A reference to a string that will receive the name of the directory.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a string that will receive the name of the directory.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to a DWORD that contains the following information:  
  
|||  
|-|-|  
|On entry|The size of the buffer referenced by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.|  
|On return|The number of characters stored to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If the member function fails and ERROR_INSUFFICIENT_BUFFER is returned, then <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> contains the number of bytes that the application must allocate in order to receive the string.|  
  
## Return Value  
 Nonzero if successful; otherwise 0. If the call fails, the Win32 function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) may be called to determine the cause of the error.  
  
## Remarks  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> behaves the same as [GetCurrentDirectory](../vs140/cftpconnection--getcurrentdirectory.md)  
  
 The parameter <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> can be either partially qualified filenames relative to the current directory or fully qualified. A backslash (\\) or forward slash (/) can be used as the directory separator for either name. <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> translates the directory name separators to the appropriate characters before they are used.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CFtpConnection Class](../vs140/cftpconnection-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFtpConnection::GetCurrentDirectory](../vs140/cftpconnection--getcurrentdirectory.md)   
 [CInternetConnection Class](../vs140/cinternetconnection-class.md)