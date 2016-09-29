---
title: "CFileDialog::OnFolderChange"
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
  - "OnFolderChange"
  - "CFileDialog::OnFolderChange"
  - "CFileDialog.OnFolderChange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFolderChange method"
  - "CFileDialog class, protected operations"
ms.assetid: 6445d800-19ae-4a78-b77f-61cc1cbc4c1c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileDialog::OnFolderChange
Override this function to handle the **WM_NOTIFY CDN_FOLDERCHANGE** message.  
  
## Syntax  
  
```  
  
virtual void OnFolderChange( );  
```  
  
## Remarks  
 The notification message is sent when a new folder is opened in the Open or Save As dialog box.  
  
 Notification is sent only if the dialog box was created with the OFN_EXPLORER style. For more information about the notification, see [CDN_FOLDERCHANGE](http://msdn.microsoft.com/library/windows/desktop/ms646859). For information about the OFN_EXPLORER style, see the [OPENFILENAME](http://msdn.microsoft.com/library/windows/desktop/ms646839) structure and [Open and Save As Dialog Boxes](http://msdn.microsoft.com/library/windows/desktop/ms646960).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFileDialog Class](../vs140/cfiledialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFileDialog::OnFileChange](#_mfc_cfiledialog.3a3a.onfolderchange)