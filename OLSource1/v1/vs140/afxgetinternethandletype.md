---
title: "AfxGetInternetHandleType"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AFXINET/AfxGetInternetHandleType"
  - "AfxGetInternetHandleType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxGetInternetHandleType function"
ms.assetid: 754d6b3c-4eee-4190-8688-e4fb0381e92f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxGetInternetHandleType
Use this global function to determine the type of an Internet handle.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A handle to an Internet query.  
  
## Return Value  
 Any of the Internet service types defined by WININET.H. See the Remarks section for a list of these Internet services. If the handle is NULL or not recognized, the function returns AFX_INET_SERVICE_UNK.  
  
## Remarks  
 The following list includes possible Internet types returned by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
-   INTERNET_HANDLE_TYPE_INTERNET  
  
-   INTERNET_HANDLE_TYPE_CONNECT_FTP  
  
-   INTERNET_HANDLE_TYPE_CONNECT_GOPHER  
  
-   INTERNET_HANDLE_TYPE_CONNECT_HTTP  
  
-   INTERNET_HANDLE_TYPE_FTP_FIND  
  
-   INTERNET_HANDLE_TYPE_FTP_FIND_HTML  
  
-   INTERNET_HANDLE_TYPE_FTP_FILE  
  
-   INTERNET_HANDLE_TYPE_FTP_FILE_HTML  
  
-   INTERNET_HANDLE_TYPE_GOPHER_FIND  
  
-   INTERNET_HANDLE_TYPE_GOPHER_FIND_HTML  
  
-   INTERNET_HANDLE_TYPE_GOPHER_FILE  
  
-   INTERNET_HANDLE_TYPE_GOPHER_FILE_HTML  
  
-   INTERNET_HANDLE_TYPE_HTTP_REQUEST  
  
> [!NOTE]
>  In order to call this function, your project must include AFXINET.H.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AfxParseURL](../vs140/afxparseurl.md)