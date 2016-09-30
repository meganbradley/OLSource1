---
title: "CTaskDialog::AddCommandControl"
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
  - "CTaskDialog.AddCommandControl"
  - "CTaskDialog::AddCommandControl"
  - "AddCommandControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddCommandControl method"
ms.assetid: 297c4c0a-419e-49f8-8963-af938ed6eb10
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::AddCommandControl
Adds a new command button control to the `CTaskDialog`.  
  
## Syntax  
  
```  
void AddCommandControl(  
   int nCommandControlID,  
   const CString& strCaption,  
   BOOL bEnabled = TRUE,  
   BOOL bRequiresElevation = FALSE  
);  
```  
  
#### Parameters  
 [in] `nCommandControlID`  
 The command control identification number.  
  
 [in] `strCaption`  
 The string that the `CTaskDialog` displays to the user. Use this string to explain the purpose of the command.  
  
 [in] `bEnabled`  
 A Boolean parameter that indicates if the new button is enabled or disabled.  
  
 [in] `bRequiresElevation`  
 A Boolean parameter that indicates whether a command requires elevation.  
  
## Remarks  
 The [CTaskDialog Class](../vs140/ctaskdialog-class.md) can display an unlimited number of command button controls. However, if a `CTaskDialog` displays any command button controls, it can display a maximum of six buttons. If a `CTaskDialog` has no command button controls, it can display an unlimited number of buttons.  
  
 When the user selects a command button control, the `CTaskDialog` closes. If your application displays the dialog box by using [CTaskDialog::DoModal](../vs140/ctaskdialog--domodal.md), `DoModal` returns the `nCommandControlID` of the selected command button control.  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#2](../vs140/codesnippet/CPP/ctaskdialog--addcommandcontrol_1.cpp)]  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::ClickCommandControl](../vs140/ctaskdialog--clickcommandcontrol.md)   
 [CTaskDialog::GetSelectedCommandControlID](../vs140/ctaskdialog--getselectedcommandcontrolid.md)   
 [CTaskDialog::IsCommandControlEnabled](../vs140/ctaskdialog--iscommandcontrolenabled.md)   
 [CTaskDialog::RemoveAllCommandControls](../vs140/ctaskdialog--removeallcommandcontrols.md)   
 [CTaskDialog::SetCommandControlOptions](../vs140/ctaskdialog--setcommandcontroloptions.md)   
 [CTaskDialog::SetDefaultCommandControl](../vs140/ctaskdialog--setdefaultcommandcontrol.md)