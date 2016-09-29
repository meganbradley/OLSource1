---
title: "CRichEditCtrl::SetTextMode"
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
  - "SetTextMode"
  - "CRichEditCtrl::SetTextMode"
  - "CRichEditCtrl.SetTextMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTextMode method"
ms.assetid: ce90c1a1-4ef1-42d2-932f-28d8d6064e7b
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::SetTextMode
Sets the text mode or undo and redo level for a rich edit control.  
  
## Syntax  
  
```  
  
      BOOL SetTextMode(  
   UINT fMode   
);  
```  
  
#### Parameters  
 *fMode*  
 Specifies the new settings for the control's text mode and undo level parameters. For a list of the possible values, see the mode parameter for [EM_SETTEXTMODE](http://msdn.microsoft.com/library/windows/desktop/bb774286) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Zero if successful, otherwise nonzero.  
  
## Remarks  
 For a description of the text modes, see **EM_SETTEXTMODE** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 This member function fails if the control contains text. To make sure the control is empty, send a [WM_SETTEXT](http://msdn.microsoft.com/library/windows/desktop/ms632644) message with an empty string.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::GetTextMode](../vs140/cricheditctrl--gettextmode.md)