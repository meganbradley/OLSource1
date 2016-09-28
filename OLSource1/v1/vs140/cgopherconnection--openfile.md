---
title: "CGopherConnection::OpenFile"
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
  - "CGopherConnection::OpenFile"
  - "CGopherConnection.OpenFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OpenFile method, Gopher connections"
  - "opening files, gopher files"
  - "gopher protocol"
  - "CGopherConnection class, operations"
  - "files [C++], opening"
  - "files [C++], gopher"
ms.assetid: 4e531019-0ad6-46fa-a9a8-9920aedf4844
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CGopherConnection::OpenFile
Call this member function to open a file on a gopher server.  
  
## Syntax  
  
```  
  
      CGopherFile* OpenFile(  
   CGopherLocator& refLocator,  
   DWORD dwFlags = 0,  
   LPCTSTR pstrView = NULL,  
   DWORD_PTR dwContext = 1   
);  
```  
  
#### Parameters  
 `refLocator`  
 A reference to a [CGopherLocator](../vs140/cgopherlocator-class.md) object.  
  
 `dwFlags`  
 Any combination of INTERNET_FLAG_* flags. See [CInternetSession::OpenUrl](../vs140/cinternetsession--openurl.md) for further information on INTERNET_FLAG_\* flags.  
  
 `pstrView`  
 A pointer to a file-view string. If several views of the file exist at the server, this parameter specifies which file view to open. If `pstrView` is **NULL**, the default file view is used.  
  
 `dwContext`  
 The context ID for the file being opened. See **Remarks** for more information about `dwContext`.  
  
## Return Value  
 A pointer to the [CGopherFile](../vs140/cgopherfile-class.md) object to be opened.  
  
## Remarks  
 Override the `dwContext` default to set the context identifier to a value of your choosing. The context identifier is associated with this specific operation of the `CGopherConnection` object created by its [CInternetSession](../vs140/cinternetsession-class.md) object. The value is returned to [CInternetSession::OnStatusCallback](../vs140/cinternetsession--onstatuscallback.md) to provide status on the operation with which it is identified. See the article [Internet First Steps: WinInet](../vs140/wininet-basics.md) for more information about the context identifier.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CGopherConnection Class](../vs140/cgopherconnection-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFtpConnection Class](../vs140/cftpconnection-class.md)   
 [CHttpConnection Class](../vs140/chttpconnection-class.md)   
 [CInternetConnection Class](../vs140/cinternetconnection-class.md)   
 [CGopherFile Class](../vs140/cgopherfile-class.md)   
 [CGopherLocator Class](../vs140/cgopherlocator-class.md)   
 [CInternetSession Class](../vs140/cinternetsession-class.md)