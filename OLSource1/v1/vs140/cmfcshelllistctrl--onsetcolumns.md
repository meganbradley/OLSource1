---
title: "CMFCShellListCtrl::OnSetColumns"
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
  - "OnSetColumns"
  - "CMFCShellListCtrl::OnSetColumns"
  - "CMFCShellListCtrl.OnSetColumns"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnSetColumns method"
ms.assetid: ceb7aa43-4046-4ca0-986a-f73aa2f8b49d
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCShellListCtrl::OnSetColumns
The framework calls this method when it sets the names of the columns.  
  
## Syntax  
  
```  
virtual void OnSetColumns();  
```  
  
## Remarks  
 By default, the framework creates four columns in a [CMFCShellListCtrl](../vs140/cmfcshelllistctrl-class.md) object. The names of these columns are `Name`, `Size`, `Type`, and `Modified`. You can override this method to customize the number of columns and their names.  
  
## Requirements  
 **Header:** afxshelllistctrl.h  
  
## See Also  
 [CMFCShellListCtrl Class](../vs140/cmfcshelllistctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)