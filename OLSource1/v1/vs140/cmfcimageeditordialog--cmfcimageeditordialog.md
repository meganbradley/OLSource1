---
title: "CMFCImageEditorDialog::CMFCImageEditorDialog"
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
  - CMFCImageEditorDialog.CMFCImageEditorDialog
  - CMFCImageEditorDialog::CMFCImageEditorDialog
  - CMFCImageEditorDialog
dev_langs: 
  - C++
helpviewer_keywords: 
  - CMFCImageEditorDialog class, constructor
ms.assetid: 59a0ef1e-65cc-4b40-9f72-78bb575562eb
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCImageEditorDialog::CMFCImageEditorDialog
Constructs a `CMFCImageEditorDialog` object.  
  
## Syntax  
  
```  
CMFCImageEditorDialog(  
   CBitmap* pBitmap,  
   CWnd* pParent=NULL,  
   int nBitsPixel=-1   
);  
```  
  
#### Parameters  
 `pBitmap`  
 Pointer to an image.  
  
 `pParent`  
 Pointer to the parent window of the current image editor dialog box.  
  
 `nBitsPixel`  
 The number of bits used to represent the color of a single pixel, which is also referred to as color depth.  If the `nBitsPixel` parameter is -1, the color depth is derived from the image specified by the `pBitmap` parameter. The default value is -1.  
  
## Return Value  
 To modify an image, pass an image pointer to the `CMFCImageEditorDialog` constructor. Then call the `DoModal` method to open a modal dialog box. When the `DoModal` method returns, the bitmap contains the new image.  
  
## Remarks  
  
## Example  
 The following example demonstrates how to construct an object of the `CMFCImageEditorDialog` class. This example is part of the [New Controls sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_NewControls#8](../vs140/codesnippet/CPP/cmfcimageeditordialog--cmfcimageeditordialog_1.cpp)]
  
[!code[NVC_MFC_NewControls#40](../vs140/codesnippet/CPP/cmfcimageeditordialog--cmfcimageeditordialog_2.cpp)]
  
  
## Requirements  
 **Header:** afximageeditordialog.h  
  
## See Also  
 [CMFCImageEditorDialog Class](../vs140/cmfcimageeditordialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)