---
title: "CSimpleStringT::Preallocate"
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
  - "ATL.CSimpleStringT.Preallocate"
  - "CSimpleStringT.Preallocate"
  - "CSimpleStringT<BaseType>::Preallocate"
  - "ATL::CSimpleStringT::Preallocate"
  - "ATL::CSimpleStringT<BaseType>::Preallocate"
  - "Preallocate"
  - "CSimpleStringT::Preallocate"
  - "ATL.CSimpleStringT<BaseType>.Preallocate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Preallocate method"
ms.assetid: 36e05a76-3d0b-4a5a-bd08-e8b2797c76f1
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleStringT::Preallocate
Allocates a specific amount of bytes for the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The exact size of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> character buffer in characters.  
  
## Remarks  
 Call this method to allocate a specific buffer size for the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> generates a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> exception if it is unable to allocate space for the character buffer. By default, memory allocation is performed by WIN32 API functions <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Example  
 The following example demonstrates the use of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 [!code[NVC_ATLMFC_Utilities#86](../vs140/codesnippet/CPP/csimplestringt--preallocate_1.cpp)]  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)