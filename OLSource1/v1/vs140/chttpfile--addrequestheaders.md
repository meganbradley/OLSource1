---
title: "CHttpFile::AddRequestHeaders"
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
  - "HTTP_ADDREQ_FLAG_COALESCE"
  - "HTTP_ADDREQ_FLAG_ADD"
  - "CHttpFile::AddRequestHeaders"
  - "HTTP_ADDREQ_FLAG_ADD_IF_NEW"
  - "CHttpFile.AddRequestHeaders"
  - "HTTP_ADDREQ_FLAG_REPLACE"
  - "AddRequestHeaders"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HTTP headers"
  - "HTTP_ADDREQ_FLAG_ADD_IF_NEW"
  - "AddRequestHeaders method"
  - "CHttpFile class, operations"
  - "HTTP_ADDREQ_FLAG_REPLACE"
  - "HTTP requests, headers"
  - "HTTP_ADDREQ_FLAG_COALESCE"
  - "HTTP_ADDREQ_FLAG_ADD"
ms.assetid: aa0af700-febb-41bc-9a78-668d63c86db4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHttpFile::AddRequestHeaders
Call this member function to add one or more HTTP request headers to the HTTP request handle.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a string containing the header or headers to append to the request. Each header must be terminated by a CR/LF pair.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Modifies the semantics of the new headers. Can be one of the following:  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> Merges headers of the same name, using the flag to add the first header found to the subsequent header. For example, "Accept: text/*" followed by "Accept: audio/\*" results in the formation of the single header "Accept: text/\*, audio/\*". It is up to the calling application to ensure a cohesive scheme with respect to data received by requests sent with coalesced or separate headers.  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> Performs a remove and add to replace the current header. The header name will be used to remove the current header, and the full value will be used to add the new header. If the header-value is empty and the header is found, it is removed. If not empty, the header-value is replaced.  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> Only adds the header if it does not already exist. If one exists, an error is returned.  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> Used with REPLACE. Adds the header if it doesn't exist.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The length, in characters, of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. If this is -1L, then <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is assumed to be zero-terminated and the length is computed.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A reference to a [CString](../vs140/cstringt-class.md) object containing the request header or headers to be added.  
  
## Return Value  
 Nonzero if successful; otherwise 0. If the call fails, the Win32 function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) may be called to determine the cause of the error.  
  
## Remarks  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> appends additional, free-format headers to the HTTP request handle. It is intended for use by sophisticated clients who need detailed control over the exact request sent to the HTTP server.  
  
> [!NOTE]
>  The application can pass multiple headers in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> for an <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> call using <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. If the application tries to remove or replace a header using **HTTP_ADDREQ_FLAG_REMOVE** or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, only one header can be supplied in <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CHttpFile Class](../vs140/chttpfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetFile Class](../vs140/cinternetfile-class.md)