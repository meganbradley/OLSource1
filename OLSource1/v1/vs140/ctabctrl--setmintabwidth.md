---
title: "CTabCtrl::SetMinTabWidth"
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
  - "CTabCtrl::SetMinTabWidth"
  - "SetMinTabWidth"
  - "CTabCtrl.SetMinTabWidth"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tab width setting"
  - "SetMinTabWidth method"
ms.assetid: 33ddd354-b68e-4cb1-99b4-e7cc09b45f7f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTabCtrl::SetMinTabWidth
Sets the minimum width of items in a tab control.  
  
## Syntax  
  
```  
  
      int SetMinTabWidth(  
  int cx   
);  
```  
  
#### Parameters  
 `cx`  
 Minimum width to be set for a tab control item. If this parameter is set to -1, the control will use the default tab width.  
  
## Return Value  
 The previous minimum tab width.  
  
## Return Value  
 This member function implements the behavior of the Win32 message [TCM_SETMINTABWIDTH](http://msdn.microsoft.com/library/windows/desktop/bb760637), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTabCtrl Class](../vs140/ctabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)