---
title: "CStrBufT::operator PXSTR"
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
  - "operatorPXSTR"
  - "CStrBufT.operatorPXSTR"
  - "PXSTR"
  - "CStrBufT::operatorPXSTR"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator PXSTR"
ms.assetid: 8e8b4fd3-c4a8-48ea-a126-798bd7cc75f4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStrBufT::operator PXSTR
Directly accesses characters stored in the associated string object as a C-style string.  
  
## Syntax  
  
```  
  
operator PXSTR( ) throw( );  
  
```  
  
## Return Value  
 A character pointer to the string's data.  
  
## Remarks  
 Call this function to return a pointer to the character buffer of a string object. The developer may change the contents of the string object with this pointer.  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CStrBufT Class](../vs140/cstrbuft-class.md)   
 [CStrBufT::operator PCXSTR](../vs140/cstrbuft--operator-pcxstr.md)   
 [CStrBufT::PXSTR](../vs140/cstrbuft--pxstr.md)