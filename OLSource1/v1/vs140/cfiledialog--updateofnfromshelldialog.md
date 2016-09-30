---
title: "CFileDialog::UpdateOFNFromShellDialog"
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
  - "CFileDialog::UpdateOFNFromShellDialog"
  - "CFileDialog.UpdateOFNFromShellDialog"
  - "UpdateOFNFromShellDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFileDialog class, operations"
  - "UpdateOFNFromShellDialog method"
ms.assetid: bdc75632-bd12-4740-9aeb-17c681f39abc
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileDialog::UpdateOFNFromShellDialog
Updates the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> data structure of the [CFileDialog](../vs140/cfiledialog-class.md) based on the current state of the internal object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 In versions of Windows before [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)], the member [OPENFILENAME](https://msdn.microsoft.com/en-us/library/ms911906.aspx) data structure was continuously synchronized with the state of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. Any changes to the [m_ofn](../vs140/cfiledialog--m_ofn.md) member variable directly affected the state of the dialog box. Also, any changes to the state of the dialog immediately updated the m_ofn member variable.  
  
 In [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)], the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> data structure is not automatically updated. To guarantee the accuracy of the data in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> member variable, you should call the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function before accessing the data. Windows calls this function automatically during the processing of [IFileDialog::OnFileOK](http://msdn.microsoft.com/library/windows/desktop/bb775879).  
  
 For more information about how to use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> class under [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)], see [CFileDialog Class](../vs140/cfiledialog-class.md).  
  
## Example  
 This example updates the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> before displaying it. Before updating the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> member variable, we need to synchronize it to the current state of the dialog box.  
  
 [!code[NVC_MFC_CFileDialog#1](../vs140/codesnippet/CPP/cfiledialog--updateofnfromshelldialog_1.cpp)]  
  
## Requirements  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)]  
  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFileDialog Class](../vs140/cfiledialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFileDialog::ApplyOFNToShellDialog](../vs140/cfiledialog--applyofntoshelldialog.md)