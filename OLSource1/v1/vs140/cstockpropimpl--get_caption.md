---
title: "CStockPropImpl::get_Caption"
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
  - get_Caption
  - ATL.CStockPropImpl.get_Caption
  - CStockPropImpl.get_Caption
  - ATL::CStockPropImpl::get_Caption
  - CStockPropImpl::get_Caption
dev_langs: 
  - C++
helpviewer_keywords: 
  - get_Caption method
ms.assetid: 884c3290-0b15-421d-b0cf-a380fb216213
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CStockPropImpl::get_Caption
Call this method to get the text specified in an object's caption.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE get_Caption(  
   BSTR * pbstrCaption  
);  
```  
  
#### Parameters  
 *pbstrCaption*  
 The text to be displayed with the control.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CStockPropImpl Class](../vs140/cstockpropimpl-class.md)   
 [CStockPropImpl::put_Caption](../vs140/cstockpropimpl--put_caption.md)