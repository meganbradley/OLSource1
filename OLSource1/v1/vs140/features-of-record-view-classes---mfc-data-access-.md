---
title: "Features of Record View Classes  (MFC Data Access)"
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
  - "record views, classes"
  - "record view classes"
ms.assetid: e7b2820f-09c4-483f-83c0-317e8be42bdf
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Features of Record View Classes  (MFC Data Access)
You can do form-based data-access programming with class [CFormView](../vs140/cformview-class.md), but [CRecordView](../vs140/crecordview-class.md) and [CDaoRecordView](../vs140/cdaorecordview-class.md) are generally better classes to derive from. In addition to their `CFormView` features, `CRecordView` and `CDaoRecordView`:  
  
-   Provide dialog data exchange (DDX) between the form controls and the associated recordset object.  
  
-   Handle Move First, Move Next, Move Previous, and Move Last commands for navigating through the records in the associated recordset object.  
  
-   Update changes to the current record when the user moves to another record.  
  
 For more information about navigation, see [Record Views: Supporting Navigation in a Record View](../vs140/supporting-navigation-in-a-record-view---mfc-data-access-.md).  
  
## See Also  
 [Record Views  (MFC Data Access)](../vs140/record-views---mfc-data-access-.md)   
 [ODBC Driver List](../vs140/odbc-driver-list.md)