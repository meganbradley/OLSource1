---
title: "CHttpFile::QueryInfoStatusCode"
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
  - "CHttpFile::QueryInfoStatusCode"
  - "QueryInfoStatusCode"
  - "CHttpFile.QueryInfoStatusCode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHttpFile class, operations"
  - "HTTP status codes"
  - "QueryInfoStatusCode method"
ms.assetid: 49b3487d-8ecf-4571-ac5f-2ad29286d863
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHttpFile::QueryInfoStatusCode
Call this member function to get the status code associated with an HTTP request and place it in the supplied <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> parameter.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to a status code. Status codes indicate the success or failure of the requested event. See **Remarks** for a selection of status code descriptions.  
  
## Return Value  
 Nonzero if successful; otherwise 0. If the call fails, the Win32 function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) may be called to determine the cause of the error.  
  
## Remarks  
 Use this member function only after a successful call to [SendRequest](../vs140/chttpfile--sendrequest.md) or on a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object successfully created by [OpenURL](../vs140/cinternetsession--openurl.md).  
  
 HTTP status codes fall into groups indicating the success or failure of the request. The following tables outline the status code groups and the most common HTTP status codes.  
  
|Group|Meaning|  
|-----------|-------------|  
|200-299|Success|  
|300-399|Information|  
|400-499|Request error|  
|500-599|Server error|  
  
 Common HTTP Status Codes:  
  
|Status code|Meaning|  
|-----------------|-------------|  
|200|URL located, transmission follows|  
|400|Unintelligible request|  
|404|Requested URL not found|  
|405|Server does not support requested method|  
|500|Unknown server error|  
|503|Server capacity reached|  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CHttpFile Class](../vs140/chttpfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetFile Class](../vs140/cinternetfile-class.md)