---
title: "CVSListBox::GetItemText"
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
  - CVSListBox.GetItemText
  - GetItemText
  - CVSListBox::GetItemText
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetItemText method
ms.assetid: 059315a6-5cc2-44a6-bd7a-b40ea4a960fa
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CVSListBox::GetItemText
Retrieves the text of an editable list control item.  
  
## Syntax  
  
```  
virtual CString GetItemText(  
   int iIndex   
) const;  
```  
  
#### Parameters  
 [in] `iIndex`  
 The zero-based index of an editable list control item.  
  
## Return Value  
 A [CString](../vs140/cstringt-class.md) object that contains the text of the specified item.  
  
## Remarks  
  
## Requirements  
 **Header:** afxvslistbox.h  
  
## See Also  
 [CVSListBox Class](../vs140/cvslistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)