---
title: "CKeyboardManager::UpdateAccelTable"
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
  - "UpdateAcellTable"
  - "CKeyboardManager::UpdateAcellTable"
  - "CKeyboardManager.UpdateAcellTable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UpdateAcellTable method"
ms.assetid: d82266bf-2af7-4768-9b34-b19ce6f140ab
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CKeyboardManager::UpdateAccelTable
Updates a shortcut key table with a new shortcut key table.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a document template.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the new shortcut key.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The size of the new shortcut table.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to the default frame window.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A handle to the new shortcut table.  
  
## Return Value  
 Nonzero if the method is successful; otherwise 0.  
  
## Remarks  
 Use this function to replace the existing shortcut table with new shortcut keys for several frame window objects. The function receives a document template as a parameter to obtain access to all frame window objects connected to the given document template.  
  
## Requirements  
 **Header:** afxkeyboardmanager.h  
  
## See Also  
 [CKeyboardManager Class](../vs140/ckeyboardmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)