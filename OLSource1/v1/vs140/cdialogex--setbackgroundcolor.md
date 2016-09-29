---
title: "CDialogEx::SetBackgroundColor"
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
  - "SetBackgroundColor"
  - "CDialogEx.SetBackgroundColor"
  - "CDialogEx::SetBackgroundColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetBackgroundColor method"
ms.assetid: b6cf8966-8b07-4ada-9084-03d8b9513797
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDialogEx::SetBackgroundColor
Sets the background color of the dialog box.  
  
## Syntax  
  
```  
void SetBackgroundColor(  
   COLORREF color,  
   BOOL bRepaint=TRUE   
);  
```  
  
#### Parameters  
 [in] `color`  
 An RGB color value.  
  
 [in] `bRepaint`  
 `TRUE` to immediately update the screen; otherwise, `FALSE`. The default value is `TRUE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxdialogex.h  
  
## See Also  
 [CDialogEx Class](../vs140/cdialogex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449)