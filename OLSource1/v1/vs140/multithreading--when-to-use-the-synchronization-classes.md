---
title: "Multithreading: When to Use the Synchronization Classes"
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
  - "threading [MFC], synchronization classes"
  - "resources [C++], multithreading"
  - "synchronization classes [C++]"
  - "synchronization [C++], multithreading"
  - "controlled resource access [C++]"
  - "synchronization access classes [C++]"
  - "threading [C++], synchronization"
  - "multithreading [C++], synchronization classes"
ms.assetid: 4914f54e-68ac-438f-93c9-c013455a657e
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Multithreading: When to Use the Synchronization Classes
The multithreaded classes provided with MFC fall into two categories: synchronization objects ([CSyncObject](../vs140/csyncobject-class.md), [CSemaphore](../vs140/csemaphore-class.md), [CMutex](../vs140/cmutex-class.md), [CCriticalSection](../vs140/ccriticalsection-class.md), and [CEvent](../vs140/cevent-class.md)) and synchronization access objects ([CMultiLock](../vs140/cmultilock-class.md) and [CSingleLock](../vs140/csinglelock-class.md)).  
  
 Synchronization classes are used when access to a resource must be controlled to ensure integrity of the resource. Synchronization access classes are used to gain access to these controlled resources. This topic describes when to use each class.  
  
 To determine which synchronization class you should use, ask the following series of questions:  
  
1.  Does the application have to wait for something to happen before it can access the resource (for example, data must be received from a communications port before it can be written to a file)?  
  
     If yes, use <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>.  
  
2.  Can more than one thread within the same application access this resource at one time (for example, your application allows up to five windows with views on the same document)?  
  
     If yes, use <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
3.  Can more than one application use this resource (for example, the resource is in a DLL)?  
  
     If yes, use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
     If no, use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 **CSyncObject** is never used directly. It is the base class for the other four synchronization classes.  
  
## Example 1: Using Three Synchronization Classes  
 As an example, take an application that maintains a linked list of accounts. This application allows up to three accounts to be examined in separate windows, but only one can be updated at any particular time. When an account is updated, the updated data is sent over the network to a data archive.  
  
 This example application uses all three types of synchronization classes. Because it allows up to three accounts to be examined at one time, it uses <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to limit access to three view objects. When an attempt to view a fourth account occurs, the application either waits until one of the first three windows closes or it fails. When an account is updated, the application uses <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to ensure that only one account is updated at a time. After the update succeeds, it signals <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, which releases a thread waiting for the event to be signaled. This thread sends the new data to the data archive.  
  
## Example 2: Using Synchronization Access Classes  
 Choosing which synchronization access class to use is even simpler. If your application is concerned with accessing a single controlled resource only, use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. If it needs access to any one of a number of controlled resources, use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. In example 1, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> would have been used, because in each case only one resource is needed at any particular time.  
  
 For information about how the synchronization classes are used, see [Multithreading: How to Use the Synchronization Classes](../vs140/multithreading--how-to-use-the-synchronization-classes.md). For information about synchronization, see [Synchronization](http://msdn.microsoft.com/library/windows/desktop/ms686353) in the [!INCLUDE[winsdkshort](../vs140/includes/winsdkshort_md.md)]. For information about multithreading support in MFC, see [Multithreading with C++ and MFC](../vs140/multithreading-with-c---and-mfc.md).  
  
## See Also  
 [Multithreading with C++ and MFC](../vs140/multithreading-with-c---and-mfc.md)