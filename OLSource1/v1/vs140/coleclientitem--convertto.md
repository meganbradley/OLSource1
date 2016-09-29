---
title: "COleClientItem::ConvertTo"
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
  - "ConvertTo"
  - "COleClientItem.ConvertTo"
  - "COleClientItem::ConvertTo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ConvertTo method"
  - "COleClientItem class, object conversion"
ms.assetid: 65d6dbd7-c8b4-4ea7-8d3d-402b3af1da55
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::ConvertTo
Call this member function to convert the item to the type specified by `clsidNew`.  
  
## Syntax  
  
```  
  
      virtual BOOL ConvertTo(  
   REFCLSID clsidNew   
);  
```  
  
#### Parameters  
 `clsidNew`  
 The class ID of the target type.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This is called automatically by [COleConvertDialog](../vs140/coleconvertdialog-class.md). It is not necessary to call it directly.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::ActivateAs](../vs140/coleclientitem--activateas.md)   
 [COleConvertDialog Class](../vs140/coleconvertdialog-class.md)