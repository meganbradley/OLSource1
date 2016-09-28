---
title: "CTaskDialog::GetCommonButtonCount"
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
  - "GetCommonButton"
  - "CTaskDialog.GetCommonButton"
  - "CTaskDialog::GetCommonButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCommonButtonCount method"
ms.assetid: 9b2249e9-ee76-48b5-a49c-95d33a1092e3
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTaskDialog::GetCommonButtonCount
Retrieves the number of common buttons.  
  
## Syntax  
  
```  
int GetCommonButtonCount() const;  
```  
  
## Return Value  
 The number of common buttons available.  
  
## Remarks  
 The common buttons are the default buttons that you provide to [CTaskDialog::CTaskDialog](../vs140/ctaskdialog--ctaskdialog.md). The [CTaskDialog Class](../vs140/ctaskdialog-class.md) displays the buttons along the bottom of the dialog box.  
  
 The enumerated list of buttons is provided in CommCtrl.h.  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::GetCommonButtonFlag](../vs140/ctaskdialog--getcommonbuttonflag.md)   
 [CTaskDialog::GetCommonButtonId](../vs140/ctaskdialog--getcommonbuttonid.md)