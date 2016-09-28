---
title: "COleConvertDialog::GetDrawAspect"
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
  - "COleConvertDialog::GetDrawAspect"
  - "COleConvertDialog.GetDrawAspect"
  - "GetDrawAspect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleConvertDialog class, operations and attributes"
  - "GetDrawAspect method"
ms.assetid: dec03e40-53f1-4c4a-85a2-87da0e520a0f
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleConvertDialog::GetDrawAspect
Call this function to determine whether the user chose to display the selected item as an icon.  
  
## Syntax  
  
```  
  
DVASPECT GetDrawAspect( ) const;  
```  
  
## Return Value  
 The method needed to render the object.  
  
-   `DVASPECT_CONTENT` Returned if the Display As Icon check box was not checked.  
  
-   `DVASPECT_ICON` Returned if the Display As Icon check box was checked.  
  
## Remarks  
 Call this function only after [DoModal](../vs140/coleconvertdialog--domodal.md) returns **IDOK**.  
  
 For more information on drawing aspect, see the [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) data structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COleConvertDialog Class](../vs140/coleconvertdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleConvertDialog::DoModal](../vs140/coleconvertdialog--domodal.md)   
 [COleConvertDialog::COleConvertDialog](../vs140/coleconvertdialog--coleconvertdialog.md)