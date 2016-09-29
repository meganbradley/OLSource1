---
title: "COlePropertiesDialog::COlePropertiesDialog"
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
  - "COlePropertiesDialog.COlePropertiesDialog"
  - "COlePropertiesDialog::COlePropertiesDialog"
  - "COlePropertiesDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COlePropertiesDialog class, constructor"
ms.assetid: 2ca2f8a6-3e24-424e-8983-8c02b0f52e28
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COlePropertiesDialog::COlePropertiesDialog
Creates a `COlePropertiesDialog` object.  
  
## Syntax  
  
```  
  
      COlePropertiesDialog(  
   COleClientItem* pItem,  
   UINT nScaleMin = 10,  
   UINT nScaleMax = 500,  
   CWnd* pParentWnd = NULL   
);  
```  
  
#### Parameters  
 `pItem`  
 Pointer to the document item whose properties are being accessed.  
  
 *nScaleMin*  
 Minimum scaling percentage for the document item image.  
  
 *nScaleMax*  
 Maximum scaling percentage for the document item image.  
  
 `pParentWnd`  
 Pointer to the dialog box's parent or owner.  
  
## Remarks  
 Derive your common OLE Object Properties dialog class from `COlePropertiesDialog` in order to implement scaling for your document items. Any dialog boxes implemented by an instance of this class will not support scaling of the document item.  
  
 By default, the common OLE Object Properties dialog box has three default pages:  
  
-   General  
  
     This page contains system information for the file represented by the selected document item. From this page, the user can convert the selected item to another type.  
  
-   View  
  
     This page contains options for displaying the item, changing the icon, and changing the scaling of the image.  
  
-   Link  
  
     This page contains options for changing the location of the linked item and updating the linked item. From this page, the user can break the link of the selected item.  
  
 To add pages beyond those provided by default, modify the [m_psh](../vs140/colepropertiesdialog--m_psh.md) member variable before exiting the constructor of your `COlePropertiesDialog`-derived class. This is an advanced implementation of the `COlePropertiesDialog` constructor.  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COlePropertiesDialog Class](../vs140/colepropertiesdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COlePropertiesDialog::OnApplyScale](../vs140/colepropertiesdialog--onapplyscale.md)