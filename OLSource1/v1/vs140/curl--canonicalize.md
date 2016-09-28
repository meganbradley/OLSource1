---
title: "CUrl::Canonicalize"
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
  - "CUrl::Canonicalize"
  - "Canonicalize"
  - "ATL::CUrl::Canonicalize"
  - "CUrl.Canonicalize"
  - "ATL.CUrl.Canonicalize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Canonicalize method"
ms.assetid: 925042b6-300b-444a-86c7-75afc40d4c75
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUrl::Canonicalize
Call this method to convert the URL string to canonical form.  
  
## Syntax  
  
```  
  
      inline BOOL Canonicalize(  
   DWORD dwFlags = 0   
) throw( );  
```  
  
#### Parameters  
 `dwFlags`  
 The flags that control canonicalization. If no flags are specified (`dwFlags` = 0), the method converts all unsafe characters and meta sequences (such as \\.,\ .., and \\...) to escape sequences. `dwFlags` can be one of the following values:  
  
-   ATL_URL_BROWSER_MODE: Does not encode or decode characters after "#" or "?" and does not remove trailing white space after "?". If this value is not specified, the entire URL is encoded and trailing white space is removed.  
  
-   ATL_URL _DECODE: Converts all %XX sequences to characters, including escape sequences, before the URL is parsed.  
  
-   ATL_URL _ENCODE_PERCENT: Encodes any percent signs encountered. By default, percent signs are not encoded.  
  
-   ATL_URL _ENCODE_SPACES_ONLY: Encodes spaces only.  
  
-   ATL_URL _NO_ENCODE: Does not convert unsafe characters to escape sequences.  
  
-   ATL_URL _NO_META: Does not remove meta sequences (such as "." and "..") from the URL.  
  
## Return Value  
 Returns TRUE on success, FALSE on failure.  
  
## Remarks  
 Converting to canonical form involves converting unsafe characters and spaces to escape sequences.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CUrl Class](../vs140/curl-class.md)