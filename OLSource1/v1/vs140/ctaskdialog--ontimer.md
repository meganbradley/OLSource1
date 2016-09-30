---
title: "CTaskDialog::OnTimer"
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
  - "CTaskDialog.OnTimer"
  - "CTaskDialog::OnTimer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnTimer method"
ms.assetid: 1355dcdc-02e2-41b0-9f55-b68fa065d087
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::OnTimer
The framework calls this method when the timer expires.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Time in milliseconds since the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> was created or the timer was reset.  
  
## Return Value  
 The default implementation returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 Override this method in a derived class to implement custom behavior.  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::TaskDialogCallback](../vs140/ctaskdialog--taskdialogcallback.md)