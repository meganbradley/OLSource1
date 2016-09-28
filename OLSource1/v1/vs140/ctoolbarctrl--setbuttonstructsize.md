---
title: "CToolBarCtrl::SetButtonStructSize"
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
  - "SetButtonStructSize"
  - "CToolBarCtrl.SetButtonStructSize"
  - "CToolBarCtrl::SetButtonStructSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetButtonStructSize method"
ms.assetid: 67c46b29-3e9b-4a20-b0bd-4ea33049334b
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::SetButtonStructSize
Specifies the size of the `TBBUTTON` structure.  
  
## Syntax  
  
```  
  
      void SetButtonStructSize(  
   int nSize   
);  
```  
  
#### Parameters  
 `nSize`  
 Size, in bytes, of the `TBBUTTON` structure.  
  
## Remarks  
 If you wanted to store extra data in the `TBBUTTON` structure, you could either derive a new structure from `TBBUTTON`, adding the members you needed, or create a new structure that contains a `TBBUTTON` structure as its first member. You would then call this function to tell the toolbar control the size of the new structure.  
  
 See [CToolBarCtrl::AddButtons](../vs140/ctoolbarctrl--addbuttons.md) for more information on the `TBBUTTON` structure.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::Create](../vs140/ctoolbarctrl--create.md)   
 [CToolBarCtrl::AddButtons](../vs140/ctoolbarctrl--addbuttons.md)   
 [CToolBarCtrl::InsertButton](../vs140/ctoolbarctrl--insertbutton.md)   
 [CToolBarCtrl::GetButton](../vs140/ctoolbarctrl--getbutton.md)