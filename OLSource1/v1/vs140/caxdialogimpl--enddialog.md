---
title: "CAxDialogImpl::EndDialog"
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
  - "ATL.CAxDialogImpl.EndDialog"
  - "ATL::CAxDialogImpl::EndDialog"
  - "CAxDialogImpl::EndDialog"
  - "CAxDialogImpl.EndDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EndDialog method"
ms.assetid: b0a948a8-879b-4093-8d42-30356adc6f73
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAxDialogImpl::EndDialog
Call this method to destroy a modal dialog box.  
  
## Syntax  
  
```  
  
      BOOL EndDialog(  
   int nRetCode   
);  
```  
  
#### Parameters  
 `nRetCode`  
 [in] The value to be returned by [DoModal](../vs140/caxdialogimpl--domodal.md).  
  
## Return Value  
 TRUE if the dialog box is destroyed; otherwise, FALSE.  
  
## Remarks  
 `EndDialog` must be called through the dialog box procedure. After the dialog box is destroyed, Windows uses the value of `nRetCode` as the return value for `DoModal`, which created the dialog box.  
  
> [!NOTE]
>  Do not call `EndDialog` to destroy a modeless dialog box. Call [DestroyWindow](../vs140/caxdialogimpl--destroywindow.md) instead.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CAxDialogImpl Class](../vs140/caxdialogimpl-class.md)   
 [CAxDialogImpl::DoModal](../vs140/caxdialogimpl--domodal.md)