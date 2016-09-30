---
title: "TN017: Destroying Window Objects"
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
  - "vc.objects"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "destroying windows"
  - "TN017"
  - "PostNcDestroy method"
ms.assetid: 5bf208a5-5683-439b-92a1-547c5ded26cd
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# TN017: Destroying Window Objects
This note describes the use of the [CWnd::PostNcDestroy](../vs140/cwnd--postncdestroy.md) method. Use this method if you want to do customized allocation of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>-derived objects. This note also explains why you should use [CWnd::DestroyWindow](../vs140/cwnd--destroywindow.md) to destroy a C++ Windows object instead of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> operator.  
  
 If you follow the guidelines in this topic, you will have few cleanup problems. These problems can result from issues such as forgetting to delete/free C++ memory, forgetting to free system resources like <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>s, or freeing objects too many times.  
  
## The Problem  
 Each windows object (object of a class derived from <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) represents both a C++ object and an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. C++ objects are allocated in the application's heap and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>s are allocated in system resources by the window manager. Because there are several ways to destroy a window object, we must provide a set of rules that prevent system resource or memory leaks. These rules must also prevent objects and Windows handles from being destroyed more than one time.  
  
## Destroying Windows  
 The following are the two permitted ways to destroy a Windows object:  
  
-   Calling <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or the Windows API <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
-   Explicitly deleting with the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> operator.  
  
 The first case is by far the most common. This case applies even if your code does not call <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> directly. When the user directly closes a frame window, this action generates the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> message, and the default response to this message is to call <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> When a parent window is destroyed, Windows calls <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> for all its children.  
  
 The second case, the use of the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> operator on Windows objects, should be rare. The following are some cases where using <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is the correct choice.  
  
## Auto Cleanup with CWnd::PostNcDestroy  
 When the system destroys a Windows window, the last Windows message sent to the window is <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. The default <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> handler for that message is [CWnd::OnNcDestroy](../vs140/cwnd--onncdestroy.md). <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> will detach the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> from the C++ object and call the virtual function <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. Some classes override this function to delete the C++ object.  
  
 The default implementation of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> does nothing, which is appropriate for window objects that are allocated on the stack frame or embedded in other objects. This is not appropriate for window objects that are designed to be allocated on the heap without any other objects. In other words, it is not appropriate for window objects that are not embedded in other C++ objects.  
  
 Those classes that are designed to be allocated alone on the heap override the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> method to perform a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. This statement will free any memory associated with the C++ object. Even though the default <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> destructor calls <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is non-NULL, this does not lead to infinite recursion because the handle will be detached and NULL during the cleanup phase.  
  
> [!NOTE]
>  The system usually calls <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> after it processes the Windows <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> message and the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and the C++ window object are no longer connected. The system will also call <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> in the implementation of most [CWnd::Create](../vs140/cwnd--create.md) calls if failure occurs. The auto cleanup rules are described later in this topic.  
  
## Auto Cleanup Classes  
 The following classes are not designed for auto-cleanup. They are typically embedded in other C++ objects or on the stack:  
  
-   All standard Windows controls (<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, and so on).  
  
-   Any child windows derived directly from <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> (for example, custom controls).  
  
-   Splitter windows (<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>).  
  
-   Default control bars (classes derived from <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, see [Technical Note 31](../vs140/tn031--control-bars.md) for enabling auto-delete for control bar objects).  
  
-   Dialogs (<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>) designed for modal dialogs on the stack frame.  
  
-   All the standard dialogs except <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
-   The default dialogs created by ClassWizard.  
  
 The following classes are designed for auto-cleanup. They are typically allocated by themselves on the heap:  
  
-   Main frame windows (derived directly or indirectly from <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>).  
  
-   View windows (derived directly or indirectly from <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>).  
  
 If you want to break these rules, you must override the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> method in your derived class. To add auto-cleanup to your class, call your base class and then do a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. To remove auto-cleanup from your class, call <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> directly instead of the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> method of your direct base class.  
  
 The most common use of changing auto cleanup behavior is to create a modeless dialog that can be allocated on the heap.  
  
## When to Call delete  
 We recommend that you call <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> to destroy a Windows object, either the C++ method or the global <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> API.  
  
 Do not call the global <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> API to destroy a MDI Child window. You should use the virtual method <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> instead.  
  
 For C++ Window objects that do not perform auto-cleanup, using the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> operator can cause a memory leak when you try to call <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> destructor if the VTBL does not point to the correctly derived class. This occurs because the system cannot find the appropriate destroy method to call. Using <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> avoids these problems. Because this can be a subtle error, compiling in debug mode will generate the following warning if you are at risk.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In the case of C++ Windows objects that do perform auto-cleanup, you must call <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>. If you use the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> operator directly, the MFC diagnostic memory allocator will notify you that you are freeing memory two times. The two occurrences are your first explicit call and the indirect call to <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> in the auto-cleanup implementation of <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
 After calling <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> on a non-auto-cleanup object, the C++ object will still be around, but <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> will be NULL. After calling <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> on an auto-cleanup object, the C++ object will be gone, freed by the C++ delete operator in the auto-cleanup implementation of <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>.  
  
## See Also  
 [Technical Notes by Number](../vs140/technical-notes-by-number.md)   
 [Technical Notes by Category](../vs140/technical-notes-by-category.md)