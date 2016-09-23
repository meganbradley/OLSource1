---
title: "CStringT::TrimLeft"
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
  - TrimLeft
  - ATL::CStringT::TrimLeft
  - ATL.CStringT.TrimLeft
  - CStringT::TrimLeft
  - CStringT.TrimLeft
dev_langs: 
  - C++
helpviewer_keywords: 
  - TrimLeft method
ms.assetid: e9a2eb1d-49a4-4e6d-b2b1-297719c65086
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CStringT::TrimLeft
Trims leading characters from the string.  
  
## Syntax  
  
```  
CStringT& TrimLeft(  
   XCHAR chTarget   
);  
CStringT& TrimLeft(  
   PCXSTR pszTargets   
);  
CStringT& TrimLeft( );  
```  
  
#### Parameters  
 `chTarget`  
 The target character to be trimmed.  
  
 `pszTargets`  
 A pointer to a string containing the target characters to be trimmed. All leading occurrences of characters in `pszTarget` will be trimmed from the `CStringT` object.  
  
## Return Value  
 The resulting trimmed string.  
  
## Remarks  
 Removes all leading and trailing occurrences of one of the following:  
  
-   The character specified by `chTarget.`  
  
-   All characters found in the string specified by `pszTargets.`  
  
-   Whitespace.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#137](../vs140/codesnippet/CPP/cstringt--trimleft_1.cpp)]
  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)   
 [CStringT::Trim](../vs140/cstringt--trim.md)   
 [CStringT::TrimRight](../vs140/cstringt--trimright.md)