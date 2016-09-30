---
title: "COleControlContainer::CheckDlgButton"
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
  - "COleControlContainer.CheckDlgButton"
  - "COleControlContainer::CheckDlgButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleControlContainer class, overridables"
  - "CheckDlgButton method"
ms.assetid: 0fcc7425-01df-4d5b-9577-f2c57bc55d95
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlContainer::CheckDlgButton
Modifies the current state of the button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The ID of the button to be modified.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the state of the button. Can be one of the following:  
  
-   **BST_CHECKED** Sets the button state to checked.  
  
-   **BST_INDETERMINATE** Sets the button state to grayed, indicating an indeterminate state. Use this value only if the button has the **BS_3STATE** or **BS_AUTO3STATE** style.  
  
-   **BST_UNCHECKED** Sets the button state to cleared.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlContainer Class](../vs140/colecontrolcontainer-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)