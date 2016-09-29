---
title: "CFindReplaceDialog::GetFindString"
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
  - "CFindReplaceDialog.GetFindString"
  - "GetFindString"
  - "CFindReplaceDialog::GetFindString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetFindString method"
  - "CFindReplaceDialog class, operations"
ms.assetid: 9bc5d133-d41a-44e2-8a08-56989afd53e2
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFindReplaceDialog::GetFindString
Call this function from your callback function to retrieve the default string to find.  
  
## Syntax  
  
```  
  
CString GetFindString( ) const;  
```  
  
## Return Value  
 The default string to find.  
  
## Example  
 [!code[NVC_MFCDocView#69](../vs140/codesnippet/CPP/cfindreplacedialog--getfindstring_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFindReplaceDialog Class](../vs140/cfindreplacedialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFindReplaceDialog::FindNext](../vs140/cfindreplacedialog--findnext.md)   
 [CFindReplaceDialog::GetReplaceString](../vs140/cfindreplacedialog--getreplacestring.md)