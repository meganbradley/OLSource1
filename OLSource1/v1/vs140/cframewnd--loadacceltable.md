---
title: "CFrameWnd::LoadAccelTable"
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
  - "CFrameWnd::LoadAccelTable"
  - "LoadAccelTable"
  - "CFrameWnd.LoadAccelTable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadAccelTable method"
  - "CFrameWnd class, initialization"
ms.assetid: b434b4fb-ff27-4748-8f90-5a4ef9edd36a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWnd::LoadAccelTable
Call to load the specified accelerator table.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Identifies the name of the accelerator resource. Use **MAKEINTRESOURCE** if the resource is identified with an integer ID.  
  
## Return Value  
 Nonzero if the accelerator table was successfully loaded; otherwise 0.  
  
## Remarks  
 Only one table can be loaded at a time.  
  
 Accelerator tables loaded from resources are freed automatically when the application terminates.  
  
 If you call <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to create the frame window, the framework loads an accelerator table along with the menu and icon resources, and a subsequent call to this member function is then unnecessary.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFrameWnd::LoadFrame](../vs140/cframewnd--loadframe.md)   
 [LoadAccelerators](http://msdn.microsoft.com/library/windows/desktop/ms646370)