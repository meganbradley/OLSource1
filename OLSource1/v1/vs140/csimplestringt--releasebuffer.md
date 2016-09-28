---
title: "CSimpleStringT::ReleaseBuffer"
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
  - "ATL::CSimpleStringT::ReleaseBuffer"
  - "ATL.CSimpleStringT.ReleaseBuffer"
  - "CSimpleStringT<BaseType>::ReleaseBuffer"
  - "CSimpleStringT.ReleaseBuffer"
  - "CSimpleStringT::ReleaseBuffer"
  - "ATL::CSimpleStringT<BaseType>::ReleaseBuffer"
  - "ReleaseBuffer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ReleaseBuffer method"
ms.assetid: ff0a3476-a7c4-4dc4-89fc-713fcfcdab16
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleStringT::ReleaseBuffer
Releases control of the buffer allocated by [GetBuffer](../vs140/csimplestringt--getbuffer.md).  
  
## Syntax  
  
```  
  
      void ReleaseBuffer(  
   int nNewLength = -1  
);  
```  
  
#### Parameters  
 `nNewLength`  
 The new length of the string in characters, not counting a null terminator. If the string is null terminated, the -1 default value sets the `CSimpleStringT` size to the current length of the string.  
  
## Remarks  
 Call this method to reallocate or free up the buffer of the string object. If you know that the string in the buffer is null terminated, you can omit the `nNewLength` argument. If your string is not null terminated, use `nNewLength` to specify its length. The address returned by [GetBuffer](../vs140/csimplestringt--getbuffer.md) is invalid after the call to `ReleaseBuffer` or any other `CSimpleStringT` operation.  
  
## Example  
 The following example demonstrates the use of `CSimpleStringT::ReleaseBuffer`.  
  
 [!code[NVC_ATLMFC_Utilities#87](../vs140/codesnippet/CPP/csimplestringt--releasebuffer_1.cpp)]  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)