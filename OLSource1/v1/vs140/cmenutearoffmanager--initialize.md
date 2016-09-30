---
title: "CMenuTearOffManager::Initialize"
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
  - "Initialize"
  - "CMenuTearOffManager::Initialize"
  - "CMenuTearOffManager.Initialize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Initialize method"
ms.assetid: f3cabcb3-24c1-49ad-8f13-b4a5ee82d15f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMenuTearOffManager::Initialize
Initializes a [CMenuTearOffManager](../vs140/cmenutearoffmanager-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A string that contains the path of a registry entry. Your applications stores the settings for tear-off bars in this registry entry.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The first menu ID for a tear-off menu.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The last menu ID for a tear-off menu.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The range of menu IDs from <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> must be a continuous interval. The interval defines the number of tear-off menus that can appear at the same time in the application.  
  
## Requirements  
 **Header:** afxmenutearoffmanager.h  
  
## See Also  
 [CMenuTearOffManager Class](../vs140/cmenutearoffmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)