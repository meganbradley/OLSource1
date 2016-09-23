---
title: "CFileDialog::SetTemplate"
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
  - CFileDialog::SetTemplate
  - SetTemplate
  - CFileDialog.SetTemplate
dev_langs: 
  - C++
helpviewer_keywords: 
  - CFileDialog class, operations
  - SetTemplate method
ms.assetid: be1ce1c4-d04a-4898-8557-0d3b244ac619
caps.latest.revision: 25
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFileDialog::SetTemplate
Sets the dialog box template for the [CFileDialog](../vs140/cfiledialog-class.md) object.  
  
## Syntax  
  
```  
void SetTemplate(  
   UINT nWin3ID,  
   UINT nWin4ID   
);  
void SetTemplate(  
   LPCTSTR lpWin3ID,  
   LPCTSTR lpWin4ID   
);  
```  
  
#### Parameters  
 [in] `nWin3ID`  
 Contains the ID number of the template resource for the non-Explorer `CFileDialog` object. This template is only used on Windows NT 3.51 or when the OFN_EXPLORER style is not present.  
  
 [in] `nWin4ID`  
 Contains the ID number of the template resource for the Explorer `CFileDialog` object. This template is used only on [!INCLUDE[WinNt4Family](../vs140/includes/winnt4family_md.md)] and later versions, Windows 95 and later versions, or when the OFN_EXPLORER style is present.  
  
 [in] `lpWin3ID`  
 Contains the name of the template resource for the non-Explorer `CFileDialog` object. This template is only used on Windows NT 3.51 or when the OFN_EXPLORER style is not present.  
  
 [in] `lpWin4ID`  
 Contains the name of the template resource of the Explorer `CFileDialog` object. This template is used only on [!INCLUDE[WinNt4Family](../vs140/includes/winnt4family_md.md)] and later versions, Windows 95 and later versions, or when the OFN_EXPLORER style is present.  
  
## Remarks  
 The system will use only one of the specified templates. The system determines which template to use based on the presence of the OFN_EXPLORER style and the operating system that the application is running on. By specifying both a non-Explorer and Explorer-style template, it is easy to support Windows NT 3.51, [!INCLUDE[WinNt4Family](../vs140/includes/winnt4family_md.md)] and later versions, and Windows 95 and later versions.  
  
> [!NOTE]
>  [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] style file dialog boxes do not support this function. Attempting to use this function on a [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] style file dialog box will throw [CNotSupportedException](../vs140/cnotsupportedexception-class.md). See [CFileDialog Class](../vs140/cfiledialog-class.md) for more information. An alternative is to use a customized dialog. For more information about using a custom `CFileDialog`, see [IFileDialogCustomize](http://msdn.microsoft.com/library/windows/desktop/bb775912).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFileDialog Class](../vs140/cfiledialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)