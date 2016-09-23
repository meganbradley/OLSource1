---
title: "CStockPropImpl::putref_MouseIcon"
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
  - CStockPropImpl.putref_MouseIcon
  - ATL.CStockPropImpl.putref_MouseIcon
  - putref_MouseIcon
  - ATL::CStockPropImpl::putref_MouseIcon
  - CStockPropImpl::putref_MouseIcon
dev_langs: 
  - C++
helpviewer_keywords: 
  - putref_MouseIcon method
ms.assetid: d7c4606c-bc8e-44bb-9b15-85fbad03480f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CStockPropImpl::putref_MouseIcon
Call this method to set the picture properties of the graphic (icon, bitmap, or metafile) to be displayed when the mouse is over the control, with a reference count.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE putref_MouseIcon(  
   IPictureDisp* pPicture   
);  
```  
  
#### Parameters  
 `pPicture`  
 A pointer to the picture properties of the graphic.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 The same as [CStockPropImpl::put_MouseIcon](../vs140/cstockpropimpl--put_mouseicon.md), but with a reference count.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CStockPropImpl Class](../vs140/cstockpropimpl-class.md)   
 [CStockPropImpl::put_MouseIcon](../vs140/cstockpropimpl--put_mouseicon.md)