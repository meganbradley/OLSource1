---
title: "CToolBarCtrl::GetColorScheme"
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
  - "CToolBarCtrl::GetColorScheme"
  - "CToolBarCtrl.GetColorScheme"
  - "GetColorScheme method"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetColorScheme method"
ms.assetid: a22fc75a-3d49-4802-ae83-bd52afd4c0bb
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::GetColorScheme
Retrieves the color scheme of the current toolbar control.  
  
## Syntax  
  
```  
BOOL GetColorScheme(  
     COLORSCHEME* lpColorScheme  
) const;  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[out] `lpColorScheme`|Pointer to a [COLORSCHEME](http://msdn.microsoft.com/library/windows/desktop/bb775502) structure that receives the color scheme information. When this method returns, the structure describes the highlight color and shadow color of the toolbar control.|  
  
## Return Value  
 `true` if this method is successful; otherwise, `false`.  
  
## Remarks  
 This method sends the [TB_GETCOLORSCHEME](http://msdn.microsoft.com/library/windows/desktop/bb787327) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [TB_GETCOLORSCHEME](http://msdn.microsoft.com/library/windows/desktop/bb787327)   
 [COLORSCHEME](http://msdn.microsoft.com/library/windows/desktop/bb775502)   
 [CToolBarCtrl::SetColorScheme](../vs140/ctoolbarctrl--setcolorscheme.md)