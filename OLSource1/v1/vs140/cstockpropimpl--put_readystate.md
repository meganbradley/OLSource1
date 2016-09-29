---
title: "CStockPropImpl::put_ReadyState"
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
  - "ATL::CStockPropImpl::put_ReadyState"
  - "ATL.CStockPropImpl.put_ReadyState"
  - "CStockPropImpl.put_ReadyState"
  - "put_ReadyState"
  - "CStockPropImpl::put_ReadyState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "put_ReadyState method"
ms.assetid: 36c56355-3ee4-4e43-ac1d-c97e671570a1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStockPropImpl::put_ReadyState
Call this method to set the control's ready state, for example, loading or loaded.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE put_ReadyState(  
   LONG nReadyState  
);  
```  
  
#### Parameters  
 *nReadyState*  
 The control's ready state.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CStockPropImpl Class](../vs140/cstockpropimpl-class.md)   
 [CStockPropImpl::get_ReadyState](../vs140/cstockpropimpl--get_readystate.md)