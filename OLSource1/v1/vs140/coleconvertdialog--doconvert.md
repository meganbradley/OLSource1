---
title: "COleConvertDialog::DoConvert"
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
  - "COleConvertDialog::DoConvert"
  - "COleConvertDialog.DoConvert"
  - "DoConvert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleConvertDialog class, operations and attributes"
  - "DoConvert method"
ms.assetid: ec720b1f-2fbe-4d94-8a50-3b5e1ec7e5e3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleConvertDialog::DoConvert
Call this function, after returning successfully from [DoModal](../vs140/coleconvertdialog--domodal.md), either to convert or to activate an object of type [COleClientItem](../vs140/coleclientitem-class.md).  
  
## Syntax  
  
```  
  
      BOOL DoConvert(  
  COleClientItem* pItem   
);  
```  
  
#### Parameters  
 `pItem`  
 Points to the item to be converted or activated. Cannot be **NULL**.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The item is converted or activated according to the information selected by the user in the Convert dialog box.  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COleConvertDialog Class](../vs140/coleconvertdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [COleConvertDialog::DoModal](../vs140/coleconvertdialog--domodal.md)   
 [COleConvertDialog::GetSelectionType](../vs140/coleconvertdialog--getselectiontype.md)   
 [COleClientItem::ConvertTo](../vs140/coleclientitem--convertto.md)   
 [COleClientItem::ActivateAs](../vs140/coleclientitem--activateas.md)