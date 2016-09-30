---
title: "CREATESTRUCT Structure"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CREATESTRUCT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CREATESTRUCT structure"
ms.assetid: 028c7b5e-4fdc-48da-a550-d3e4f9e6cc85
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CREATESTRUCT Structure
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure defines the initialization parameters passed to the window procedure of an application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to data to be used to create the window.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Identifies the module-instance handle of the module that owns the new window.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Identifies the menu to be used by the new window. If a child window, contains the integer ID.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Identifies the window that owns the new window. This member is **NULL** if the new window is a top-level window.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the height of the new window.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies the width of the new window.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the upper left corner of the new window. Coordinates are relative to the parent window if the new window is a child window; otherwise coordinates are relative to the screen origin.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the upper left corner of the new window. Coordinates are relative to the parent window if the new window is a child window; otherwise coordinates are relative to the screen origin.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Specifies the new window's [style](../vs140/styles-used-by-mfc.md).  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Points to a null-terminated string that specifies the new window's name.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Points to a null-terminated string that specifies the new window's Windows class name (a [WNDCLASS](http://msdn.microsoft.com/library/windows/desktop/ms633576) structure; for more information, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]).  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Specifies the [extended style](../vs140/extended-window-styles.md) for the new window.  
  
## Requirements  
 **Header:** winuser.h  
  
## See Also  
 [Structures, Styles, Callbacks, and Message Maps](../vs140/structures--styles--callbacks--and-message-maps.md)   
 [CWnd::OnCreate](../vs140/cwnd--oncreate.md)