---
title: "CMFCCaptionButton::GetHit"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CMFCCaptionButton::GetHit
  - GetHit
  - CMFCCaptionButton.GetHit
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetHit method
ms.assetid: 7580f8ef-966e-460f-8678-b44ad0ad7b18
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCCaptionButton::GetHit
Returns the command represented by the button.  
  
## Syntax  
  
```  
UINT GetHit() const;  
```  
  
## Return Value  
 The command represented by the button.  
  
 The following table lists possible return values.  
  
|Value|Command|  
|-----------|-------------|  
|`AFX_HTCLOSE`|Close button.|  
|`HTMINBUTTON`|Minimize button.|  
|`HTMAXBUTTON`|Maximize button.|  
|`AFX_HTLEFTBUTTON`|Left arrow button.|  
|`AFX_HTRIGHTBUTTON`|Right arrow button.|  
|`AFX_HTMENU`|Down arrow menu button.|  
|`HTNOWHERE`|The default value; represents no command.|  
  
## Requirements  
 **Header:** afxcaptionbutton.h  
  
## See Also  
 [CMFCCaptionButton Class](../vs140/cmfccaptionbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)