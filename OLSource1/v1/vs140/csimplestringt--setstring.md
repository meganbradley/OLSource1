---
title: "CSimpleStringT::SetString"
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
  - "CSimpleStringT::SetString"
  - "CSimpleStringT<BaseType>::SetString"
  - "ATL::CSimpleStringT<BaseType>::SetString"
  - "ATL::CSimpleStringT::SetString"
  - "ATL.CSimpleStringT<BaseType>.SetString"
  - "CSimpleStringT.SetString"
  - "ATL.CSimpleStringT.SetString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetString method"
ms.assetid: 4c392507-6e14-4b8f-b917-35ad1320d080
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleStringT::SetString
Sets the string of a `CSimpleStringT` object.  
  
## Syntax  
  
```  
  
      void SetString(  
   PCXSTR pszSrc,  
   int nLength  
);  
void SetString(  
   PCXSTR pszSrc  
);  
```  
  
#### Parameters  
 `pszSrc`  
 A pointer to a null-terminated string.  
  
 `nLength`  
 A count of the number of characters in `pszSrc`.  
  
## Remarks  
 Copy a string into the `CSimpleStringT` object. `SetString` overwrites the older string data in the buffer.  
  
 Both versions of `SetString` check whether `pszSrc` is a null pointer, and if it is, throw an **E_INVALIDARG** error.  
  
 The one-parameter version of `SetString` expects `pszSrc` to point to a null-terminated string.  
  
 The two-parameter version of `SetString` also expects `pszSrc` to be a null-terminated string. It uses `nLength` as the string length unless it encounters a null terminator first.  
  
 The two-parameter version of `SetString` also checks whether `pszSrc` points to a location in the current buffer in `CSimpleStringT`. In this special case, `SetString` uses a memory copy function that does not overwrite the string data as it copies the string data back to its buffer.  
  
## Example  
 The following example demonstrates the use of `CSimpleStringT::SetString`.  
  
 [!code[NVC_ATLMFC_Utilities#90](../vs140/codesnippet/CPP/csimplestringt--setstring_1.cpp)]  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)