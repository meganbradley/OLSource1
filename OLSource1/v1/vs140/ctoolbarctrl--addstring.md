---
title: "CToolBarCtrl::AddString"
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
  - "CToolBarCtrl.AddString"
  - "CToolBarCtrl::AddString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddString method"
ms.assetid: 15920ba7-3af3-44a1-8402-617e8b4abf6c
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::AddString
Adds a new string, passed as a resource ID, to the toolbar's internal list of strings.  
  
## Syntax  
  
```  
  
      int AddString(  
   UINT nStringID   
);  
```  
  
#### Parameters  
 *nStringID*  
 Resource identifier of the string resource to add to the toolbar control's string list.  
  
## Return Value  
 The zero-based index of the first new string added if successful; otherwise –1.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::AddStrings](../vs140/ctoolbarctrl--addstrings.md)   
 [CToolBarCtrl::AddButtons](../vs140/ctoolbarctrl--addbuttons.md)   
 [CToolBarCtrl::InsertButton](../vs140/ctoolbarctrl--insertbutton.md)   
 [CToolBarCtrl::AddBitmap](../vs140/ctoolbarctrl--addbitmap.md)