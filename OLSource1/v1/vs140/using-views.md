---
title: "Using Views"
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
  - "interacting with users and role of view class"
  - "drawing, data"
  - "rendering data"
  - "view classes, role in managing user interaction"
  - "CView class, view architecture"
  - "MFC, views"
  - "views, using"
  - "painting data"
  - "user input, interpreting through view class"
  - "view classes, role in displaying application data"
ms.assetid: dc3de6ad-5c64-4317-8f10-8bdcc38cdbd5
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Views
The view's responsibilities are to display the document's data graphically to the user and to accept and interpret user input as operations on the document. Your tasks in writing your view class are to:  
  
-   Write your view class's [OnDraw](../vs140/cview--ondraw.md) member function, which renders the document's data.  
  
-   Connect appropriate Windows messages and user-interface objects such as menu items to message-handler member functions in the view class.  
  
-   Implement those handlers to interpret user input.  
  
 In addition, you may need to override other `CView` member functions in your derived view class. In particular, you may want to override [OnInitialUpdate](../vs140/cview--oninitialupdate.md) to perform special initialization for the view and [OnUpdate](../vs140/cview--onupdate.md) to do any special processing needed just before the view redraws itself. For multipage documents, you also must override [OnPreparePrinting](../vs140/cview--onprepareprinting.md) to initialize the Print dialog box with the number of pages to print and other information. For more information on overriding `CView` member functions, see class [CView](../vs140/cview-class.md) in the *MFC Reference*.  
  
## What do you want to know more about?  
  
-   [Derived view classes available in MFC](../vs140/derived-view-classes-available-in-mfc.md)  
  
-   [Drawing in a view](../vs140/drawing-in-a-view.md)  
  
-   [Interpreting user input through a view](../vs140/interpreting-user-input-through-a-view.md)  
  
-   [The role of the view in printing](../vs140/role-of-the-view-in-printing.md)  
  
-   [Scrolling and scaling views](../vs140/scrolling-and-scaling-views.md)  
  
-   [Initializing and cleaning up documents and views](../vs140/initializing-and-cleaning-up-documents-and-views.md)  
  
## See Also  
 [Document/View Architecture](../vs140/document-view-architecture.md)   
 [CFormView Class](../vs140/cformview-class.md)   
 [Record Views  (MFC Data Access)](../vs140/record-views---mfc-data-access-.md)   
 [Bypassing the Serialization Mechanism](../vs140/bypassing-the-serialization-mechanism.md)