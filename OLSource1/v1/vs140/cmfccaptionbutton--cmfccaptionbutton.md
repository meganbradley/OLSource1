---
title: "CMFCCaptionButton::CMFCCaptionButton"
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
  - "CMFCCaptionButton.CMFCCaptionButton"
  - "CMFCCaptionButton::CMFCCaptionButton"
  - "CMFCCaptionButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCCaptionButton, constructor"
ms.assetid: d5843924-31f6-438b-93c7-afb7fdcd9b74
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCCaptionButton::CMFCCaptionButton
Constructs a `CMFCCaptionButton` object.  
  
## Syntax  
  
```  
CMFCCaptionButton();  
CMFCCaptionButton(  
   UINT nHit,  
   BOOL bLeftAlign = FALSE  
);  
```  
  
#### Parameters  
 [in] `nHit`  
 The command associated with the button.  
  
 [in] `bLeftAlign`  
 Specifies whether the button is aligned to the left.  
  
 The following table lists possible values for the `nHit` parameter.  
  
|Value|Command|  
|-----------|-------------|  
|`AFX_HTCLOSE`|Close button.|  
|`HTMINBUTTON`|Minimize button.|  
|`HTMAXBUTTON`|Maximize button.|  
|`AFX_HTLEFTBUTTON`|Left arrow button.|  
|`AFX_HTRIGHTBUTTON`|Right arrow button.|  
|`AFX_HTMENU`|Down arrow menu button.|  
|`HTNOWHERE`|The default value; represents no command.|  
  
## Remarks  
 By default, caption buttons are not associated with a command.  
  
 Caption buttons are aligned either on the right or left.  
  
## Requirements  
 **Header:** afxcaptionbutton.h  
  
## See Also  
 [CMFCCaptionButton Class](../vs140/cmfccaptionbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)