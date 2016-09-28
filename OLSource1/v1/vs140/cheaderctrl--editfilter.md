---
title: "CHeaderCtrl::EditFilter"
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
  - "CHeaderCtrl::EditFilter"
  - "EditFilter"
  - "CHeaderCtrl.EditFilter"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EditFilter method"
ms.assetid: b72acba0-9252-4230-a271-378255cf0449
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHeaderCtrl::EditFilter
Begins to edit the specified filter of a header control.  
  
## Syntax  
  
```  
BOOL EditFilter(  
   int nColumn,  
   BOOL bDiscardChanges  
);  
```  
  
#### Parameters  
 `nColumn`  
 The column to edit.  
  
 `bDiscardChanges`  
 A value that specifies how to handle the user's editing changes if the user is in the process of editing the filter when the [HDM_EDITFILTER](http://msdn.microsoft.com/library/windows/desktop/bb775312) message is sent.  
  
 Specify `true` to discard the changes made by the user, or `false` to accept the changes made by the user.  
  
## Return Value  
 `true` if this method is successful; otherwise, `false`.  
  
## Remarks  
 This method implements the behavior of the Win32 message [HDM_EDITFILTER](http://msdn.microsoft.com/library/windows/desktop/bb775312), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CHeaderCtrl#7](../vs140/codesnippet/CPP/cheaderctrl--editfilter_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CHeaderCtrl Class](../vs140/cheaderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHeaderCtrl::ClearAllFilters](../vs140/cheaderctrl--clearallfilters.md)   
 [CHeaderCtrl::ClearFilter](../vs140/cheaderctrl--clearfilter.md)   
 [CHeaderCtrl::SetFilterChangeTimeout](../vs140/cheaderctrl--setfilterchangetimeout.md)