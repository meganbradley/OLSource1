---
title: "CFileDialog::OnTypeChange"
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
  - "CFileDialog.OnTypeChange"
  - "CFileDialog::OnTypeChange"
  - "OnTypeChange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnTypeChange method"
  - "CFileDialog class, protected operations"
ms.assetid: b6bab10e-e07d-4358-9116-58a67226866a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileDialog::OnTypeChange
Override this function to handle the **WM_NOTIFY CDN_TYPECHANGE** message.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The notification message is sent when the user selects a new file type from the list of file types in the Open or Save As dialog box.  
  
 Notification is sent only if the dialog box was created with the OFN_EXPLORER style. For more information about the notification, see [CDN_TYPECHANGE](http://msdn.microsoft.com/library/windows/desktop/ms646868). For information about the OFN_EXPLORER style, see the [OPENFILENAME](http://msdn.microsoft.com/library/windows/desktop/ms646839) structure and [Open and Save As Dialog Boxes](http://msdn.microsoft.com/library/windows/desktop/ms646960).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFileDialog Class](../vs140/cfiledialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFileDialog::OnFolderChange](../vs140/cfiledialog--onfolderchange.md)