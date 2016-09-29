---
title: "Derived View Classes Available in MFC"
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
  - "CView class, classes derived from"
  - "classes [C++], derived"
  - "derived classes, view classes"
  - "view classes, derived"
ms.assetid: dba42178-7459-4ccc-b025-f3d9b8a4b737
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Derived View Classes Available in MFC
The following table shows MFC's view classes and their relationships to one another. The capabilities of your view class depend on the MFC view class from which it derives.  
  
### View Classes  
  
|Class|Description|  
|-----------|-----------------|  
|[CView](../vs140/cview-class.md)|Base class of all views.|  
|[CCtrlView](../vs140/cctrlview-class.md)|Base class of `CTreeView`, `CListView`, `CEditView`, and `CRichEditView`. These classes let you use document/view architecture with the indicated Windows common controls.|  
|[CEditView](../vs140/ceditview-class.md)|A simple view based on the Windows edit box control. Allows entering and editing text and can be used as the basis for a simple text editor application. See also `CRichEditView`.|  
|[CRichEditView](../vs140/cricheditview-class.md)|A view containing a [CRichEditCtrl](../vs140/cricheditctrl-class.md) object. This class is analogous to `CEditView`, but unlike `CEditView`, `CRichEditView` handles formatted text.|  
|[CListView](../vs140/clistview-class.md)|A view containing a [CListCtrl](../vs140/clistctrl-class.md) object.|  
|[CTreeView](../vs140/ctreeview-class.md)|A view containing a [CTreeCtrl](../vs140/ctreectrl-class.md) object, for views that resemble the Solution Explorer window in Visual C++.|  
|[CScrollView](../vs140/cscrollview-class.md)|Base class of `CFormView`, `CRecordView`, and `CDaoRecordView`. Implements scrolling the view's contents.|  
|[CFormView](../vs140/cformview-class.md)|A form view, a view that contains controls. A forms-based application provides one or more such form interfaces.|  
|[CHtmlView](../vs140/chtmlview-class.md)|A Web browser view with which the application's user can browse sites on the World Wide Web, as well as folders in the local file system and on a network. The Web browser view can also work as an Active document container.|  
|[CRecordView](../vs140/crecordview-class.md)|A form view that displays ODBC database records in controls. If you select ODBC support in your project, the view's base class is `CRecordView`. The view is connected to a `CRowset` object.|  
|[CDaoRecordView](../vs140/cdaorecordview-class.md)|A form view that displays DAO database records in controls. If you select DAO support in your project, the view's base class is `CDaoRecordView`. The view is connected to a `CDaoRecordset` object.|  
|[COleDBRecordView](../vs140/coledbrecordview-class.md)|A form view that displays OLE DB records in controls. If you select OLE DB support in your project, the view's base class is `COleDBRecordView`. The view is connected to a `CRowset` object.|  
  
> [!NOTE]
>  As of MFC version 4.0, `CEditView` is derived from `CCtrlView`.  
  
 To use these classes in your application, derive the application's view classes from them. For related information, see [Scrolling and Scaling Views](../vs140/scrolling-and-scaling-views.md). For more information on the database classes, see [Overview: Database Programming](../vs140/data-access-programming--mfc-atl-.md).  
  
## See Also  
 [Using Views](../vs140/using-views.md)