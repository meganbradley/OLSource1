---
title: "CToolBar::LoadToolBar"
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
  - "CToolBar::LoadToolBar"
  - "CToolBar.LoadToolBar"
  - "LoadToolBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CToolBar class, loading toolbar resources"
  - "toolbars [C++], loading"
  - "LoadToolBar method"
ms.assetid: fa05c955-f1bf-4d0d-bccb-955085f589c6
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBar::LoadToolBar
Call this member function to load the toolbar specified by `lpszResourceName` or `nIDResource`.  
  
## Syntax  
  
```  
  
      BOOL LoadToolBar(  
   LPCTSTR lpszResourceName   
);  
BOOL LoadToolBar(  
   UINT nIDResource   
);  
```  
  
#### Parameters  
 `lpszResourceName`  
 Pointer to the resource name of the toolbar to be loaded.  
  
 `nIDResource`  
 Resource ID of the toolbar to be loaded.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 See [toolbar editor](../vs140/toolbar-editor.md) in for more information about creating a toolbar resource.  
  
## Example  
 See the example for [CToolBar::CreateEx](../vs140/ctoolbar--createex.md).  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CToolBar Class](../vs140/ctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBar::Create](../vs140/ctoolbar--create.md)   
 [CToolBar::LoadBitmap](../vs140/ctoolbar--loadbitmap.md)   
 [CToolBar::SetButtons](../vs140/ctoolbar--setbuttons.md)