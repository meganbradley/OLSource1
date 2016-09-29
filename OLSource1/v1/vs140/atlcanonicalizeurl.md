---
title: "AtlCanonicalizeUrl"
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
  - "ATL::AtlCanonicalizeUrl"
  - "AtlCanonicalizeUrl"
  - "ATLUTIL/AtlCanonicalizeUrl"
  - "ATL.AtlCanonicalizeUrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlCanonicalizeUrl function"
ms.assetid: 80015d95-081d-4bbb-a176-77670cdb16e8
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlCanonicalizeUrl
Call this function to canonicalize a URL, which includes converting unsafe characters and spaces into escape sequences.  
  
## Syntax  
  
```  
  
      inline BOOL AtlCanonicalizeUrl(  
   LPCTSTR szUrl,  
   LPTSTR szCanonicalized,  
   DWORD* pdwMaxLength,  
   DWORD dwFlags = 0   
) throw( );  
```  
  
#### Parameters  
 `szUrl`  
 The URL to be canonicalized.  
  
 `szCanonicalized`  
 Caller-allocated buffer to receive the canonicalized URL.  
  
 `pdwMaxLength`  
 Pointer to a variable that contains the length in characters of `szCanonicalized`. If the function succeeds, the variable receives the number of characters written to the buffer not including the terminating null character. If the function fails, the variable receives the required length in bytes of the buffer including space for the terminating null character.  
  
 `dwFlags`  
 Flags controlling the behavior of this function. See [ATL_URL Flags](../vs140/atl_url-flags.md).  
  
## Return Value  
 Returns **TRUE** on success, **FALSE** on failure.  
  
## Remarks  
 Behaves like the current version of [InternetCanonicalizeUrl](http://msdn.microsoft.com/library/windows/desktop/aa384342) but does not require WinInet or Internet Explorer to be installed.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)   
 [InternetCanonicalizeUrl](http://msdn.microsoft.com/library/windows/desktop/aa384342)