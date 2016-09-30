---
title: "CRecordset::DoBulkFieldExchange"
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
  - "CRecordset.DoBulkFieldExchange"
  - "CRecordset::DoBulkFieldExchange"
  - "DoBulkFieldExchange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bulk row fetching, bulk RFX"
  - "bulk record field exchange"
  - "DoBulkFieldExchange method"
ms.assetid: bdd9b9bd-aa94-4a22-b733-e44cc7efa9f9
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::DoBulkFieldExchange
Called to exchange bulk rows of data from the data source to the recordset. Implements bulk record field exchange (Bulk RFX).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a [CFieldExchange](../vs140/cfieldexchange-class.md) object. The framework will already have set up this object to specify a context for the field exchange operation.  
  
## Remarks  
 When bulk row fetching is implemented, the framework calls this member function to automatically transfer data from the data source to your recordset object. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> also binds your parameter data members, if any, to parameter placeholders in the SQL statement string for the recordset's selection.  
  
 If bulk row fetching is not implemented, the framework calls [DoFieldExchange](../vs140/crecordset--dofieldexchange.md). To implement bulk row fetching, you must specify the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> option of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter in the [Open](../vs140/crecordset--open.md) member function.  
  
> [!NOTE]
>  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is available only if you are using a class derived from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. If you have created a recordset object directly from <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, you must call the [GetFieldValue](../vs140/crecordset--getfieldvalue.md) member function to retrieve data.  
  
 Bulk record field exchange (Bulk RFX) is similar to record field exchange (RFX). Data is automatically transferred from the data source to the recordset object. However, you cannot call <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, **Edit**, **Delete**, or **Update** to transfer changes back to the data source. Class <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> currently does not provide a mechanism for updating bulk rows of data; however, you can write your own functions by using the ODBC API function **SQLSetPos**.  
  
 Note that ClassWizard does not support bulk record field exchange; therefore, you must override <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> manually by writing calls to the Bulk RFX functions. For more information about these functions, see the topic [Record Field Exchange Functions](../vs140/record-field-exchange-functions.md).  
  
 For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md). For related information, see the article [Record Field Exchange (RFX)](../vs140/record-field-exchange--rfx-.md).  
  
## Exceptions  
 This method can throw exceptions of type **CDBException\***.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::m_nFields](../vs140/crecordset--m_nfields.md)   
 [CRecordset::m_nParams](../vs140/crecordset--m_nparams.md)   
 [CRecordset::DoFieldExchange](../vs140/crecordset--dofieldexchange.md)   
 [CRecordset::GetFieldValue](../vs140/crecordset--getfieldvalue.md)   
 [CFieldExchange Class](../vs140/cfieldexchange-class.md)   
 [Record Field Exchange Functions](../vs140/record-field-exchange-functions.md)