---
title: "CStockPropImpl::put_TabStop"
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
  - "ATL::CStockPropImpl::put_TabStop"
  - "CStockPropImpl.put_TabStop"
  - "CStockPropImpl::put_TabStop"
  - "ATL.CStockPropImpl.put_TabStop"
  - "put_TabStop"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "put_TabStop method"
ms.assetid: 30be4763-bd53-46b6-8d8e-5ac9630ffb60
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStockPropImpl::put_TabStop
Call this method to set the flag that indicates if the control is a tab stop or not.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE put_TabStop(  
   VARIANT_BOOL bTabStop  
);  
```  
  
#### Parameters  
 *bTabStop*  
 TRUE if the control is a tab stop.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CStockPropImpl Class](../vs140/cstockpropimpl-class.md)   
 [CStockPropImpl::get_TabStop](../vs140/cstockpropimpl--get_tabstop.md)