---
title: "CJumpList::AddTasks"
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
  - "AddTasks"
  - "afxadv/CJumpList::AddTasks"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddTasks"
ms.assetid: 4f7891bc-95e9-4755-b156-1e1752b552e6
caps.latest.revision: 10
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CJumpList::AddTasks
Adds items to the canonical Tasks category.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A collection of tasks to be added.  
  
## Return Value  
  
## Remarks  
 The instance of CJumpList accumulates specified tasks and adds them to the Destination List during <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. Task items will appear in a category at the bottom of the application's destination menu. This category takes precedence over all other categories when it is filled in the UI.  
  
## Requirements  
 **Header:** afxadv.h  
  
## See Also  
 [CJumpList](../vs140/cjumplist-class.md)