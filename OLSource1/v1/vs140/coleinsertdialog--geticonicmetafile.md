---
title: "COleInsertDialog::GetIconicMetafile"
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
  - "COleInsertDialog.GetIconicMetafile"
  - "COleInsertDialog::GetIconicMetafile"
  - "GetIconicMetafile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleInsertDialog class, operations and attributes"
  - "GetIconicMetafile method"
ms.assetid: f2b2b3c6-8c99-45cf-9ff6-68e655d7f26f
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleInsertDialog::GetIconicMetafile
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
 [COleInsertDialog Class](../vs140/coleinsertdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleInsertDialog::DoModal](../vs140/coleinsertdialog--domodal.md)   
 [COleInsertDialog::GetDrawAspect](../vs140/coleinsertdialog--getdrawaspect.md)