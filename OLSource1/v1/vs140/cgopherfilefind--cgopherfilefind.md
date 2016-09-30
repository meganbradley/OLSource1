---
title: "CGopherFileFind::CGopherFileFind"
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
  - "CGopherFileFind::CGopherFileFind"
  - "CGopherFileFind.CGopherFileFind"
  - "CGopherFileFind"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "INTERNET_OPEN_FLAG_RAW_DATA"
  - "INTERNET_OPEN_FLAG_USE_EXISTING"
  - "INTERNET_FLAG_RELOAD"
  - "CGopherFileFind class, constructor"
  - "INTERNET_FLAG_SECURE"
  - "INTERNET_FLAG_DONT_CACHE"
ms.assetid: cd99d01b-eee6-449d-8c89-770cce7f318b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CGopherFileFind::CGopherFileFind
This member function is called to construct a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a [CGopherConnection](../vs140/cgopherconnection-class.md) object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The context identifier for the operation. See **Remarks** for more information about <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 The default value for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is sent by MFC to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object from the [CInternetSession](../vs140/cinternetsession-class.md) object that created the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object. When you construct a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object, you can override the default to set the context identifier to a value of your choosing. The context identifier is returned to [CInternetSession::OnStatusCallback](../vs140/cinternetsession--onstatuscallback.md) to provide status on the object with which it is identified. See the article [Internet First Steps: WinInet](../vs140/wininet-basics.md) for more information about the context identifier.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CGopherFileFind Class](../vs140/cgopherfilefind-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFtpFileFind Class](../vs140/cftpfilefind-class.md)   
 [CFileFind Class](../vs140/cfilefind-class.md)