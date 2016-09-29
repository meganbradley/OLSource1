---
title: "MFC Macros and Globals"
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
  - "vc.mfc.macros"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MFC, global functions and variables"
  - "MFC, macros"
  - "global functions, MFC"
  - "macros, MFC"
  - "global functions"
  - "global variables, MFC"
  - "Afx naming convention"
  - "macros"
ms.assetid: add4e33f-0e62-4d27-be14-896cb8675d22
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MFC Macros and Globals
The Microsoft Foundation Class Library can be divided into two major sections: (1) the MFC classes and (2) macros and globals. If a function or variable is not a member of a class, it is a global function or variable.  
  
 The MFC library and the Active Template Library (ATL) share string conversion macros. For more information, see [String Conversion Macros](../vs140/string-conversion-macros.md) in the ATL documentation.  
  
 The MFC macros and globals offer functionality in the following categories.  
  
## General MFC  
  
-   [Data types](../vs140/data-types--mfc-.md)  
  
-   [Type casting of MFC class objects](../vs140/type-casting-of-mfc-class-objects.md)  
  
-   [Run-time object model services](../vs140/run-time-object-model-services.md)  
  
-   [Diagnostic services](../vs140/diagnostic-services.md)  
  
-   [Exception processing](../vs140/exception-processing.md)  
  
-   [CString formatting and message-box display](../vs140/cstring-formatting-and-message-box-display.md)  
  
-   [Message maps](../vs140/message-map-macros--mfc-.md)  
  
-   [Application information and management](../vs140/application-information-and-management.md)  
  
-   [Standard command and window IDs](../vs140/standard-command-and-window-ids.md)  
  
-   [Collection class helpers](../vs140/collection-class-helpers.md)  
  
-   [Gray and dithered bitmap functions](../vs140/gray-and-dithered-bitmap-functions.md)  
  
-   [Standard dialog data exchange (DDX) routines](../vs140/standard-dialog-data-exchange-routines.md)  
  
-   [Standard dialog data validation (DDV) routines](../vs140/standard-dialog-data-validation-routines.md)  
  
-   [AFX Messages](../vs140/afx-messages.md)  
  
-   [Toolbar Control Styles](../vs140/toolbar-control-styles.md)  
  
-   [CMFCImagePaintArea::IMAGE_EDIT_MODE Enumeration](../vs140/cmfcimagepaintarea--image_edit_mode-enumeration.md)  
  
## Database  
  
-   [Record Field Exchange (RFX) functions](../vs140/record-field-exchange-functions.md) and [Bulk Record Field Exchange (bulk RFX) functions](../vs140/record-field-exchange-functions.md) for the MFC ODBC classes  
  
-   [Record field exchange (DFX) functions](../vs140/record-field-exchange-functions.md) for the MFC DAO classes  
  
-   [Dialog data exchange (DDX) functions for CRecordView and CDaoRecordView](../vs140/dialog-data-exchange-functions-for-crecordview-and-cdaorecordview.md) (MFC ODBC and DAO classes)  
  
-   [Dialog data exchange (DDX) functions for OLE controls](../vs140/dialog-data-exchange-functions-for-ole-controls.md)  
  
-   [Macros and globals to aid in calling Open Database Connectivity (ODBC) API functions directly](../vs140/database-macros-and-globals.md)  
  
-   [DAO database engine initialization and termination](../vs140/dao-database-engine-initialization-and-termination.md)  
  
## Internet  
  
-   [Internet URL parsing globals](../vs140/internet-url-parsing-globals.md)  
  
## DHTML / DHTML Event Maps  
  
-   [DHTML dialog data exchange (DDX) helper macros](../vs140/ddx_dhtml-helper-macros.md)  
  
-   [DHTML event maps](../vs140/dhtml-event-maps.md)  
  
## OLE  
  
-   [OLE initialization](../vs140/ole-initialization.md)  
  
-   [Application control](../vs140/application-control.md)  
  
-   [Dispatch maps](../vs140/dispatch-maps.md)  
  
 In addition, MFC provides a function called [AfxEnableControlContainer](../vs140/afxenablecontrolcontainer.md) that enables any OLE container developed with MFC 4.0 to fully support embedded OLE controls.  
  
## OLE Controls  
  
-   [Variant parameter type constants](../vs140/variant-parameter-type-constants.md)  
  
-   [Type library access](../vs140/type-library-access.md)  
  
-   [Property pages](../vs140/property-pages--mfc-.md)  
  
-   [Event maps](../vs140/event-maps.md)  
  
-   [Event sink maps](../vs140/event-sink-maps.md)  
  
-   [Connection maps](../vs140/connection-maps.md)  
  
-   [Registering OLE controls](../vs140/registering-ole-controls.md)  
  
-   [Class factories and licensing](../vs140/class-factories-and-licensing.md)  
  
-   [Persistence of OLE controls](../vs140/persistence-of-ole-controls.md)  
  
 The first part of this section briefly discusses each of the previous categories and lists the globals and macros in the category, together with brief descriptions of functionality. Following this are descriptions of the global functions, global variables, and macros in the MFC library.  
  
> [!NOTE]
>  Many global functions start with the prefix "Afx", but some, for example, the dialog data exchange (DDX) functions and many of the database functions, do not follow this convention. All global variables start with "afx" as a prefix. Macros do not start with any particular prefix, but they are written in uppercase letters.  
  
## See Also  
 [Class Overview](../vs140/class-library-overview.md)