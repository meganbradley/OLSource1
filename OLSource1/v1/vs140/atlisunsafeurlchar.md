---
title: "AtlIsUnsafeUrlChar"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ATLUTIL/AtlIsUnsafeUrlChar
  - ATL::AtlIsUnsafeUrlChar
  - AtlIsUnsafeUrlChar
  - ATL.AtlIsUnsafeUrlChar
dev_langs: 
  - C++
helpviewer_keywords: 
  - AtlIsUnsafeUrlChar function
ms.assetid: bf434973-0530-48ea-86cc-f40551e4d4a3
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AtlIsUnsafeUrlChar
Call this function to find out whether a character is safe for use in a URL.  
  
## Syntax  
  
```  
  
      inline BOOL AtlIsUnsafeUrlChar(  
   char chIn   
) throw( );  
```  
  
#### Parameters  
 `chIn`  
 The character to be tested for safety.  
  
## Return Value  
 Returns **TRUE** if the input character is unsafe, **FALSE** otherwise.  
  
## Remarks  
 Characters that should not be used in URLs can be tested using this function and converted using [AtlCanonicalizeUrl](../vs140/atlcanonicalizeurl.md).  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)