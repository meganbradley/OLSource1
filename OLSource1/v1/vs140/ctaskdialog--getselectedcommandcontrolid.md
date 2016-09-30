---
title: "CTaskDialog::GetSelectedCommandControlID"
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
  - "CTaskDialog::GetSelectedCommandControlID"
  - "GetSelectedCommandControlID"
  - "CTaskDialog.GetSelectedCommandControlID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSelectedCommandControlID method"
ms.assetid: ee405234-7f6f-44d7-9aa2-63c6e7d6020f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::GetSelectedCommandControlID
Returns the selected command button control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The ID of the currently selected command button control.  
  
## Remarks  
 You do not have to use this method to retrieve the ID of the command button that the user selected. That ID is returned by either [CTaskDialog::DoModal](../vs140/ctaskdialog--domodal.md) or [CTaskDialog::ShowDialog](../vs140/ctaskdialog--showdialog.md).  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#2](../vs140/codesnippet/CPP/ctaskdialog--getselectedcommandcontrolid_1.cpp)]  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::AddCommandControl](../vs140/ctaskdialog--addcommandcontrol.md)   
 [CTaskDialog::SetCommandControlOptions](../vs140/ctaskdialog--setcommandcontroloptions.md)   
 [CTaskDialog::IsCommandControlEnabled](../vs140/ctaskdialog--iscommandcontrolenabled.md)   
 [CTaskDialog::SetDefaultCommandControl](../vs140/ctaskdialog--setdefaultcommandcontrol.md)   
 [CTaskDialog::RemoveAllCommandControls](../vs140/ctaskdialog--removeallcommandcontrols.md)