---
title: "CPropertySheet::Create"
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
  - "CPropertySheet::Create"
  - "CPropertySheet.Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPropertySheet class, operations"
  - "Create method [C++]"
ms.assetid: e2fb8a7d-40ca-4736-acce-734b6f92316e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropertySheet::Create
Displays a modeless property sheet.  
  
## Syntax  
  
```  
  
      virtual BOOL Create(  
   CWnd* pParentWnd = NULL,  
   DWORD dwStyle = (DWORD)–1,  
   DWORD dwExStyle = 0   
);  
```  
  
#### Parameters  
 `pParentWnd`  
 Points to parent window. If **NULL**, parent is the desktop.  
  
 `dwStyle`  
 Window styles for property sheet. For a complete list of available styles, see [Window Styles](../vs140/window-styles.md).  
  
 `dwExStyle`  
 Extended window styles for property sheet. For a complete list of available styles, see [Extended Window Styles](../vs140/extended-window-styles.md)  
  
## Return Value  
 Nonzero if the property sheet is created successfully; otherwise 0.  
  
## Remarks  
 The call to **Create** can be inside the constructor, or you can call it after the constructor is invoked.  
  
 The default style, expressed by passing –1 as `dwStyle`, is actually **WS_SYSMENU &#124;** `WS_POPUP` **&#124; WS_CAPTION &#124; DS_MODALFRAME &#124; DS_CONTEXTHELP &#124; WS_VISIBLE**. The default extended window style, expressed by passing 0 as `dwExStyle`, is actually **WS_EX_DLGMODALFRAME**.  
  
 The **Create** member function returns immediately after creating the property sheet. To destroy the property sheet, call [CWnd::DestroyWindow](../vs140/cwnd--destroywindow.md).  
  
 Modeless property sheets displayed with a call to **Create** do not have OK, Cancel, Apply Now, and Help buttons as modal property sheets do. Desired buttons must be created by the user.  
  
 To display a modal property sheet, call [DoModal](../vs140/cpropertysheet--domodal.md) instead.  
  
## Example  
 [!code[NVC_MFCDocView#132](../vs140/codesnippet/CPP/cpropertysheet--create_1.cpp)]  
  
 [!code[NVC_MFCDocView#133](../vs140/codesnippet/CPP/cpropertysheet--create_2.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertySheet Class](../vs140/cpropertysheet-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDialog::Create](../vs140/cdialog--create.md)   
 [CPropertySheet::DoModal](../vs140/cpropertysheet--domodal.md)