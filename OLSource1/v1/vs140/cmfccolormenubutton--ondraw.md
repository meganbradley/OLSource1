---
title: "CMFCColorMenuButton::OnDraw"
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
  - "OnDraw"
  - "CMFCColorMenuButton.OnDraw"
  - "CMFCColorMenuButton::OnDraw"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDraw method"
ms.assetid: df74d39a-28aa-4540-9ef0-5f60d81de7a3
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorMenuButton::OnDraw
Called by the framework to display an image on a button.  
  
## Syntax  
  
```  
virtual void OnDraw(  
   CDC* pDC,  
   const CRect& rect,  
   CMFCToolBarImages* pImages,  
   BOOL bHorz=TRUE,  
   BOOL bCustomizeMode=FALSE,  
   BOOL bHighlight=FALSE,  
   BOOL bDrawBorder=TRUE,  
   BOOL bGrayDisabledButtons=TRUE   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rect`  
 A rectangle that bounds the area to be redrawn.  
  
 [in] `pImages`  
 Points to a list of toolbar images.  
  
 [in] `bHorz`  
 `TRUE` to specify that the toolbar is in a horizontal docked state; otherwise, `FALSE`. The default is `TRUE`.  
  
 [in] `bCustomizeMode`  
 `TRUE` to specify that the application is in customization mode; otherwise, `FALSE`. The default is `FALSE`.  
  
 [in] `bHighlight`  
 `TRUE` to specify that the button is highlighted; otherwise, `FALSE`. The default is `FALSE`.  
  
 [in] `bDrawBorder`  
 `TRUE` to specify that the button's border is displayed; otherwise, `FALSE`. The default is `TRUE`.  
  
 [in] `bGrayDisabledButtons`  
 `TRUE` to specify that disabled buttons are grayed (dimmed) out; otherwise, `FALSE`. The default is `TRUE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxcolormenubutton.h  
  
## See Also  
 [CMFCColorMenuButton Class](../vs140/cmfccolormenubutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)