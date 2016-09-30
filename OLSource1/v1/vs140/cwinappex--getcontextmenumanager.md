---
title: "CWinAppEx::GetContextMenuManager"
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
  - "CWinAppEx::GetContextMenuManager"
  - "CWinAppEx.GetContextMenuManager"
  - "GetContextMenuManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetContextMenuManager method"
ms.assetid: 31827311-4dbc-4da2-9d97-bb4189ae3f7f
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::GetContextMenuManager
Returns a pointer to the global [CContextMenuManager](../vs140/ccontextmenumanager-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to the global <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Remarks  
 If the CContextMenuManager object is not initialized, this function calls [CWinAppEx::InitContextMenuManager](../vs140/cwinappex--initcontextmenumanager.md) before it returns a pointer.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CWinAppEx::InitContextMenuManager](../vs140/cwinappex--initcontextmenumanager.md)   
 [CContextMenuManager Class](../vs140/ccontextmenumanager-class.md)