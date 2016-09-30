---
title: "CPagerCtrl::GetButtonSize"
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
  - "CPagerCtrl::GetButtonSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetButtonSize method"
ms.assetid: 3440d7a2-fc31-4a7e-a6d6-77ef4348ead7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPagerCtrl::GetButtonSize
Retrieves the button size of the current pager control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** afxcmn.h  
  
## Return Value  
 The current button size, measured in pixels.  
  
## Remarks  
 This method sends the [PGM_GETBUTTONSIZE](http://msdn.microsoft.com/library/windows/desktop/bb760870) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 If the pager control has the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> style, the button size determines the width of the pager buttons, and if the pager control has the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> style, the button size determines the height of the pager buttons. For more information, see [Pager Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb760859).  
  
## See Also  
 [CPagerCtrl Class](../vs140/cpagerctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [PGM_GETBUTTONSIZE](http://msdn.microsoft.com/library/windows/desktop/bb760870)   
 [CPagerCtrl::SetButtonSize](../vs140/cpagerctrl--setbuttonsize.md)