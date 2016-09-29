---
title: "CWnd::SetIcon"
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
  - "CWnd::SetIcon"
  - "CWnd.SetIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "window icon"
  - "SetIcon method"
  - "icons, setting"
ms.assetid: 5bc2b1a0-a6b6-49f5-a976-a7e56152918e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::SetIcon
Call this member function to set the handle to a specific icon, as identified by `hIcon`.  
  
## Syntax  
  
```  
  
      HICON SetIcon(  
   HICON hIcon,  
   BOOL bBigIcon   
);  
```  
  
#### Parameters  
 `hIcon`  
 A handle to a previous icon.  
  
 `bBigIcon`  
 Specifies a 32 pixel by 32 pixel icon if **TRUE**; specifies a 16 pixel by 16 pixel icon if **FALSE**.  
  
## Return Value  
 A handle to an icon.  
  
## Remarks  
 When the window class is registered, it selects an icon.  
  
## Example  
 See the example for [CWnd::GetSystemMenu](../vs140/cwnd--getsystemmenu.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetIcon](../vs140/cwnd--geticon.md)