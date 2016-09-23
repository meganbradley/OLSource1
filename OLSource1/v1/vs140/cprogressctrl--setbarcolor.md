---
title: "CProgressCtrl::SetBarColor"
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
  - SetBarColor method
  - CProgressCtrl.SetBarColor
  - CProgressCtrl::SetBarColor
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetBarColor method
ms.assetid: a2539f23-d225-43ab-ade3-0c0193fa6b42
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CProgressCtrl::SetBarColor
Sets the color of the progress indicator bar in the current progress bar control.  
  
## Syntax  
  
```  
COLORREF SetBarColor(  
         COLORREF clrBar  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `clrBar`|A [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value that specifies the new color of the progress indicator bar. Specify `CLR_DEFAULT` to cause the progress bar to use its default color.|  
  
## Return Value  
 The previous color of the progress indicator bar, represented as a [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value, or `CLR_DEFAULT` if the color of the progress indicator bar is the default color.  
  
## Remarks  
 The `SetBarColor` method sets the progress bar color only if a [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] [theme](_inet_themes_visualstyles_overview) is not in effect.  
  
 This method sends the [PBM_SETBARCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb760838) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 The following code example defines the variable, `m_progressCtrl`, that is used to programmatically access the progress bar control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CProgressCtrl_s1#9](../vs140/codesnippet/CPP/cprogressctrl--setbarcolor_1.h)]
  
  
## Example  
 The following code example changes the color of the progress bar to red, green, blue, or the default.  
  
 [!code[NVC_MFC_CProgressCtrl_s1#1](../vs140/codesnippet/CPP/cprogressctrl--setbarcolor_2.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CProgressCtrl Class](../vs140/cprogressctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [PBM_SETBARCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb760838)   
 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449)   
 [Using CProgressCtrl](../vs140/using-cprogressctrl.md)   
 [CProgressCtrl::GetBarColor](../vs140/cprogressctrl--getbarcolor.md)