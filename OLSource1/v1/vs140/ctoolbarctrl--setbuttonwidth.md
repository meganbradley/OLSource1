---
title: "CToolBarCtrl::SetButtonWidth"
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
  - "CToolBarCtrl.SetButtonWidth"
  - "CToolBarCtrl::SetButtonWidth"
  - "SetButtonWidth"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetButtonWidth method"
ms.assetid: 5eda95f6-9ddb-4397-8346-baee0628a324
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::SetButtonWidth
Sets the minimum and maximum button widths in the toolbar control.  
  
## Syntax  
  
```  
  
      BOOL SetButtonWidth(  
   int cxMin,  
   int cxMax   
);  
```  
  
#### Parameters  
 `cxMin`  
 Minimum button width, in pixels. Toolbar buttons will never be narrower than this value.  
  
 *cxMax*  
 Maximum button width, in pixels. If button text is too wide, the control displays it with ellipsis points.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TB_SETBUTTONWIDTH](http://msdn.microsoft.com/library/windows/desktop/bb787417), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::SetButtonInfo](../vs140/ctoolbarctrl--setbuttoninfo.md)