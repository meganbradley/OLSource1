---
title: "CMFCKeyMapDialog::GetCommandKeys"
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
  - CMFCKeyMapDialog.GetCommandKeys
  - GetCommandKeys
  - CMFCKeyMapDialog::GetCommandKeys
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetCommandKeys method
ms.assetid: add817b3-e1a2-4fe5-8f3e-852348003a9c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCKeyMapDialog::GetCommandKeys
Retrieves a string value. The string contains a list of shortcut keys that are associated with a specified command.  
  
## Syntax  
  
```  
virtual CString GetCommandKeys(  
   UINT uiCmdID   
) const;  
```  
  
#### Parameters  
 [in] `uiCmdID`  
 A command ID.  
  
## Return Value  
 A semicolon-delimited (';') list of shortcut keys that is associated with the specified command.  
  
## Remarks  
  
## Requirements  
 **Header:** afxkeymapdialog.h  
  
## See Also  
 [CMFCKeyMapDialog Class](../vs140/cmfckeymapdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)