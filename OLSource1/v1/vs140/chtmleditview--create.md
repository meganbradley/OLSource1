---
title: "CHtmlEditView::Create"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CHtmlEditView::Create
  - CHtmlEditView.Create
dev_langs: 
  - C++
helpviewer_keywords: 
  - Create method [C++]
ms.assetid: 8a8b16fc-2eed-46a1-a743-671758de77c6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CHtmlEditView::Create
Creates a new window object.  
  
## Syntax  
  
```  
  
      virtual BOOL Create(  
   LPCTSTR lpszClassName,  
   LPCTSTR lpszWindowName,  
   DWORD dwStyle,  
   const RECT& rect,  
   CWnd* pParentWnd,  
   UINT nID,  
   CCreateContext* pContext = NULL  
);  
```  
  
#### Parameters  
 `lpszClassName`  
 Points to a null-terminated character string that names the Windows class. The class name can be any name registered with the [AfxRegisterWndClass](../vs140/afxregisterwndclass.md) global function or the **RegisterClass** Windows function. If **NULL**, uses the predefined default [CFrameWnd](../vs140/cframewnd-class.md) attributes.  
  
 `lpszWindowName`  
 Points to a null-terminated character string that represents the window name.  
  
 `dwStyle`  
 Specifies the window style attributes. By default, the **WS_VISIBLE** and **WS_CHILD** Windows styles are set.  
  
 `rect`  
 A reference to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure specifying the size and position of the window. The `rectDefault` value allows Windows to specify the size and position of the new window.  
  
 `pParentWnd`  
 A pointer to the parent window of the control.  
  
 `nID`  
 The ID number of the view. By default, set to **AFX_IDW_PANE_FIRST**.  
  
 `pContext`  
 A pointer to a [CCreateContext](../vs140/ccreatecontext-structure.md). **NULL** by default.  
  
## Remarks  
 This method will also call the contained WebBrowser's **Navigate** method to load a default document (see [CHtmlEditView::GetStartDocument](../vs140/chtmleditview--getstartdocument.md)).  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditView Class](../vs140/chtmleditview-class.md)   
 [CHtmlView::Create](../vs140/chtmlview--create.md)