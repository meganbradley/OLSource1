---
title: "CContainedWindowT::UnsubclassWindow"
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
  - "CContainedWindowT::UnsubclassWindow"
  - "CContainedWindow.UnsubclassWindow"
  - "UnsubclassWindow"
  - "ATL::CContainedWindowT::UnsubclassWindow"
  - "CContainedWindowT.UnsubclassWindow"
  - "ATL.CContainedWindowT.UnsubclassWindow"
  - "CContainedWindow::UnsubclassWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UnsubclassWindow method"
ms.assetid: 4baa289b-6a73-4f5c-b4be-60e79a68d624
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CContainedWindowT::UnsubclassWindow
Detaches the subclassed window from the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object and restores the original window procedure, saved in [m_pfnSuperWindowProc](../vs140/ccontainedwindowt--m_pfnsuperwindowproc.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Set to **TRUE** to force the original window procedure to be restored even if the window procedure for this <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object is not currently active. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is set to **FALSE** and the window procedure for this <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object is not currently active, the original window procedure will not be restored.  
  
## Return Value  
 The handle to the window previously subclassed. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is set to **FALSE** and the window procedure for this <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object is not currently active, returns **NULL**.  
  
## Remarks  
 Use this method only if you want to restore the original window procedure before the window is destroyed. Otherwise, [WindowProc](../vs140/ccontainedwindowt--windowproc.md) will automatically do this when the window is destroyed.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CContainedWindowT Class](../vs140/ccontainedwindowt-class.md)   
 [CContainedWindowT::SubclassWindow](../vs140/ccontainedwindowt--subclasswindow.md)