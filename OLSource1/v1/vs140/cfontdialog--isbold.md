---
title: "CFontDialog::IsBold"
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
  - "CFontDialog::IsBold"
  - "IsBold"
  - "CFontDialog.IsBold"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsBold method"
  - "CFontDialog class, operations"
ms.assetid: c289c692-3f84-4ded-a456-4ee3e2f016f4
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFontDialog::IsBold
Call this function to determine if the selected font is bold.  
  
## Syntax  
  
```  
  
BOOL IsBold( ) const;  
```  
  
## Return Value  
 Nonzero if the selected font has the Bold characteristic enabled; otherwise 0.  
  
## Example  
 [!code[NVC_MFCDocView#85](../vs140/codesnippet/CPP/cfontdialog--isbold_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFontDialog Class](../vs140/cfontdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFontDialog::GetCurrentFont](../vs140/cfontdialog--getcurrentfont.md)