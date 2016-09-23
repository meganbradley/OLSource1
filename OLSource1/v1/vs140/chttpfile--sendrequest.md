---
title: "CHttpFile::SendRequest"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CHttpFile::SendRequest
  - SendRequest
  - CHttpFile.SendRequest
dev_langs: 
  - C++
helpviewer_keywords: 
  - CHttpFile class, operations
  - HTTP requests, sending
  - SendRequest method
ms.assetid: e88873d0-2734-491a-bf07-0fe5e5f2c5a3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CHttpFile::SendRequest
Call this member function to send a request to an HTTP server.  
  
## Syntax  
  
```  
  
      BOOL SendRequest(  
   LPCTSTR pstrHeaders = NULL,  
   DWORD dwHeadersLen = 0,  
   LPVOID lpOptional = NULL,  
   DWORD dwOptionalLen = 0   
);  
BOOL SendRequest(  
   CString& strHeaders,  
   LPVOID lpOptional = NULL,  
   DWORD dwOptionalLen = 0   
);  
```  
  
#### Parameters  
 `pstrHeaders`  
 A pointer to a string containing the name of the headers to send.  
  
 `dwHeadersLen`  
 The length of the headers identified by `pstrHeaders`.  
  
 `lpOptional`  
 Any optional data to send immediately after the request headers. This is generally used for **POST** and **PUT** operations. This can be **NULL** if there is no optional data to send.  
  
 *dwOptionalLen*  
 The length of `lpOptional`.  
  
 `strHeaders`  
 A string containing the name of the headers for the request being sent.  
  
## Return Value  
 Nonzero if successful; otherwise 0. If the call fails, determine the cause of the failure by examining the thrown [CInternetException](../vs140/cinternetexception-class.md) object.  
  
## Exceptions  
 This method can throw exceptions of type `CInternetException`.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CHttpFile Class](../vs140/chttpfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetFile Class](../vs140/cinternetfile-class.md)   
 [CHttpFile::SendRequestEx](../vs140/chttpfile--sendrequestex.md)