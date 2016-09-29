---
title: "CTaskDialog::IsCommandControlEnabled"
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
  - "CTaskDialog::IsCommandControlEnabled"
  - "CTaskDialog.IsCommandControlEnabled"
  - "IsCommandControlEnabled"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsCommandControlEnabled method"
ms.assetid: d4a45967-57f0-41fd-b013-206a70a868a8
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::IsCommandControlEnabled
Determines whether a command button control or button is enabled.  
  
## Syntax  
  
```  
BOOL IsCommandControlEnabled(  
   int nCommandControlID  
) const;  
```  
  
#### Parameters  
 [in] `nCommandControlID`  
 The ID of the command button control or button to test.  
  
## Return Value  
 `TRUE` if the control is enabled, `FALSE` if it is not.  
  
## Remarks  
 You can use this method to determine the availability of both command button controls and the common buttons of the [CTaskDialog Class](../vs140/ctaskdialog-class.md).  
  
 If `nCommandControlID` is not a valid identifier for either a common `CTaskDialog` button or a command button control, this method throws an exception.  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#2](../vs140/codesnippet/CPP/ctaskdialog--iscommandcontrolenabled_1.cpp)]  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::AddCommandControl](../vs140/ctaskdialog--addcommandcontrol.md)   
 [CTaskDialog::SetCommandControlOptions](../vs140/ctaskdialog--setcommandcontroloptions.md)   
 [CTaskDialog::GetSelectedCommandControlID](../vs140/ctaskdialog--getselectedcommandcontrolid.md)   
 [CTaskDialog::SetDefaultCommandControl](../vs140/ctaskdialog--setdefaultcommandcontrol.md)   
 [CTaskDialog::RemoveAllCommandControls](../vs140/ctaskdialog--removeallcommandcontrols.md)