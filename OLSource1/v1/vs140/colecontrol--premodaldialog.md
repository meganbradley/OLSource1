---
title: "COleControl::PreModalDialog"
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
  - "COleControl.PreModalDialog"
  - "PreModalDialog"
  - "COleControl::PreModalDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PreModalDialog method"
ms.assetid: ba73629e-a4a9-41fd-a9e6-89ae37ee19dd
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::PreModalDialog
Notifies the container that a modal dialog box is about to be displayed.  
  
## Syntax  
  
```  
  
      void PreModalDialog(  
   HWND hWndParent = NULL  
);  
```  
  
#### Parameters  
 `hWndParent`  
 Handle to the parent window of the modal dialog box.  
  
## Remarks  
 Call this function before displaying any modal dialog box. You must call this function so that the container can disable all its top-level windows. After the modal dialog box has been displayed, you must then call `PostModalDialog`.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::PostModalDialog](../vs140/colecontrol--postmodaldialog.md)