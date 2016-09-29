---
title: "CFileDialog::CFileDialog"
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
  - "CFileDialog::CFileDialog"
  - "CFileDialog.CFileDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFileDialog class, construction/destruction"
  - "CFileDialog class, constructor"
ms.assetid: 58c4b5af-1bff-448a-acd9-dad7a40a7301
caps.latest.revision: 33
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileDialog::CFileDialog
Call this function to construct a standard Windows file dialog box.  
  
## Syntax  
  
```  
explicit CFileDialog(  
   BOOL bOpenFileDialog,  
   LPCTSTR lpszDefExt = NULL,  
   LPCTSTR lpszFileName = NULL,  
   DWORD dwFlags = OFN_HIDEREADONLY | OFN_OVERWRITEPROMPT,  
   LPCTSTR lpszFilter = NULL,  
   CWnd* pParentWnd = NULL,  
   DWORD dwSize = 0,  
   BOOL bVistaStyle = TRUE  
);  
```  
  
#### Parameters  
 [in] `bOpenFileDialog`  
 The parameter that specifies what type of dialog box to create. Set it to `TRUE` to construct a **File Open** dialog box. Set it to `FALSE` to construct a **File Save As** dialog box.  
  
 [in] `lpszDefExt`  
 The default file name extension. If the user does not include a known extension (one that has an association on the user’s computer) in the Filename box, the extension specified by `lpszDefExt` is automatically appended to the file name. If this parameter is `NULL`, no extension is appended.  
  
 [in] `lpszFileName`  
 The initial file name that appears in the Filename box. If `NULL`, no initial file name appears.  
  
 [in] `dwFlags`  
 A combination of one or more flags that you can use to customize the dialog box. For a description of these flags, see the [OPENFILENAME](http://msdn.microsoft.com/library/windows/desktop/ms646839) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. If you modify the `m_ofn.Flags` structure member, use a bitwise-OR operator in your changes to keep the default behavior intact.  
  
 [in] `lpszFilter`  
 A series of string pairs that specify filters you can apply to the file. If you specify file filters, only files that match filter criteria will appear in the Files list. See the Remarks section for more information about how to work with file filters.  
  
 [in] `pParentWnd`  
 A pointer to the parent or owner window of the file dialog box.  
  
 [in] `dwSize`  
 The size of the `OPENFILENAME` structure. This value depends on the operating system version. MFC used this parameter to determine the appropriate kind of dialog box to create (for example, new [!INCLUDE[win2kfamily](../vs140/includes/win2kfamily_md.md)] dialog boxes instead of NT4 dialog boxes). The default size of 0 means that the MFC code will determine the correct dialog box size to use based on the operating system version on which the program is run.  
  
 [in] `bVistaStyle`  
 **Note** This parameter is available in Visual Studio 2008 and later and is will cause the new-style dialog to be used only if you are running in [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] or later.  
  
 The parameter that specifies the style of the file dialog. Set it to `TRUE` to use the new Vista style file dialogs. Otherwise, the old style of dialog boxes will be used. See the Remarks section for more information about running under Vista.  
  
## Remarks  
 Either a **File Open** or **File Save As** dialog box is constructed, depending on the value of `bOpenFileDialog`.  
  
 Specifying a default extension using `lpszDefExt` may not produce the behavior that you expect, because it is seldom predictable what extensions have file associations on the user’s computer. If you need more control over the appending of a default extension, you can derive your own class from `CFileDialog`, and override the `CFileDialog::OnFileNameOK` method to perform your own extension handling.  
  
 To enable the user to select multiple files, set the `OFN_ALLOWMULTISELECT` flag before you call [DoModal](../vs140/cfiledialog--domodal.md). You must supply your own file name buffer to store the returned list of multiple file names. Do this by replacing `m_ofn.lpstrFile` with a pointer to a buffer you have allocated, after you construct the [CFileDialog](../vs140/cfiledialog-class.md), but before you call `DoModal`. Additionally, you must set `m_ofn.nMaxFile` with the number of characters in the buffer pointed to by `m_ofn.lpstrFile`. If you set the maximum number of files to be selected to `n`, the necessary buffer size is `n`*(_MAX_PATH + 1) + 1. For example:  
  
 [!code[NVC_MFCFiles#23](../vs140/codesnippet/CPP/cfiledialog--cfiledialog_1.cpp)]  
  
 To enable the user to resize an Explorer-style dialog box by using either the mouse or keyboard, set the `OFN_ENABLESIZING` flag. Setting this flag is necessary only if you provide a hook procedure or custom template. The flag works only with an Explorer-style dialog box; old-style dialog boxes cannot be resized.  
  
 The `lpszFilter` parameter is used to determine the type of file name a file must have to be displayed in the file list. The first string in the string pair describes the filter; the second string indicates the file name extension to use. Multiple extensions may be specified by using a semicolon (the ';' character) as the delimiter. The string ends with two '&#124;' characters, followed by a `NULL` character. You can also use a [CString](../vs140/using-cstring.md) object for this parameter.  
  
 For example, [!INCLUDE[ofprexcel](../vs140/includes/ofprexcel_md.md)] allows users to open files that have extensions .xlc (chart) or .xls (worksheet), among others. The filter for Excel could be written as:  
  
 [!code[NVC_MFCFiles#24](../vs140/codesnippet/CPP/cfiledialog--cfiledialog_2.cpp)]  
  
 However, if you plan to use this string to directly update the `OPENFILENAME` structure, you should delimit your strings with the null character, '\0', instead of the vertical bars ('&#124;').  
  
 The `bVistaStyle` parameter is applicable only when running under [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)]. Under earlier versions of Windows, this parameter is ignored. If `bVistaStyle` is set to `TRUE`, when you compile a program with [!INCLUDE[vs_orcas_long](../vs140/includes/vs_orcas_long_md.md)] or later, the new Vista style **File Dialog** will be used. Otherwise, the previous MFC style **File Dialog** will be used. See [CFileDialog Class](../vs140/cfiledialog-class.md) for more information.  
  
 Dialog templates are not supported on dialogs based on `bVistaStyle`  
  
## Example  
 See the example for [CFileDialog::DoModal](../vs140/cfiledialog--domodal.md).  
  
## Requirements  
 `Header:` afxdlgs.h  
  
## See Also  
 [CFileDialog Class](../vs140/cfiledialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFileDialog::DoModal](../vs140/cfiledialog--domodal.md)   
 [GetOpenFileName](http://msdn.microsoft.com/library/windows/desktop/ms646927)   
 [GetSaveFileName](http://msdn.microsoft.com/library/windows/desktop/ms646928)   
 [OPENFILENAME](http://msdn.microsoft.com/library/windows/desktop/ms646839)