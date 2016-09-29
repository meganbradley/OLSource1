---
title: "CStockPropImpl::get_ReadyState"
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
  - "get_ReadyState"
  - "ATL::CStockPropImpl::get_ReadyState"
  - "CStockPropImpl.get_ReadyState"
  - "ATL.CStockPropImpl.get_ReadyState"
  - "CStockPropImpl::get_ReadyState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_ReadyState method"
ms.assetid: 528085c0-7ddc-45f0-97cf-44d7767e5ee3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStockPropImpl::get_ReadyState
Call this method to get the control's ready state, for example, loading or loaded.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE get_ReadyState(  
   LONG * pnReadyState  
);  
```  
  
#### Parameters  
 *pnReadyState*  
 Variable that receives the control's ready state.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CStockPropImpl Class](../vs140/cstockpropimpl-class.md)   
 [CStockPropImpl::put_ReadyState](../vs140/cstockpropimpl--put_readystate.md)