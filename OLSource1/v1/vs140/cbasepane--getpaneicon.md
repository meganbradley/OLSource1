---
title: "CBasePane::GetPaneIcon"
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
  - "GetPaneIcon"
  - "CBasePane.GetPaneIcon"
  - "CBasePane::GetPaneIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPaneIcon method"
ms.assetid: 192a01d7-1fd9-4cb8-98cc-ab04e221d223
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::GetPaneIcon
Returns a handle to the pane icon.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies a 32 pixel by 32 pixel icon if <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>; specifies a 16 pixel by 16 pixel icon if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Return Value  
 A handle to the pane icon. If unsuccessful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 The default implementation calls [CWnd::GetIcon](../vs140/cwnd--geticon.md).  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)