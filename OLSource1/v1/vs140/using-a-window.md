---
title: "Using a Window"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ATL, windows"
  - "CWindow class, about CWindow class"
  - "windows [C++], ATL"
ms.assetid: b3b9cc8e-4287-486b-b080-38852bc2943a
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using a Window
Class [CWindow](../vs140/cwindow-class.md) allows you to use a window. Once you attach a window to a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> object, you can then call <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> methods to manipulate the window. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> also contains an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> operator to convert a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object to an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Thus you can pass a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object to any function that requires a handle to a window. You can easily mix <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method calls and Win32 function calls, without creating any temporary objects.  
  
 Because <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> has only two data member (a window handle and the default dimensions), it does not impose an overhead on your code. In addition, many of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> methods simply wrap corresponding Win32 API functions. By using <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> member is automatically passed to the Win32 function.  
  
 In addition to using <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> directly, you can also derive from it to add data or code to your class. ATL itself derives three classes from <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>: [CWindowImpl](../vs140/implementing-a-window.md), [CDialogImpl](../vs140/implementing-a-dialog-box.md), and [CContainedWindowT](../vs140/using-contained-windows.md).  
  
## See Also  
 [Window Classes](../vs140/atl-window-classes.md)