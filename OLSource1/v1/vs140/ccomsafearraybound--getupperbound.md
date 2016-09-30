---
title: "CComSafeArrayBound::GetUpperBound"
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
  - "ATL.CComSafeArrayBound.GetUpperBound"
  - "CComSafeArrayBound.GetUpperBound"
  - "ATL::CComSafeArrayBound::GetUpperBound"
  - "CComSafeArrayBound::GetUpperBound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetUpperBound method"
ms.assetid: 81d865a5-a0ce-449b-9e44-74c088188b9d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSafeArrayBound::GetUpperBound
Call this method to return the upper bound.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the upper bound of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Remarks  
 The upper bound depends on the number of elements and the lower bound value. For example, if the lower bound is 0 and the number of elements is 10, the upper bound will automatically be set to 9.  
  
## Requirements  
 **Header:** atlsafe.h  
  
## See Also  
 [CComSafeArrayBound Class](../vs140/ccomsafearraybound-class.md)   
 [CComSafeArrayBound::GetCount](../vs140/ccomsafearraybound--getcount.md)   
 [CComSafeArrayBound::GetLowerBound](../vs140/ccomsafearraybound--getlowerbound.md)