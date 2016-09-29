---
title: "CMFCRibbonEdit::CMFCRibbonEdit"
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
  - "CMFCRibbonEdit.CMFCRibbonEdit"
  - "CMFCRibbonEdit"
  - "CMFCRibbonEdit::CMFCRibbonEdit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonEdit, constructor"
ms.assetid: b38cd4e6-8844-4b4f-9b3d-8ac8d3d7715f
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonEdit::CMFCRibbonEdit
Constructs a [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) object.  
  
## Syntax  
  
```  
CMFCRibbonEdit(  
   UINT nID,  
   int nWidth,  
   LPCTSTR lpszLabel = NULL,  
   int nImage = -1  
);  
CMFCRibbonEdit();  
```  
  
#### Parameters  
 [in] `nID`  
 Command ID for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control.  
  
 [in] `nWidth`  
 The width, in pixels, of the text box for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control.  
  
 [in] `lpszLabel`  
 The label for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control.  
  
 [in] `nImage`  
 Index of the small image to use for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control. The collection of small images is maintained by the parent ribbon category.  
  
## Remarks  
 The [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control does not use a large image.  
  
## Requirements  
 **Header:** afxribbonedit.h  
  
## See Also  
 [CMFCRibbonEdit Class](../vs140/cmfcribbonedit-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)