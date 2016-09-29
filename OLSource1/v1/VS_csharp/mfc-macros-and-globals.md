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
  
 The MFC library and the Active Template Library (ATL) share string conversion macros. For more information, see [String Conversion Macros](../VS_csharp/string-conversion-macros.md) in the ATL documentation.  
  
 The MFC macros and globals offer functionality in the following categories.  
  
## General MFC  
  
-   [Data types](../VS_csharp/data-types--mfc-.md)  
  
-   [Type casting of MFC class objects](../VS_csharp/type-casting-of-mfc-class-objects.md)  
  
-   [Run-time object model services](../VS_csharp/run-time-object-model-services.md)  
  
-   [Diagnostic services](../VS_csharp/diagnostic-services.md)  
  
-   [Exception processing](../VS_csharp/exception-processing.md)  
  
-   [CString formatting and message-box display](../VS_csharp/cstring-formatting-and-message-box-display.md)  
  
-   [Message maps](../VS_csharp/message-map-macros--mfc-.md)  
  
-   [Application information and management](../VS_csharp/application-information-and-management.md)  
  
-   [Standard command and window IDs](../VS_csharp/standard-command-and-window-ids.md)  
  
-   [Collection class helpers](../VS_csharp/collection-class-helpers.md)  
  
-   [Gray and dithered bitmap functions](../VS_csharp/gray-and-dithered-bitmap-functions.md)  
  
-   [Standard dialog data exchange (DDX) routines](../VS_csharp/standard-dialog-data-exchange-routines.md)  
  
-   [Standard dialog data validation (DDV) routines](../VS_csharp/standard-dialog-data-validation-routines.md)  
  
-   [AFX Messages](../VS_csharp/afx-messages.md)  
  
-   [Toolbar Control Styles](../VS_csharp/toolbar-control-styles.md)  
  
-   [CMFCImagePaintArea::IMAGE_EDIT_MODE Enumeration](../VS_csharp/cmfcimagepaintarea--image_edit_mode-enumeration.md)  
  
## Database  
  
-   [Record Field Exchange (RFX) functions](../VS_csharp/record-field-exchange-functions.md) and [Bulk Record Field Exchange (bulk RFX) functions](../VS_csharp/record-field-exchange-functions.md) for the MFC ODBC classes  
  
-   [Record field exchange (DFX) functions](../VS_csharp/record-field-exchange-functions.md) for the MFC DAO classes  
  
-   [Dialog data exchange (DDX) functions for CRecordView and CDaoRecordView](../VS_csharp/dialog-data-exchange-functions-for-crecordview-and-cdaorecordview.md) (MFC ODBC and DAO classes)  
  
-   [Dialog data exchange (DDX) functions for OLE controls](../VS_csharp/dialog-data-exchange-functions-for-ole-controls.md)  
  
-   [Macros and globals to aid in calling Open Database Connectivity (ODBC) API functions directly](../VS_csharp/database-macros-and-globals.md)  
  
-   [DAO database engine initialization and termination](../VS_csharp/dao-database-engine-initialization-and-termination.md)  
  
## Internet  
  
-   [Internet URL parsing globals](../VS_csharp/internet-url-parsing-globals.md)  
  
## DHTML / DHTML Event Maps  
  
-   [DHTML dialog data exchange (DDX) helper macros](../VS_csharp/ddx_dhtml-helper-macros.md)  
  
-   [DHTML event maps](../VS_csharp/dhtml-event-maps.md)  
  
## OLE  
  
-   [OLE initialization](../VS_csharp/ole-initialization.md)  
  
-   [Application control](../VS_csharp/application-control.md)  
  
-   [Dispatch maps](../VS_csharp/dispatch-maps.md)  
  
 In addition, MFC provides a function called [AfxEnableControlContainer](../VS_csharp/afxenablecontrolcontainer.md) that enables any OLE container developed with MFC 4.0 to fully support embedded OLE controls.  
  
## OLE Controls  
  
-   [Variant parameter type constants](../VS_csharp/variant-parameter-type-constants.md)  
  
-   [Type library access](../VS_csharp/type-library-access.md)  
  
-   [Property pages](../VS_csharp/property-pages--mfc-.md)  
  
-   [Event maps](../VS_csharp/event-maps.md)  
  
-   [Event sink maps](../VS_csharp/event-sink-maps.md)  
  
-   [Connection maps](../VS_csharp/connection-maps.md)  
  
-   [Registering OLE controls](../VS_csharp/registering-ole-controls.md)  
  
-   [Class factories and licensing](../VS_csharp/class-factories-and-licensing.md)  
  
-   [Persistence of OLE controls](../VS_csharp/persistence-of-ole-controls.md)  
  
 The first part of this section briefly discusses each of the previous categories and lists the globals and macros in the category, together with brief descriptions of functionality. Following this are descriptions of the global functions, global variables, and macros in the MFC library.  
  
> [!NOTE]
>  Many global functions start with the prefix "Afx", but some, for example, the dialog data exchange (DDX) functions and many of the database functions, do not follow this convention. All global variables start with "afx" as a prefix. Macros do not start with any particular prefix, but they are written in uppercase letters.  
  
## See Also  
 [Class Overview](../VS_csharp/class-library-overview.md)