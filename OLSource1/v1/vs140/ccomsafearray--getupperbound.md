---
title: "CComSafeArray::GetUpperBound"
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
  - "ATL::CComSafeArray::GetUpperBound"
  - "CComSafeArray::GetUpperBound"
  - "ATL.CComSafeArray.GetUpperBound"
  - "CComSafeArray.GetUpperBound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetUpperBound method"
ms.assetid: 4d8bc153-ce3b-473b-b6f6-4730fb1beb23
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSafeArray::GetUpperBound
Returns the upper bound for any dimension of the array.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The array dimension for which to get the upper bound. If omitted, the default is 0.  
  
## Return Value  
 Returns the upper bound. This value is inclusive, the maximum valid index for this dimension.  
  
## Remarks  
 In the event of an error, for example, an invalid dimension argument, this method calls <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> with an HRESULT describing the error.  
  
## Requirements  
 **Header:** atlsafe.h  
  
## See Also  
 [CComSafeArray Class](../vs140/ccomsafearray-class.md)   
 [CComSafeArray::GetLowerBound](../vs140/ccomsafearray--getlowerbound.md)   
 [CComSafeArray::GetCount](../vs140/ccomsafearray--getcount.md)