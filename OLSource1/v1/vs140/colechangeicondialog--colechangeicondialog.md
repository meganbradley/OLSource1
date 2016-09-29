---
title: "COleChangeIconDialog::COleChangeIconDialog"
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
  - "COleChangeIconDialog::COleChangeIconDialog"
  - "COleChangeIconDialog"
  - "COleChangeIconDialog.COleChangeIconDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleChangeIconDialog class, constructor"
ms.assetid: dddaec5e-4031-4d36-808a-6531b64cee67
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleChangeIconDialog::COleChangeIconDialog
This function constructs only a `COleChangeIconDialog` object.  
  
## Syntax  
  
```  
  
      explicit COleChangeIconDialog(   
   COleClientItem* pItem,   
   DWORD dwFlags = CIF_SELECTCURRENT,   
   CWnd* pParentWnd = NULL    
);  
```  
  
#### Parameters  
 `pItem`  
 Points to the item to be converted.  
  
 `dwFlags`  
 Creation flag, which contains any number of the following values combined using the bitwise-or operator:  
  
-   **CIF_SELECTCURRENT** Specifies that the Current radio button will be selected initially when the dialog box is called. This is the default.  
  
-   **CIF_SELECTDEFAULT** Specifies that the Default radio button will be selected initially when the dialog box is called.  
  
-   **CIF_SELECTFROMFILE** Specifies that the From File radio button will be selected initially when the dialog box is called.  
  
-   **CIF_SHOWHELP** Specifies that the Help button will be displayed when the dialog box is called.  
  
-   **CIF_USEICONEXE** Specifies that the icon should be extracted from the executable specified in the **szIconExe** field of [m_ci](../vs140/colechangeicondialog--m_ci.md) instead of retrieved from the type. This is useful for embedding or linking to non-OLE files.  
  
 `pParentWnd`  
 Points to the parent or owner window object (of type `CWnd`) to which the dialog object belongs. If it is **NULL**, the parent window of the dialog box will be set to the main application window.  
  
## Remarks  
 To display the dialog box, call the [DoModal](../vs140/colechangeicondialog--domodal.md) function.  
  
 For more information, see the [OLEUICHANGEICON](http://msdn.microsoft.com/library/windows/desktop/ms680098) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COleChangeIconDialog Class](../vs140/colechangeicondialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [COleChangeIconDialog::DoModal](../vs140/colechangeicondialog--domodal.md)