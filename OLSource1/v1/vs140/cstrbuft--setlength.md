---
title: "CStrBufT::SetLength"
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
  - "ATL.CStrBufT<TCharType>.SetLength"
  - "CStrBufT::SetLength"
  - "CStrBufT<TCharType>.SetLength"
  - "ATL::CStrBufT::SetLength"
  - "ATL::CStrBufT<TCharType>::SetLength"
  - "CStrBufT<TCharType>::SetLength"
  - "CStrBufT.SetLength"
  - "ATL.CStrBufT.SetLength"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetLength method"
ms.assetid: 3a4c99aa-d2df-4878-aa78-b3b50dd34981
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStrBufT::SetLength
Sets the length of the character buffer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The new length of the character buffer of the string object.  
  
> [!NOTE]
>  Must be less than or equal to the minimum buffer length specified in the constructor of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 Call this function to set the length of the string represented by the buffer object.  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CStrBufT Class](../vs140/cstrbuft-class.md)