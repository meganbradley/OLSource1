---
title: "AfxParseURL"
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
  - "AfxParseURL"
  - "AFXINET/AfxParseURL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "parsing, URLs"
  - "URLs, parsing"
  - "parsing, Internet addresses"
  - "Internet services, discovering"
  - "parsing, Internet URLs"
  - "Internet services"
  - "AfxParseURL function"
ms.assetid: 505c717e-aa52-4106-8522-eedff3d9bbae
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxParseURL
This global is used in [CInternetSession::OpenURL](../vs140/cinternetsession--openurl.md).  
  
## Syntax  
  
```  
  
      BOOL AFXAPI AfxParseURL(  
   LPCTSTR pstrURL,  
   DWORD& dwServiceType,  
   CString& strServer,  
   CString& strObject,  
   INTERNET_PORT& nPort  
);  
```  
  
#### Parameters  
 *pstrURL*  
 A pointer to a string containing the URL to be parsed.  
  
 `dwServiceType`  
 Indicates the type of Internet service. Possible values are as follows:  
  
-   AFX_INET_SERVICE_FTP  
  
-   AFX_INET_SERVICE_HTTP  
  
-   AFX_INET_SERVICE_HTTPS  
  
-   AFX_INET_SERVICE_GOPHER  
  
-   AFX_INET_SERVICE_FILE  
  
-   AFX_INET_SERVICE_MAILTO  
  
-   AFX_INET_SERVICE_NEWS  
  
-   AFX_INET_SERVICE_NNTP  
  
-   AFX_INET_SERVICE_TELNET  
  
-   AFX_INET_SERVICE_WAIS  
  
-   AFX_INET_SERVICE_MID  
  
-   AFX_INET_SERVICE_CID  
  
-   AFX_INET_SERVICE_PROSPERO  
  
-   AFX_INET_SERVICE_AFS  
  
-   AFX_INET_SERVICE_UNK  
  
 `strServer`  
 The first segment of the URL following the service type.  
  
 `strObject`  
 An object that the URL refers to (may be empty).  
  
 `nPort`  
 Determined from either the Server or Object portions of the URL, if either exists.  
  
## Return Value  
 Nonzero if the URL was successfully parsed; otherwise, 0 if it is empty or does not contain a known Internet service type.  
  
## Remarks  
 It parses a URL string and returns the type of service and its components.  
  
 For example, `AfxParseURL` parses URLs of the form **service://server/dir/dir/object.ext:port** and returns its components stored as follows:  
  
 `strServer` == "server"  
  
 `strObject` == "/dir/dir/object/object.ext"  
  
 `nPort` == #port  
  
 `dwServiceType` == #service  
  
> [!NOTE]
>  To call this function, your project must include AFXINET.H.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AfxGetInternetHandleType](../vs140/afxgetinternethandletype.md)   
 [AfxParseURLEx](../vs140/afxparseurlex.md)