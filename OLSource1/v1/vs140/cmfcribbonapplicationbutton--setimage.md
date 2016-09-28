---
title: "CMFCRibbonApplicationButton::SetImage"
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
  - "SetImage"
  - "CMFCRibbonApplicationButton::SetImage"
  - "CMFCRibbonApplicationButton.SetImage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetImage method"
ms.assetid: d9659fd5-64ea-4bfd-814a-b006fb6b92c5
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonApplicationButton::SetImage
Assigns an image to the application button.  
  
## Syntax  
  
```  
void SetImage(  
   UINT uiBmpResID   
);  
void SetImage(  
   HBITMAP hBmp   
);  
```  
  
#### Parameters  
 [in] `uiBmpResID`  
 The resource ID of the image to display on the application button.  
  
 [in] `hBmp`  
 A handle to a bitmap to display on the application button.  
  
## Remarks  
 Use this method to assign a new image to the ribbon application button after you create the button. The application button is located in the upper-left corner of the application window.  
  
## Requirements  
 **Header:** afxRibbonBar.h  
  
## See Also  
 [CMFCRibbonApplicationButton Class](../vs140/cmfcribbonapplicationbutton-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)