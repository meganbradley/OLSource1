---
title: "COleChangeIconDialog::DoModal"
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
  - "COleChangeIconDialog::DoModal"
  - "COleChangeIconDialog.DoModal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoModal method"
  - "COleChangeIconDialog class, operations and attributes"
ms.assetid: aef3d917-dbc0-4863-b04c-c17e35aa44e7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleChangeIconDialog::DoModal
Call this function to display the OLE Change Icon dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Completion status for the dialog box. One of the following values:  
  
-   **IDOK** if the dialog box was successfully displayed.  
  
-   **IDCANCEL** if the user canceled the dialog box.  
  
-   **IDABORT** if an error occurred. If **IDABORT** is returned, call the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function to get more information about the type of error that occurred. For a listing of possible errors, see the [OleUIChangeIcon](http://msdn.microsoft.com/library/windows/desktop/ms688307) function in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 If you want to initialize the various dialog box controls by setting members of the [m_ci](../vs140/colechangeicondialog--m_ci.md) structure, you should do this before calling <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, but after the dialog object is constructed.  
  
 If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns **IDOK**, you can call other member functions to retrieve the settings or information that was input by the user into the dialog box.  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COleChangeIconDialog Class](../vs140/colechangeicondialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDialog::GetLastError](../vs140/coledialog--getlasterror.md)   
 [CDialog::DoModal](../vs140/cdialog--domodal.md)   
 [COleChangeIconDialog::m_ci](../vs140/colechangeicondialog--m_ci.md)   
 [COleChangeIconDialog::DoChangeIcon](../vs140/colechangeicondialog--dochangeicon.md)   
 [COleChangeIconDialog::GetIconicMetafile](../vs140/colechangeicondialog--geticonicmetafile.md)