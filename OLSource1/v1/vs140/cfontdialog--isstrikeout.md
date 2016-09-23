---
title: "CFontDialog::IsStrikeOut"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CFontDialog::IsStrikeOut
  - IsStrikeOut
  - CFontDialog.IsStrikeOut
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsStrikeOut method
  - CFontDialog class, operations
ms.assetid: fa1e3a68-f1a9-40e1-a0f2-19fdea2bff52
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFontDialog::IsStrikeOut
Call this function to determine if the selected font is displayed with strikeout.  
  
## Syntax  
  
```  
  
BOOL IsStrikeOut( ) const;  
```  
  
## Return Value  
 Nonzero if the selected font has the Strikeout characteristic enabled; otherwise 0.  
  
## Example  
 [!code[NVC_MFCDocView#87](../vs140/codesnippet/CPP/cfontdialog--isstrikeout_1.cpp)]
  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFontDialog Class](../vs140/cfontdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFontDialog::GetCurrentFont](../vs140/cfontdialog--getcurrentfont.md)