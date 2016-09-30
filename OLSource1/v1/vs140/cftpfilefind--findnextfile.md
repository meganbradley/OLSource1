---
title: "CFtpFileFind::FindNextFile"
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
  - "CFtpFileFind.FindNextFile"
  - "CFtpFileFind::FindNextFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFtpFileFind class, operations"
  - "FindNextFile method"
ms.assetid: 38e09283-f4b7-4434-a7f2-da92363254d0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFtpFileFind::FindNextFile
Call this member function to continue a file search begun with a call to the [FindFile](../vs140/cftpfilefind--findfile.md) member function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if there are more files; zero if the file found is the last one in the directory or if an error occurred. To get extended error information, call the Win32 function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360). If the file found is the last file in the directory, or if no matching files can be found, the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function returns ERROR_NO_MORE_FILES.  
  
## Remarks  
 You must call this function at least once before calling any attribute function (see [CFileFind::FindNextFile](../vs140/cfilefind--findnextfile.md)).  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> wraps the Win32 function [FindNextFile](http://msdn.microsoft.com/library/windows/desktop/aa364428).  
  
## Example  
 See the example in the [CFtpFileFind](../vs140/cftpfilefind-class.md) class overview.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CFtpFileFind Class](../vs140/cftpfilefind-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFileFind Class](../vs140/cfilefind-class.md)