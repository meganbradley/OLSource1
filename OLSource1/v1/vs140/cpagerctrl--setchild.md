---
title: "CPagerCtrl::SetChild"
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
  - CPagerCtrl::SetChild
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetChild method
ms.assetid: 8870116a-541e-4d0e-9424-383c71ad8b63
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPagerCtrl::SetChild
Sets the contained window for the current pager control.  
  
## Syntax  
  
```  
void SetChild(  
     HWND hwndChild  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `hwndChild`|Handle to the window to be contained.|  
  
## Requirements  
 **Header:** afxcmn.h  
  
## Remarks  
 This method sends the [PGM_SETCHILD](http://msdn.microsoft.com/library/windows/desktop/bb760884) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 This method does not change the parent of the contained window; it only assigns a window handle to the pager control for scrolling. In most cases, the contained window will be a child window of the pager control.  
  
## Example  
 The following example creates a pager control, then uses the [CPagerCtrl::SetChild](../vs140/cpagerctrl--setchild.md) method to associate a very long button control with the pager control. The example then uses the [CPagerCtrl::SetButtonSize](../vs140/cpagerctrl--setbuttonsize.md) method to set the height of the pager control to 20 pixels, and the [CPagerCtrl::SetBorder](../vs140/cpagerctrl--setborder.md) method to set the border thickness to 1 pixel.  
  
 [!code[NVC_MFC_CSplitButton_s2#1](../vs140/codesnippet/CPP/cpagerctrl--setchild_1.cpp)]
  
  
## See Also  
 [CPagerCtrl Class](../vs140/cpagerctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)