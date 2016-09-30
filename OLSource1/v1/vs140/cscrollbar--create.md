---
title: "CScrollBar::Create"
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
  - "CScrollBar.Create"
  - "CScrollBar::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method [C++]"
  - "CScrollBar class, initialization"
  - "scroll bars, creating"
ms.assetid: c4c51067-d48d-4f05-bb93-7ac8f5ad53f0
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CScrollBar::Create
Creates the Windows scroll bar and attaches it to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the scroll bar's style. Apply any combination of [scroll-bar styles](../vs140/scroll-bar-styles.md) to the scroll bar.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the scroll bar's size and position. Can be either a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> structure or a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the scroll bar's parent window, usually a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object. It must not be **NULL**.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The scroll bar's control ID.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 You construct a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object in two steps. First, call the constructor, which constructs the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object; then call **Create**, which creates and initializes the associated Windows scroll bar and attaches it to the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.  
  
 Apply the following [window styles](../vs140/window-styles.md) to a scroll bar:  
  
-   **WS_CHILD** Always  
  
-   **WS_VISIBLE** Usually  
  
-   **WS_DISABLED** Rarely  
  
-   **WS_GROUP** To group controls  
  
## Example  
 [!code[NVC_MFC_CScrollBar#1](../vs140/codesnippet/CPP/cscrollbar--create_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CScrollBar Class](../vs140/cscrollbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CScrollBar::CScrollBar](../vs140/cscrollbar--cscrollbar.md)