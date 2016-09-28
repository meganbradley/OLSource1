---
title: "COleDocument::OnEditChangeIcon"
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
  - "COleDocument.OnEditChangeIcon"
  - "OnEditChangeIcon"
  - "COleDocument::OnEditChangeIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnEditChangeIcon method"
  - "COleDocument class, message handlers"
ms.assetid: 1c86468f-0aa3-47f0-96ff-4ea2cdee7c01
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDocument::OnEditChangeIcon
Displays the OLE Change Icon dialog box and changes the icon representing the currently selected OLE item to the icon the user selects in the dialog box.  
  
## Syntax  
  
```  
  
afx_msg void OnEditChangeIcon( );  
```  
  
## Remarks  
 `OnEditChangeIcon` creates and launches a `COleChangeIconDialog` Change Icon dialog box.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDocument Class](../vs140/coledocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDocument::OnUpdateEditChangeIcon](../vs140/coledocument--onupdateeditchangeicon.md)   
 [COleChangeIconDialog Class](../vs140/colechangeicondialog-class.md)