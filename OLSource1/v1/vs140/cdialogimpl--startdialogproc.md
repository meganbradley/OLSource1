---
title: "CDialogImpl::StartDialogProc"
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
  - "StartDialogProc"
  - "CDialogImpl::StartDialogProc"
  - "CDialogImpl.StartDialogProc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "StartDialogProc method"
ms.assetid: 96d34eb1-a693-44e6-b048-5b95a3041a94
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDialogImpl::StartDialogProc
Called only once, when the first message is received, to process messages sent to the dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The handle to the dialog box.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The message sent to the dialog box.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Additional message-specific information.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Additional message-specific information.  
  
## Return Value  
 The window procedure.  
  
## Remarks  
 After the initial call to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is set as a dialog procedure, and further calls go there.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CDialogImpl Class](../vs140/cdialogimpl-class.md)   
 [CDialogImpl::DialogProc](../vs140/cdialogimpl--dialogproc.md)