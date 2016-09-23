---
title: "CTreeCtrl::GetToolTips"
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
  - CTreeCtrl.GetToolTips
  - CTreeCtrl::GetToolTips
  - GetToolTips
dev_langs: 
  - C++
helpviewer_keywords: 
  - tool tips [C++], retrieving
  - GetToolTips method
ms.assetid: d1c95b8c-2492-4d89-9ba2-41147f72cf96
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTreeCtrl::GetToolTips
This member function implements the behavior of the Win32 message [TVM_GETTOOLTIPS](http://msdn.microsoft.com/library/windows/desktop/bb773729), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
```  
  
CToolTipCtrl* GetToolTips( ) const;  
  
```  
  
## Return Value  
 A pointer to a [CToolTipCtrl](../vs140/ctooltipctrl-class.md) object to be used by the tree control. If the [Create](../vs140/ctreectrl--create.md) member function uses the style **TVS_NOTOOLTIPS**, no tooltips are used, and **NULL** is returned.  
  
## Remarks  
 The MFC implementation of `GetToolTips` returns a `CToolTipCtrl` object, which is used by the tree control, rather than a handle to a tooltip control.  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#25](../vs140/codesnippet/CPP/ctreectrl--gettooltips_1.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::SetToolTips](../vs140/ctreectrl--settooltips.md)