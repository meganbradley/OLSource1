---
title: "CWnd::Create"
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
  - "CWnd.Create"
  - "CWnd::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method [C++]"
ms.assetid: b922f3eb-429b-4ab8-8045-dd0f24a3c32f
caps.latest.revision: 25
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::Create
Creates the specified child window and attaches it to the [CWnd](../vs140/cwnd-class.md) object.  
  
## Syntax  
  
```  
virtual BOOL Create(  
   LPCTSTR lpszClassName,  
   LPCTSTR lpszWindowName,  
   DWORD dwStyle,  
   Const RECT& rect,  
   CWnd* pParentWnd,  
   UINT nID,  
   CCreateContext* pContext = NULL  
);  
```  
  
#### Parameters  
 [in] `lpszClassName`  
 Pointer to a null-terminated string that contains the name of a registered system window class; or the name of a predefined system window class.  
  
 [in] `lpszWindowName`  
 Pointer to a null-terminated string that contains the window display name; otherwise `NULL` for no window display name.  
  
 [in] `dwStyle`  
 Bitwise combination (OR) of [window styles](../vs140/window-styles.md). The `WS_POPUP` option is not a valid style.  
  
 [in] `rect`  
 The size and location of the window relative to the top-left corner of the parent window.  
  
 [in] `pParentWnd`  
 Pointer to the parent window.  
  
 [in] `nID`  
 ID of the window.  
  
 [in] `pContext`  
 Pointer to a [CCreateContext](../vs140/ccreatecontext-structure.md) structure that is used to customize the document-view architecture for the application.  
  
## Return Value  
 `TRUE` if the method was successful; otherwise `FALSE`.  
  
## Remarks  
  
> [!WARNING]
>  `CWnd::PreCreateWindow` now assigns the hMenu member of its `CREATESTRUCT` parameter to the `this` pointer if the menu is `NULL` and the style contains `WS_CHILD`. For proper functionality, ensure that your dialog control has an ID that is not `NULL`.  
>   
>  This change fixes a crash in managed/native interop scenarios. A `TRACE` statement in `CWnd::Create` alerts the developer of the problem.  
  
 Use the [AfxRegisterWndClass](../vs140/afxregisterwndclass.md) function to register window classes. User defined window classes are available in the module where they are registered.  
  
 The [CWnd::OnCreate](../vs140/cwnd--oncreate.md) method is called before the `Create` method returns, and before the window becomes visible.  
  
## Example  
 [!code[NVC_MFCWindowing#79](../vs140/codesnippet/CPP/cwnd--create_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::CWnd](../vs140/cwnd--cwnd.md)   
 [CWnd::CreateEx](../vs140/cwnd--createex.md)   
 [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680)