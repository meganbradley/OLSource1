---
title: "COleChangeSourceDialog::COleChangeSourceDialog"
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
  - "COleChangeSourceDialog"
  - "COleChangeSourceDialog::COleChangeSourceDialog"
  - "COleChangeSourceDialog.COleChangeSourceDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleChangeSourceDialog class, constructor"
ms.assetid: b52046b3-4d99-48bb-8bdd-3486989ab874
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleChangeSourceDialog::COleChangeSourceDialog
This function constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the linked [COleClientItem](../vs140/coleclientitem-class.md) whose source is to be updated.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Points to the parent or owner window object (of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) to which the dialog object belongs. If it is **NULL**, the parent window of the dialog box will be set to the main application window.  
  
## Remarks  
 To display the dialog box, call the [DoModal](../vs140/colechangesourcedialog--domodal.md) function.  
  
 For more information, see the [OLEUICHANGESOURCE](http://msdn.microsoft.com/library/windows/desktop/ms682160) structure and [OleUIChangeSource](http://msdn.microsoft.com/library/windows/desktop/ms682497) function in [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COleChangeSourceDialog Class](../vs140/colechangesourcedialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)