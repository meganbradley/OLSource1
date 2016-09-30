---
title: "CMFCOutlookBarTabCtrl::Create"
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
  - "Create"
  - "CMFCOutlookBarTabCtrl::Create"
  - "CMFCOutlookBarTabCtrl.Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method"
ms.assetid: 4811d9a1-8b07-4151-a6a9-eaccc69a908c
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCOutlookBarTabCtrl::Create
Creates the Outlook bar tab control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the initial size and position, in pixels.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to the parent window. Must not be <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The control ID.  
  
## Return Value  
 Nonzero if the control has been created successfully; otherwise 0.  
  
## Remarks  
 Usually, outlook bar tab controls are created when [CMFCOutlookBar Class](../vs140/cmfcoutlookbar-class.md) controls the  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> message of the process.  
  
## Requirements  
 **Header:** afxOutlookBarTabCtrl.h  
  
## See Also  
 [CMFCOutlookBarTabCtrl Class](../vs140/cmfcoutlookbartabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCOutlookBar Class](../vs140/cmfcoutlookbar-class.md)