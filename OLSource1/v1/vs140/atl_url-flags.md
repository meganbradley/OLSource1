---
title: "ATL_URL Flags"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ATL_URL flags"
ms.assetid: 76e8cc5c-4e17-4eb1-ac29-a94d5256c4a7
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATL_URL Flags
These flags modify the behavior of [AtlEscapeUrl](../vs140/atlescapeurl.md) and [AtlCanonicalizeUrl](../vs140/atlcanonicalizeurl.md) .  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
  
|Flag|Description|  
|----------|-----------------|  
|ATL_URL_BROWSER_MODE|Does not encode or decode characters after "#" or "?", and does not remove trailing white space after "?". If this value is not specified, the entire URL is encoded and trailing white space is removed.|  
|ATL_URL_DECODE|Converts all %XX sequences to characters, including escape sequences, before the URL is parsed.|  
|ATL_URL_ENCODE_PERCENT|Encodes any percent signs encountered. By default, percent signs are not encoded.|  
|ATL_URL_ENCODE_SPACES_ONLY|Encodes spaces only.|  
|ATL_URL_ESCAPE|Converts all escape sequences (%XX) to their corresponding characters.|  
|ATL_URL_NO_ENCODE|Does not convert unsafe characters to escape sequences.|  
|ATL_URL_NO_META|Does not remove meta sequences (such as "." and "..") from the URL.|  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Macros Alphabetical Reference](../vs140/atl-macros-alphabetical-reference.md)