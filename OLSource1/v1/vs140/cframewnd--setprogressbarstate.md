---
title: "CFrameWnd::SetProgressBarState"
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
  - "SetProgressBarState"
  - "afxwin/CFrameWnd::SetProgressBarState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetProgressBarState"
ms.assetid: f22ad49c-2e62-4435-ae09-9ee7d2c33232
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWnd::SetProgressBarState
Sets the type and state of the progress indicator displayed on a taskbar button.  
  
## Syntax  
  
```  
void SetProgressBarState(  
   TBPFLAG tbpFlags  
);  
```  
  
#### Parameters  
 `tbpFlags`  
 Flags that control the current state of the progress button. Specify only one of the following flags because all states are mutually exclusive: TBPF_NOPROGRESS, TBPF_INDETERMINATE, TBPF_NORMAL, TBPF_ERROR, TBPF_PAUSED.  
  
## Remarks  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)