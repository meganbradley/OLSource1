---
title: "CFrameWndEx::OnDrawMenuLogo"
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
  - "CFrameWndEx.OnDrawMenuLogo"
  - "CFrameWndEx::OnDrawMenuLogo"
  - "OnDrawMenuLogo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawMenuLogo method"
ms.assetid: 62789935-0664-4db8-8c52-3f4442454e80
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::OnDrawMenuLogo
Called by the framework when a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object processes a WM_PAINT message.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the menu item.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A reference to a constant <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure that specifies the screen position and size of the menu logo.  
  
## Remarks  
 Override this function if you want to display a logo on the pop-up menu that belongs to the menu bar owned by the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> derived object.  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)