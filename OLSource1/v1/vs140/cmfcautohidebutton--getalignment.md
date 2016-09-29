---
title: "CMFCAutoHideButton::GetAlignment"
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
  - "GetAlignment"
  - "CMFCAutoHideButton::GetAlignment"
  - "CMFCAutoHideButton.GetAlignment"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAlignment method"
ms.assetid: df2849ba-63be-44b9-acbb-3ec4797d69ef
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCAutoHideButton::GetAlignment
Retrieves the alignment of the auto-hide button.  
  
## Syntax  
  
```  
DWORD GetAlignment() const;  
```  
  
## Return Value  
 A `DWORD` value that contains the current alignment of the auto-hide button.  
  
## Remarks  
 The alignment of the auto-hide button indicates where the button resides on the application. It can be any one of the following values:  
  
-   `CBRS_ALIGN_LEFT`  
  
-   `CBRS_ALIGN_RIGHT`  
  
-   `CRBS_ALIGN_TOP`  
  
-   `CBRS_ALIGN_BOTTOM`  
  
## Requirements  
 **Header:** afxautohidebutton.h  
  
## See Also  
 [CMFCAutoHideButton Class](../vs140/cmfcautohidebutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)