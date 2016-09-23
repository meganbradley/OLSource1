---
title: "CPropertySheet::DoModal"
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
  - CPropertySheet::DoModal
  - CPropertySheet.DoModal
dev_langs: 
  - C++
helpviewer_keywords: 
  - CPropertySheet class, operations
  - DoModal method
ms.assetid: 72e0a452-93bb-44c9-938b-e13a7fda7f3e
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPropertySheet::DoModal
Displays a modal property sheet.  
  
## Syntax  
  
```  
virtual INT_PTR DoModal();  
```  
  
## Return Value  
 `IDOK` or `IDCANCEL` if the function was successful; otherwise 0 or -1. If the property sheet has been established as a wizard (see [SetWizardMode](../vs140/cpropertysheet--setwizardmode.md)), `DoModal` returns either `ID_WIZFINISH` or `IDCANCEL`.  
  
## Remarks  
 The return value corresponds to the ID of the control that closed the property sheet. After this function returns, the windows corresponding to the property sheet and all the pages will have been destroyed. The objects themselves will still exist. Typically, you will retrieve data from the [CPropertyPage](../vs140/cpropertypage-class.md) objects after `DoModal` returns `IDOK`.  
  
 To display a modeless property sheet, call [Create](../vs140/cpropertysheet--create.md) instead.  
  
 When a property page is created from its corresponding dialog resource, it can cause a first-chance exception. This results from the property page changing the style of the dialog resource to the required style before the page is created. Because resources are generally read-only, this causes an exception. The system handles the exception, and makes a copy of the modified resource. The first-chance exception can therefore be ignored.  
  
> [!NOTE]
>  This exception must be handled by the operating system if you are compiling with the asynchronous exception handling model. For more information about exception handling models, see [/EH (Exception Handling Model)](../vs140/-eh--exception-handling-model-.md). In this case, do not wrap calls to `CPropertySheet::DoModal` with a C++ try-catch block in which the catch handles all exceptions, for example, `catch (...)`. This block would handle the exception intended for the operating system, and cause unpredictable behavior. However, you can safely use C++ exception handling with specific exception types or structured exception handling where the Access Violation exception is passed through to the operating system.  
  
 To avoid generating this first-chance exception, you can manually guarantee that the property sheet has the correct [Window Styles](../vs140/window-styles.md). You need to set the following styles for a property sheet:  
  
-   DS_3DLOOK  
  
-   DS_CONTROL  
  
-   WS_CHILD  
  
-   WS_TABSTOP  
  
 You can use the following optional styles without causing a first-chance exception:  
  
-   DS_SHELLFONT  
  
-   DS_LOCALEDIT  
  
-   WS_CLIPCHILDREN  
  
 Disable all other Windows styles because they are not compatible with property sheets. This advice does not apply to extended styles. Setting these standard styles appropriately will guarantee that the property sheet does not have to be modified and will avoid generating the first-chance exception.  
  
## Example  
 See the example for [CPropertySheet::AddPage](../vs140/cpropertysheet--addpage.md).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertySheet Class](../vs140/cpropertysheet-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDialog::DoModal](../vs140/cdialog--domodal.md)   
 [CPropertySheet::Create](../vs140/cpropertysheet--create.md)