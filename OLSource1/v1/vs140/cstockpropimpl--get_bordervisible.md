---
title: "CStockPropImpl::get_BorderVisible"
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
  - "ATL.CStockPropImpl.get_BorderVisible"
  - "get_BorderVisible"
  - "CStockPropImpl::get_BorderVisible"
  - "CStockPropImpl.get_BorderVisible"
  - "ATL::CStockPropImpl::get_BorderVisible"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_BorderVisible method"
ms.assetid: 0c2a57bc-8c74-4fb0-bf53-b3a01338445b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStockPropImpl::get_BorderVisible
Call this method to get the status of the flag that indicates if the control's border is visible or not.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE get_BorderVisible(  
   VARIANT_BOOL * pbBorderVisible  
);  
```  
  
#### Parameters  
 *pbBorderVisible*  
 Variable that receives the flag status. TRUE indicates that the control's border is visible.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CStockPropImpl Class](../vs140/cstockpropimpl-class.md)   
 [CStockPropImpl::put_BorderVisible](../vs140/cstockpropimpl--put_bordervisible.md)