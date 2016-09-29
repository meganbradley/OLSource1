---
title: "COleClientItem::ActivateAs"
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
  - "COleClientItem::ActivateAs"
  - "COleClientItem.ActivateAs"
  - "ActivateAs"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleClientItem class, object conversion"
  - "ActivateAs method"
ms.assetid: 92adc79d-4c04-49a9-b1ec-1ab3a0803da0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::ActivateAs
Uses OLE's object conversion facilities to activate the item as though it were an item of the type specified by `clsidNew`.  
  
## Syntax  
  
```  
  
      virtual BOOL ActivateAs(  
   LPCTSTR lpszUserType,  
   REFCLSID clsidOld,  
   REFCLSID clsidNew   
);  
```  
  
#### Parameters  
 *lpszUserType*  
 Pointer to a string representing the target user type, such as "Word Document."  
  
 *clsidOld*  
 A reference to the item's current class ID. The class ID should represent the type of the actual object, as stored, unless it is a link. In that case, it should be the CLSID of the item to which the link refers. The [COleConvertDialog](../vs140/coleconvertdialog-class.md) automatically provides the correct class ID for the item.  
  
 `clsidNew`  
 A reference to the target class ID.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This is called automatically by [COleConvertDialog::DoConvert](../vs140/coleconvertdialog--doconvert.md). It is not usually called directly.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleConvertDialog Class](../vs140/coleconvertdialog-class.md)   
 [COleClientItem::ConvertTo](../vs140/coleclientitem--convertto.md)   
 [COleClientItem::Reload](../vs140/coleclientitem--reload.md)