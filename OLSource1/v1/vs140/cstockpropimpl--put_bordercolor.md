---
title: "CStockPropImpl::put_BorderColor"
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
  - "ATL::CStockPropImpl::put_BorderColor"
  - "CStockPropImpl::put_BorderColor"
  - "ATL.CStockPropImpl.put_BorderColor"
  - "CStockPropImpl.put_BorderColor"
  - "put_BorderColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "put_BorderColor method"
ms.assetid: 68d8c09c-61b7-462a-964d-4857fefcfad2
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStockPropImpl::put_BorderColor
Call this method to set the control's border color.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE put_BorderColor(  
   OLE_COLOR clrBorderColor  
);  
```  
  
#### Parameters  
 *clrBorderColor*  
 The new border color. The OLE_COLOR data type is internally represented as a 32-bit long integer.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CStockPropImpl Class](../vs140/cstockpropimpl-class.md)   
 [CStockPropImpl::get_BorderColor](../vs140/cstockpropimpl--get_bordercolor.md)