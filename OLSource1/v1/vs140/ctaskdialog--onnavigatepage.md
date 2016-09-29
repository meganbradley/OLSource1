---
title: "CTaskDialog::OnNavigatePage"
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
  - "CTaskDialog::OnNavigatePage"
  - "CTaskDialog.OnNavigatePage"
  - "OnNavigatePage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnNavigatePage method"
ms.assetid: 68eaa126-dd12-4de2-8b62-6474277e63d3
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::OnNavigatePage
The framework calls this method in response to the [CTaskDialog::NavigateTo](../vs140/ctaskdialog--navigateto.md) method.  
  
## Syntax  
  
```  
virtual HRESULT OnNavigatePage();  
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
 [CTaskDialog::NavigateTo](../vs140/ctaskdialog--navigateto.md)