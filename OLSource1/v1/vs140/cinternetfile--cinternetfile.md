---
title: "CInternetFile::CInternetFile"
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
  - "CInternetFile::CInternetFile"
  - "CInternetFile.CInternetFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CInternetFile class, constructor"
ms.assetid: 89396a11-dc2a-4a04-b250-5cb920921a10
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInternetFile::CInternetFile
This member function is called when a `CInternetFile` object is created.  
  
## Syntax  
  
```  
  
      CInternetFile(   
   HINTERNET hFile,   
   LPCTSTR pstrFileName,   
   CInternetConnection* pConnection,   
   BOOL bReadMode    
);  
CInternetFile(   
   HINTERNET hFile,   
   HINTERNET hSession,   
   LPCTSTR pstrFileName,   
   LPCTSTR pstrServer,   
   DWORD_PTR dwContext,   
   BOOL bReadMode   
);  
```  
  
#### Parameters  
 `hFile`  
 A handle to an Internet file.  
  
 `pstrFileName`  
 A pointer to a string containing the file name.  
  
 `pConnection`  
 A pointer to a [CInternetConnection](../vs140/cinternetconnection-class.md) object.  
  
 *bReadMode*  
 Indicates whether the file is read-only.  
  
 `hSession`  
 A handle to an Internet session.  
  
 `pstrServer`  
 A pointer to a string containing the name of the server.  
  
 `dwContext`  
 The context identifier for the `CInternetFile` object. See [WinInet Basics](../vs140/wininet-basics.md) for more information about the context identifier.  
  
## Remarks  
 You never create a `CInternetFile` object directly. Instead, create an object of one of its derived classes by calling [CGopherConnection::OpenFile](../vs140/cgopherconnection--openfile.md) or [CHttpConnection::OpenRequest](../vs140/chttpconnection--openrequest.md). You also can create a `CInternetFile` object by calling [CFtpConnection::OpenFile](../vs140/cftpconnection--openfile.md).  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CInternetFile Class](../vs140/cinternetfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetConnection Class](../vs140/cinternetconnection-class.md)   
 [CHttpFile Class](../vs140/chttpfile-class.md)   
 [CGopherFile Class](../vs140/cgopherfile-class.md)