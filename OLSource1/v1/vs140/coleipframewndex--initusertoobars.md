---
title: "COleIPFrameWndEx::InitUserToobars"
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
  - "COleIPFrameWndEx.InitUserToobars"
  - "InitUserToobars"
  - "COleIPFrameWndEx::InitUserToobars"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InitUserToobars method"
ms.assetid: c7184600-3a37-41af-a273-99169f8744ea
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleIPFrameWndEx::InitUserToobars
Specifies a range of control IDs that the framework assigns to the user-defined toolbars.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The registry entry where the library stores user toolbar settings.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Control ID assigned to the first user-defined toolbar.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Control ID assigned to the last user-defined toolbar.  
  
## Remarks  
 Use this function to initialize a range of control IDs for assignment to toolbars that users define dynamically. The parameters <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> define a range of allowed toolbar control IDs. To disable the creation of user-defined toolbars, set <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to -1.  
  
## Requirements  
 **Header:** afxoleipframewndex.h  
  
## See Also  
 [COleIPFrameWndEx Class](../vs140/coleipframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)