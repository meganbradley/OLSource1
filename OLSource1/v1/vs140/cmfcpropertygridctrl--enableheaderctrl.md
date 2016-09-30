---
title: "CMFCPropertyGridCtrl::EnableHeaderCtrl"
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
  - "CMFCPropertyGridCtrl.EnableHeaderCtrl"
  - "CMFCPropertyGridCtrl::EnableHeaderCtrl"
  - "EnableHeaderCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableHeaderCtrl method"
ms.assetid: 1f16c674-befe-4f6c-944f-6dc395323380
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridCtrl::EnableHeaderCtrl
Enables or disables the header control at the top of the property grid control.  
  
## Syntax  
  
```  
void EnableHeaderCtrl(  
   BOOL bEnable=TRUE,  
   LPCTSTR lpszLeftColumn=_T("Property"),  
   LPCTSTR lpszRightColumn=_T("Value")   
);  
```  
  
#### Parameters  
 [in] `bEnable`  
 `TRUE` to enable the header control; `FALSE` to disable the header control. The default value is `TRUE`.  
  
 [in] `lpszLeftColumn`  
 The title of the left column of the header control. The default value is **Property**.  
  
 [in] `lpszRightColumn`  
 The title of the right column of the header control. The default value is **Value**.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridCtrl Class](../vs140/cmfcpropertygridctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)