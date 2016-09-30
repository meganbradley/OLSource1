---
title: "Using Contained Windows"
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
  - "windows [C++], ATL"
  - "contained windows in ATL"
ms.assetid: 7b3d79e5-b569-413f-9b98-df4f14efbe2b
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Contained Windows
ATL implements contained windows with [CContainedWindowT](../vs140/ccontainedwindowt-class.md). A contained window represents a window that delegates its messages to a container object instead of handling them in its own class.  
  
> [!NOTE]
>  You do not need to derive a class from <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> in order to use contained windows.  
  
 With contained windows, you can either superclass an existing Windows class or subclass an existing window. To create a window that superclasses an existing Windows class, first specify the existing class name in the constructor for the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object. Then call <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. To subclass an existing window, you don't need to specify a Windows class name (pass **NULL** to the constructor). Simply call the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method with the handle to the window being subclassed.  
  
 You typically use contained windows as data members of a container class. The container does not need to be a window; however, it must derive from [CMessageMap](../vs140/cmessagemap-class.md).  
  
 A contained window can use alternate message maps to handle its messages. If you have more than one contained window, you should declare several alternate message maps, each corresponding to a separate contained window.  
  
## Example  
 Following is an example of a container class with two contained windows:  
  
 [!code[NVC_ATL_Windowing#67](../vs140/codesnippet/CPP/using-contained-windows_1.h)]  
  
 For more information about contained windows, see the [SUBEDIT](../vs140/visual-c---samples.md) sample.  
  
## See Also  
 [Window Classes](../vs140/atl-window-classes.md)