---
title: "Creating New Documents, Windows, and Views"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - MDI [C++], creating windows
  - window objects [C++], creating
  - objects [C++], creating document objects
  - MFC default objects
  - frame windows [C++], creating
  - windows [C++], MDI
  - MFC [C++], documents
  - view objects, creating
  - windows [C++], creating
  - overriding, default view behavior
  - views [C++], initializing
  - customizing MFC default objects
  - MFC [C++], frame windows
  - MFC [C++], views
  - MDI [C++], frame windows
  - child windows, creating MDI
  - view objects
  - document objects, creating
  - MFC default objects, customizing
  - views [C++], overriding default behavior
  - initializing views
ms.assetid: 88aa1f5f-2078-4603-b16b-a2b4c7b4a2a3
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Creating New Documents, Windows, and Views
The following figures give an overview of the creation process for documents, views, and frame windows. Other articles that focus on the participating objects provide further details.  
  
 Upon completion of this process, the cooperating objects exist and store pointers to each other. The following figures show the sequence in which objects are created. You can follow the sequence from figure to figure.  
  
 ![Sequence for creating a document](../vs140/media/vc387l1.gif "vc387L1")  
Sequence in Creating a Document  
  
 ![Frame Window Creation Sequence](../vs140/media/vc387l2.png "vc387L2")  
Sequence in Creating a Frame Window  
  
 ![Sequence for creating a view](../vs140/media/vc387l3.gif "vc387L3")  
Sequence in Creating a View  
  
 For information about how the framework initializes the new document, view, and frame-window objects, see classes [CDocument](../vs140/cdocument-class.md), [CView](../vs140/cview-class.md), [CFrameWnd](../vs140/cframewnd-class.md), [CMDIFrameWnd](../vs140/cmdiframewnd-class.md), and [CMDIChildWnd](../vs140/cmdichildwnd-class.md) in the MFC Library Reference. Also see [Technical Note 22](../vs140/tn022--standard-commands-implementation.md), which explains the creation and initialization processes further under its discussion of the framework's standard commands for the `New` and **Open** items on the **File** menu.  
  
##  <a name="_core_initializing_your_own_additions_to_these_classes"></a> Initializing Your Own Additions to These Classes  
 The preceding figures also suggest the points at which you can override member functions to initialize your application's objects. An override of `OnInitialUpdate` in your view class is the best place to initialize the view. The `OnInitialUpdate` call occurs immediately after the frame window is created and the view within the frame window is attached to its document. For example, if your view is a scroll view (derived from `CScrollView` rather than `CView`), you should set the view size based on the document size in your `OnInitialUpdate` override. (This process is described in the description of class [CScrollView](../vs140/cscrollview-class.md).) You can override the **CDocument** member functions `OnNewDocument` and `OnOpenDocument` to provide application-specific initialization of the document. Typically, you must override both since a document can be created in two ways.  
  
 In most cases, your override should call the base class version. For more information, see the named member functions of classes [CDocument](../vs140/cdocument-class.md), [CView](../vs140/cview-class.md), [CFrameWnd](../vs140/cframewnd-class.md), and [CWinApp](../vs140/cwinapp-class.md) in the MFC Library Reference.  
  
## See Also  
 [Document Templates and the Document/View Creation Process](../vs140/document-templates-and-the-document-view-creation-process.md)   
 [Document Template Creation](../vs140/document-template-creation.md)   
 [Document/View Creation](../vs140/document-view-creation.md)   
 [Relationships Among MFC Objects](../vs140/relationships-among-mfc-objects.md)