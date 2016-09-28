---
title: "COleConvertDialog::GetClassID"
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
  - "GetClassID"
  - "COleConvertDialog.GetClassID"
  - "COleConvertDialog::GetClassID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetClassID method [C++]"
  - "COleConvertDialog class, operations and attributes"
ms.assetid: ec12cd7e-83a9-4599-a35c-8a7434e7e4d7
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleConvertDialog::GetClassID
Call this function to get the **CLSID** associated with the item the user selected in the Convert dialog box.  
  
## Syntax  
  
```  
  
REFCLSID GetClassID( ) const;  
```  
  
## Return Value  
 The **CLSID** associated with the item that was selected in the Convert dialog box.  
  
## Remarks  
 Call this function only after [DoModal](../vs140/coleconvertdialog--domodal.md) returns **IDOK**.  
  
 For more information, see [CLSID Key](http://msdn.microsoft.com/library/windows/desktop/ms691424) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COleConvertDialog Class](../vs140/coleconvertdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleConvertDialog::DoModal](../vs140/coleconvertdialog--domodal.md)