---
title: "CBaseTabbedPane::GetPaneIcon"
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
  - "CBaseTabbedPane::GetPaneIcon"
  - "CBaseTabbedPane.GetPaneIcon"
  - "GetPaneIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPaneIcon method"
ms.assetid: 8624d1b5-c011-4742-a718-e0a2899b63e1
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBaseTabbedPane::GetPaneIcon
Retrieves the minimum allowed size for the pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object that is filled with the minimum allowed size.  
  
## Remarks  
 If consistent handling of minimum pane sizes is active ([CPane::m_bHandleMinSize](../vs140/cpane--m_bhandleminsize.md)), <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is filled with the minimum allowed size for the active tab. Otherwise, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is filled with the return value of [CPane::GetMinSize](../vs140/cpane--getminsize.md).  
  
## Requirements  
 **Header:** afxbasetabbedpane.h  
  
## See Also  
 [CBaseTabbedPane Class](../vs140/cbasetabbedpane-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)