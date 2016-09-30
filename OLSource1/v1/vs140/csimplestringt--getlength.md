---
title: "CSimpleStringT::GetLength"
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
  - "ATL.CSimpleStringT.GetLength"
  - "CSimpleStringT<BaseType>::GetLength"
  - "ATL::CSimpleStringT<BaseType>::GetLength"
  - "ATL::CSimpleStringT::GetLength"
  - "CSimpleStringT.GetLength"
  - "ATL.CSimpleStringT<BaseType>.GetLength"
  - "CSimpleStringT::GetLength"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetLength method"
ms.assetid: 1dd781f7-b3d7-441f-8fd6-7fd614c33c97
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleStringT::GetLength
Returns the number of characters in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A count of the characters in the string.  
  
## Remarks  
 Call this method to return the number of characters in the object. The count does not include a null terminator.  
  
 For multibyte character sets (MBCS), <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> counts each 8-bit character; that is, a lead and trail byte in one multibyte character are counted as two bytes. See [FreeExtra](../vs140/csimplestringt--freeextra.md) for an example of calling this function.  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)   
 [CSimpleStringT::IsEmpty](../vs140/csimplestringt--isempty.md)