---
title: "CFrameWndEx::OnMenuChar"
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
  - "CFrameWndEx::OnMenuChar"
  - "OnMenuChar"
  - "CFrameWndEx.OnMenuChar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnMenuChar method"
ms.assetid: b6e6ed35-359a-43a2-a58e-bd6c12a1af09
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::OnMenuChar
Called by the framework when a menu is displayed and the user presses a key that does not correspond to a command.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Character code of the pressed key.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Contains the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> flag if the menu displayed is a submenu; contains the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> flag if the menu displayed is a control menu.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to a menu.  
  
## Return Value  
 The high-order word must be one of the following values.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The framework should ignore the keystroke.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The framework should close the menu.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The framework should select one of the items displayed in the menu. The low-order word contains the ID of the command to select.  
  
## Remarks  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)