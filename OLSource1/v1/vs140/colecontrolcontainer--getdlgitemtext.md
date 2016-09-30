---
title: "COleControlContainer::GetDlgItemText"
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
  - "COleControlContainer.GetDlgItemText"
  - "COleControlContainer::GetDlgItemText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleControlContainer class, overridables"
  - "GetDlgItemText method"
ms.assetid: 1f5c1cd9-9222-48d7-92a9-63cf7e49f877
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlContainer::GetDlgItemText
Retrieves the text of the given control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The identifier of the control.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the text of the control.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the maximum length, in characters, of the string to be copied to the buffer pointed to by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If the length of the string exceeds the limit, the string is truncated.  
  
## Return Value  
 If the function succeeds, the return value specifies the number of characters copied to the buffer, not including the terminating null character.  
  
 If the function fails, the return value is zero. To get extended error information, call [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360).  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlContainer Class](../vs140/colecontrolcontainer-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)