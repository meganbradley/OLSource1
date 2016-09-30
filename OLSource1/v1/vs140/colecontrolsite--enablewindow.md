---
title: "COleControlSite::EnableWindow"
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
  - "COleControlSite.EnableWindow"
  - "COleControlSite::EnableWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableWindow method"
  - "COleControlSite class, overridables"
ms.assetid: b17adc34-0883-4d31-ab8b-9a5d486919ce
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlSite::EnableWindow
Enables or disables mouse and keyboard input to the control site.  
  
## Syntax  
  
```  
  
      virtual BOOL EnableWindow(  
   BOOL bEnable   
);  
```  
  
#### Parameters  
 `bEnable`  
 Specifies whether to enable or disable the window: **TRUE** if window input is to be enabled, otherwise **FALSE**.  
  
## Return Value  
 Nonzero if the window was previously disabled, otherwise 0.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlSite Class](../vs140/colecontrolsite-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)