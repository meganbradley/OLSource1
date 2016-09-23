---
title: "CComVariant::Attach"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CComVariant.Attach
  - ATL::CComVariant::Attach
  - CComVariant::Attach
  - ATL.CComVariant.Attach
dev_langs: 
  - C++
helpviewer_keywords: 
  - Attach method [ATL]
ms.assetid: 9f9926e5-cc23-4304-8917-36f624a1d5e0
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComVariant::Attach
Safely clears the current contents of the `CComVariant` object, copies the contents of `pSrc` into this object, then sets the variant type of `pSrc` to `VT_EMPTY`.  
  
## Syntax  
  
```  
  
      HRESULT Attach(  
   VARIANT* pSrc   
);  
```  
  
#### Parameters  
 `pSrc`  
 [in] Points to the [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) to be attached to the object.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 Ownership of the data held by `pSrc` is transferred to the `CComVariant` object.  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [CComVariant Class](../vs140/ccomvariant-class.md)   
 [CComVariant::Detach](../vs140/ccomvariant--detach.md)