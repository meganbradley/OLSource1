---
title: "CHttpFile::CHttpFile"
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
  - "CHttpFile.CHttpFile"
  - "CHttpFile::CHttpFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHttpFile class, constructor"
ms.assetid: 93bc7702-bda1-434b-8d4d-59d67a220454
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHttpFile::CHttpFile
This member function is called to construct a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A handle to an Internet file.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A handle to an Internet session.  
  
 *pstrObject*  
 A pointer to a string containing the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to a string containing the name of the server.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A pointer to a string containing the method to be used when sending the request. Can be **POST**, **HEAD**, or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 dwContext  
 The context identifier for the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object. See **Remarks** for more information about this parameter.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A pointer to a [CHttpConnection](../vs140/chttpconnection-class.md) object.  
  
## Remarks  
 You never construct a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object directly; rather call [CInternetSession::OpenURL](../vs140/cinternetsession--openurl.md) or [CHttpConnection::OpenRequest](../vs140/chttpconnection--openrequest.md) instead.  
  
 The default value for <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is sent by MFC to the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object from the [CInternetSession](../vs140/cinternetsession-class.md) object that created the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object. When you call <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to construct a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object, you can override the default to set the context identifier to a value of your choosing. The context identifier is returned to [CInternetSession::OnStatusCallback](../vs140/cinternetsession--onstatuscallback.md) to provide status on the object with which it is identified. See the article [Internet First Steps: WinInet](../vs140/wininet-basics.md) for more information about the context identifier.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CHttpFile Class](../vs140/chttpfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetFile Class](../vs140/cinternetfile-class.md)