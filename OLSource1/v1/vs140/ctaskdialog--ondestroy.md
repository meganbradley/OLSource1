---
title: "CTaskDialog::OnDestroy"
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
  - "CTaskDialog::OnDestroy"
  - "CTaskDialog.OnDestroy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDestroy method"
ms.assetid: f42e2df6-4382-4bc1-9498-86744453fd69
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::OnDestroy
The framework calls this method immediately before it destroys the `CTaskDialog`.  
  
## Syntax  
  
```  
virtual HRESULT OnDestroy();  
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