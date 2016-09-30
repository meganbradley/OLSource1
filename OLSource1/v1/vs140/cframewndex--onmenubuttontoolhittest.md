---
title: "CFrameWndEx::OnMenuButtonToolHitTest"
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
  - "OnMenuButtonToolHitTest"
  - "CFrameWndEx.OnMenuButtonToolHitTest"
  - "CFrameWndEx::OnMenuButtonToolHitTest"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnMenuButtonToolHitTest method"
ms.assetid: 0d66c7f6-d515-4160-b5ba-3a1ac1a10e84
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::OnMenuButtonToolHitTest
Called by the framework when a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object processes a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> message.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the tool bar button.  
  
 [out] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to a tool information structure.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the application fills the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> otherwise.  
  
## Remarks  
 Override this method if you want to provide a tooltip information about a specific menu item.  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)