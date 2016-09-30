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
  
 For example, Win32's concept of window is encapsulated by MFC class <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>. That is, a C++ class called <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> encapsulates or "wraps" the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> handle that represents a Windows window. Likewise, class <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> encapsulates Win32 dialog boxes.  
  
 Encapsulation means that the C++ class <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, for example, contains a member variable of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and the class's member functions encapsulate calls to Win32 functions that take an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> as a parameter. The class member functions typically have the same name as the Win32 function they encapsulate.  
  
## In This Section  
 [SDI and MDI](../vs140/sdi-and-mdi.md)  
  
 [Documents, Views, and the Framework](../vs140/documents--views--and-the-framework.md)  
  
 [Wizards and Resource Editors](../vs140/wizards-and-the-resource-editors.md)  
  
## In Related Sections  
 [Building on the Framework](../vs140/building-on-the-framework.md)  
  
 [How the Framework Calls Your Code](../vs140/how-the-framework-calls-your-code.md)  
  
 [CWinApp: The Application Class](../vs140/cwinapp--the-application-class.md)  
  
 [Document Templates and the Document/View Creation Process](../vs140/document-templates-and-the-document-view-creation-process.md)  
  
 [Message Handling and Mapping](../vs140/message-handling-and-mapping.md)  
  
 [Window Objects](../vs140/window-objects.md)  
  
## See Also  
 [Using the Classes to Write Applications for Windows](../vs140/using-the-classes-to-write-applications-for-windows.md)