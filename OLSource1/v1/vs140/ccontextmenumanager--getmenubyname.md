---
title: "CContextMenuManager::GetMenuByName"
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
  - "CContextMenuManager.GetMenuByName"
  - "GetMenuByName"
  - "CContextMenuManager::GetMenuByName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMenuByName method"
ms.assetid: 9ff9dcc8-f712-49c5-9183-7b68cc759ae2
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CContextMenuManager::GetMenuByName
Returns a handle to a specific menu.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A string that contains the name of the menu to retrieve.  
  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. This parameter contains the resource ID of the specified menu, if found.  
  
## Return Value  
 A handle to the menu that matches the name that was specified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if there is no menu called <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 If this method finds a menu that matches <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> stores the menu resource ID in the parameter <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxcontextmenumanager.h  
  
## See Also  
 [CContextMenuManager Class](../vs140/ccontextmenumanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)