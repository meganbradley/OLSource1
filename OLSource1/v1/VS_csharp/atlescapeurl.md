---
title: "AtlEscapeUrl"
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
  - "AtlEscapeUrl"
  - "ATLUTIL/AtlEscapeUrl"
  - "ATL.AtlEscapeUrl"
  - "ATL::AtlEscapeUrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlEscapeUrl function"
ms.assetid: e4413300-dd10-43ad-9eaf-772e58398316
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlEscapeUrl
Call this function to convert all unsafe characters to escape sequences.  
  
## Syntax  
  
```  
  
      inline BOOL AtlEscapeUrl(  
   LPCSTR szStringIn,  
   LPSTR szStringOut,  
   DWORD* pdwStrLen,  
   DWORD dwMaxLength,  
   DWORD dwFlags = 0   
) throw( );  
inline BOOL AtlEscapeUrl(  
   LPCWSTR szStringIn,  
   LPWSTR szStringOut,  
   DWORD* pdwStrLen,  
   DWORD dwMaxLength,  
   DWORD dwFlags = 0   
) throw( );  
```  
  
#### Parameters  
 `lpszStringIn`  
 The URL to be converted.  
  
 `lpszStringOut`  
 Caller-allocated buffer to which the converted URL will be written.  
  
 `pdwStrLen`  
 Pointer to a DWORD variable. If the function succeeds, `pdwStrLen` receives the number of characters written to the buffer, not including the terminating null character. If the function fails, the variable receives the required length in bytes of the buffer including space for the terminating null character. When using the wide character version of this method, `pdwStrLen` receives the number of characters required, not the number of bytes.  
  
 `dwMaxLength`  
 The size of the buffer `lpszStringOut`.  
  
 `dwFlags`  
 Flags controlling the behavior of this function. See [ATL_URL Flags](../VS_csharp/atl_url-flags.md).  
  
## Return Value  
 Returns **TRUE** on success, **FALSE** on failure.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [ATL Concepts](../VS_csharp/active-template-library--atl--concepts.md)   
 [ATL Reference](../VS_csharp/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../VS_csharp/atl-functions-alphabetical-reference.md)   
 [AtlUnescapeUrl](../VS_csharp/atlunescapeurl.md)