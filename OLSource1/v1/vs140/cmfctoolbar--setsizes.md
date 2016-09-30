---
title: "CMFCToolBar::SetSizes"
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
  - "CMFCToolBar.SetSizes"
  - "CMFCToolBar::SetSizes"
  - "SetSizes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetSizes method"
ms.assetid: 46be0f44-a140-474d-bd8a-34b6847aaf5a
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::SetSizes
Specifies the sizes of buttons and images on all toolbars.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The size of toolbar buttons, in pixels.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The size of toolbar button images, in pixels.  
  
## Remarks  
 The default size of toolbar buttons is 23x22 pixels. The default size of toolbar button images is 16x15 pixels.  
  
 Call the [CMFCToolBar::GetImageSize](../vs140/cmfctoolbar--getimagesize.md) method to retrieve the size of toolbar button images. Call the [CMFCToolBar::GetButtonSize](../vs140/cmfctoolbar--getbuttonsize.md) method to retrieve the size of toolbar buttons.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::GetImageSize](../vs140/cmfctoolbar--getimagesize.md)   
 [CMFCToolBar::GetButtonSize](../vs140/cmfctoolbar--getbuttonsize.md)