---
title: "CD2DTextLayout::CD2DTextLayout"
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
  - CD2DTextLayout
  - afxrendertarget/CD2DTextLayout::CD2DTextLayout
dev_langs: 
  - C++
helpviewer_keywords: 
  - CD2DTextLayout class, constructor
ms.assetid: 7e72dbb7-0409-4afb-bcd7-5ea050f4149a
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CD2DTextLayout::CD2DTextLayout
Constructs a CD2DTextLayout object.  
  
## Syntax  
  
```  
CD2DTextLayout(  
   CRenderTarget* pParentTarget,  
   const CString& strText,  
   CD2DTextFormat& textFormat,  
   const CD2DSizeF& sizeMax,  
   BOOL bAutoDestroy = TRUE  
);  
```  
  
#### Parameters  
 `pParentTarget`  
 A pointer to the render target.  
  
 `strText`  
 A CString object that contains the string to create a new CD2DTextLayout object from.  
  
 `textFormat`  
 A CString object that contains the format to apply to the string.  
  
 `sizeMax`  
 The size of the layout box.  
  
 `bAutoDestroy`  
 Indicates that the object will be destroyed by owner (pParentTarget).  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DTextLayout Class](../vs140/cd2dtextlayout-class.md)