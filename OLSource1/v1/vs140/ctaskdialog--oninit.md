---
title: "CTaskDialog::OnInit"
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
  - OnInit
  - CTaskDialog::OnInit
  - CTaskDialog.OnInit
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnInit method
ms.assetid: 97ea6a02-b258-445d-85ab-5fd513ee3e47
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTaskDialog::OnInit
The framework calls this method when the `CTaskDialog` is initialized.  
  
## Syntax  
  
```  
virtual HRESULT OnInit();  
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