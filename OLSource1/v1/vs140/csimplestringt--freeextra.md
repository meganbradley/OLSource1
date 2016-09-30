---
title: "CSimpleStringT::FreeExtra"
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
  - "CSimpleStringT<BaseType>::FreeExtra"
  - "ATL::CSimpleStringT<BaseType>::FreeExtra"
  - "CSimpleStringT::FreeExtra"
  - "ATL::CSimpleStringT::FreeExtra"
  - "ATL.CSimpleStringT.FreeExtra"
  - "ATL.CSimpleStringT<BaseType>.FreeExtra"
  - "CSimpleStringT.FreeExtra"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FreeExtra method"
ms.assetid: 448e8bb3-be9c-488f-aab0-443d87e7d126
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleStringT::FreeExtra
Frees any extra memory previously allocated by the string but no longer needed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This should reduce the memory overhead consumed by the string object. The method reallocates the buffer to the exact length returned by [GetLength](../vs140/csimplestringt--getlength.md).  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#79](../vs140/codesnippet/CPP/csimplestringt--freeextra_1.cpp)]  
  
## Remarks  
 The output from this example is as follows:  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)