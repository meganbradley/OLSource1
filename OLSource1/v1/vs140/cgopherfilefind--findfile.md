---
title: "CGopherFileFind::FindFile"
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
  - "CGopherFileFind.FindFile"
  - "CGopherFileFind::FindFile"
  - "INTERNET_FLAG_RAW_DATA"
  - "INTERNET_FLAG_USE_EXISTING"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "INTERNET_FLAG_USE_EXISTING"
  - "INTERNET_FLAG_RELOAD"
  - "FindFile method"
  - "FindFile method, Gopher"
  - "INTERNET_FLAG_RAW_DATA"
  - "CGopherFileFind class, attributes"
  - "INTERNET_FLAG_SECURE"
  - "INTERNET_FLAG_DONT_CACHE"
ms.assetid: 37856d0b-2fdf-40a8-9658-b7a0fdcbf92b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CGopherFileFind::FindFile
Call this member function to find a gopher file.  
  
## Syntax  
  
```  
  
      virtual BOOL FindFile(  
   CGopherLocator& refLocator,  
   LPCTSTR pstrString,  
   DWORD dwFlags = INTERNET_FLAG_RELOAD   
);  
virtual BOOL FindFile(  
   LPCTSTR pstrString,  
   DWORD dwFlags = INTERNET_FLAG_RELOAD   
);  
```  
  
#### Parameters  
 `refLocator`  
 A reference to a [CGopherLocator](../vs140/cgopherlocator-class.md) object.  
  
 *pstrString*  
 A pointer to a string containing the file name.  
  
 `dwFlags`  
 The flags describing how to handle this session. The valid flags are:  
  
-   INTERNET_FLAG_RELOAD   Get the data from the remote server even if it is locally cached.  
  
-   INTERNET_FLAG_DONT_CACHE   Do not cache the data, either locally or in any gateways.  
  
-   INTERNET_FLAG_SECURE   Request secure transactions on the wire with Secure Sockets Layer or PCT. This flag is applicable to HTTP requests only.  
  
-   INTERNET_FLAG_USE_EXISTING   If possible, reuse the existing connections to the server for new **FindFile** requests, instead of creating a new session for each request.  
  
## Return Value  
 Nonzero if successful; otherwise 0. To get extended error information, call the Win32 function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360).  
  
## Remarks  
 After calling **FindFile** to retrieve the first gopher object, you can call [FindNextFile](../vs140/cgopherfilefind--findnextfile.md) to retrieve subsequent gopher files.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CGopherFileFind Class](../vs140/cgopherfilefind-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFileFind::FindFile](../vs140/cfilefind--findfile.md)