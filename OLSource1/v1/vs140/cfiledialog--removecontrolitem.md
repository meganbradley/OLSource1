---
title: "CFileDialog::RemoveControlItem"
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
  - afxdlgs/CFileDialog::RemoveControlItem
  - RemoveControlItem
dev_langs: 
  - C++
helpviewer_keywords: 
  - RemoveControlItem
ms.assetid: ac1157d1-8592-4e28-b588-6dec29ffa36e
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFileDialog::RemoveControlItem
Removes an item from a container control in the dialog.  
  
## Syntax  
  
```  
HRESULT RemoveControlItem(  
   DWORD dwIDCtl,  
   DWORD dwIDItem  
);  
```  
  
#### Parameters  
 `dwIDCtl`  
 The ID of the container control to remove the item from.  
  
 `dwIDItem`  
 The ID of the item.  
  
## Remarks  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFileDialog Class](../vs140/cfiledialog-class.md)