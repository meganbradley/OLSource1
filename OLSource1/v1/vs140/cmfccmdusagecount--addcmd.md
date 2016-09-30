---
title: "CMFCCmdUsageCount::AddCmd"
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
  - "CMFCCmdUsageCount.AddCmd"
  - "AddCmd"
  - "CMFCCmdUsageCount::AddCmd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddCmd method"
ms.assetid: 791acba8-cc07-4f4b-bd55-2d3c6e1a733f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCCmdUsageCount::AddCmd
Increments by one the counter that is associated with the given command.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Specifies the command counter to increment.|  
  
## Remarks  
 This method adds a new entry to the map structure of command counts, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, if the entry does not already exist.  
  
 This method does nothing in the following cases:  
  
-   The toolbar framework is in customization mode (the [CMFCToolBar::IsCustomizeMode](../vs140/cmfctoolbar--iscustomizemode.md) method returns a nonzero value).  
  
-   The command refers to a submenu or menu separator (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> equals 0 or -1).  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> refers to a standard command (the global <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function returns a nonzero value).  
  
## Requirements  
 **Header:** afxcmdusagecount.h  
  
## See Also  
 [CMFCCmdUsageCount Class](../vs140/cmfccmdusagecount-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::IsCustomizeMode](../vs140/cmfctoolbar--iscustomizemode.md)