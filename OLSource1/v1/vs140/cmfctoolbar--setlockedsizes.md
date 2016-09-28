---
title: "CMFCToolBar::SetLockedSizes"
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
  - "CMFCToolBar::SetLockedSizes"
  - "SetLockedSizes"
  - "CMFCToolBar.SetLockedSizes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetLockedSizes method"
ms.assetid: dfe882ab-dc53-4051-b038-b5aedfdeda82
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::SetLockedSizes
Sets the sizes of locked buttons and locked images on the toolbar.  
  
## Syntax  
  
```  
void SetLockedSizes(  
   SIZE sizeButton,  
   SIZE sizeImage,  
   BOOL bDontScale = FALSE  
);  
```  
  
#### Parameters  
 [in] `sizeButton`  
 Specifies the size of locked toolbar buttons.  
  
 [in] `sizeImage`  
 Specifies the size of locked toolbar images.  
  
 `bDontScale`  
 Specifies whether to scale or not locked toolbar images in high DPI mode.  
  
## Remarks  
 The default size of locked buttons is 23x22 pixels. The default size of locked images is 16x15 pixels.  
  
 Call the [CMFCToolBar::GetLockedImageSize](../vs140/cmfctoolbar--getlockedimagesize.md) method to retrieve the size of locked images. Call the [CMFCToolBar::GetButtonSize](../vs140/cmfctoolbar--getbuttonsize.md) method to retrieve the size of locked toolbar buttons.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::GetLockedImageSize](../vs140/cmfctoolbar--getlockedimagesize.md)   
 [CMFCToolBar::GetButtonSize](../vs140/cmfctoolbar--getbuttonsize.md)