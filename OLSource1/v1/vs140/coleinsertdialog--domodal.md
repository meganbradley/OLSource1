---
title: "COleInsertDialog::DoModal"
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
  - "COleInsertDialog::DoModal"
  - "DocObjectOnly"
  - "COleInsertDialog.DoModal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ControlsOnly"
  - "COleInsertDialog class, operations and attributes"
  - "DoModal method"
  - "DocObjectOnly"
  - "COleInsertDialog class, DoModal flags"
ms.assetid: f7c225e7-bf00-4530-9997-e484fffe1f0c
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleInsertDialog::DoModal
Call this function to display the OLE Insert Object dialog box.  
  
## Syntax  
  
```  
virtual INT_PTR   
   DoModal();  
INT_PTR   
   DoModal(  
   DWORD dwFlags   
);  
```  
  
#### Parameters  
 `dwFlags`  
 One of the following values:  
  
 `COleInsertDialog::DocObjectsOnly` inserts only DocObjects.  
  
 `COleInsertDialog::ControlsOnly` inserts only ActiveX controls.  
  
 Zero inserts neither a DocObject nor an ActiveX control. This value results in the same implementation as the first prototype listed above.  
  
## Return Value  
 Completion status for the dialog box. One of the following values:  
  
-   IDOK if the dialog box was successfully displayed.  
  
-   IDCANCEL if the user canceled the dialog box.  
  
-   IDABORT if an error occurred. If IDABORT is returned, call the [COleDialog::GetLastError](../vs140/coledialog--getlasterror.md) member function to get more information about the type of error that occurred. For a listing of possible errors, see the [OleUIInsertObject](http://msdn.microsoft.com/library/windows/desktop/ms694325) function in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 If you want to initialize the various dialog box controls by setting members of the [m_io](../vs140/coleinsertdialog--m_io.md) structure, you should do this before calling `DoModal`, but after the dialog object is constructed.  
  
 If `DoModal` returns IDOK, you can call other member functions to retrieve the settings or information input into the dialog box by the user.  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COleInsertDialog Class](../vs140/coleinsertdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDialog::GetLastError](../vs140/coledialog--getlasterror.md)   
 [CDialog::DoModal](../vs140/cdialog--domodal.md)   
 [COleInsertDialog::GetSelectionType](../vs140/coleinsertdialog--getselectiontype.md)   
 [COleInsertDialog::GetClassID](../vs140/coleinsertdialog--getclassid.md)   
 [COleInsertDialog::GetDrawAspect](../vs140/coleinsertdialog--getdrawaspect.md)   
 [COleInsertDialog::GetIconicMetafile](../vs140/coleinsertdialog--geticonicmetafile.md)   
 [COleInsertDialog::GetPathName](../vs140/coleinsertdialog--getpathname.md)   
 [COleInsertDialog::m_io](../vs140/coleinsertdialog--m_io.md)