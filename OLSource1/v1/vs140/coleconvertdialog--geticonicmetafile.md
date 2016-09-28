---
title: "COleConvertDialog::GetIconicMetafile"
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
  - "COleConvertDialog::GetIconicMetafile"
  - "GetIconicMetafile"
  - "COleConvertDialog.GetIconicMetafile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleConvertDialog class, operations and attributes"
  - "GetIconicMetafile method"
ms.assetid: e214714a-4fa6-449f-9e5b-98bab7d1236f
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleConvertDialog::GetIconicMetafile
Call this function to get a handle to the metafile that contains the iconic aspect of the selected item.  
  
## Syntax  
  
```  
  
HGLOBAL GetIconicMetafile( ) const;  
```  
  
## Return Value  
 The handle to the metafile containing the iconic aspect of the selected item, if the Display As Icon check box was checked when the dialog was dismissed by choosing **OK**; otherwise **NULL**.  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COleConvertDialog Class](../vs140/coleconvertdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleConvertDialog::DoModal](../vs140/coleconvertdialog--domodal.md)   
 [COleConvertDialog::COleConvertDialog](../vs140/coleconvertdialog--coleconvertdialog.md)   
 [COleConvertDialog::GetDrawAspect](../vs140/coleconvertdialog--getdrawaspect.md)