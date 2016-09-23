---
title: "CFontDialog::GetSize"
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
  - CFontDialog::GetSize
  - CFontDialog.GetSize
dev_langs: 
  - C++
helpviewer_keywords: 
  - CFontDialog class, operations
  - GetSize method
ms.assetid: 0a3e3aac-e210-4e6d-a962-b5024358fa83
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFontDialog::GetSize
Call this function to retrieve the size of the selected font.  
  
## Syntax  
  
```  
  
int GetSize( ) const;  
```  
  
## Return Value  
 The font's size, in tenths of a point.  
  
## Example  
 [!code[NVC_MFCDocView#82](../vs140/codesnippet/CPP/cfontdialog--getsize_1.cpp)]
  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFontDialog Class](../vs140/cfontdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFontDialog::GetWeight](../vs140/cfontdialog--getweight.md)   
 [CFontDialog::GetCurrentFont](../vs140/cfontdialog--getcurrentfont.md)