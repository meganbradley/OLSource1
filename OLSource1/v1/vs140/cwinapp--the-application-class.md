---
title: "CWinApp: The Application Class"
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
  - "CWinApp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "application class"
  - "CWinApp class, CWinThread"
  - "MFC [C++], WinMain and"
  - "CWinApp class, multithreading"
  - "CWinThread class, and CWinApp"
  - "InitApplication method"
  - "WinMain method"
  - "WinMain method, in MFC"
  - "CWinApp class, WinMain"
ms.assetid: 935822bb-d463-481b-a5f6-9719d68ed1d5
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp: The Application Class
The main application class in MFC encapsulates the initialization, running, and termination of an application for the Windows operating system. An application built on the framework must have one and only one object of a class derived from [CWinApp](../vs140/cwinapp-class.md). This object is constructed before windows are created.  
  
 <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> is derived from <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, which represents the main thread of execution for your application, which might have one or more threads. In recent versions of MFC, the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, **Run**, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> member functions are actually in class <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. These functions are discussed here as if they were <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> members instead, because the discussion concerns the object's role as application object rather than as primary thread.  
  
> [!NOTE]
>  Your application class constitutes your application's primary thread of execution. Using Win32 API functions, you can also create secondary threads of execution. These threads can use the MFC Library. For more information, see [Multithreading](../vs140/multithreading-support-for-older-code--visual-c---.md).  
  
 Like any program for the Windows operating system, your framework application has a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function. In a framework application, however, you do not write <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. It is supplied by the class library and is called when the application starts up. <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> performs standard services such as registering window classes. It then calls member functions of the application object to initialize and run the application. (You can customize <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> by overriding the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> member functions that <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> calls.)  
  
 To initialize the application, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> calls your application object's <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> member functions. To run the application's message loop, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> calls the **Run** member function. On termination, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> calls the application object's <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> member function.  
  
> [!NOTE]
>  Names shown in **bold** in this documentation indicate elements supplied by the Microsoft Foundation Class Library and Visual C++. Names shown in <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> type indicate elements that you create or override.  
  
## See Also  
 [General MFC Topics](../vs140/general-mfc-topics.md)   
 [CWinApp and the MFC Application Wizard](../vs140/cwinapp-and-the-mfc-application-wizard.md)   
 [Overridable CWinApp Member Functions](../vs140/overridable-cwinapp-member-functions.md)   
 [Special CWinApp Services](../vs140/special-cwinapp-services.md)