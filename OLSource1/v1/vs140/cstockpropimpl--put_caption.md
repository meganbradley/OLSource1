---
title: "CStockPropImpl::put_Caption"
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
  - CStockPropImpl.put_Caption
  - ATL.CStockPropImpl.put_Caption
  - ATL::CStockPropImpl::put_Caption
  - put_Caption
  - CStockPropImpl::put_Caption
dev_langs: 
  - C++
helpviewer_keywords: 
  - put_Caption method
ms.assetid: 381ce56c-d55d-4e0c-89b1-8e8fbd781eaf
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CStockPropImpl::put_Caption
Call this method to set the text to be displayed with the control.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE put_Caption(  
   BSTR bstrCaption  
);  
```  
  
#### Parameters  
 *bstrCaption*  
 The text to be displayed with the control.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CStockPropImpl Class](../vs140/cstockpropimpl-class.md)   
 [CStockPropImpl::get_Caption](../vs140/cstockpropimpl--get_caption.md)