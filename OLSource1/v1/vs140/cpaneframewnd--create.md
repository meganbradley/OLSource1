---
title: "CPaneFrameWnd::Create"
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
  - "CPaneFrameWnd.Create"
  - "CPaneFrameWnd::Create"
  - "Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method"
ms.assetid: d8e0516c-79b2-43d7-b56b-c6673396724b
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPaneFrameWnd::Create
Creates a miniframe window and attaches it to the [CPaneFrameWnd](../vs140/cpaneframewnd-class.md) object.  
  
## Syntax  
  
```  
virtual BOOL Create(  
    LPCTSTR lpszWindowName,  
    DWORD dwStyle,  
    const RECT& rect,  
    CWnd* pParentWnd,  
    CCreateContext* pContext = NULL  
);  
```  
  
#### Parameters  
 [in] `lpszWindowName`  
 Specifies the text to display on the miniframe window.  
  
 [in] `dwStyle`  
 Specifies the window style. For more information, see [Window Styles](../vs140/window-styles.md).  
  
 [in] `rect`  
 Specifies the initial size and position of the miniframe window.  
  
 [in] [out] `pParentWnd`  
 Specifies the parent frame of the miniframe window. This value must not be `NULL`.  
  
 [in] [out] `pContext`  
 Specifies user-defined context.  
  
## Return Value  
 `TRUE` if the window was created successfully; otherwise, `FALSE`.  
  
## Remarks  
 A miniframe window is created in two steps. First, the framework creates a [CPaneFrameWnd](../vs140/cpaneframewnd-class.md) object. Second, it calls `Create` to create the Windows miniframe window and attach it to the `CPaneFrameWnd` object.  
  
## Requirements  
 **Header:** afxPaneFrameWnd.h  
  
## See Also  
 [CPaneFrameWnd Class](../vs140/cpaneframewnd-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)