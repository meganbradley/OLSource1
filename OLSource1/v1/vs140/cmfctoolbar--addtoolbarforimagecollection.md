---
title: "CMFCToolBar::AddToolBarForImageCollection"
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
  - "CMFCToolBar.AddToolBarForImageCollection"
  - "AddToolBarForImageCollection"
  - "CMFCToolBar::AddToolBarForImageCollection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddToolBarForImageCollection method"
ms.assetid: 621861a2-fd87-4df2-a1f1-7e907537bea2
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::AddToolBarForImageCollection
Adds images from the user interface resources to the collection of images in the application.  
  
## Syntax  
  
```  
static BOOL __stdcall AddToolBarForImageCollection(  
   UINT uiResID,  
   UINT uiBmpResID=0,  
   UINT uiColdResID=0,  
   UINT uiMenuResID=0,  
   UINT uiDisabledResID=0,  
   UINT uiMenuDisabledResID=0   
);  
```  
  
#### Parameters  
 [in] `uiResID`  
 Resource ID of a toolbar with images to load.  
  
 [in] `uiBmpResID`  
 Resource ID of a bitmap with toolbar images.  
  
 [in] `uiColdResID`  
 Resource ID of a bitmap with "cold" toolbar images.  
  
 [in] `uiMenuResID`  
 Resource ID of a bitmap with menu images.  
  
 [in] `uiDisabledResID`  
 Resource ID of a bitmap with disabled toolbar images.  
  
 [in] `uiMenuDisabledResID`  
 Resource ID of a bitmap with disabled menu images.  
  
## Return Value  
 `TRUE` if the method succeeds; `FALSE` if `uiResID` or `uiBmpResID` do not specify valid resources, or another error occurs.  
  
## Remarks  
 Call this method to load a bitmap with toolbar images and add it to the collection of toolbar images. This method creates a temporary toolbar object and calls [CMFCToolBar::LoadToolBar](../vs140/cmfctoolbar--loadtoolbar.md).  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::LoadToolBar](../vs140/cmfctoolbar--loadtoolbar.md)