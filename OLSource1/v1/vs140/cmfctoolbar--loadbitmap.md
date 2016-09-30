---
title: "CMFCToolBar::LoadBitmap"
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
  - "LoadBitmap"
  - "CMFCToolBar.LoadBitmap"
  - "CMFCToolBar::LoadBitmap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadBitmap method"
ms.assetid: 644659e0-dc98-4473-b771-309381ee392a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::LoadBitmap
Loads toolbar images from application resources.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The resource ID of the bitmap that refers to the hot toolbar images.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The resource ID of the bitmap that refers to the cold toolbar images.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The resource ID of the bitmap that refers to the regular menu images.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to lock the toolbar; otherwise <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The resource ID of the bitmap that refers to the disabled toolbar images.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The resource ID of the bitmap that refers to the disabled menu images.  
  
## Return Value  
 Nonzero if the method succeeds; otherwise 0.  
  
## Remarks  
 The [CMFCToolBar::LoadToolBarEx](../vs140/cmfctoolbar--loadtoolbarex.md) method calls this method to load the images that are associated with the toolbar. Override this method to perform custom loading of image resources.  
  
 Call the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method to load additional images after you create the toolbar.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::LoadToolBarEx](../vs140/cmfctoolbar--loadtoolbarex.md)