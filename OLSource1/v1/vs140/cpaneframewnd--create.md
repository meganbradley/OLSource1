---
title: "CPaneFrameWnd::Create"
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
  - "CPaneFrameWnd.Create"
  - "CPaneFrameWnd::Create"
  - "Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method"
ms.assetid: d8e0516c-79b2-43d7-b56b-c6673396724b
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPaneFrameWnd::Create
Creates a miniframe window and attaches it to the [CPaneFrameWnd](../vs140/cpaneframewnd-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the text to display on the miniframe window.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the window style. For more information, see [Window Styles](../vs140/window-styles.md).  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the initial size and position of the miniframe window.  
  
 [in] [out] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the parent frame of the miniframe window. This value must not be <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 [in] [out] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies user-defined context.  
  
## Return Value  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the window was created successfully; otherwise, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Remarks  
 A miniframe window is created in two steps. First, the framework creates a [CPaneFrameWnd](../vs140/cpaneframewnd-class.md) object. Second, it calls <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to create the Windows miniframe window and attach it to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.  
  
## Requirements  
 **Header:** afxPaneFrameWnd.h  
  
## See Also  
 [CPaneFrameWnd Class](../vs140/cpaneframewnd-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)