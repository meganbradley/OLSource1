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
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::ShowDialog
Creates and displays a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The string to use for the content of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The main instruction of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The title of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The string ID of the first command.  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The string ID of the last command.  
  
 [in] <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A mask of the buttons to add to the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The set of options to use for the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The string to use as the footer.  
  
## Return Value  
 An integer that corresponds to the selection made by the user.  
  
## Remarks  
 This static method enables you to create an instance of the [CTaskDialog Class](../vs140/ctaskdialog-class.md) without explicitly creating a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object in your code. Because there is no <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object, you cannot call any other methods of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> if you use this method to show a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to the user.  
  
 This method creates command button controls by using data from the resource file of your application. The string table in the resource file has several strings with associated string IDs. This method adds a command button control for each valid entry in the string table between <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, inclusive. For these command button controls, the string in the string table is the control's caption and the string ID is the control's ID.  
  
 See [CTaskDialog::SetOptions](../vs140/ctaskdialog--setoptions.md) for a list of valid options.  
  
 The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> closes when the user selects a common button, a command link control, or closes the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. The return value is the identifier that indicates how the user closed the dialog box.  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#1](../vs140/codesnippet/CPP/ctaskdialog--showdialog_1.cpp)]  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::CTaskDialog](../vs140/ctaskdialog--ctaskdialog.md)   
 [Walkthrough: Adding a CTaskDialog to an Application](../vs140/walkthrough--adding-a-ctaskdialog-to-an-application.md)