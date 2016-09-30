---
title: "Creating an Active Document Container Application"
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
  - "active documents [C++], containers"
  - "containers [C++], active document"
  - "active document containers [C++], creating"
  - "MFC COM [C++], active document containment"
  - "applications [MFC], active document container"
ms.assetid: 14e2d022-a6c5-4249-8712-706b0f4433f7
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Creating an Active Document Container Application
The simplest and most recommended way to create an active document container application is to create an MFC EXE container application using the MFC Application Wizard, then modify the application to support active document containment.  
  
#### To create an active document container application  
  
1.  From the **File** menu, click **Project**from the **New** submenu.  
  
2.  From the left pane, click **Visual C++** project type.  
  
3.  Select **MFC Application** from the right pane.  
  
4.  Name the project <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, click **OK**.  
  
5.  Select the **Compound Document Support** page.  
  
6.  Select the **Container** or **Container/Full-server** option.  
  
7.  Select the **Active document container** check box.  
  
8.  Click **Finish**.  
  
9. When the MFC Application Wizard finishes generating the application, open the following files using Solution Explorer:  
  
    -   MyProjview.cpp  
  
10. In MyProjview.cpp, make the following changes:  
  
    -   In <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, replace the function contents with the following code:  
  
         [!code[NVC_MFCDocView#56](../vs140/codesnippet/CPP/creating-an-active-document-container-application_1.cpp)]  
  
     <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> provides printing support. This code replaces <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, which is the default print preparation.  
  
     Active document containment provides an improved printing scheme:  
  
    -   You can first call the active document through its <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>interface and tell it to print itself. This is different from previous OLE containment, in which the container had to render an image of the contained item onto the printer <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>object.  
  
    -   If that fails, tell the contained item to print itself through its <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>interface  
  
    -   If that fails, make your own rendering of the item.  
  
     The static member functions <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, as implemented in the previous code, handle this improved printing scheme.  
  
11. Add any implementation of your own and build the application.  
  
## See Also  
 [Active Document Containment](../vs140/active-document-containment.md)