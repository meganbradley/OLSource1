---
title: "CRowset::Insert"
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
  - "ATL.CRowset<TAccessor>.Insert"
  - "CRowset.Insert"
  - "CRowset<TAccessor>.Insert"
  - "CRowset<TAccessor>::Insert"
  - "ATL::CRowset<TAccessor>::Insert"
  - "ATL.CRowset.Insert"
  - "CRowset::Insert"
  - "ATL::CRowset::Insert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Insert method"
ms.assetid: 6a64a1c3-10ac-4296-8685-0fd6fe63a13b
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRowset::Insert
Creates and initializes a new row using data from the accessor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The number of the accessor to use for inserting the data.  
  
 *bGetHRow*  
 [in] Indicates whether the handle for the inserted row is retrieved.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method requires the optional interface <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, which might not be supported on all providers; if this is the case, the method returns **E_NOINTERFACE**. You must also set **DBPROP_IRowsetChange** to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> before calling **Open** on the table or command containing the rowset.  
  
 Insert might fail if one or more columns is not writable. Modify your cursor map to correct this.  
  
## Example  
 The following example shows how to access a data source through a rowset and then insert a string using a table in that rowset.  
  
 First, create a table class by inserting a New ATL Object into your project. For example, right-click the project in the Workspace pane and select **New ATL Object**. From the **Data Access** category, select **Consumer**. Create a consumer object of type **Table**. (Selecting **Table** creates a rowset directly from the table; selecting **Command** creates a rowset through a SQL command.) Select a data source, specifying a table through which to access that data source. If you call your consumer object **CCustomerTable**, you would then implement your insertion code as follows:  
  
 [!code[NVC_OLEDB_Consumer#10](../vs140/codesnippet/CPP/crowset--insert_1.cpp)]  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CRowset Class](../vs140/crowset-class.md)