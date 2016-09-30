---
title: "CFindReplaceDialog::IsTerminating"
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
  - "CFindReplaceDialog::IsTerminating"
  - "IsTerminating"
  - "CFindReplaceDialog.IsTerminating"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFindReplaceDialog class, operations"
  - "IsTerminating method"
ms.assetid: 0c6352ec-884f-4662-a089-e8fd21df5db5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFindReplaceDialog::IsTerminating
Call this function within your callback function to determine whether the user has decided to terminate the dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the user has decided to terminate the dialog box; otherwise 0.  
  
## Remarks  
 If this function returns nonzero, you should call the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function of the current dialog box and set any dialog box pointer variable to **NULL**. Optionally, you can also store the find/replace text last entered and use it to initialize the next find/replace dialog box.  
  
## Example  
 See the example for [CFindReplaceDialog::GetFindString](../vs140/cfindreplacedialog--getfindstring.md).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFindReplaceDialog Class](../vs140/cfindreplacedialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)