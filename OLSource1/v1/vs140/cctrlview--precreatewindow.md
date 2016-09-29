---
title: "CCtrlView::PreCreateWindow"
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
  - "CCtrlView::PreCreateWindow"
  - "CCtrlView.PreCreateWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PreCreateWindow method"
ms.assetid: c4885506-ec2b-4e18-9c80-ed658efd8b8b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCtrlView::PreCreateWindow
Called before the creation of the Windows window attached to this `CWnd` object.  
  
## Syntax  
  
```  
  
      virtual BOOL PreCreateWindow(  
   CREATESTRUCT& cs  
);  
```  
  
#### Parameters  
 *cs*  
 A [CREATESTRUCT](http://msdn.microsoft.com/library/windows/desktop/ms632603) structure.  
  
## Return Value  
 Nonzero if the window creation should continue; 0 to indicate creation failure.  
  
## Remarks  
 Never call this function directly.  
  
 The default implementation of this function checks for a **NULL** window class name and substitutes an appropriate default. Override this member function to modify the `CREATESTRUCT` structure before the window is created.  
  
 Each class derived from `CCtrlView` adds its own functionality to its override of `PreCreateWindow`. By design, these derivations of `PreCreateWindow` are not documented. To determine the styles appropriate to each class and the interdependencies between the styles, you can examine the MFC source code for your application's base class. If you choose to override `PreCreateWindow`, you can determine whether the styles used in your application's base class provide the functionality you need by using information gathered from the MFC source code.  
  
 For more information on changing window styles, see the [Changing the Styles of a Window Created by MFC](../vs140/changing-the-styles-of-a-window-created-by-mfc.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCtrlView Class](../vs140/cctrlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)