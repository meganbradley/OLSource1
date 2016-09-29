---
title: "CTaskDialog::SetCommandControlOptions"
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
  - "CTaskDialog::SetCommandControlOptions"
  - "SetCommandControlOptions"
  - "CTaskDialog.SetCommandControlOptions"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetCommandControlOptions method"
ms.assetid: 796f2e82-2db5-4d5c-88f3-c0ea3483f0b3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::SetCommandControlOptions
Updates a command button control on the `CTaskDialog`.  
  
## Syntax  
  
```  
void SetCommandControlOptions(  
   int nCommandControlID,  
   BOOL bEnabled,  
   BOOL bRequiresElevation = FALSE  
);  
```  
  
#### Parameters  
 [in] `nCommandControlID`  
 The ID of the command control to update.  
  
 [in] `bEnabled`  
 A Boolean parameter that indicates if the specified command button control is enabled or disabled.  
  
 [in] `bRequiresElevation`  
 A Boolean parameter that indicates if the specified command button control requires elevation.  
  
## Remarks  
 Use this method to change whether a command button control is enabled or requires elevation after it has been added to the [CTaskDialog Class](../vs140/ctaskdialog-class.md).  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#2](../vs140/codesnippet/CPP/ctaskdialog--setcommandcontroloptions_1.cpp)]  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::AddCommandControl](../vs140/ctaskdialog--addcommandcontrol.md)   
 [CTaskDialog::ClickCommandControl](../vs140/ctaskdialog--clickcommandcontrol.md)   
 [CTaskDialog::GetSelectedCommandControlID](../vs140/ctaskdialog--getselectedcommandcontrolid.md)   
 [CTaskDialog::IsCommandControlEnabled](../vs140/ctaskdialog--iscommandcontrolenabled.md)   
 [CTaskDialog::RemoveAllCommandControls](../vs140/ctaskdialog--removeallcommandcontrols.md)   
 [CTaskDialog::SetDefaultCommandControl](../vs140/ctaskdialog--setdefaultcommandcontrol.md)