---
title: "CComCurrency::GetFraction"
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
  - "ATL.CComCurrency.GetFraction"
  - "ATL::CComCurrency::GetFraction"
  - "CComCurrency::GetFraction"
  - "CComCurrency.GetFraction"
  - "GetFraction"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetFraction method"
ms.assetid: a9fad4ab-41c0-4e6d-9b90-667cf3870e6b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCurrency::GetFraction
Call this method to return the fractional component of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the fractional component of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> data member.  
  
## Remarks  
 The fractional component is a 4-digit integer value between -9999 (**CY_MIN_FRACTION**) and +9999 (**CY_MAX_FRACTION**). <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns this value scaled by 10000 (**CY_SCALE**). The values of **CY_MIN_FRACTION**, **CY_MAX_FRACTION**, and **CY_SCALE** are defined in atlcur.h.  
  
## Example  
 [!code[NVC_ATL_Utilities#50](../vs140/codesnippet/CPP/ccomcurrency--getfraction_1.cpp)]  
  
## Requirements  
 **Header:** atlcur.h  
  
## See Also  
 [CComCurrency Class](../vs140/ccomcurrency-class.md)   
 [CComCurrency::SetFraction](../vs140/ccomcurrency--setfraction.md)   
 [CComCurrency::GetInteger](../vs140/ccomcurrency--getinteger.md)   
 [CComCurrency::SetInteger](../vs140/ccomcurrency--setinteger.md)