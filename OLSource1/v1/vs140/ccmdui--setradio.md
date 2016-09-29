---
title: "CCmdUI::SetRadio"
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
  - "CCmdUI.SetRadio"
  - "CCmdUI::SetRadio"
  - "SetRadio"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetRadio method"
  - "CCmdUI class, operations"
ms.assetid: 4283f592-9d71-48e3-a40a-b7365c96c350
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCmdUI::SetRadio
Call this member function to set the user-interface item for this command to the appropriate check state.  
  
## Syntax  
  
```  
  
      virtual void SetRadio(  
   BOOL bOn = TRUE   
);  
```  
  
#### Parameters  
 `bOn`  
 **TRUE** to enable the item; otherwise **FALSE**.  
  
## Remarks  
 This member function operates like `SetCheck`, except that it operates on user-interface items acting as part of a radio group. Unchecking the other items in the group is not automatic unless the items themselves maintain the radio-group behavior.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCmdUI Class](../vs140/ccmdui-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCmdUI::SetCheck](../vs140/ccmdui--setcheck.md)