---
title: "CProgressCtrl::GetBarColor"
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
  - "CProgressCtrl::GetBarColor"
  - "GetBarColor method"
  - "CProgressCtrl.GetBarColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetBarColor method"
ms.assetid: 13d44072-058a-403e-bc9e-a9d087c9c491
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CProgressCtrl::GetBarColor
Gets the color of the progress indicator bar for the current progress bar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The color of the current progress bar, represented as a [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value, or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the progress indicator bar color is the default color.  
  
## Remarks  
 This method sends the [PBM_GETBARCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb760826) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This control is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CProgressCtrl Class](../vs140/cprogressctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [PBM_GETBARCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb760826)   
 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449)   
 [Using CProgressCtrl](../vs140/using-cprogressctrl.md)   
 [CProgressCtrl::SetBarColor](../vs140/cprogressctrl--setbarcolor.md)