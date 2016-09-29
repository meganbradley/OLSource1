---
title: "CMFCRibbonButton::CMFCRibbonButton"
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
  - "CMFCRibbonButton"
  - "CMFCRibbonButton::CMFCRibbonButton"
  - "CMFCRibbonButton.CMFCRibbonButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonButton class, constructor"
ms.assetid: 14f0f5a1-fc94-44d9-b8d0-001609085bde
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonButton::CMFCRibbonButton
Constructs a ribbon button object.  
  
## Syntax  
  
```  
CMFCRibbonButton(  
   UINT nID,  
   LPCTSTR lpszText,  
   int nSmallImageIndex=-1,  
   int nLargeImageIndex=-1,  
   BOOL bAlwaysShowDescription=FALSE   
);  
CMFCRibbonButton(  
   UINT nID,  
   LPCTSTR lpszText,  
   HICON hIcon,  
   BOOL bAlwaysShowDescription=FALSE,  
   HICON hIconSmall=NULL,  
   BOOL bAutoDestroyIcon=FALSE,  
   BOOL bAlphaBlendIcon=FALSE   
);  
```  
  
#### Parameters  
 [in] `nID`  
 Specifies the command ID of the button.  
  
 [in] `lpszText`  
 Specifies the text label of the button.  
  
 [in] `nSmallImageIndex`  
 Specifies a zero-based index of the button's small image in the image list of the parent category.  
  
 [in] `nLargeImageIndex`  
 Specifies a zero-based index of the button's large image in the image list of the parent category.  
  
 [in] `hIcon`  
 Specifies a handle to the icon that the application uses as the button's image.  
  
## Example  
 The following example demonstrates how to construct a `CMFCRibbonButton` object.  
  
 [!code[NVC_MFC_RibbonApp#6](../vs140/codesnippet/CPP/cmfcribbonbutton--cmfcribbonbutton_1.cpp)]  
  
## Requirements  
 **Header:** afxribbonbutton.h  
  
## See Also  
 [CMFCRibbonButton Class](../vs140/cmfcribbonbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)