---
title: "CD2DBitmap::CD2DBitmap"
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
  - CD2DBitmap
  - afxrendertarget/CD2DBitmap::CD2DBitmap
dev_langs: 
  - C++
helpviewer_keywords: 
  - CD2DBitmap class, constructor
ms.assetid: 89514bf5-f63f-4439-92dc-297219097cc2
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CD2DBitmap::CD2DBitmap
Constructs a CD2DBitmap object from resource.  
  
## Syntax  
  
```  
CD2DBitmap(  
   CRenderTarget* pParentTarget,  
   UINT uiResID,  
   LPCTSTR lpszType = NULL,  
   CD2DSizeU sizeDest = CD2DSizeU(0,  
   0),  
   BOOL bAutoDestroy = TRUE  
);  
CD2DBitmap(  
   CRenderTarget* pParentTarget,  
   LPCTSTR lpszPath,  
   CD2DSizeU sizeDest = CD2DSizeU(0,  
   0),  
   BOOL bAutoDestroy = TRUE  
);  
CD2DBitmap(  
   CRenderTarget* pParentTarget,  
   HBITMAP hbmpSrc,  
   CD2DSizeU sizeDest = CD2DSizeU(0,  
   0),  
   BOOL bAutoDestroy = TRUE  
);  
CD2DBitmap(  
   CRenderTarget* pParentTarget,  
   BOOL bAutoDestroy = TRUE  
);  
```  
  
#### Parameters  
 `pParentTarget`  
 A pointer to the render target.  
  
 `uiResID`  
 The resource ID number of the resource.  
  
 `lpszType`  
 Pointer to a null-terminated string that contains the resource type.  
  
 `sizeDest`  
 Destination size of the bitmap.  
  
 `bAutoDestroy`  
 Indicates that the object will be destroyed by owner (pParentTarget).  
  
 `lpszPath`  
 Pointer to a null-terminated string that contains the name of file.  
  
 `hbmpSrc`  
 Handle to the bitmap.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DBitmap Class](../vs140/cd2dbitmap-class.md)