---
title: "CPagerCtrl::SetBorder"
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
  - "CPagerCtrl::SetBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetBorder method"
ms.assetid: 92e29ddc-0fa1-445a-87cd-447a9ef0cd61
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPagerCtrl::SetBorder
Sets the border size of the current pager control.  
  
## Syntax  
  
```  
int SetBorder(  
    int iBorder  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `iBorder`|The new border size, measured in pixels. If the `iBorder` parameter is negative, the border size is set to zero.|  
  
## Requirements  
 **Header:** afxcmn.h  
  
## Return Value  
 The previous border size, measured in pixels.  
  
## Remarks  
 This method sends the [PGM_SETBORDER](http://msdn.microsoft.com/library/windows/desktop/bb760880) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 The following example creates a pager control, then uses the [CPagerCtrl::SetChild](../vs140/cpagerctrl--setchild.md) method to associate a very long button control with the pager control. The example then uses the [CPagerCtrl::SetButtonSize](../vs140/cpagerctrl--setbuttonsize.md) method to set the height of the pager control to 20 pixels, and the [CPagerCtrl::SetBorder](../vs140/cpagerctrl--setborder.md) method to set the border thickness to 1 pixel.  
  
 [!code[NVC_MFC_CSplitButton_s2#1](../vs140/codesnippet/CPP/cpagerctrl--setborder_1.cpp)]  
  
## See Also  
 [CPagerCtrl Class](../vs140/cpagerctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [PGM_SETBORDER](http://msdn.microsoft.com/library/windows/desktop/bb760880)   
 [CPagerCtrl::GetBorder](../vs140/cpagerctrl--getborder.md)