---
title: "CMFCColorDialog::GetColor"
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
  - "CMFCColorDialog::GetColor"
  - "CMFCColorDialog.GetColor"
  - "GetColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetColor method"
ms.assetid: da0c9357-83f0-4d4e-8812-c07fd710fbd2
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorDialog::GetColor
Retrieves the color that the user selects from the color dialog.  
  
## Syntax  
  
```  
COLORREF GetColor() const;  
```  
  
## Return Value  
 A [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value that contains the RGB information for the color selected in the color dialog box.  
  
## Remarks  
 Call this function after you call the `DoModal` method.  
  
## Requirements  
 **Header:** afxcolordialog.h  
  
## See Also  
 [CMFCColorDialog Class](../vs140/cmfccolordialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)