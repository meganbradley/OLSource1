---
title: "CWinApp::IsTaskbarInteractionEnabled"
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
  - "IsTaskbarInteractionEnabled"
  - "afxwin/CWinApp::IsTaskbarInteractionEnabled"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsTaskbarInteractionEnabled"
ms.assetid: 4fceafac-3600-4197-8f4b-03f44a83d605
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::IsTaskbarInteractionEnabled
Tells whether Windows 7 Taskbar interaction is enabled.  
  
## Syntax  
  
```  
virtual BOOL IsTaskbarInteractionEnabled();  
```  
  
## Return Value  
 Returns `TRUE` if `EnableTaskbarInteraction` has been called and the Operating System is Windows 7 or higher.  
  
## Remarks  
 Taskbar interaction means that MDI application displays the content of MDI children in separate tabbed thumbnails that appear when the mouse pointer is over the application taskbar button.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)