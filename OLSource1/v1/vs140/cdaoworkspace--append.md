---
title: "CDaoWorkspace::Append"
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
  - "CDaoWorkspace.Append"
  - "CDaoWorkspace::Append"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Workspaces collection, appending to"
  - "workspaces [C++], appending to collections"
  - "Append method"
  - "Workspaces collection, appending workspaces to"
ms.assetid: 469c8910-989c-4d05-bc37-336a37def6d3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoWorkspace::Append
Call this member function after you call [Create](../vs140/cdaoworkspace--create.md).  
  
## Syntax  
  
```  
  
virtual void Append( );  
  
```  
  
## Remarks  
 **Append** appends a newly created workspace object to the database engine's Workspaces collection. Workspaces do not persist between database engine sessions; they are stored only in memory, not on disk. You do not have to append a workspace; if you do not, you can still use it.  
  
 An appended workspace remains in the Workspaces collection, in an active, open state, until you call its [Close](../vs140/cdaoworkspace--close.md) member function.  
  
 For related information, see the topic "Append Method" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoWorkspace Class](../vs140/cdaoworkspace-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)