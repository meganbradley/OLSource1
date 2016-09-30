---
title: "COlePasteSpecialDialog::DoModal"
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
  - "COlePasteSpecialDialog::DoModal"
  - "COlePasteSpecialDialog.DoModal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COlePasteSpecialDialog class, operations and attributes"
  - "DoModal method"
ms.assetid: 3d71b4f3-5764-4479-b6d2-627f6c448ea0
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COlePasteSpecialDialog::DoModal
Displays the OLE Paste Special dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Completion status for the dialog box. One of the following values:  
  
-   **IDOK** if the dialog box was successfully displayed.  
  
-   **IDCANCEL** if the user canceled the dialog box.  
  
-   **IDABORT** if an error occurred. If **IDABORT** is returned, call the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function to get more information about the type of error that occurred. For a listing of possible errors, see the [OleUIPasteSpecial](http://msdn.microsoft.com/library/windows/desktop/ms694512) function in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 If you want to initialize the various dialog box controls by setting members of the [m_ps](../vs140/colepastespecialdialog--m_ps.md) structure, you should do this before calling <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, but after the dialog object is constructed.  
  
 If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns **IDOK**, you can call other member functions to retrieve the settings or information input by the user into the dialog box.  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COlePasteSpecialDialog Class](../vs140/colepastespecialdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataObject Class](../vs140/coledataobject-class.md)   
 [COleDialog::GetLastError](../vs140/coledialog--getlasterror.md)   
 [CDialog::DoModal](../vs140/cdialog--domodal.md)   
 [COlePasteSpecialDialog::COlePasteSpecialDialog](../vs140/colepastespecialdialog--colepastespecialdialog.md)   
 [COlePasteSpecialDialog::GetDrawAspect](../vs140/colepastespecialdialog--getdrawaspect.md)   
 [COlePasteSpecialDialog::GetIconicMetafile](../vs140/colepastespecialdialog--geticonicmetafile.md)   
 [COlePasteSpecialDialog::GetPasteIndex](../vs140/colepastespecialdialog--getpasteindex.md)   
 [COlePasteSpecialDialog::GetSelectionType](../vs140/colepastespecialdialog--getselectiontype.md)