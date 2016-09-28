---
title: "CTaskDialog::ShowDialog"
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
  - "CTaskDialog.ShowDialog"
  - "ShowDialog"
  - "CTaskDialog::ShowDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ShowDialog method"
ms.assetid: f26d019d-0da6-4e54-9a4f-bd69634a0f19
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::ShowDialog
Creates and displays a `CTaskDialog`.  
  
## Syntax  
  
```  
static INT_PTR ShowDialog(  
   const CString& strContent,  
   const CString& strMainInstruction,  
   const CString& strTitle,  
   int nIDCommandControlsFirst,  
   int nIDCommandControlsLast,  
   int nCommonButtons = TDCBF_YES_BUTTON | TDCBF_NO_BUTTON,  
   int nTaskDialogOptions = TDF_ENABLE_HYPERLINKS | TDF_USE_COMMAND_LINKS,  
   const CString& strFooter = _T("")  
);  
```  
  
#### Parameters  
 [in] `strContent`  
 The string to use for the content of the `CTaskDialog`.  
  
 [in] `strMainInstruction`  
 The main instruction of the `CTaskDialog`.  
  
 [in] `strTitle`  
 The title of the `CTaskDialog`.  
  
 [in] `nIDCommandControlsFirst`  
 The string ID of the first command.  
  
 [in] `nIDCommandControlsLast`  
 The string ID of the last command.  
  
 [in] `nCommonButtons`  
 A mask of the buttons to add to the `CTaskDialog`.  
  
 [in] `nTaskDialogOptions`  
 The set of options to use for the `CTaskDialog`.  
  
 [in] `strFooter`  
 The string to use as the footer.  
  
## Return Value  
 An integer that corresponds to the selection made by the user.  
  
## Remarks  
 This static method enables you to create an instance of the [CTaskDialog Class](../vs140/ctaskdialog-class.md) without explicitly creating a `CTaskDialog` object in your code. Because there is no `CTaskDialog` object, you cannot call any other methods of the `CTaskDialog` if you use this method to show a `CTaskDialog` to the user.  
  
 This method creates command button controls by using data from the resource file of your application. The string table in the resource file has several strings with associated string IDs. This method adds a command button control for each valid entry in the string table between `nIDCommandControlsFirst` and `nCommandControlsLast`, inclusive. For these command button controls, the string in the string table is the control's caption and the string ID is the control's ID.  
  
 See [CTaskDialog::SetOptions](../vs140/ctaskdialog--setoptions.md) for a list of valid options.  
  
 The `CTaskDialog` closes when the user selects a common button, a command link control, or closes the `CTaskDialog`. The return value is the identifier that indicates how the user closed the dialog box.  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#1](../vs140/codesnippet/CPP/ctaskdialog--showdialog_1.cpp)]  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::CTaskDialog](../vs140/ctaskdialog--ctaskdialog.md)   
 [Walkthrough: Adding a CTaskDialog to an Application](../vs140/walkthrough--adding-a-ctaskdialog-to-an-application.md)