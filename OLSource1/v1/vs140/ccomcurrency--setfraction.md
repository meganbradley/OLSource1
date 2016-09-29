---
title: "CComCurrency::SetFraction"
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
  - "CComCurrency.SetFraction"
  - "ATL.CComCurrency.SetFraction"
  - "ATL::CComCurrency::SetFraction"
  - "CComCurrency::SetFraction"
  - "SetFraction"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetFraction method"
ms.assetid: 5c9491cb-dd83-4ade-b496-b48b4d97542f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCurrency::SetFraction
Call this method to set the fractional component of a `CComCurrency` object.  
  
## Syntax  
  
```  
  
      HRESULT SetFraction(  
   SHORT nFraction   
);  
```  
  
#### Parameters  
 *nFraction*  
 The value to be assigned to the fractional component of the `m_currency` data member. The sign of the fractional component must the same as the integer component, and the value must be in range -9999 (**CY_MIN_FRACTION**) to +9999 (**CY_MAX_FRACTION**).  
  
## Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
## Example  
 [!code[NVC_ATL_Utilities#53](../vs140/codesnippet/CPP/ccomcurrency--setfraction_1.cpp)]  
  
## Requirements  
 **Header:** atlcur.h  
  
## See Also  
 [CComCurrency Class](../vs140/ccomcurrency-class.md)   
 [CComCurrency::GetFraction](../vs140/ccomcurrency--getfraction.md)   
 [CComCurrency::SetInteger](../vs140/ccomcurrency--setinteger.md)   
 [CComCurrency::SetInteger](../vs140/ccomcurrency--setinteger.md)