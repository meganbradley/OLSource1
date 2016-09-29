---
title: "CStockPropImpl::put_Picture"
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
  - "CStockPropImpl::put_Picture"
  - "ATL.CStockPropImpl.put_Picture"
  - "ATL::CStockPropImpl::put_Picture"
  - "put_Picture"
  - "CStockPropImpl.put_Picture"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "put_Picture method"
ms.assetid: 7901ae51-d4cc-46e2-a1fa-618fe410e83d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStockPropImpl::put_Picture
Call this method to set the picture properties of a graphic (icon, bitmap, or metafile) to be displayed.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE put_Picture(  
   IPictureDisp* pPicture   
);  
```  
  
#### Parameters  
 `pPicture`  
 A pointer to the picture's properties. See [IPictureDisp](http://msdn.microsoft.com/library/windows/desktop/ms680762) for more details.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CStockPropImpl Class](../vs140/cstockpropimpl-class.md)   
 [CStockPropImpl::get_Picture](../vs140/cstockpropimpl--get_picture.md)   
 [CStockPropImpl::putref_Picture](../vs140/cstockpropimpl--putref_picture.md)