---
title: "CFileDialog::m_ofn"
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
  - "CFileDialog.m_ofn"
  - "m_ofn"
  - "CFileDialog::m_ofn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_ofn"
  - "CFileDialog class, data members"
ms.assetid: 93c04491-1e0c-4312-884d-10b9ed579f6e
caps.latest.revision: 27
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileDialog::m_ofn
`m_ofn` is a structure of type `OPENFILENAME`. The data in this structure represents the current state of the `CFileDialog`.  
  
## Remarks  
 Use this structure to initialize the appearance of a **File Open** or **File Save As** dialog box after you construct it but before you display it with the [DoModal](../vs140/cfiledialog--domodal.md) method. For example, you can set the `lpstrTitle` member of `m_ofn` to the caption you want the dialog box to have.  
  
 With the [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] style of [CFileDialog](../vs140/cfiledialog-class.md), `m_ofn` is not guaranteed to always match the state of the dialog box. It is synchronized with the dialog box in earlier versions of Windows. See [CFileDialog::ApplyOFNToShellDialog](../vs140/cfiledialog--applyofntoshelldialog.md) and [CFileDialog::UpdateOFNFromShellDialog](../vs140/cfiledialog--updateofnfromshelldialog.md) for more information about synchronizing the `m_ofn` structure and the `CFileDialog` state under [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)].  
  
 [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] style file dialogs do not support certain members and flags of the `CFileDialog`. As a result, these will have no effect.  
  
 The following is a list of the members that are not supported by [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)]:  
  
-   `lpstrCustomFilter`  
  
-   `lpstrInitialDir`  
  
-   `lCustData`  
  
-   `lpfnHook`  
  
-   `lpTemplateName`  
  
 The following flags are not supported and therefore have no effect when you use the [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] style of `CFileDialog`:  
  
-   OFN_ENABLEHOOK  
  
-   OFN_ENABLEINCLUDENOTIFY  
  
-   OFN_ENABLETEMPLATE  
  
-   OFN_ENABLETEMPLATEHANDLE  
  
-   OFN_EXPLORER  
  
-   OFN_EXTENSIONDIFFERENT  
  
-   OFN_HIDEREADONLY  
  
-   OFN_LONGNAMES - effectively always on in [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)]  
  
-   OFN_NOLONGNAMES - effectively always off in [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)]  
  
-   OFN_NONETWORKBUTTON - effectively always on in [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)]  
  
-   OFN_READONLY  
  
-   OFN_SHOWHELP  
  
 For more information about this structure, see the [OPENFILENAME](http://msdn.microsoft.com/library/windows/desktop/ms646839) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For more information about the different behavior of the `CFileDialog` under [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)], see [CFileDialog Class](../vs140/cfiledialog-class.md).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFileDialog Class](../vs140/cfiledialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)