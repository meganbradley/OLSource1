---
title: "CTreeCtrl::SetInsertMarkColor"
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
  - "CTreeCtrl.SetInsertMarkColor"
  - "CTreeCtrl::SetInsertMarkColor"
  - "SetInsertMarkColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetInsertMarkColor method"
ms.assetid: 9d3272ff-0ad4-46ac-bb7a-93facd279c15
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::SetInsertMarkColor
This member function implements the behavior of the Win32 message [TVM_SETINSERTMARKCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb773755), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
```  
  
      COLORREF SetInsertMarkColor(  
   COLORREF clrNew   
);  
```  
  
#### Parameters  
 `clrNew`  
 A **COLORREF** value that contains the new insertion mark color.  
  
## Return Value  
 A **COLORREF** value that contains the previous insertion mark color.  
  
## Example  
 See the example for [CTreeCtrl::GetInsertMarkColor](../vs140/ctreectrl--getinsertmarkcolor.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::GetInsertMarkColor](../vs140/ctreectrl--getinsertmarkcolor.md)