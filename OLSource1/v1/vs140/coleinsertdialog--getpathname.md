---
title: "COleInsertDialog::GetPathName"
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
  - "COleInsertDialog::GetPathName"
  - "COleInsertDialog.GetPathName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleInsertDialog class, operations and attributes"
  - "GetPathName method"
ms.assetid: 5a9d28e5-a434-4ce5-85f4-482bc1b22b90
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleInsertDialog::GetPathName
Call this function to get the full path of the selected file only if [DoModal](../vs140/coleinsertdialog--domodal.md) returns **IDOK** and the selection type is not **COleInsertDialog::createNewItem**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The full path to the file selected in the dialog box. If the selection type is <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, this function returns a meaningless <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in release mode or causes an assertion in debug mode.  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COleInsertDialog Class](../vs140/coleinsertdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleInsertDialog::GetSelectionType](../vs140/coleinsertdialog--getselectiontype.md)   
 [COleInsertDialog::DoModal](../vs140/coleinsertdialog--domodal.md)