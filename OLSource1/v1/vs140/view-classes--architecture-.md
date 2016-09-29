---
title: "View Classes (Architecture)"
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
  - "vc.classes.view"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "form and record views"
  - "view classes"
  - "control views"
  - "view classes, architecture"
ms.assetid: 8894579a-1436-441e-b985-83711061e495
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# View Classes (Architecture)
`CView` and its derived classes are child windows that represent the client area of a frame window. Views show data and accept input for a document.  
  
 A view class is associated with a document class and a frame window class using a document-template object.  
  
 [CView](../vs140/cview-class.md)  
 The base class for application-specific views of a document's data. Views display data and accept user input to edit or select the data. Derive your view class(es) from `CView`.  
  
 [CScrollView](../vs140/cscrollview-class.md)  
 The base class for views with scrolling capabilities. Derive your view class from `CScrollView` for automatic scrolling.  
  
## Form and Record Views  
 Form views are also scrolling views. They are based on a dialog box template.  
  
 Record views are derived from form views. In addition to the dialog box template, they also have a connection to a database.  
  
 [CFormView](../vs140/cformview-class.md)  
 A scroll view whose layout is defined in a dialog box template. Derive a class from `CFormView` to implement a user interface based on a dialog box template.  
  
 [CDaoRecordView](../vs140/cdaorecordview-class.md)  
 Provides a form view directly connected to a Data Access Object (DAO) recordset object. Like all form views, a `CDaoRecordView` is based on a dialog box template.  
  
 [CHtmlView](../vs140/chtmlview-class.md)  
 Supports a control for Web browsing within an application. The control supports dynamic HTML in MFC.  
  
 [COLEDBRecordView](../vs140/coledbrecordview-class.md)  
 Provides MFC OLE DB support for form views.  
  
 [CRecordView](../vs140/crecordview-class.md)  
 Provides a form view directly connected to an Open Database Connectivity (ODBC) recordset object. Like all form views, a `CRecordView` is based on a dialog box template.  
  
## Control Views  
 Control views display a control as their view.  
  
 [CCtrlView](../vs140/cctrlview-class.md)  
 The base class for all views associated with Windows controls. The views based on controls are described below.  
  
 [CEditView](../vs140/ceditview-class.md)  
 A view that contains a Windows standard edit control (see [CEdit](../vs140/cedit-class.md)). Edit controls support text editing, searching, replacing, and scrolling capabilities.  
  
 [CRichEditView](../vs140/cricheditview-class.md)  
 A view that contains a Windows rich edit control (see [CRichEditCtrl](../vs140/cricheditctrl-class.md)). In addition to the capabilities of an edit control, rich edit controls support fonts, colors, paragraph formatting, and embedded OLE objects.  
  
 [CListView](../vs140/clistview-class.md)  
 A view that contains a Windows list control (see [CListCtrl](../vs140/clistctrl-class.md)). A list control displays icons and strings in a manner similar to the right pane of File Explorer.  
  
 [CTreeView](../vs140/ctreeview-class.md)  
 A view that contains a Windows tree control (see [CTreeCtrl](../vs140/ctreectrl-class.md)). A tree control displays icons and strings arranged in a hierarchy in a manner similar to the left pane of File Explorer.  
  
## See Also  
 [Class Overview](../vs140/class-library-overview.md)