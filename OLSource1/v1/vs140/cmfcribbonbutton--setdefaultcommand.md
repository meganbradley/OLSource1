---
title: "CMFCRibbonButton::SetDefaultCommand"
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
  - "SetDefaultCommand"
  - "CMFCRibbonButton::SetDefaultCommand"
  - "CMFCRibbonButton.SetDefaultCommand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDefaultCommand method"
ms.assetid: b27d75fe-9d70-4919-b21f-0ae0a31541f3
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonButton::SetDefaultCommand
Enables the default command for the ribbon button.  
  
## Syntax  
  
```  
void SetDefaultCommand(  
   BOOL bSet=TRUE   
);  
```  
  
#### Parameters  
 [in] `bSet`  
 If `TRUE`, the button can execute its default command. If `FALSE`, the button cannot execute its default command.  
  
## Remarks  
 `bSet` is relevant only when the button has a menu. If `bSet` is `TRUE`, the button can execute its default command and the assigned pop-up menu appears only when a user clicks the arrow at the right edge of the button. Otherwise, the button cannot execute its default command, and the pop-up menu appears regardless of which area of the button the user clicks.  
  
## Requirements  
 **Header:** afxribbonbutton.h  
  
## See Also  
 [CMFCRibbonButton Class](../vs140/cmfcribbonbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)