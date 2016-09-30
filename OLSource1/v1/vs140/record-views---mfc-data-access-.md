---
title: "Record Views  (MFC Data Access)"
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
  - "DAO [C++], record views"
  - "MFC [C++], record views"
  - "ODBC recordsets [C++], record views"
  - "databases [C++], record views"
  - "record views [C++]"
  - "forms [C++], data access tasks"
ms.assetid: 562122d9-01d8-4284-acf6-ea109ab0408d
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Record Views  (MFC Data Access)
This section applies only to the MFC ODBC and DAO classes. For information about OLE DB record views, see [COleDBRecordView](../vs140/coledbrecordview-class.md) and [Using OLE DB Record Views](../vs140/using-ole-db-record-views.md).  
  
 To support form-based data-access applications, the class library provides class [CRecordView](../vs140/crecordview-class.md) and class [CDaoRecordView](../vs140/cdaorecordview-class.md). A record view is a form view object whose controls are mapped directly to the field data members of a [recordset](../vs140/recordset--odbc-.md) object (and indirectly to the corresponding columns in a query result or table on the data source). Like their base class [CFormView](../vs140/cformview-class.md), <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> are based on a dialog template resource.  
  
## Form Uses  
 Forms are useful for a variety of data-access tasks:  
  
-   Entering data  
  
-   Performing read-only examination of data  
  
-   Updating data  
  
## Further Reading About Record Views  
 The material in topics applies to both the ODBC-based and the DAO-based classes. Use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> for ODBC and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> for DAO.  
  
 Topics include:  
  
-   [Features of Record View Classes](../vs140/features-of-record-view-classes---mfc-data-access-.md)  
  
-   [Data Exchange for Record Views](../vs140/data-exchange-for-record-views----mfc-data-access-.md)  
  
-   [Your Role in Working with a Record View](../vs140/your-role-in-working-with-a-record-view---mfc-data-access-.md)  
  
-   [Designing and Creating a Record View](../vs140/designing-and-creating-a-record-view---mfc-data-access-.md)  
  
-   [Using a Record View](../vs140/using-a-record-view---mfc-data-access-.md)  
  
## See Also  
 [Data Access Programming (MFC/ATL)](../vs140/data-access-programming--mfc-atl-.md)   
 [ODBC Driver List](../vs140/odbc-driver-list.md)