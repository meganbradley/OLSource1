---
title: "CToolBarCtrl::GetAnchorHighlight"
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
  - "CToolBarCtrl::GetAnchorHighlight"
  - "CToolBarCtrl.GetAnchorHighlight"
  - "GetAnchorHighlight"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CToolBarCtrl class, attributes"
  - "GetAnchorHighlight method"
ms.assetid: 58b56c7d-406f-4d9b-9233-035ead10ded1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::GetAnchorHighlight
Retrieves the anchor highlight setting for a toolbar.  
  
## Syntax  
  
```  
  
BOOL GetAnchorHighlight( ) const;  
  
```  
  
## Return Value  
 If nonzero, anchor highlighting is enabled. If zero, anchor highlighting is disabled.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TB_GETANCHORHIGHLIGHT](http://msdn.microsoft.com/library/windows/desktop/bb787313), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::SetAnchorHighlight](../vs140/ctoolbarctrl--setanchorhighlight.md)