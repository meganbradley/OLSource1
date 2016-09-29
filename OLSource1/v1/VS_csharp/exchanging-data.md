---
title: "Exchanging Data"
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
  - "property sheets, data exchange"
  - "exchanging data with property sheets"
  - "DDX (dialog data exchange), property sheets"
ms.assetid: 689f02d0-51a9-455b-8ffb-5b44f0aefa28
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Exchanging Data
As with most dialog boxes, the exchange of data between the property sheet and the application is one of the most important functions of the property sheet. This article describes how to accomplish this task.  
  
 Exchanging data with a property sheet is actually a matter of exchanging data with the individual property pages of the property sheet. The procedure for exchanging data with a property page is the same as for exchanging data with a dialog box, since a [CPropertyPage](../VS_csharp/cpropertypage-class.md) object is just a specialized [CDialog](../VS_csharp/cdialog-class.md) object. The procedure takes advantage of the framework's dialog data exchange (DDX) facility, which exchanges data between controls in a dialog box and member variables of the dialog box object.  
  
 The important difference between exchanging data with a property sheet and with a normal dialog box is that the property sheet has multiple pages, so you must exchange data with all the pages in the property sheet. For more information on DDX, see [Dialog Data Exchange and Validation](../VS_csharp/dialog-data-exchange-and-validation.md).  
  
 The following example illustrates exchanging data between a view and two pages of a property sheet:  
  
 [!code[NVC_MFCDocView#4](../VS_csharp/codesnippet/CPP/exchanging-data_1.cpp)]  
  
## See Also  
 [Property Sheets](../VS_csharp/property-sheets--mfc-.md)