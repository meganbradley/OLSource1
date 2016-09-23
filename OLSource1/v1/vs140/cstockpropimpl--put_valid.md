---
title: "CStockPropImpl::put_Valid"
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
  - ATL::CStockPropImpl::put_Valid
  - CStockPropImpl.put_Valid
  - ATL.CStockPropImpl.put_Valid
  - CStockPropImpl::put_Valid
  - put_Valid
dev_langs: 
  - C++
helpviewer_keywords: 
  - put_Valid method
ms.assetid: 6ac432b7-cabd-49cd-bac4-85c60dbacc78
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CStockPropImpl::put_Valid
Call this method to set the flag that indicates if the control is valid or not.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE get_Valid(   
   VARIANT_BOOL bValid  
);  
```  
  
#### Parameters  
 *bValid*  
 TRUE if the control is valid.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CStockPropImpl Class](../vs140/cstockpropimpl-class.md)   
 [CStockPropImpl::get_Valid](../vs140/cstockpropimpl--get_valid.md)