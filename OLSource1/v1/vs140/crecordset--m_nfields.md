---
title: "CRecordset::m_nFields"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "m_nFields"
  - "CRecordset.m_nFields"
  - "CRecordset::m_nFields"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_nFields"
ms.assetid: ee7088af-bd8a-4984-81d3-897910d492b5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::m_nFields
Contains the number of field data members in the recordset class; that is, the number of columns selected by the recordset from the data source.  
  
## Remarks  
 The constructor for the recordset class must initialize <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> with the correct number. If you have not implemented bulk row fetching, ClassWizard writes this initialization for you when you use it to declare your recordset class. You can also write it manually.  
  
 The framework uses this number to manage interaction between the field data members and the corresponding columns of the current record on the data source.  
  
> [!CAUTION]
>  This number must correspond to the number of "output columns" registered in <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> after a call to [SetFieldType](../vs140/cfieldexchange--setfieldtype.md) with the parameter **CFieldExchange::outputColumn**.  
  
 You can bind columns dynamically, as explained in the article "Recordset: Dynamically Binding Data Columns." If you do so, you must increase the count in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to reflect the number of RFX or Bulk RFX function calls in your <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> member function for the dynamically bound columns.  
  
 For more information, see the articles [Recordset: Dynamically Binding Data Columns (ODBC)](../vs140/recordset--dynamically-binding-data-columns--odbc-.md) and [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
## Example  
 See the article [Record Field Exchange: Using RFX](../vs140/record-field-exchange--using-rfx.md).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::DoFieldExchange](../vs140/crecordset--dofieldexchange.md)   
 [CRecordset::DoBulkFieldExchange](../vs140/crecordset--dobulkfieldexchange.md)   
 [CRecordset::m_nParams](../vs140/crecordset--m_nparams.md)   
 [CFieldExchange::SetFieldType](../vs140/cfieldexchange--setfieldtype.md)