---
title: "Implementing a Window with CWindowImpl"
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
  - "CWindowImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ATL, windows"
  - "windows [C++], subclassing"
  - "windows [C++], superclassing"
  - "windows [C++], ATL"
  - "subclassing ATL window classes"
  - "superclassing, ATL"
ms.assetid: 3fc40550-f1d6-4702-8b7c-4cf682b6a855
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Implementing a Window with CWindowImpl
To implement a window, derive a class from <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>. In your derived class, declare a message map and the message handler functions. You can now use your class in three different ways:  
  
-   [Create a window based on a new Windows class](#_atl_creating_a_window_based_on_a_new_windows_class)  
  
-   [Superclass an existing Windows class](#_atl_superclassing_an_existing_windows_class)  
  
-   [Subclass an existing window](#_atl_subclassing_an_existing_window)  
  
##  \<a name="_atl_creating_a_window_based_on_a_new_windows_class">\</a> Creating a Window Based on a New Windows Class  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> contains the [DECLARE_WND_CLASS](../vs140/declare_wnd_class.md) macro to declare Windows class information. This macro implements the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function, which uses [CWndClassInfo](../vs140/cwndclassinfo-class.md) to define the information of a new Windows class. When <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is called, this Windows class is registered and a new window is created.  
  
> [!NOTE]
>  <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> passes **NULL** to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> macro, which means ATL will generate a Windows class name. To specify your own name, pass a string to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in your <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>-derived class.  
  
## Example  
 Following is an example of a class that implements a window based on a new Windows class:  
  
 [!code[NVC_ATL_Windowing#64](../vs140/codesnippet/CPP/implementing-a-window-with-cwindowimpl_1.h)]  
  
 To create a window, create an instance of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and then call the **Create** method.  
  
> [!NOTE]
>  To override the default Windows class information, implement the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method in your derived class by setting the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> members to the appropriate values.  
  
##  \<a name="_atl_superclassing_an_existing_windows_class">\</a> Superclassing an Existing Windows Class  
 The [DECLARE_WND_SUPERCLASS](../vs140/declare_wnd_superclass.md) macro allows you to create a window that superclasses an existing Windows class. Specify this macro in your <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>-derived class. Like any other ATL window, messages are handled by a message map.  
  
 When you use <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, a new Windows class will be registered. This new class will be the same as the existing class you specify, but will replace the window procedure with <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> (or with your function that overrides this method).  
  
## Example  
 Following is an example of a class that superclasses the standard Edit class:  
  
 [!code[NVC_ATL_Windowing#65](../vs140/codesnippet/CPP/implementing-a-window-with-cwindowimpl_2.h)]  
  
 To create the superclassed Edit window, create an instance of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and then call the **Create** method.  
  
##  \<a name="_atl_subclassing_an_existing_window">\</a> Subclassing an Existing Window  
 To subclass an existing window, derive a class from <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and declare a message map, as in the two previous cases. Note, however, that you do not specify any Windows class information, since you will subclass an already existing window.  
  
 Instead of calling **Create**, call <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and pass it the handle to the existing window you want to subclass. Once the window is subclassed, it will use <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> (or your function that overrides this method) to direct messages to the message map. To detach a subclassed window from your object, call <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. The window's original window procedure will then be restored.  
  
## See Also  
 [Implementing a Window](../vs140/implementing-a-window.md)