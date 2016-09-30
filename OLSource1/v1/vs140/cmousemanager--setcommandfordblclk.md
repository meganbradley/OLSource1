---
title: "CMouseManager::SetCommandForDblClk"
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
  - "CMouseManager::SetCommandForDblClk"
  - "SetCommandForDblClk"
  - "CMouseManager.SetCommandForDblClk"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetCommandForDblClk method"
ms.assetid: 982bf0fa-198a-4dc8-b964-dba66f60da96
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMouseManager::SetCommandForDblClk
Associates a custom command with a view that is first registered with the mouse manager.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The view identifier.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The command identifier.  
  
## Remarks  
 In order to associate a custom command with a view, you must first register the view by using [CMouseManager::AddView](../vs140/cmousemanager--addview.md). The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method requires a view identifier as an input parameter. Once you register a view, you can call <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> with the same view identifier input parameter that you supplied to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Thereafter, when the user double-clicks the mouse in the registered view, the application will execute the command indicated by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> To support the custom mouse behavior, you will also need to customize the view registered with the mouse manager. For more information about custom mouse behavior, see [Keyboard and Mouse Customization](../vs140/keyboard-and-mouse-customization.md).  
  
 If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is set to 0, the specified view is no longer associated with a command.  
  
## Requirements  
 **Header:** afxmousemanager.h  
  
## See Also  
 [CMouseManager Class](../vs140/cmousemanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [Keyboard and Mouse Customization](../vs140/keyboard-and-mouse-customization.md)