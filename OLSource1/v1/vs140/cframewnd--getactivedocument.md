---
title: "CFrameWnd::GetActiveDocument"
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
  - "CFrameWnd.GetActiveDocument"
  - "GetActiveDocument"
  - "CFrameWnd::GetActiveDocument"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFrameWnd class, operations"
  - "GetActiveDocument method"
ms.assetid: b478cc18-ac02-4c25-b9a2-3427cc4e3589
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWnd::GetActiveDocument
Call this member function to obtain a pointer to the current **CDocument** attached to the current active view.  
  
## Syntax  
  
```  
  
virtual CDocument* GetActiveDocument( );  
```  
  
## Return Value  
 A pointer to the current [CDocument](../vs140/cdocument-class.md). If there is no current document, returns **NULL**.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFrameWnd::GetActiveView](../vs140/cframewnd--getactiveview.md)