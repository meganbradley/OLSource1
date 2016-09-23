---
title: "CFileDialog::OnInitDone"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CFileDialog::OnInitDone
  - OnInitDone
  - CFileDialog.OnInitDone
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnInitDone method
  - CFileDialog class, protected operations
ms.assetid: 46e9fcc6-58f1-4809-bbd4-3b9c9fab9af7
caps.latest.revision: 23
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFileDialog::OnInitDone
Override this function to handle the `WM_NOTIFY` `CDN_INITDONE` message.  
  
## Syntax  
  
```  
virtual void OnInitDone( );  
```  
  
## Remarks  
 The system sends this notification message when the system has finished arranging controls in the **Open** or **Save As** dialog box to make room for the controls of the child dialog box.  
  
 The system sends this only if the dialog box was created with the OFN_EXPLORER style. For more information about the notification, see [CDN_INITDONE](http://msdn.microsoft.com/library/windows/desktop/ms646863). For information about the OFN_EXPLORER style, see the [OPENFILENAME](http://msdn.microsoft.com/library/windows/desktop/ms646839) structure and [Open and Save As Dialog Boxes](http://msdn.microsoft.com/library/windows/desktop/ms646960).  
  
> [!NOTE]
>  [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] style file dialogs do not support this function. Attempting to use this function on a [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] style file dialog will throw [CNotSupportedException](../vs140/cnotsupportedexception-class.md). See [CFileDialog Class](../vs140/cfiledialog-class.md) for more information.  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFileDialog Class](../vs140/cfiledialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)