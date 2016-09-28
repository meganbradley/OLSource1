---
title: "CToolBarCtrl::SetPadding"
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
  - "CToolBarCtrl.SetPadding"
  - "SetPadding method"
  - "CToolBarCtrl::SetPadding"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetPadding method"
ms.assetid: 3bc1be70-6fd2-491e-a75e-52c62cad43c5
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::SetPadding
Sets the horizontal and vertical padding of the current toolbar control.  
  
## Syntax  
  
```  
DWORD SetPadding(  
      int nHorzPadding,   
      int nVertPadding  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `nHorzPadding`|Specifies the horizontal padding of the toolbar control, in pixels.|  
|[in] `nVertPadding`|Specifies the vertical padding of the toolbar control, in pixels.|  
  
## Return Value  
 A `DWORD` whose low word contains the previous horizontal padding value, and whose high word contains the previous vertical padding value. The padding values are measured in pixels.  
  
## Remarks  
 This method sends the [TB_SETPADDING](http://msdn.microsoft.com/library/windows/desktop/bb787448) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## Example  
 The following code example sets the horizontal and vertical padding of the current toolbar control to 20 pixels.  
  
 [!code[NVC_MFC_CToolBarCtrl_s1#4](../vs140/codesnippet/CPP/ctoolbarctrl--setpadding_1.cpp)]  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [TB_SETPADDING](http://msdn.microsoft.com/library/windows/desktop/bb787448)   
 [CToolBarCtrl::GetPadding](../vs140/ctoolbarctrl--getpadding.md)