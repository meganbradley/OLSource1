---
title: "CTreeCtrl::SetLineColor"
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
  - "SetLineColor"
  - "CTreeCtrl.SetLineColor"
  - "CTreeCtrl::SetLineColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetLineColor method"
ms.assetid: 4d511173-56df-4080-a3f8-6b41057b0691
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::SetLineColor
Call this member function to set the current line color for the tree view control.  
  
## Syntax  
  
```  
  
      COLORREF SetLineColor(  
   COLORREF clrNew = CLR_DEFAULT   
);  
```  
  
#### Parameters  
 `clrNew`  
 The new line color.  
  
## Return Value  
 The previous line color.  
  
## Remarks  
 This member function implements the behavior of the win32 message [TVM_SETLINECOLOR](http://msdn.microsoft.com/library/windows/desktop/bb773764), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#35](../vs140/codesnippet/CPP/ctreectrl--setlinecolor_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::GetLineColor](../vs140/ctreectrl--getlinecolor.md)