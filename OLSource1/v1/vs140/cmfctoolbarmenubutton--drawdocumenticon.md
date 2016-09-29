---
title: "CMFCToolBarMenuButton::DrawDocumentIcon"
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
  - "CMFCToolBarMenuButton.DrawDocumentIcon"
  - "DrawDocumentIcon"
  - "CMFCToolBarMenuButton::DrawDocumentIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawDocumentIcon method"
ms.assetid: bda62154-2f76-46ac-8ffc-de9d5c2b50db
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarMenuButton::DrawDocumentIcon
Draws a document icon on the menu button.  
  
## Syntax  
  
```  
void DrawDocumentIcon(  
   CDC* pDC,  
   const CRect& rectImage,  
   HICON hIcon   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to the device context.  
  
 [in] `rectImage`  
 Coordinates of the image bounding rectangle.  
  
 [in] `hIcon`  
 A handle to the icon.  
  
## Remarks  
 This method takes a document icon and draws it on the menu button, centered in the area specified by `rectImage`.  
  
## Requirements  
 **Header:** afxtoolbarmenubutton.h  
  
## See Also  
 [CMFCToolBarMenuButton Class](../vs140/cmfctoolbarmenubutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)