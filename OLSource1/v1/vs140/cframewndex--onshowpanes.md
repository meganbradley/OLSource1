---
title: "CFrameWndEx::OnShowPanes"
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
  - "CFrameWndEx.OnShowPanes"
  - "CFrameWndEx::OnShowPanes"
  - "OnShowPanes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnShowPanes method"
ms.assetid: 7cb6286e-8e37-4044-8644-13d2052cfc88
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::OnShowPanes
Called by the framework to show or hide panes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the application shows the panes; <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> otherwise.  
  
## Return Value  
 This method always return <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 The default implementation shows the panes if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and the panes are hidden or when <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and the panes are visible.  
  
 The default implementation hides the panes if <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and the panes are visible or when <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and the panes are hidden.  
  
 Override this method in a derived class to execute custom code when the framework shows or hides panes.  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)