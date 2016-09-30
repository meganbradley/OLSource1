---
title: "CProgressCtrl::GetBkColor"
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
  - "CProgressCtrl.GetBkColor"
  - "CProgressCtrl::GetBkColor"
  - "GetBkColor method"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetBkColor method"
ms.assetid: 5a3c547b-1a34-4e0d-9880-b8eeb85423a9
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CProgressCtrl::GetBkColor
Gets the background color of the current progress bar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The background color of the current progress bar, represented as a [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value.  
  
## Remarks  
 This method sends the [PBM_GETBKCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb760828) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This control is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CProgressCtrl Class](../vs140/cprogressctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [PBM_GETBKCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb760828)   
 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449)   
 [Using CProgressCtrl](../vs140/using-cprogressctrl.md)   
 [CProgressCtrl::SetBkColor](../vs140/cprogressctrl--setbkcolor.md)