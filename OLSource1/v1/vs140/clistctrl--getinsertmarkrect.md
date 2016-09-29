---
title: "CListCtrl::GetInsertMarkRect"
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
  - "GetInsertMarkRect"
  - "CListCtrl::GetInsertMarkRect"
  - "CListCtrl.GetInsertMarkRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetInsertMarkRect method"
ms.assetid: a15d7a21-ade3-4e50-bf1e-94837daac4b7
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::GetInsertMarkRect
Retrieves the rectangle that bounds the insertion point.  
  
## Syntax  
  
```  
  
      int GetInsertMarkRect(  
   LPRECT pRect   
) const;  
```  
  
#### Parameters  
 `pRect`  
 Pointer to a `RECT` structure that contains the coordinates of a rectangle that bounds the insertion point.  
  
## Return Value  
 Returns one of the following values:  
  
-   **0** No insertion point found.  
  
-   **1** Insertion point found.  
  
## Remarks  
 This member function emulates the functionality of the [LVM_GETINSERTMARKRECT](http://msdn.microsoft.com/library/windows/desktop/bb774949) message, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)