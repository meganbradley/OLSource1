---
title: "AtlAxCreateDialog"
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
  - "ATL.AtlAxCreateDialog"
  - "ATL::AtlAxCreateDialog"
  - "AtlAxCreateDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlAxCreateDialog function"
ms.assetid: ffde4deb-f681-461f-9732-b1bdb4084370
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlAxCreateDialog
Creates a modeless dialog box from a dialog template provided by the user.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
      ATLAPI_(HWND) AtlAxCreateDialog(  
HINSTANCE hInstance,  
LPCWSTR lpTemplateName,  
HWND hWndParent,  
DLGPROC lpDialogProc,  
LPARAM dwInitParam   
);  
```  
  
#### Parameters  
 `hInstance`  
 [in] Identifies an instance of the module whose executable file contains the dialog box template.  
  
 `lpTemplateName`  
 [in] Identifies the dialog box template. This parameter is either the pointer to a null-terminated character string that specifies the name of the dialog box template or an integer value that specifies the resource identifier of the dialog box template. If the parameter specifies a resource identifier, its high-order word must be zero and its low-order word must contain the identifier. You can use the [MAKEINTRESOURCE](http://msdn.microsoft.com/library/windows/desktop/ms648029) macro to create this value.  
  
 `hWndParent`  
 [in] Identifies the window that owns the dialog box.  
  
 `lpDialogProc`  
 [in] Points to the dialog box procedure. For more information about the dialog box procedure, see [DialogProc](http://msdn.microsoft.com/library/windows/desktop/ms645469).  
  
 `dwInitParam`  
 [in] Specifies the value to pass to the dialog box in the **lParam** parameter of the **WM_INITDIALOG** message.  
  
## Return Value  
 One of the standard HRESULT values.  
  
## Remarks  
 The resulting dialog box can contain ActiveX controls.  
  
 See [CreateDialog](http://msdn.microsoft.com/library/windows/desktop/ms645434) and [CreateDialogParam](http://msdn.microsoft.com/library/windows/desktop/ms645445) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlhost.h  
  
## See Also  
 [Composite Control Global Functions](../vs140/composite-control-global-functions.md)   
 [Composite Control Fundamentals](../vs140/atl-composite-control-fundamentals.md)   
 [AtlAxDialogBox](../vs140/atlaxdialogbox.md)