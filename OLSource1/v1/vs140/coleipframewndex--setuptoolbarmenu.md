---
title: "COleIPFrameWndEx::SetupToolbarMenu"
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
  - "SetupToolbarMenu"
  - "COleIPFrameWndEx.SetupToolbarMenu"
  - "COleIPFrameWndEx::SetupToolbarMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetupToolbarMenu method"
ms.assetid: 68ae4b28-6274-4d41-a35e-61801382c00b
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleIPFrameWndEx::SetupToolbarMenu
Modifies a toolbar object by searching for dummy items and replacing them with the specified user-defined items.  
  
## Syntax  
  
```  
void SetupToolbarMenu(  
   CMenu& menu,  
   const UINT uiViewUserToolbarCmdFirst,  
   const UINT uiViewUserToolbarCmdLast   
);  
```  
  
#### Parameters  
 [in] `menu`  
 A reference to a [CMenu](../vs140/cmenu-class.md) object to be modified.  
  
 [in] `uiViewUserToolbarCmdFirst`  
 Specifies the first user-defined command.  
  
 [in] `uiViewUserToolbarCmdLast`  
 Specifies the last user-defined command.  
  
## Remarks  
  
## Requirements  
 **Header:** afxoleipframewndex.h  
  
## See Also  
 [COleIPFrameWndEx Class](../vs140/coleipframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)