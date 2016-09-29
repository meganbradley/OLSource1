---
title: "AtlAxDialogBox"
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
  - "ATL::AtlAxDialogBox"
  - "AtlAxDialogBox"
  - "ATL.AtlAxDialogBox"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlAxDialogBox function"
ms.assetid: fd1effa3-ccc2-4384-b474-95903ea3082f
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlAxDialogBox
Creates a modal dialog box from a dialog template provided by the user.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
      ATLAPI_(int) AtlAxDialogBox(  
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
 To use **AtlAxDialogBox** with a dialog template that contains an ActiveX control, specify a valid **CLSID**, **APPID** or URL string as the *text* field of the **CONTROL** section of the dialog resource, along with "AtlAxWin80" as the *class name* field under the same section. The following demonstrates what a valid **CONTROL** section might look like:  
  
 `CONTROL    "{04FE35E9-ADBC-4f1d-83FE-8FA4D1F71C7F}", IDC_TEST,`  
  
 `"AtlAxWin80", WS_GROUP | WS_TABSTOP, 0, 0, 100, 100`  
  
 For more information on editing resource scripts, see [Opening a Resource Script File in Text Format](../VS_csharp/how-to--open-a-resource-script-file-in-text-format.md). For more information on control resource-definition statements, see [Common Control Parameters](http://msdn.microsoft.com/library/windows/desktop/aa380902) under [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)]*: SDK Tools*.  
  
 For more information on dialog boxes in general, refer to [DialogBox](http://msdn.microsoft.com/library/windows/desktop/ms645452) and [CreateDialogParam](http://msdn.microsoft.com/library/windows/desktop/ms645445) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlhost.h  
  
## See Also  
 [Composite Control Global Functions](../VS_csharp/composite-control-global-functions.md)   
 [Composite Control Fundamentals](../VS_csharp/atl-composite-control-fundamentals.md)   
 [AtlAxCreateDialog](../VS_csharp/atlaxcreatedialog.md)