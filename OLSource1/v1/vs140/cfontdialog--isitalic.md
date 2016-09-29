---
title: "CFontDialog::IsItalic"
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
  - "IsItalic"
  - "CFontDialog::IsItalic"
  - "CFontDialog.IsItalic"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFontDialog class, operations"
  - "IsItalic method"
ms.assetid: d1b10398-73ae-4b63-9cd3-477e68a028e6
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFontDialog::IsItalic
Call this function to determine if the selected font is italic.  
  
## Syntax  
  
```  
  
BOOL IsItalic( ) const;  
```  
  
## Return Value  
 Nonzero if the selected font has the Italic characteristic enabled; otherwise 0.  
  
## Example  
 [!code[NVC_MFCDocView#86](../vs140/codesnippet/CPP/cfontdialog--isitalic_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFontDialog Class](../vs140/cfontdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFontDialog::GetCurrentFont](../vs140/cfontdialog--getcurrentfont.md)