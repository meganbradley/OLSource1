---
title: "CFindReplaceDialog::MatchCase"
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
  - "CFindReplaceDialog::MatchCase"
  - "MatchCase"
  - "CFindReplaceDialog.MatchCase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MatchCase method"
  - "CFindReplaceDialog class, operations"
ms.assetid: 1289512d-39d4-46e6-a9fe-65bccd4368b4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFindReplaceDialog::MatchCase
Call this function to determine whether the user wants to match the case of the find string exactly.  
  
## Syntax  
  
```  
  
BOOL MatchCase( ) const;  
```  
  
## Return Value  
 Nonzero if the user wants to find occurrences of the search string that exactly match the case of the search string; otherwise 0.  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFindReplaceDialog Class](../vs140/cfindreplacedialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFindReplaceDialog::MatchWholeWord](../vs140/cfindreplacedialog--matchwholeword.md)