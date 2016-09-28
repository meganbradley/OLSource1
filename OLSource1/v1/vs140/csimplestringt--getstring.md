---
title: "CSimpleStringT::GetString"
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
  - "ATL::CSimpleStringT<BaseType>::GetString"
  - "CSimpleStringT<BaseType>::GetString"
  - "ATL.CSimpleStringT<BaseType>.GetString"
  - "CSimpleStringT::GetString"
  - "ATL.CSimpleStringT.GetString"
  - "ATL::CSimpleStringT::GetString"
  - "CSimpleStringT.GetString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetString method"
ms.assetid: 6674050e-2188-44ab-8408-5df8a4e1c27c
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleStringT::GetString
Retrieves the character string.  
  
## Syntax  
  
```  
PCXSTR GetString( ) const throw( );  
```  
  
## Return Value  
 A pointer to a null-terminated character string.  
  
## Remarks  
 Call this method to retrieve the character string associated with the `CSimpleStringT` object.  
  
> [!NOTE]
>  The returned `PCXSTR` pointer is `const` and does not allow direct modification of `CSimpleStringT` contents.  
  
## Example  
 The following example demonstrates the use of `CSimpleStringT::GetString`.  
  
 [!code[NVC_ATLMFC_Utilities#83](../vs140/codesnippet/CPP/csimplestringt--getstring_1.cpp)]  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)   
 [CSimpleStringT::GetBuffer](../vs140/csimplestringt--getbuffer.md)