---
title: "CFileDialog::GetIFileDialogCustomize"
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
  - "CFileDialog::GetIFileDialogCustomize"
  - "CFileDialog.GetIFileDialogCustomize"
  - "GetIFileDialogCustomize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFileDialog class, operations"
  - "GetIFileDialogCustomize method"
ms.assetid: 90ca7c7a-93d8-482c-b509-c9c3fe9c1e47
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileDialog::GetIFileDialogCustomize
Retrieves a pointer to the internal COM object for a given [CFileDialog](../vs140/cfiledialog-class.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The pointer to the internal COM object for the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. It is your responsibility to release this pointer appropriately.  
  
## Remarks  
 Use this function only under [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] with an object that has <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. If you use this function when <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, it will return <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in release mode and throw an assertion in debug mode.  
  
 For more information about the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> interface,  see [IFileDialogCustomize](http://msdn.microsoft.com/library/windows/desktop/bb775912).  
  
## Example  
 This example retrieves the internal COM object. To run this code example, you must compile it under [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)].  
  
 [!code[NVC_MFC_CFileDialog#4](../vs140/codesnippet/CPP/cfiledialog--getifiledialogcustomize_1.cpp)]  
  
## Requirements  
 **Minimum required operating system:** [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)]  
  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFileDialog Class](../vs140/cfiledialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFileDialog::GetIFileOpenDialog](../vs140/cfiledialog--getifileopendialog.md)   
 [CFileDialog::GetIFileSaveDialog](../vs140/cfiledialog--getifilesavedialog.md)