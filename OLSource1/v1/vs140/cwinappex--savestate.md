---
title: "CWinAppEx::SaveState"
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
  - "CWinAppEx::SaveState"
  - "CWinAppEx.SaveState"
  - "SaveState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SaveState method"
ms.assetid: 9ea6b353-7c00-4a76-86c5-d5e3ce6f6b56
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::SaveState
Writes the application state to the Windows registry.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A string that contains the relative path of a registry key.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object. This frame is saved to the Windows registry.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to a frame window object. This frame is saved to the Windows registry.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if successful; <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> otherwise.  
  
## Remarks  
 This method saves the state of the application and any state information for the provided frame window. If you do not provide a frame window, the method only saves the application state. The application information includes the state of the [CMouseManager Class](../vs140/cmousemanager-class.md), [CContextMenuManager Class](../vs140/ccontextmenumanager-class.md), [CKeyboardManager Class](../vs140/ckeyboardmanager-class.md), and the [CUserToolsManager Class](../vs140/cusertoolsmanager-class.md).  
  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter is not the absolute path for a registry entry. It is a relative path that is appended to the end of the default registry key for your application. To get or set the default registry key, use the methods [CWinAppEx::GetRegistryBase](../vs140/cwinappex--getregistrybase.md) and [CWinAppEx::SetRegistryBase](../vs140/cwinappex--setregistrybase.md) respectively.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CWinAppEx::LoadState](../vs140/cwinappex--loadstate.md)