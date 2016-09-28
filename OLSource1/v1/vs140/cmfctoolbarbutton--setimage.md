---
title: "CMFCToolBarButton::SetImage"
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
  - "CMFCToolBarButton.SetImage"
  - "SetImage"
  - "CMFCToolBarButton::SetImage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetImage method"
ms.assetid: 17b33020-ac0e-4dc2-9514-146bf0d4eb1b
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::SetImage
Sets the image index of the button.  
  
## Syntax  
  
```  
virtual void SetImage(  
   int iImage   
);  
```  
  
#### Parameters  
 [in] `iImage`  
 The index of the image in the collection of toolbar images.  
  
## Remarks  
 If the toolbar button is a separator, `iImage` refers to the new width of the separator button.  
  
 If `iImage` is less than zero, this method disables drawing of the image and enables drawing of the text label of the button.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::GetImage](../vs140/cmfctoolbarbutton--getimage.md)