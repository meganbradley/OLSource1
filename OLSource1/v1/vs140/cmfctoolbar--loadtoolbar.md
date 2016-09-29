---
title: "CMFCToolBar::LoadToolBar"
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
  - "CMFCToolBar::LoadToolBar"
  - "LoadToolBar"
  - "CMFCToolBar.LoadToolBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadToolBar method"
ms.assetid: 44a42479-f6eb-4397-8369-42c2cd5c95f9
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::LoadToolBar
Loads the toolbar from application resources.  
  
## Syntax  
  
```  
virtual BOOL LoadToolBar(  
   UINT uiResID,  
   UINT uiColdResID=0,  
   UINT uiMenuResID=0,  
   BOOL bLocked=FALSE,  
   UINT uiDisabledResID=0,  
   UINT uiMenuDisabledResID=0,  
   UINT uiHotResID=0   
);  
```  
  
#### Parameters  
 [in] `uiResID`  
 The resource ID of the toolbar.  
  
 [in] `uiColdResID`  
 The resource ID of the bitmap that refers to the cold toolbar images.  
  
 [in] `uiMenuResID`  
 The resource ID of the bitmap that refers to the regular menu images.  
  
 [in] `bLocked`  
 A Boolean value that specifies whether the toolbar is locked or not. If this parameter is `TRUE`, the toolbar is locked. Otherwise, the toolbar is not locked.  
  
 [in] `uiDisabledResID`  
 The resource ID of the bitmap that refers to the disabled toolbar images.  
  
 [in] `uiMenuDisabledResID`  
 The resource ID of the bitmap that refers to the disabled menu images.  
  
 [in] `uiHotResID`  
 The resource ID of the bitmap that refers to the hot toolbar images.  
  
## Return Value  
 Nonzero if the method succeeds; otherwise 0.  
  
## Remarks  
 The framework calls this method during initialization to load the images that are associated with the toolbar.  
  
## Example  
 The following example demonstrates how to use the `LoadToolBar` method in the `CMFCToolBar` class. This code snippet is part of the [IE Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_IEDemo#6](../vs140/codesnippet/CPP/cmfctoolbar--loadtoolbar_1.h)]  
[!code[NVC_MFC_IEDemo#7](../vs140/codesnippet/CPP/cmfctoolbar--loadtoolbar_2.cpp)]  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)