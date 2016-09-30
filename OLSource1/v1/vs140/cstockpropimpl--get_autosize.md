---
title: "CStockPropImpl::get_AutoSize"
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
  - "get_AutoSize"
  - "ATL::CStockPropImpl::get_AutoSize"
  - "ATL.CStockPropImpl.get_AutoSize"
  - "CStockPropImpl.get_AutoSize"
  - "CStockPropImpl::get_AutoSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_AutoSize method"
ms.assetid: e55eb416-6c03-4a54-b0f2-e1db202c016c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStockPropImpl::get_AutoSize
Call this method to get the status of the flag that indicates if the control cannot be any other size.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE get_Autosize(  
   VARIANT_BOOL * pbAutoSize  
);  
```  
  
#### Parameters  
 *pbAutoSize*  
 Variable that receives the flag status. TRUE indicates that the control cannot be any other size.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CStockPropImpl Class](../vs140/cstockpropimpl-class.md)   
 [CStockPropImpl::put_AutoSize](../vs140/cstockpropimpl--put_autosize.md)