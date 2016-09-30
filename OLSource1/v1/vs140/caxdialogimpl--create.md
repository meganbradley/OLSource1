---
title: "CAxDialogImpl::Create"
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
  - "ATL::CAxDialogImpl::Create"
  - "ATL.CAxDialogImpl.Create"
  - "CAxDialogImpl.Create"
  - "CAxDialogImpl::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method [C++]"
ms.assetid: 4d32454c-570a-4601-8926-e6c70d569091
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAxDialogImpl::Create
Call this method to create a modeless dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The handle to the owner window.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Specifies the value to pass to the dialog box in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter of the **WM_INITDIALOG** message.  
  
 **RECT&**  
 This parameter is not used. This parameter is passed in by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Return Value  
 The handle to the newly created dialog box.  
  
## Remarks  
 This dialog box is automatically attached to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object. To create a modal dialog box, call [DoModal](../vs140/caxdialogimpl--domodal.md).  
  
 The second override is provided only so dialog boxes can be used with [CComControl](../vs140/ccomcontrol-class.md).  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CAxDialogImpl Class](../vs140/caxdialogimpl-class.md)   
 [CAxDialogImpl::DestroyWindow](../vs140/caxdialogimpl--destroywindow.md)   
 [CAxDialogImpl::DoModal](../vs140/caxdialogimpl--domodal.md)