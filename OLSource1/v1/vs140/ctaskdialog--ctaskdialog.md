---
title: "CTaskDialog::CTaskDialog"
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
  - "CTaskDialog.CTaskDialog"
  - "CTaskDialog::CTaskDialog"
  - "CTaskDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CTaskDialog constructor"
ms.assetid: b85933b3-4989-4663-9720-39466e6773d7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::CTaskDialog
Creates an instance of the [CTaskDialog Class](../vs140/ctaskdialog-class.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The string to use for the content of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The main instruction of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The title of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A mask of the common buttons to add to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The set of options to use for the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The string to use as the footer.  
  
 [in] <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The string ID of the first command.  
  
 [in] <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The string ID of the last command.  
  
## Remarks  
 There are two ways that you can add a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to your application. The first way is to use one of the constructors to create a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and display it using [CTaskDialog::DoModal](../vs140/ctaskdialog--domodal.md). The second way is to use the static function [CTaskDialog::ShowDialog](../vs140/ctaskdialog--showdialog.md), which enables you to display a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> without explicitly creating a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.  
  
 The second constructor creates command button controls by using data from the resource file of your application. The string table in the resource file has several strings with associated string IDs. This method adds a command button control for each valid entry in the string table between <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, inclusive. For these command button controls, the string in the string table is the control's caption and the string ID is the control's ID.  
  
 See [CTaskDialog::SetOptions](../vs140/ctaskdialog--setoptions.md) for a list of valid options.  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#7](../vs140/codesnippet/CPP/ctaskdialog--ctaskdialog_1.cpp)]  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::ShowDialog](../vs140/ctaskdialog--showdialog.md)   
 [CTaskDialog::DoModal](../vs140/ctaskdialog--domodal.md)   
 [CTaskDialog::SetOptions](../vs140/ctaskdialog--setoptions.md)   
 [Walkthrough: Adding a CTaskDialog to an Application](../vs140/walkthrough--adding-a-ctaskdialog-to-an-application.md)