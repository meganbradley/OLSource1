---
title: "CFtpFileFind::CFtpFileFind"
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
  - "CFtpFileFind.CFtpFileFind"
  - "CFtpFileFind::CFtpFileFind"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFtpFileFind class, construction"
  - "CFtpFileFind class, constructor"
ms.assetid: 1837a301-87c8-4fad-8777-078c342944e1
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFtpFileFind::CFtpFileFind
This member function is called to construct a `CFtpFileFind` object.  
  
## Syntax  
  
```  
  
      explicit CFtpFileFind(  
   CFtpConnection* pConnection,  
   DWORD_PTR dwContext = 1   
);  
```  
  
#### Parameters  
 `pConnection`  
 A pointer to a `CFtpConnection` object. You can obtain an FTP connection by calling [CInternetSession::GetFtpConnection](../vs140/cinternetsession--getftpconnection.md).  
  
 `dwContext`  
 The context identifier for the `CFtpFileFind` object. See **Remarks** for more information about this parameter.  
  
## Remarks  
 The default value for `dwContext` is sent by MFC to the `CFtpFileFind` object from the [CInternetSession](../vs140/cinternetsession-class.md) object that created the `CFtpFileFind` object. You can override the default to set the context identifier to a value of your choosing. The context identifier is returned to [CInternetSession::OnStatusCallback](../vs140/cinternetsession--onstatuscallback.md) to provide status on the object with which it is identified. See the article [Internet First Steps: WinInet](../vs140/wininet-basics.md) for more information about the context identifier.  
  
## Example  
 See the example in the [CFtpFileFind](../vs140/cftpfilefind-class.md) class overview.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CFtpFileFind Class](../vs140/cftpfilefind-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CGopherFileFind Class](../vs140/cgopherfilefind-class.md)   
 [CFileFind Class](../vs140/cfilefind-class.md)