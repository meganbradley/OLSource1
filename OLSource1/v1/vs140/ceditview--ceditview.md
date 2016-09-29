---
title: "CEditView::CEditView"
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
  - "CEditView.CEditView"
  - "CEditView::CEditView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CEditView class, constructor"
  - "CEditView class, construction/destruction"
ms.assetid: 25431cbe-6756-423c-a3fa-d1fa6c3be531
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEditView::CEditView
Constructs an object of type `CEditView`.  
  
## Syntax  
  
```  
  
CEditView( );  
```  
  
## Remarks  
 After constructing the object, you must call the [CWnd::Create](../vs140/cwnd--create.md) function before the edit control is used. If you derive a class from `CEditView` and add it to the template using `CWinApp::AddDocTemplate`, the framework calls both this constructor and the **Create** function.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CEditView Class](../vs140/ceditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::Create](../vs140/cwnd--create.md)   
 [CWinApp::AddDocTemplate](../vs140/cwinapp--adddoctemplate.md)