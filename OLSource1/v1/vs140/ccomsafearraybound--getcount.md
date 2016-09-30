---
title: "CComSafeArrayBound::GetCount"
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
  - "ATL.CComSafeArrayBound.GetCount"
  - "ATL::CComSafeArrayBound::GetCount"
  - "CComSafeArrayBound.GetCount"
  - "CComSafeArrayBound::GetCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCount method [ATL]"
ms.assetid: 7c33d699-225d-4570-8368-ce11754c4d6b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSafeArrayBound::GetCount
Call this method to return the number of elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the number of elements.  
  
## Remarks  
 If the associated <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object represents a multidimensional array, this method will only return the total number of elements in the rightmost dimension. Use [CComSafeArray::GetCount](../vs140/ccomsafearray--getcount.md) to obtain the total number of elements.  
  
## Requirements  
 **Header:** atlsafe.h  
  
## See Also  
 [CComSafeArrayBound Class](../vs140/ccomsafearraybound-class.md)   
 [CComSafeArray::GetCount](../vs140/ccomsafearray--getcount.md)