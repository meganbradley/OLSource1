---
title: "CMFCRibbonUndoButton::CMFCRibbonUndoButton"
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
  - "CMFCRibbonUndoButton"
  - "CMFCRibbonUndoButton::CMFCRibbonUndoButton"
  - "CMFCRibbonUndoButton.CMFCRibbonUndoButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonUndoButton class, constructor"
ms.assetid: 9e4e718c-9e61-483f-ac5f-fd6ffd38be43
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonUndoButton::CMFCRibbonUndoButton
Constructs a new `CMFCRibbonUndoButton` object by using the command ID that you specify, text label and images from the image list of the parent object.  
  
## Syntax  
  
```  
CMFCRibbonUndoButton(  
   UINT nID,  
   LPCTSTR lpszText,  
   int nSmallImageIndex=-1,  
   int nLargeImageIndex=-1   
);  
CMFCRibbonUndoButton(  
   UINT nID,  
   LPCTSTR lpszText,  
   HICON hIcon   
);  
```  
  
#### Parameters  
 [in] `nID`  
 Specifies the command identifier.  
  
 [in] `lpszText`  
 Specifies the text label of the button.  
  
 [in] `nSmallImageIndex`  
 Zero-based index in the image list of the parent object for the button's small image.  
  
 [in] `nLargeImageIndex`  
 Zero-based index in the image list of the parent object for the of button's large image.  
  
 [in] `hIcon`  
 A handle to an icon that you can use as a button's image.  
  
## Requirements  
 **Header:** afxribbonundobutton.h  
  
## See Also  
 [CMFCRibbonUndoButton Class](../vs140/cmfcribbonundobutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)