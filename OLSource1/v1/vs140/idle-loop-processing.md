---
title: "Idle Loop Processing"
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
  - "MFC, background processing"
  - "PeekMessage method, elsewhere than message loop"
  - "PeekMessage method"
  - "MFC, messages"
  - "messages, loops"
  - "OnIdle method"
  - "processing, background"
  - "idle loop processing"
  - "idle processing"
  - "threading [MFC], alternatives to multithreading"
  - "processing, during idle loop"
  - "processing"
  - "background processing"
ms.assetid: 5c7c46c1-6107-4304-895f-480983bb1e44
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Idle Loop Processing
Many applications perform lengthy processing "in the background." Sometimes performance considerations dictate using multithreading for such work. Threads involve extra development overhead, so they are not recommended for simple tasks like the idle-time work that MFC does in the [OnIdle](../vs140/cwinthread--onidle.md) function. This article focuses on idle processing. For more information about multithreading, see [Multithreading Topics](../vs140/multithreading-support-for-older-code--visual-c---.md).  
  
 Some kinds of background processing are appropriately done during intervals that the user is not otherwise interacting with the application. In an application developed for the Microsoft Windows operating system, an application can perform idle-time processing by splitting a lengthy process into many small fragments. After processing each fragment, the application yields execution control to Windows using a [PeekMessage](http://msdn.microsoft.com/library/windows/desktop/ms644943) loop.  
  
 This article explains two ways to do idle processing in your application:  
  
-   Using **PeekMessage** in MFC's main message loop.  
  
-   Embedding another **PeekMessage** loop somewhere else in the application.  
  
##  \<a name="_core_peekmessage_in_the_mfc_message_loop">\</a> PeekMessage in the MFC Message Loop  
 In an application developed with MFC, the main message loop in the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> class contains a message loop that calls the [PeekMessage](http://msdn.microsoft.com/library/windows/desktop/ms644943) Win32 API. This loop also calls the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> between messages. An application can process messages in this idle time by overriding the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function.  
  
> [!NOTE]
>  **Run**, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, and certain other member functions are now members of class <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> rather than of class <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is derived from <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 For more information about performing idle processing, see [OnIdle](../vs140/cwinthread--onidle.md) in the *MFC Reference*.  
  
##  \<a name="_core_peekmessage_elsewhere_in_your_application">\</a> PeekMessage Elsewhere in Your Application  
 Another method for performing idle processing in an application involves embedding a message loop in one of your functions. This message loop is very similar to MFC's main message loop, found in [CWinThread::Run](../vs140/cwinthread--run.md). That means such a loop in an application developed with MFC must perform many of the same functions as the main message loop. The following code fragment demonstrates writing a message loop that is compatible with MFC:  
  
 [!code[NVC_MFCDocView#8](../vs140/codesnippet/CPP/idle-loop-processing_1.cpp)]  
  
 This code, embedded in a function, loops as long as there is idle processing to do. Within that loop, a nested loop repeatedly calls **PeekMessage**. As long as that call returns a nonzero value, the loop calls <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to perform normal message translation and dispatching. Although <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is undocumented, you can examine its source code in the ThrdCore.Cpp file in the \atlmfc\src\mfc directory of your Visual C++ installation.  
  
 Once the inner loop ends, the outer loop performs idle processing with one or more calls to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The first call is for MFC's purposes. You can make additional calls to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to do your own background work.  
  
 For more information about performing idle processing, see [OnIdle](../vs140/cwinthread--onidle.md) in the MFC Library Reference.  
  
## See Also  
 [General MFC Topics](../vs140/general-mfc-topics.md)