---
title: "CMouseManager::SaveState"
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
  - "CMouseManager.SaveState"
  - "CMouseManager::SaveState"
  - "SaveState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SaveState method"
ms.assetid: 424c4e1d-a5fd-4f2e-beee-08807f6f3696
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMouseManager::SaveState
Writes the state of the [CMouseManager Class](../vs140/cmousemanager-class.md) to the registry.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A path of a registry key.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The state information written to the registry includes all registered views, view identifiers, and the associated commands. If the parameter <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, this function writes the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> data to the default registry location controlled by the [CWinAppEx Class](../vs140/cwinappex-class.md).  
  
 In most cases, you do not have to call this function directly. It is called as a part of the workspace serialization process. For more information about the workspace serialization process, see [CWinAppEx::SaveState](../vs140/cwinappex--savestate.md).  
  
## Requirements  
 **Header:** afxmousemanager.h  
  
## See Also  
 [CMouseManager Class](../vs140/cmousemanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [CWinAppEx::SaveState](../vs140/cwinappex--savestate.md)