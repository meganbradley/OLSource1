---
title: "CToolBarCtrl::SetColorScheme"
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
  - "CToolBarCtrl.SetColorScheme"
  - "CToolBarCtrl::SetColorScheme"
  - "SetColorScheme method"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetColorScheme method"
ms.assetid: 53e3b954-4d00-4d12-86da-298608e0b298
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::SetColorScheme
Sets the color scheme of the current toolbar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Pointer to a [COLORSCHEME](http://msdn.microsoft.com/library/windows/desktop/bb775502) structure that describes the highlight color and shadow color of the toolbar control.|  
  
## Remarks  
 This method has no effect if a [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] visual theme is set.  
  
 This method sends the [TB_SETCOLORSCHEME](http://msdn.microsoft.com/library/windows/desktop/bb787421) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## Example  
 The following code example sets the color scheme for the current toolbar control. The code example makes the left and top edges of each tool button red and the right and bottom edges blue. When the user presses the button, the button's red edges turn blue and its blue edges turn red.  
  
 [!code[NVC_MFC_CToolBarCtrl_s1#3](../vs140/codesnippet/CPP/ctoolbarctrl--setcolorscheme_1.cpp)]  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [TB_SETCOLORSCHEME](http://msdn.microsoft.com/library/windows/desktop/bb787421)   
 [COLORSCHEME](http://msdn.microsoft.com/library/windows/desktop/bb775502)   
 [CToolBarCtrl::GetColorScheme](../vs140/ctoolbarctrl--getcolorscheme.md)