---
title: "CTaskDialog::GetOptions"
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
  - CTaskDialog.GetOptions
  - GetOptions
  - CTaskDialog::GetOptions
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetOptions method
ms.assetid: 1cfa83af-b89e-43d6-9b78-8a01ec6f2c08
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTaskDialog::GetOptions
Returns the option flags for this `CTaskDialog`.  
  
## Syntax  
  
```  
int GetOptions() const;  
```  
  
## Return Value  
 The flags for the `CTaskDialog`.  
  
## Remarks  
 For more information about the options available to the [CTaskDialog Class](../vs140/ctaskdialog-class.md), see [CTaskDialog::SetOptions](../vs140/ctaskdialog--setoptions.md).  
  
## Example  
 [!code[NVC_MFC_CTaskDialog#7](../vs140/codesnippet/CPP/ctaskdialog--getoptions_1.cpp)]
  
  
## Requirements  
 **Header:** afxtaskdialog.h  
  
## See Also  
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTaskDialog::SetOptions](../vs140/ctaskdialog--setoptions.md)