---
title: "CListCtrl::SetIconSpacing"
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
  - "SetIconSpacing"
  - "CListCtrl.SetIconSpacing"
  - "CListCtrl::SetIconSpacing"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetIconSpacing method"
ms.assetid: cd803b6d-5231-4a9c-a525-9d18370a30d0
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::SetIconSpacing
Sets the spacing between icons in a list view control.  
  
## Syntax  
  
```  
  
      CSize SetIconSpacing(  
   int cx,  
   int cy   
);  
CSize SetIconSpacing(  
   CSize size   
);  
```  
  
#### Parameters  
 `cx`  
 The distance (in pixels) between icons on the x-axis.  
  
 `cy`  
 The distance (in pixels) between icons on the y-axis.  
  
 `size`  
 A `CSize` object specifying the distance (in pixels) between icons on the x- and y-axes.  
  
## Return Value  
 A [CSize](../vs140/csize-class.md) object containing the previous values for icon spacing.  
  
## Remarks  
 This member function implements the behavior of the Win32 macro, [ListView_SetIconSpacing](http://msdn.microsoft.com/library/windows/desktop/bb775085), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CListCtrl#34](../vs140/codesnippet/CPP/clistctrl--seticonspacing_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)