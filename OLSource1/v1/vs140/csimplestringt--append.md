---
title: "CSimpleStringT::Append"
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
  - "ATL::CSimpleStringT::Append"
  - "ATL.CSimpleStringT.Append"
  - "CSimpleStringT.Append"
  - "ATL.CSimpleStringT<BaseType>.Append"
  - "CSimpleStringT<BaseType>.Append"
  - "CSimpleStringT<BaseType>::Append"
  - "CSimpleStringT::Append"
  - "ATL::CSimpleStringT<BaseType>::Append"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Append method"
ms.assetid: ee448ce2-f91b-4198-a4af-e26bbc883f8b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleStringT::Append
Appends a `CSimpleStringT` object to an existing `CSimpleStringT` object.  
  
## Syntax  
  
```  
  
      void Append(  
   const CSimpleStringT& strSrc   
);  
void Append(  
   PCXSTR pszSrc,  
   int nLength  
);  
void Append(  
   PCXSTR pszSrc  
);  
```  
  
#### Parameters  
 `strSrc`  
 The `CSimpleStringT` object to be appended.  
  
 `pszSrc`  
 A pointer to a string containing the characters to be appended.  
  
 `nLength`  
 The number of characters to append.  
  
## Remarks  
 Call this method to append an existing `CSimpleStringT` object to another `CSimpleStringT` object.  
  
## Example  
 The following example demonstrates the use of `CSimpleStringT::Append`.  
  
 [!code[NVC_ATLMFC_Utilities#75](../vs140/codesnippet/CPP/csimplestringt--append_1.cpp)]  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)   
 [CSimpleStringT::AppendChar](../vs140/csimplestringt--appendchar.md)