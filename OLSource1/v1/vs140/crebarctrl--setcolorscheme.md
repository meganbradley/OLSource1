---
title: "CReBarCtrl::SetColorScheme"
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
  - "CReBarCtrl.SetColorScheme"
  - "SetColorScheme"
  - "CReBarCtrl::SetColorScheme"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CReBarCtrl class, operations"
  - "SetColorScheme"
ms.assetid: 0fc551cf-07cd-47ae-a8c7-97af962fde6e
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBarCtrl::SetColorScheme
Sets the color scheme for the buttons on a rebar control.  
  
## Syntax  
  
```  
  
void SetColorScheme( const COLORSCHEME*   
lpcs  
 );  
  
```  
  
#### Parameters  
 `lpcs`  
 A pointer to a [COLORSCHEME](http://msdn.microsoft.com/library/windows/desktop/bb775502) structure, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 The **COLORSCHEME** structure includes both the button highlight color and the button shadow color.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CReBarCtrl::GetColorScheme](../vs140/crebarctrl--getcolorscheme.md)