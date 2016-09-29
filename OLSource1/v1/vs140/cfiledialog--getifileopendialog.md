---
title: "CFileDialog::GetIFileOpenDialog"
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
  - "GetIFileOpenDialog"
  - "CFileDialog.GetIFileOpenDialog"
  - "CFileDialog::GetIFileOpenDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFileDialog class, operations"
  - "GetIFileOpenDialog method"
ms.assetid: 637db7fb-a516-4674-9780-8343d7045bd0
caps.latest.revision: 23
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileDialog::GetIFileOpenDialog
Retrieves a pointer to the internal COM object for a given `CFileDialog`.  
  
## Syntax  
  
```  
IFileOpenDialog* GetIFileOpenDialog();  
```  
  
## Return Value  
 The pointer to the internal COM object for the `CFileDialog`. It is your responsibility to release this pointer appropriately.  
  
## Remarks  
 Use this function only under [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] with an object that has `bVistaStyle` set to `true`. This function returns `NULL` if the `CFileDialog` is not an **Open** dialog box or if `bVistaStyle` is set to `false`. In this final case, the function only returns `NULL` in release mode - in debug mode it will throw an assertion.  
  
 For more information about the `IFileOpenDialog` interface, see [IFileOpenDialog](http://msdn.microsoft.com/library/windows/desktop/bb775834).  
  
## Example  
 This example retrieves the internal COM object. To run this code, you must compile it under [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)].  
  
 [!code[NVC_MFC_CFileDialog#2](../vs140/codesnippet/CPP/cfiledialog--getifileopendialog_1.cpp)]  
  
## Requirements  
 `Minimum required operating system:` [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)]  
  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFileDialog Class](../vs140/cfiledialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFileDialog::GetIFileDialogCustomize](../vs140/cfiledialog--getifiledialogcustomize.md)   
 [CFileDialog::GetIFileSaveDialog](../vs140/cfiledialog--getifilesavedialog.md)