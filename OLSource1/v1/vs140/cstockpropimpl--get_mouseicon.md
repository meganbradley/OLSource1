---
title: "CStockPropImpl::get_MouseIcon"
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
  - CStockPropImpl::get_MouseIcon
  - CStockPropImpl.get_MouseIcon
  - ATL.CStockPropImpl.get_MouseIcon
  - ATL::CStockPropImpl::get_MouseIcon
  - get_MouseIcon
dev_langs: 
  - C++
helpviewer_keywords: 
  - get_MouseIcon method
ms.assetid: e297425b-efcc-45e1-acd3-c74aef873ad7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CStockPropImpl::get_MouseIcon
Call this method to get the picture properties of the graphic (icon, bitmap, or metafile) to be displayed when the mouse is over the control.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE get_MouseIcon(  
   IPictureDisp** ppPicture   
);  
```  
  
#### Parameters  
 `ppPicture`  
 Variable that receives a pointer to the picture properties of the graphic.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CStockPropImpl Class](../vs140/cstockpropimpl-class.md)   
 [CStockPropImpl::put_MouseIcon](../vs140/cstockpropimpl--put_mouseicon.md)