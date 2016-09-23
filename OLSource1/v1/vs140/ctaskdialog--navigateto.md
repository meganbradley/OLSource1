---
title: "CTaskDialog::NavigateTo"
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
  - CTaskDialog.NavigateTo
  - CTaskDialog::NavigateTo
  - NavigateTo
dev_langs: 
  - C++
helpviewer_keywords: 
  - NavigateTo method
ms.assetid: e3f94035-ec99-44d0-904a-5fed67e6f574
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTaskDialog::NavigateTo
Transfers the focus to another `CTaskDialog`.  
  
## Syntax  
  
```  
protected:  
void NavigateTo(  
   CTaskDialog& oTaskDialog  
) const;  
```  
  
#### Parameters  
 [in] `oTaskDialog`  
 The `CTaskDialog` that receives the focus.  
  
## Remarks  
 This method hides the current `CTaskDialog` when it displays the `oTaskDialog`. The `oTaskDialog` is displayed in the same location as the current `CTaskDialog`.  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)