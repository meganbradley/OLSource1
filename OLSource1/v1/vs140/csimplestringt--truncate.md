---
title: "CSimpleStringT::Truncate"
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
  - "ATL::CSimpleStringT<BaseType>::Truncate"
  - "ATL.CSimpleStringT.Truncate"
  - "CSimpleStringT<BaseType>::Truncate"
  - "Truncate"
  - "ATL.CSimpleStringT<BaseType>.Truncate"
  - "CSimpleStringT::Truncate"
  - "CSimpleStringT.Truncate"
  - "ATL::CSimpleStringT::Truncate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Truncate method"
ms.assetid: 47c8081b-85ea-4042-b890-67b802d8db9f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleStringT::Truncate
Truncates the string to the new length.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The new length of the string.  
  
## Remarks  
 Call this method to truncate the contents of the string to the new length.  
  
> [!NOTE]
>  This does not affect the allocated length of the buffer. To decrease or increase the current buffer, see [FreeExtra](../vs140/csimplestringt--freeextra.md) and [Preallocate](../vs140/csimplestringt--preallocate.md).  
  
## Example  
 The following example demonstrates the use of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 [!code[NVC_ATLMFC_Utilities#92](../vs140/codesnippet/CPP/csimplestringt--truncate_1.cpp)]  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)