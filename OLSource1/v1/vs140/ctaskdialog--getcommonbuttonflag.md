---
title: "CTaskDialog::GetCommonButtonFlag"
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
  - CTaskDialog::GetCommonButtonFlag
  - CTaskDialog.GetCommonButtonFlag
  - GetCommonButtonFlag
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetCommonButtonFlag method
ms.assetid: 4384bd62-ef83-46bb-94cd-7f3d4efadde3
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTaskDialog::GetCommonButtonFlag
Converts a standard Windows button to the common button type associated with the [CTaskDialog Class](../vs140/ctaskdialog-class.md).  
  
## Syntax  
  
```  
int GetCommonButtonFlag(  
   int nButtonId  
) const;  
```  
  
#### Parameters  
 [in] `nButtonId`  
 The standard Windows button value.  
  
## Return Value  
 The value of the corresponding `CTaskDialog` common button. If there is no corresponding common button, this method returns 0.  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::GetCommonButtonId](../vs140/ctaskdialog--getcommonbuttonid.md)   
 [CTaskDialog::GetCommonButtonCount](../vs140/ctaskdialog--getcommonbuttoncount.md)