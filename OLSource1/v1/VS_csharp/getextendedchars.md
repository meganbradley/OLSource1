---
title: "GetExtendedChars"
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
  - "GetExtendedChars"
  - "ATL::GetExtendedChars"
  - "ATL.GetExtendedChars"
  - "ATLENC/GetExtendedChars"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetExtendedChars function"
ms.assetid: 26c5fa33-f313-4c4b-baf7-cca2ac11885c
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# GetExtendedChars
Call this function to get the number of extended characters in a string.  
  
## Syntax  
  
```  
  
      inline int GetExtendedChars(  
   LPCSTR szSrc,  
   int nSrcLen   
) throw( );  
```  
  
#### Parameters  
 `szSrc`  
 The string to be analyzed.  
  
 `nSrcLen`  
 The length of the string in characters.  
  
## Return Value  
 Returns the number of extended characters found within the string as determined by [IsExtendedChar](../VS_csharp/isextendedchar.md).  
  
## Requirements  
 **Header:** atlenc.h  
  
## See Also  
 [ATL Concepts](../VS_csharp/active-template-library--atl--concepts.md)   
 [ATL Reference](../VS_csharp/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../VS_csharp/atl-functions-alphabetical-reference.md)   
 [IsExtendedChar](../VS_csharp/isextendedchar.md)