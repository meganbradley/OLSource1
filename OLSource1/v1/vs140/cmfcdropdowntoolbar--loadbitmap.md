---
title: "CMFCDropDownToolBar::LoadBitmap"
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
  - "CMFCDropDownToolBar.LoadBitmap"
  - "CMFCDropDownToolBar::LoadBitmap"
  - "LoadBitmap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadBitmap method"
ms.assetid: 3403bf57-b376-4a5c-9659-2b6acd495fe6
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCDropDownToolBar::LoadBitmap
Loads toolbar images from application resources.  
  
## Syntax  
  
```  
virtual BOOL LoadBitmap(  
   UINT uiResID,  
   UINT uiColdResID=0,  
   UINT uiMenuResID=0,  
   BOOL bLocked=FALSE,  
   UINT uiDisabledResID=0,  
   UINT uiMenuDisabledResID=0   
);  
```  
  
#### Parameters  
 [in] `uiResID`  
 The resource ID of the bitmap that refers to the hot toolbar images.  
  
 [in] `uiColdResID`  
 The resource ID of the bitmap that refers to the cold toolbar images.  
  
 [in] `uiMenuResID`  
 The resource ID of the bitmap that refers to the regular menu images.  
  
 [in] `bLocked`  
 `TRUE` to lock the toolbar; otherwise `FALSE`.  
  
 [in] `uiDisabledResID`  
 The resource ID of the bitmap that refers to the disabled toolbar images.  
  
 [in] `uiMenuDisabledResID`  
 The resource ID of the bitmap that refers to the disabled menu images.  
  
## Return Value  
 Nonzero if the method succeeds; otherwise 0.  
  
## Remarks  
 The [CMFCToolBar::LoadToolBarEx](../vs140/cmfctoolbar--loadtoolbarex.md) method calls this method to load the images that are associated with the toolbar. Override this method to perform custom loading of image resources.  
  
 Call the `LoadBitmapEx` method to load additional images after you create the toolbar.  
  
## Requirements  
 **Header:** afxdropdowntoolbar.h  
  
## See Also  
 [CMFCDropDownToolBar Class](../vs140/cmfcdropdowntoolbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)