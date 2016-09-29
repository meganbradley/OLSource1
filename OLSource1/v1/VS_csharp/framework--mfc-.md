---
title: "Framework (MFC)"
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
  - "encapsulation [C++], Win32 API"
  - "MFC [C++], application framework"
  - "wrapper classes, explained"
  - "Win32 [C++], API encapsulation by MFC"
  - "application framework [C++], about MFC application framework"
  - "APIs [C++], encapsulation by MFC Win32"
  - "encapsulation [C++]"
  - "Windows API [C++], encapsulation by MFC"
  - "encapsulated Win32 API"
ms.assetid: 3be0fec8-9843-4119-ae42-ece993ef500b
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Framework (MFC)
Your work with the Microsoft Foundation Class (MFC) Library framework is based largely on a few major classes and several Visual C++ tools. Some classes encapsulate a large portion of the Win32 application programming interface (API). Other classes encapsulate application concepts such as documents, views, and the application itself. Still others encapsulate OLE features and ODBC and DAO data-access functionality.  
  
 For example, Win32's concept of window is encapsulated by MFC class `CWnd`. That is, a C++ class called `CWnd` encapsulates or "wraps" the `HWND` handle that represents a Windows window. Likewise, class `CDialog` encapsulates Win32 dialog boxes.  
  
 Encapsulation means that the C++ class `CWnd`, for example, contains a member variable of type `HWND`, and the class's member functions encapsulate calls to Win32 functions that take an `HWND` as a parameter. The class member functions typically have the same name as the Win32 function they encapsulate.  
  
## In This Section  
 [SDI and MDI](../VS_csharp/sdi-and-mdi.md)  
  
 [Documents, Views, and the Framework](../VS_csharp/documents--views--and-the-framework.md)  
  
 [Wizards and Resource Editors](../VS_csharp/wizards-and-the-resource-editors.md)  
  
## In Related Sections  
 [Building on the Framework](../VS_csharp/building-on-the-framework.md)  
  
 [How the Framework Calls Your Code](../VS_csharp/how-the-framework-calls-your-code.md)  
  
 [CWinApp: The Application Class](../VS_csharp/cwinapp--the-application-class.md)  
  
 [Document Templates and the Document/View Creation Process](../VS_csharp/document-templates-and-the-document-view-creation-process.md)  
  
 [Message Handling and Mapping](../VS_csharp/message-handling-and-mapping.md)  
  
 [Window Objects](../VS_csharp/window-objects.md)  
  
## See Also  
 [Using the Classes to Write Applications for Windows](../VS_csharp/using-the-classes-to-write-applications-for-windows.md)