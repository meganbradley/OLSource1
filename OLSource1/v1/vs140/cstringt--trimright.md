---
title: "CStringT::TrimRight"
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
  - "ATL.CStringT.TrimRight"
  - "TrimRight"
  - "CStringT::TrimRight"
  - "ATL::CStringT::TrimRight"
  - "CStringT.TrimRight"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TrimRight method"
ms.assetid: e301c416-c9c4-4896-9cb3-336b056b2019
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::TrimRight
Trims trailing characters from the string.  
  
## Syntax  
  
```  
CStringT& TrimRight(  
   XCHAR chTarget   
);  
CStringT& TrimRight(  
   PCXSTR pszTargets   
);  
CStringT& TrimRight( );  
```  
  
#### Parameters  
 `chTarget`  
 The target character to be trimmed.  
  
 `pszTargets`  
 A pointer to a string containing the target characters to be trimmed. All trailing occurrences of characters in `pszTarget` will be trimmed from the `CStringT` object.  
  
## Return Value  
 Returns the `CStringT` object that contains the trimmed string.  
  
## Remarks  
 Removes trailing occurrences of one of the following:  
  
-   The character specified by `chTarget.`  
  
-   All characters found in the string specified by `pszTargets.`  
  
-   Whitespace.  
  
 The `CStringT& TrimRight(XCHAR chTarget)` version accepts one character parameter and removes all copies of that character from the end of `CStringT` string data. It starts from the end of the string and works toward the front. It stops when it finds a different character or when `CSTringT` runs out of character data.  
  
 The `CStringT& TrimRight(PCXSTR pszTargets)` version accepts a null-terminated string that contains all the different characters to search for. It removes all copies of those characters in the `CStringT` object. It starts at the end of the string and works toward the front. It stops when it finds a character that is not in the target string, or when `CStringT` runs out of character data. It does not try to match the whole target string to a substring at the end of `CStringT`.  
  
 The `CStringT& TrimRight()` version requires no parameters. It trims any trailing whitespace characters from the end of the `CStringT` string. Whitespace characters can be line breaks, spaces, or tabs.  
  
-  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#138](../vs140/codesnippet/CPP/cstringt--trimright_1.cpp)]  
  
## Output  
 The output from this example is as follows:  
  
 `Before: "Soccer is best!?!?!?!?!"`  
  
 `After : "Soccer is best"`  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)   
 [CStringT::Trim](../vs140/cstringt--trim.md)   
 [CStringT::TrimLeft](../vs140/cstringt--trimleft.md)