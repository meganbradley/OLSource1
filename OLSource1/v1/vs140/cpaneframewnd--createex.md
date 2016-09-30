---
title: "CPaneFrameWnd::CreateEx"
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
  - "CreateEx"
  - "CPaneFrameWnd.CreateEx"
  - "CPaneFrameWnd::CreateEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateEx method"
ms.assetid: 060f11a6-f62a-45d2-a0c9-fb90b41df66c
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPaneFrameWnd::CreateEx
Creates a miniframe window and attaches it to the [CPaneFrameWnd](../vs140/cpaneframewnd-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the extended window style. For more information, see [Extended Window Styles](../vs140/extended-window-styles.md)  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the text to display on the miniframe window.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the window style. For more information, see [Window Styles](../vs140/window-styles.md).  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the initial size and position of the miniframe window.  
  
 [in] [out] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the parent frame of the miniframe window. This value must not be <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 [in] [out] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies user-defined context.  
  
## Return Value  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if the window was created successfully; otherwise, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Remarks  
 A miniframe window is created in two steps. First, the framework creates a [CPaneFrameWnd](../vs140/cpaneframewnd-class.md) object. Second, it calls <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to create the Windows miniframe window and attach it to the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.  
  
## Requirements  
 **Header:** afxPaneFrameWnd.h  
  
## See Also  
 [CPaneFrameWnd Class](../vs140/cpaneframewnd-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)