---
title: "CStockPropImpl::put_MouseIcon"
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
  - "put_MouseIcon"
  - "CStockPropImpl::put_MouseIcon"
  - "ATL::CStockPropImpl::put_MouseIcon"
  - "ATL.CStockPropImpl.put_MouseIcon"
  - "CStockPropImpl.put_MouseIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "put_MouseIcon method"
ms.assetid: d31243ca-ad22-4421-a598-3eb1f92f4457
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStockPropImpl::put_MouseIcon
Call this method to set the picture properties of the graphic (icon, bitmap, or metafile) to be displayed when the mouse is over the control.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE put_MouseIcon(  
   IPictureDisp* pPicture   
);  
```  
  
#### Parameters  
 `pPicture`  
 A pointer to the picture properties of the graphic.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CStockPropImpl Class](../vs140/cstockpropimpl-class.md)   
 [CStockPropImpl::get_MouseIcon](../vs140/cstockpropimpl--get_mouseicon.md)   
 [CStockPropImpl::putref_MouseIcon](../vs140/cstockpropimpl--putref_mouseicon.md)