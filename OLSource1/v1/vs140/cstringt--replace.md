---
title: "CStringT::Replace"
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
  - "ATL.CStringT.Replace"
  - "CStringT::Replace"
  - "ATL::CStringT::Replace"
  - "CStringT.Replace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Replace method"
ms.assetid: 4c6b2f1d-a4b1-4ed6-9d8f-fbc1226b3255
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::Replace
There are two versions of `Replace`.The first version replaces one or more copies of a substring by using another substring. Both substrings are null-terminated. The second version replaces one or more copies of a character by using another character. Both versions operate on the character data stored in `CStringT`.  
  
## Syntax  
  
```  
int Replace(  
   PCXSTR pszOld,  
   PCXSTR pszNew  
);  
int Replace(  
   XCHAR chOld,  
   XCHAR chNew  
);  
```  
  
#### Parameters  
 `pszOld`  
 A pointer to a null-terminated string to be replaced by `pszNew`.  
  
 `pszNew`  
 A pointer to a null-terminated string that replaces `pszOld`.  
  
 `chOld`  
 The character to be replaced by `chNew`.  
  
 `chNew`  
 The character replacing `chOld`.  
  
## Return Value  
 Returns the number of replaced instances of the character or substring, or zero if the string is not changed.  
  
## Remarks  
 `Replace` can change the string length because `pszNew` and `pszOld` do not have to be the same length, and several copies of the old substring can be changed to the new one. The function performs a case-sensitive match.  
  
 Examples of `CStringT` instances are `CString`, `CStringA`, and `CStringW`.  
  
 For `CStringA`, `Replace` works with ANSI or multibyte (MBCS) characters. For `CStringW`, `Replace` works with wide characters.  
  
 For `CString`, the character data type is selected at compile time, based on whether the constants in the following table are defined.  
  
|Defined Constant|Character Data Type|  
|----------------------|-------------------------|  
|`_UNICODE`|Wide characters|  
|`_MBCS`|Multi-byte characters|  
|Neither|Single-byte characters|  
|Both|Undefined|  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#200](../vs140/codesnippet/CPP/cstringt--replace_1.cpp)]  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)