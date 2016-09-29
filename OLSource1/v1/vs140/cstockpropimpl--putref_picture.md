---
title: "CStockPropImpl::putref_Picture"
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
  - "ATL.CStockPropImpl.putref_Picture"
  - "CStockPropImpl.putref_Picture"
  - "ATL::CStockPropImpl::putref_Picture"
  - "putref_Picture"
  - "CStockPropImpl::putref_Picture"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "putref_Picture method"
ms.assetid: 38c575a2-af79-41ee-a6cd-08de00113e0c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStockPropImpl::putref_Picture
Call this method to set the picture properties of a graphic (icon, bitmap, or metafile) to be displayed, with a reference count.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE putref_Picture(  
   IPictureDisp* pPicture   
);  
```  
  
#### Parameters  
 `pPicture`  
 A pointer to the picture's properties. See [IPictureDisp](http://msdn.microsoft.com/library/windows/desktop/ms680762) for more details.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 The same as [CStockPropImpl::put_Picture](../vs140/cstockpropimpl--put_picture.md), but with a reference count.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CStockPropImpl Class](../vs140/cstockpropimpl-class.md)   
 [CStockPropImpl::put_Picture](../vs140/cstockpropimpl--put_picture.md)