---
title: "CDialogEx::SetBackgroundImage"
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
  - "SetBackgroundImage"
  - "CDialogEx.SetBackgroundImage"
  - "CDialogEx::SetBackgroundImage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetBackgroundImage method"
ms.assetid: a20173b4-3a54-4679-8361-174dc86b0b0c
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDialogEx::SetBackgroundImage
Sets the background image of the dialog box.  
  
## Syntax  
  
```  
void SetBackgroundImage(  
   HBITMAP hBitmap,  
   BackgroundLocation location=BACKGR_TILE,  
   BOOL bAutoDestroy=TRUE,  
   BOOL bRepaint=TRUE   
);  
BOOL SetBackgroundImage(  
   UINT uiBmpResId,  
   BackgroundLocation location=BACKGR_TILE,  
   BOOL bRepaint=TRUE   
);  
```  
  
#### Parameters  
 [in] `hBitmap`  
 A handle to the background image.  
  
 [in] `uiBmpResId`  
 The resource ID of the background image.  
  
 [in] `location`  
 One of the  `CDialogEx::BackgroundLocation` values that specify the location of the image. Valid values include BACKGR_TILE, BACKGR_TOPLEFT, BACKGR_TOPRIGHT, BACKGR_BOTTOMLEFT, and BACKGR_BOTTOMRIGHT. The default value is BACKGR_TILE.  
  
 [in] `bAutoDestroy`  
 `TRUE` to automatically destroy the background image; otherwise, `FALSE`.  
  
 [in] `bRepaint`  
 `TRUE` to immediately redraw the dialog box; otherwise, `FALSE`.  
  
## Return Value  
 In the second method overload syntax, `TRUE` if the method is successful; otherwise, `FALSE`.  
  
## Remarks  
 The image that you specify is not stretched to fit the dialog box client area.  
  
## Requirements  
 **Header:** afxdialogex.h  
  
## See Also  
 [CDialogEx Class](../vs140/cdialogex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)