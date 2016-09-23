---
title: "CTaskDialog::OnHelp"
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
  - CTaskDialog::OnHelp
  - CTaskDialog.OnHelp
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnHelp method
ms.assetid: 22e48d03-d927-418a-a114-e40f74e8d1c7
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTaskDialog::OnHelp
The framework calls this method when the user requests help.  
  
## Syntax  
  
```  
virtual HRESULT OnHelp();  
```  
  
## Return Value  
 The default implementation returns `S_OK`.  
  
## Remarks  
 Override this method in a derived class to implement custom behavior.  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::TaskDialogCallback](../vs140/ctaskdialog--taskdialogcallback.md)