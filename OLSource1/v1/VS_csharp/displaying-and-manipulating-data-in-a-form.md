---
title: "Displaying and Manipulating Data in a Form"
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
  - "forms [C++], displaying data"
  - "displaying data [C++], forms"
  - "ODBC [C++], forms"
  - "record views [C++], displaying data"
  - "data [MFC]"
  - "data [MFC], displaying in a form"
ms.assetid: c56185c4-12cb-40b1-b499-02b29ea83e3a
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Displaying and Manipulating Data in a Form
Many data-access applications select data and display it in fields in a form. The database class [CRecordView](../VS_csharp/crecordview-class.md) gives you a [CFormView](../VS_csharp/cformview-class.md) object directly connected to a recordset object. The record view uses [dialog data exchange (DDX)](../VS_csharp/dialog-data-exchange-and-validation.md) to move the values of the fields of the current record from the recordset to the controls on the form and to move updated information back to the recordset. The recordset, in turn, uses record field exchange (RFX) to move data between its field data members and the corresponding columns in a table on the data source.  
  
 You can use the MFC Application Wizard or **Add Class** (as described in [Adding an MFC ODBC Consumer](../VS_csharp/adding-an-mfc-odbc-consumer.md)) to create the view class and its associated recordset class in conjunction.  
  
 The record view and its recordset are destroyed when you close the document. For more information about record views, see [Record Views](../VS_csharp/record-views---mfc-data-access-.md). For more information about RFX, see [Record Field Exchange (RFX)](../VS_csharp/record-field-exchange--rfx-.md).  
  
## See Also  
 [ODBC and MFC](../VS_csharp/odbc-and-mfc.md)