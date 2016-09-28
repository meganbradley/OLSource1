---
title: "CMFCOutlookBarPane::RemoveButton"
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
  - "CMFCOutlookBarPane::RemoveButton"
  - "RemoveButton"
  - "CMFCOutlookBarPane.RemoveButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveButton method"
ms.assetid: ebd3026d-5d46-418f-9178-befa34523097
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCOutlookBarPane::RemoveButton
Removes the button that has a specified command ID.  
  
## Syntax  
  
```  
BOOL RemoveButton(  
   UINT iIdCommand   
);  
```  
  
#### Parameters  
 [in] `iIdCommand`  
 Specifies the command ID of a button to remove.  
  
## Return Value  
 `TRUE` if the button was successfully removed; `FALSE` if the specified command ID is not valid.  
  
## Requirements  
 **Header:** afxoutlookbarpane.h  
  
## See Also  
 [CMFCOutlookBarPane Class](../vs140/cmfcoutlookbarpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)