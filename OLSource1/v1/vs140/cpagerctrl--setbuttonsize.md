---
title: "CPagerCtrl::SetButtonSize"
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
  - "CPagerCtrl::SetButtonSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetButtonSize method"
ms.assetid: 423e24dc-91b2-4120-bccd-cab519e10df3
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPagerCtrl::SetButtonSize
Sets the button size of the current pager control.  
  
## Syntax  
  
```  
int SetButtonSize(  
    int iButtonSize  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `iButtonSize`|The new button size, measured in pixels.|  
  
## Requirements  
 **Header:** afxcmn.h  
  
## Return Value  
 The previous button size, measured in pixels.  
  
## Remarks  
 This method sends the [PGM_SETBUTTONSIZE](http://msdn.microsoft.com/library/windows/desktop/bb760886) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 If the pager control has the `PGS_HORZ` style, the button size determines the width of the pager buttons, and if the pager control has the `PGS_VERT` style, the button size determines the height of the pager buttons. The default button size is three-fourths of the width of the scroll bar, and the minimum button size is 12 pixels. For more information, see [Pager Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb760859).  
  
## Example  
 The following example creates a pager control, then uses the [CPagerCtrl::SetChild](../vs140/cpagerctrl--setchild.md) method to associate a very long button control with the pager control. The example then uses the [CPagerCtrl::SetButtonSize](../vs140/cpagerctrl--setbuttonsize.md) method to set the height of the pager control to 20 pixels, and the [CPagerCtrl::SetBorder](../vs140/cpagerctrl--setborder.md) method to set the border thickness to 1 pixel.  
  
 [!code[NVC_MFC_CSplitButton_s2#1](../vs140/codesnippet/CPP/cpagerctrl--setbuttonsize_1.cpp)]  
  
## See Also  
 [CPagerCtrl Class](../vs140/cpagerctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [PGM_SETBUTTONSIZE](http://msdn.microsoft.com/library/windows/desktop/bb760886)   
 [CPagerCtrl::GetButtonSize](../vs140/cpagerctrl--getbuttonsize.md)