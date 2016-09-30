---
title: "COccManager::CreateDlgControls"
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
  - "COccManager.CreateDlgControls"
  - "CreateDlgControls"
  - "COccManager::CreateDlgControls"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COccManager class, overridables"
  - "CreateDlgControls method"
ms.assetid: 6db96849-93ab-440a-9135-6f84ff2617d8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COccManager::CreateDlgControls
Call this function to create ActiveX controls specified by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> parameter.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pWndParent*  
 A pointer to the parent of the dialog object.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The name of the resource being created.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the dialog template used to create the dialog object.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to a resource.  
  
## Return Value  
 Nonzero if the control was created successfully; otherwise zero.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COccManager Class](../vs140/coccmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)