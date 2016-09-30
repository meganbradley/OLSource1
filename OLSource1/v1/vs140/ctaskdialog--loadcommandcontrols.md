---
title: "CTaskDialog::LoadCommandControls"
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
  - "LoadCommandControls"
  - "CTaskDialog::LoadCommandControls"
  - "CTaskDialog.LoadCommandControls"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadCommandControls method"
ms.assetid: 8a321702-82b0-469b-8500-00bd6b6f06e8
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::LoadCommandControls
Adds command button controls by using data from the string table.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The string ID of the first command.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The string ID of the last command.  
  
## Remarks  
 This method creates command button controls by using data from the resource file of your application. The string table in the resource file has several strings with associated string IDs. New command button controls added by using this method use the string for the control's caption and the string ID for the control's ID. The range of strings selected is provided by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, inclusive. If there is an empty entry in the range, the method does not add a command button control for that entry.  
  
 By default, new command button controls are enabled and do not require elevation.  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#2](../vs140/codesnippet/CPP/ctaskdialog--loadcommandcontrols_1.cpp)]  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::AddCommandControl](../vs140/ctaskdialog--addcommandcontrol.md)   
 [CTaskDialog::SetCommandControlOptions](../vs140/ctaskdialog--setcommandcontroloptions.md)   
 [CTaskDialog::RemoveAllCommandControls](../vs140/ctaskdialog--removeallcommandcontrols.md)