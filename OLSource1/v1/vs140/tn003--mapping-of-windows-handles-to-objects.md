---
title: "TN003: Mapping of Windows Handles to Objects"
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
  - "vc.mapping"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TN003"
  - "handle maps"
  - "Windows handles to objects [C++]"
  - "mappings, Windows handles to objects"
ms.assetid: fbea9f38-992c-4091-8dbc-f29e288617d6
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# TN003: Mapping of Windows Handles to Objects
This note describes the MFC routines that support mapping Windows object handles to C++ objects.  
  
## The Problem  
 Windows objects are typically represented by various [HANDLE](http://msdn.microsoft.com/library/windows/desktop/aa383751) objects The MFC classes wrap Windows object handles with C++ objects. The handle wrapping functions of the MFC class library let you find the C++ object that is wrapping the Windows object that has a particular handle. However, sometimes an object does not have a C++ wrapper object and at these times the system creates a temporary object to act as the C++ wrapper.  
  
 The Windows objects that use handle maps are as follows:  
  
-   HWND ([CWnd](../vs140/cwnd-class.md) and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>-derived classes)  
  
-   HDC ([CDC](../vs140/cdc-class.md) and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>-derived classes)  
  
-   HMENU ([CMenu](../vs140/cmenu-class.md))  
  
-   HPEN ([CGdiObject](../vs140/cgdiobject-class.md))  
  
-   HBRUSH (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>)  
  
-   HFONT (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>)  
  
-   HBITMAP (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>)  
  
-   HPALETTE (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>)  
  
-   HRGN (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>)  
  
-   HIMAGELIST ([CImageList](../vs140/cimagelist-class.md))  
  
-   SOCKET ([CSocket](../vs140/csocket-class.md))  
  
 Given a handle to any one of these objects, you can find the MFC object that wraps the handle by calling the static method <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. For example, given an HWND called <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, the following line will return a pointer to the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> that wraps <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> does not have a specific wrapper object, a temporary <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is created to wrap <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. This makes it possible to obtain a valid C++ object from any handle.  
  
 After you have a wrapper object, you can retrieve its handle from a public member variable of the wrapper class. In the case of a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> contains the HWND for that object.  
  
## Attaching Handles to MFC Objects  
 Given a newly created handle-wrapper object and a handle to a Windows object, you can associate the two by calling the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> function as in this example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This makes an entry in the permanent map associating <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. Calling <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> will now return a pointer to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. When <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is deleted, the destructor will automatically destroy <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> by calling the Windows [DestroyWindow](http://msdn.microsoft.com/library/windows/desktop/ms632682) function. If this is not desired, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> must be detached from <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> before <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is destroyed (normally when leaving the scope at which <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> was defined). The <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> method does this.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## More About Temporary Objects  
 Temporary objects are created whenever <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is given a handle that does not already have a wrapper object. These temporary objects are detached from their handle and deleted by the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> functions. By default [CWinThread::OnIdle](../vs140/cwinthread--onidle.md) automatically calls <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> for each class that supports temporary handle maps. This means that you cannot assume a pointer to a temporary object will be valid past the point of exit from the function where the pointer was obtained.  
  
## Wrapper Objects and Multiple Threads  
 Both temporary and permanent objects are maintained on a per-thread basis. That is, one thread cannot access another thread's C++ wrapper objects, regardless of whether it is temporary or permanent.  
  
 To pass these objects from one thread to another, always send them as their native <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> type. Passing a C++ wrapper object from one thread to another will often cause unexpected results.  
  
## See Also  
 [Technical Notes by Number](../vs140/technical-notes-by-number.md)   
 [Technical Notes by Category](../vs140/technical-notes-by-category.md)