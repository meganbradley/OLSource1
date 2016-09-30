---
title: "TN025: Document, View, and Frame Creation"
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
  - "vc.creation"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "documents, view and frame creation"
  - "TN025"
ms.assetid: 09254d72-6e1d-43db-80e9-693887dbeda2
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# TN025: Document, View, and Frame Creation
> [!NOTE]
>  The following technical note has not been updated since it was first included in the online documentation. As a result, some procedures and topics might be out of date or incorrect. For the latest information, it is recommended that you search for the topic of interest in the online documentation index.  
  
 This note describes the creation and ownership issues for WinApps, DocTemplates, Documents, Frames and Views.  
  
## WinApp  
 There is one <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object in the system.  
  
 It is statically constructed and initialized by the framework's internal implementation of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. You must derive from <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to do anything useful (exception: extension DLLs should not have a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> instance — initialization is done in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> instead).  
  
 The one <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object owns a list of document templates (a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>). There is one or more document template per application. DocTemplates are usually loaded from the resource file (that is, a string array) in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The one <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object owns all frame windows in the application. The main frame window for the application should be stored in **CWinApp::m_pMainWnd**; usually you set <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> implementation if you have not let AppWizard do it for you. For single document interface (SDI) this is one <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> that serves as the main application frame window as well as the only document frame window. For multiple document interface (MDI) this is an MDI-Frame (class <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>) that serves as the main application frame window that contains all the child <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>s. Each child window is of class <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> (derived from <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>) and serves as one of potentially many document frame windows.  
  
## DocTemplates  
 The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is the creator and manager of documents. It owns the documents that it creates. If your application uses the resource-based approach described below, it will not need to derive from <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 For an SDI application, the class <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> keeps track of one open document. For an MDI application, the class <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> keeps a list (a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>) of all the currently open documents created from that template. <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> provide the virtual member functions for adding or removing a document from the template. <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is a friend of **CDocument** so we can set the protected **CDocument::m_pDocTemplate** back pointer to point back to the doc template that created the document.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> handles the default <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> implementation, which will in turn query all the doc templates. The implementation includes looking for already open documents and deciding what format to open new documents in.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> manages the UI binding for documents and frames.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> keeps a count of the number of unnamed documents.  
  
## CDocument  
 A **CDocument** is owned by a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
 Documents have a list of currently open views (derived from <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>) that are viewing the document (a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>).  
  
 Documents do not create/destroy the views, but they are attached to each other after they are created. When a document is closed (that is, through File/Close), all attached views will be closed. When the last view on a document is closed (that is, Window/Close) the document will be closed.  
  
 The <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> interface is used to maintain the view list. **CDocument** is a friend of <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> so we can set the **CView::m_pDocument** back pointer.  
  
## CFrameWnd  
 A <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> (also known as a frame) plays the same role as in MFC 1.0, but now the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> class is designed to be used in many cases without deriving a new class. The derived classes <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> are also enhanced so many standard commands are already implemented.  
  
 The <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is responsible for creating windows in the client area of the frame. Normally there is one main window filling the client area of the frame.  
  
 For an MDI-Frame window, the client area is filled with the MDICLIENT control which is in turn the parent of all the MDI-Child frame windows. For an SDI-Frame window or an MDI-Child frame window, the client area is usually filled with a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>-derived window object. In the case of <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, the client area of the view is filled with the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> window object, and the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>-derived window objects (one per split pane) are created as child windows of the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
## See Also  
 [Technical Notes by Number](../vs140/technical-notes-by-number.md)   
 [Technical Notes by Category](../vs140/technical-notes-by-category.md)