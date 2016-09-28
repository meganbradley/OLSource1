---
title: "CFrameWnd::SetProgressBarPosition"
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
  - "afxwin/CFrameWnd::SetProgressBarPosition"
  - "SetProgressBarPosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetProgressBarPosition"
ms.assetid: 2ff30f99-9b5f-4b10-b2c7-a54e0b874750
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWnd::SetProgressBarPosition
Sets the current position for the Windows 7 progress bar displayed on the taskbar.  
  
## Syntax  
  
```  
void SetProgressBarPosition(  
   int nProgressPos  
);  
```  
  
#### Parameters  
 `nProgressPos`  
 Specifies the position to set. It must be within the range set by `SetProgressBarRange`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)