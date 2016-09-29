---
title: "CRichEditCtrl::SetBackgroundColor"
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
  - "CRichEditCtrl::SetBackgroundColor"
  - "CRichEditCtrl.SetBackgroundColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetBackgroundColor method"
ms.assetid: e5f071de-fe4c-4fd3-8e2b-47a302d3a2d4
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::SetBackgroundColor
Sets the background color for this `CRichEditCtrl` object.  
  
## Syntax  
  
```  
  
      COLORREF SetBackgroundColor(  
   BOOL bSysColor,  
   COLORREF cr   
);  
```  
  
#### Parameters  
 `bSysColor`  
 Indicates if the background color should be set to the system value. If this value is **TRUE**, `cr` is ignored.  
  
 `cr`  
 The requested background color. Used only if `bSysColor` is **FALSE**.  
  
## Return Value  
 The previous background color for this `CRichEditCtrl` object.  
  
## Remarks  
 The background color can be set to the system value or to a specified [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value.  
  
 For more information, see [EM_SETBKGNDCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb774228) message and [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CRichEditCtrl#24](../vs140/codesnippet/CPP/cricheditctrl--setbackgroundcolor_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SetBkColor](../vs140/cdc--setbkcolor.md)