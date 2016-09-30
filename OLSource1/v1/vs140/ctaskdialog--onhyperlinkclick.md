---
title: "CTaskDialog::OnHyperlinkClick"
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
  - "CTaskDialog.OnHyperlinkClick"
  - "OnHyperlinkClick"
  - "CTaskDialog::OnHyperlinkClick"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnHyperlinkClick method"
ms.assetid: e4d47495-c136-41ad-ac9b-a52389001d0a
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::OnHyperlinkClick
The framework calls this method when the user clicks on a hyperlink.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The string that represents the hyperlink.  
  
## Return Value  
 The default implementation returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method calls [ShellExecute](http://msdn.microsoft.com/library/windows/desktop/bb762153) before it returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 Override this method in a derived class to implement custom behavior.  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::TaskDialogCallback](../vs140/ctaskdialog--taskdialogcallback.md)