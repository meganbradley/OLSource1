---
title: "CReBarCtrl::GetColorScheme"
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
  - "GetColorScheme"
  - "CReBarCtrl.GetColorScheme"
  - "CReBarCtrl::GetColorScheme"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CReBarCtrl class, operations"
  - "GetColorScheme"
ms.assetid: 7f6b1480-6782-4aee-9119-3b71965fa310
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBarCtrl::GetColorScheme
Retrieves the [COLORSCHEME](http://msdn.microsoft.com/library/windows/desktop/bb775502) structure for the rebar control.  
  
## Syntax  
  
```  
  
BOOL GetColorScheme( COLORSCHEME*   
lpcs  
 );  
  
```  
  
#### Parameters  
 `lpcs`  
 A pointer to a [COLORSCHEME](http://msdn.microsoft.com/library/windows/desktop/bb775502) structure, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 The **COLORSCHEME** structure includes the button highlight color and the button shadow color.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CReBarCtrl::SetColorScheme](../vs140/crebarctrl--setcolorscheme.md)