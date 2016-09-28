---
title: "CMFCKeyMapDialog::SetColumnsWidth"
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
  - "CMFCKeyMapDialog::SetColumnsWidth"
  - "SetColumnsWidth"
  - "CMFCKeyMapDialog.SetColumnsWidth"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetColumnsWidth method"
ms.assetid: f4cdd209-baf2-4c81-9900-65081a8942aa
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCKeyMapDialog::SetColumnsWidth
Called by the framework to set the width of the columns in the internal list control that supports the keyboard mapping control.  
  
## Syntax  
  
```  
virtual void SetColumnsWidth();  
```  
  
## Remarks  
 This method sets the internal list control's columns to default widths. First, the width of the shortcut keys column is calculated. Then one-third of the remaining width is allocated to the command column and the remaining two-thirds is allocated to the description column.  
  
## Requirements  
 **Header:** afxkeymapdialog.h  
  
## See Also  
 [CMFCKeyMapDialog Class](../vs140/cmfckeymapdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)