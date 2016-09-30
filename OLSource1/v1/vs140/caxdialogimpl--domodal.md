---
title: "CAxDialogImpl::DoModal"
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
  - "CAxDialogImpl::DoModal"
  - "ATL::CAxDialogImpl::DoModal"
  - "CAxDialogImpl.DoModal"
  - "ATL.CAxDialogImpl.DoModal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoModal method"
ms.assetid: 6e73edec-cf82-4179-95d9-ca18d8814fb3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAxDialogImpl::DoModal
Call this method to create a modal dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The handle to the owner window. The default value is the return value of the [GetActiveWindow](http://msdn.microsoft.com/library/windows/desktop/ms646292) Win32 function.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Specifies the value to pass to the dialog box in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter of the **WM_INITDIALOG** message.  
  
## Return Value  
 If successful, the value of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter specified in the call to [EndDialog](../vs140/caxdialogimpl--enddialog.md); otherwise, -1.  
  
## Remarks  
 This dialog box is automatically attached to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
 To create a modeless dialog box, call [Create](../vs140/caxdialogimpl--create.md).  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CAxDialogImpl Class](../vs140/caxdialogimpl-class.md)   
 [CAxDialogImpl::EndDialog](../vs140/caxdialogimpl--enddialog.md)   
 [CAxDialogImpl::Create](../vs140/caxdialogimpl--create.md)