---
title: "CUrl::CreateUrl"
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
  - "CUrl.CreateUrl"
  - "ATL.CUrl.CreateUrl"
  - "ATL::CUrl::CreateUrl"
  - "CUrl::CreateUrl"
  - "CreateUrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateUrl method"
ms.assetid: b16edd02-5069-46bb-9a66-b7d56b476869
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUrl::CreateUrl
This method constructs a URL string from a CUrl object's component fields.  
  
## Syntax  
  
```  
  
      inline BOOL CreateUrl(  
   LPTSTR lpszUrl,  
   DWORD* pdwMaxLength,  
   DWORD dwFlags = 0   
) const throw( );  
```  
  
#### Parameters  
 *lpszUrl*  
 A string buffer to hold the complete URL string.  
  
 `pdwMaxLength`  
 The maximum length of the *lpszUrl* string buffer.  
  
 `dwFlags`  
 Specify ATL_URL_ESCAPE to convert all escape characters in *lpszUrl* to their real values.  
  
## Return Value  
 Returns TRUE on success, FALSE on failure.  
  
## Remarks  
 This method appends its individual fields in order to construct the complete URL string using the following format:  
  
 **\<scheme>://\<user>:\<pass>@\<domain>:\<port>\<path>\<extra>**  
  
 When calling this method, the `pdwMaxLength` parameter should initially contain the maximum length of the string buffer referenced by the *lpszUrl* parameter. The value of the `pdwMaxLength` parameter will be updated with the actual length of the URL string.  
  
## Example  
 This sample demonstrates creation of a CUrl object and retrieving its URL string  
  
 [!code[NVC_ATL_Utilities#133](../vs140/codesnippet/CPP/curl--createurl_1.cpp)]  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CUrl Class](../vs140/curl-class.md)   
 [CUrl::CrackUrl](../vs140/curl--crackurl.md)   
 [CUrl::GetUrlLength](../vs140/curl--geturllength.md)