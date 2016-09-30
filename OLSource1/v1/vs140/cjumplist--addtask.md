---
title: "CJumpList::AddTask"
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
  - "AddTask"
  - "afxadv/CJumpList::AddTask"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddTask"
ms.assetid: accfb31a-2b2a-46f9-adc8-0cf4f16bca48
caps.latest.revision: 10
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CJumpList::AddTask
Adds items to the canonical Tasks category.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the target task path.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies command line arguments of the executable specified by strTargetExecutablePath.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Task name that will be displayed in the Destination List.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Location of icon that will be displayed in the Destination List along with the title.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Icon index.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Shell Link that represents a task to be added.  
  
## Return Value  
  
## Remarks  
 The instance of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> accumulates specified tasks and adds them to the Destination List during <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. Task items will appear in a category at the bottom of the application's destination menu. This category takes precedence over all other categories when it is filled in the UI.  
  
## Requirements  
 **Header:** afxadv.h  
  
## See Also  
 [CJumpList](../vs140/cjumplist-class.md)