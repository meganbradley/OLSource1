---
title: "CStockPropImpl::put_BorderVisible"
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
  - "CStockPropImpl.put_BorderVisible"
  - "ATL::CStockPropImpl::put_BorderVisible"
  - "ATL.CStockPropImpl.put_BorderVisible"
  - "put_BorderVisible"
  - "CStockPropImpl::put_BorderVisible"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "put_BorderVisible method"
ms.assetid: 4d55adea-af5b-4d56-b938-91667477107a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStockPropImpl::put_BorderVisible
Call this method to set the value of the flag that indicates if the control's border is visible or not.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE put_BorderVisible(  
   VARIANT_BOOL bBorderVisible  
);  
```  
  
#### Parameters  
 *bBorderVisible*  
 TRUE if the border is to be visible.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CStockPropImpl Class](../vs140/cstockpropimpl-class.md)   
 [CStockPropImpl::get_BorderVisible](../vs140/cstockpropimpl--get_bordervisible.md)