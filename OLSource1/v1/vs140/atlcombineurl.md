---
title: "AtlCombineUrl"
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
  - "ATLUTIL/AtlCombineUrl"
  - "ATL::AtlCombineUrl"
  - "AtlCombineUrl"
  - "ATL.AtlCombineUrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlCombineUrl function"
ms.assetid: c5bb1b78-6eb3-4a27-92ad-0e48d8d5846a
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlCombineUrl
Call this function to combine a base URL and a relative URL into a single, canonical URL.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *szBaseUrl*  
 The base URL.  
  
 *szRelativeUrl*  
 The URL relative to the base URL.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Caller-allocated buffer to receive the canonicalized URL.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a variable that contains the length in characters of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. If the function succeeds, the variable receives the number of characters written to the buffer not including the terminating null character. If the function fails, the variable receives the required length in bytes of the buffer including space for the terminating null character.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Flags controlling the behavior of this function. See [ATL_URL Flags](../vs140/atl_url-flags.md).  
  
## Return Value  
 Returns **TRUE** on success, **FALSE** on failure.  
  
## Remarks  
 Behaves like the current version of [InternetCombineUrl](http://msdn.microsoft.com/library/windows/desktop/aa384355) but does not require WinInet or Internet Explorer to be installed.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)   
 [InternetCombineUrl](http://msdn.microsoft.com/library/windows/desktop/aa384355)