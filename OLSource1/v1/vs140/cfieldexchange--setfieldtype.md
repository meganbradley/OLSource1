---
title: "CFieldExchange::SetFieldType"
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
  - "CFieldExchange::SetFieldType"
  - "CFieldExchange.SetFieldType"
  - "SetFieldType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetFieldType method"
ms.assetid: 3d9619e4-1ce0-4ca5-a5fe-5cbe0a0b0d19
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFieldExchange::SetFieldType
You need a call to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in your recordset class's [DoFieldExchange](../vs140/crecordset--dofieldexchange.md) or [DoBulkFieldExchange](../vs140/crecordset--dobulkfieldexchange.md) override.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A value of the **enum FieldType**, declared in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, which can be one of the following:  
  
-   **CFieldExchange::outputColumn**  
  
-   **CFieldExchange::inputParam**  
  
-   **CFieldExchange::param**  
  
-   **CFieldExchange::outputParam**  
  
-   **CFieldExchange::inoutParam**  
  
## Remarks  
 For field data members, you must call <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> with a parameter of **CFieldExchange::outputColumn**, followed by calls to the RFX or Bulk RFX functions. If you have not implemented bulk row fetching, then ClassWizard places this <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> call for you in the field map section of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 If you parameterize your recordset class, you must call <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> again, outside any field map section, followed by RFX calls for all the parameter data members. Each type of parameter data member must have its own <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> call. The following table distinguishes the different values you can pass to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to represent the parameter data members of your class:  
  
|SetFieldType parameter value|Type of parameter data member|  
|----------------------------------|-----------------------------------|  
|**CFieldExchange::inputParam**|Input parameter. A value that is passed into the recordset's query or stored procedure.|  
|**CFieldExchange::param**|Same as **CFieldExchange::inputParam**.|  
|**CFieldExchange::outputParam**|Output parameter. A return value of the recordset's stored procedure.|  
|**CFieldExchange::inoutParam**|Input/output parameter. A value that is passed into and returned from the recordset's stored procedure.|  
  
 In general, each group of RFX function calls associated with field data members or parameter data members must be preceded by a call to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter of each <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> call identifies the type of the data members represented by the RFX function calls that follow the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> call.  
  
 For more information about handling output and input/output parameters, see the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> member function [FlushResultSet](../vs140/crecordset--flushresultset.md). For more information about the RFX and Bulk RFX functions, see the topic [Record Field Exchange Functions](../vs140/record-field-exchange-functions.md). For related information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
## Example  
 This example shows several calls to RFX functions with accompanying calls to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. Note that <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is called through the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> pointer to a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.  
  
 [!code[NVC_MFCDatabase#33](../vs140/codesnippet/CPP/cfieldexchange--setfieldtype_1.cpp)]  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CFieldExchange Class](../vs140/cfieldexchange-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::DoFieldExchange](../vs140/crecordset--dofieldexchange.md)   
 [CRecordset::DoBulkFieldExchange](../vs140/crecordset--dobulkfieldexchange.md)   
 [CRecordset::FlushResultSet](../vs140/crecordset--flushresultset.md)   
 [Record Field Exchange Functions](../vs140/record-field-exchange-functions.md)