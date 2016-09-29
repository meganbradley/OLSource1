---
title: "CFindReplaceDialog::FindNext"
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
  - "CFindReplaceDialog::FindNext"
  - "CFindReplaceDialog.FindNext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FindNext method"
  - "CFindReplaceDialog class, operations"
ms.assetid: fd043744-d3a9-4c1f-8d0a-b989a45e7500
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFindReplaceDialog::FindNext
Call this function from your callback function to determine whether the user wants to find the next occurrence of the search string.  
  
## Syntax  
  
```  
  
BOOL FindNext( ) const;  
```  
  
## Return Value  
 Nonzero if the user wants to find the next occurrence of the search string; otherwise 0.  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFindReplaceDialog Class](../vs140/cfindreplacedialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFindReplaceDialog::GetFindString](../vs140/cfindreplacedialog--getfindstring.md)   
 [CFindReplaceDialog::SearchDown](../vs140/cfindreplacedialog--searchdown.md)   
 [CFindReplaceDialog::IsTerminating](../vs140/cfindreplacedialog--isterminating.md)