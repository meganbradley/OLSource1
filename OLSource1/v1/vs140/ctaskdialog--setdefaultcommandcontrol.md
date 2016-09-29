---
title: "CTaskDialog::SetDefaultCommandControl"
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
  - "CTaskDialog.SetDefaultCommandControl"
  - "SetDefaultCommandControl"
  - "CTaskDialog::SetDefaultCommandControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDefaultCommandControl method"
ms.assetid: 17afe828-8525-4c2c-a503-c162a1df000c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::SetDefaultCommandControl
Specifies the default command button control.  
  
## Syntax  
  
```  
void SetDefaultCommandControl(  
   int nCommandControlID  
);  
```  
  
#### Parameters  
 [in] `nCommandControlID`  
 The ID of the command button control to be the default.  
  
## Remarks  
 The default command button control is the control that is selected when the `CTaskDialog` is first displayed to the user.  
  
 This method throws an exception if it cannot find the command button control specified by `nCommandControlID`.  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#2](../vs140/codesnippet/CPP/ctaskdialog--setdefaultcommandcontrol_1.cpp)]  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::AddCommandControl](../vs140/ctaskdialog--addcommandcontrol.md)   
 [CTaskDialog::SetCommandControlOptions](../vs140/ctaskdialog--setcommandcontroloptions.md)   
 [CTaskDialog::GetSelectedCommandControlID](../vs140/ctaskdialog--getselectedcommandcontrolid.md)   
 [CTaskDialog::IsCommandControlEnabled](../vs140/ctaskdialog--iscommandcontrolenabled.md)   
 [CTaskDialog::RemoveAllCommandControls](../vs140/ctaskdialog--removeallcommandcontrols.md)