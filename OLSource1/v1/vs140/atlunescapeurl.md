---
title: "AtlUnescapeUrl"
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
  - "ATL::AtlUnescapeUrl"
  - "ATLUTIL/AtlUnescapeUrl"
  - "ATL.AtlUnescapeUrl"
  - "AtlUnescapeUrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlUnescapeUrl function"
ms.assetid: f6174219-3f95-4446-bc39-8e4bd1520eb2
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlUnescapeUrl
Call this function to convert escaped characters back to their original values.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The URL to be converted.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Caller-allocated buffer to which the converted URL will be written.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to a DWORD variable. If the function succeeds, the variable receives the number of characters written to the buffer not including the terminating null character. If the function fails, the variable receives the required length in bytes of the buffer including space for the terminating null character.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The size of the buffer <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Return Value  
 Returns **TRUE** on success, **FALSE** on failure.  
  
## Remarks  
 Reverses the conversion process applied by [AtlEscapeUrl](../vs140/atlescapeurl.md).  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)   
 [AtlEscapeUrl](../vs140/atlescapeurl.md)