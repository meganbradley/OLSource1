---
title: "Data Access: ADO and RDO"
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
  - "data controls [C++]"
  - "bound controls [C++], ADO"
  - "data binding [C++], RDO"
  - "data-bound controls [C++], ADO"
  - "data binding [C++], ADO"
  - "data access [C++], RDO data controls"
  - "data-bound controls [C++], RDO"
  - "bound controls [C++], RDO"
  - "controls [C++], data binding"
ms.assetid: 92da8f1e-144b-4605-ac0a-43c25bdc14a7
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Data Access: ADO and RDO
The following table shows two underlying technologies that support data-source or data-bound controls.  
  
 **ADO**  
 ADO is a COM wrapper of OLE DB that facilitates writing data access applications (consumers). OLE DB is a COM-based universal data access technology, allowing you to use any data source, not just indexed, sequential access methods (ISAM) and SQL-based databases.  
  
 OLE DB providers can access data from a variety of data sources and is not limited to SQL queries to retrieve data but rather can use queries as defined in the provider.  
  
 **RDO**  
 RDO is the COM wrapper of ODBC. ODBC, a C-based API, allows general-purpose (heterogeneous) data access. However, RDO relies on SQL as the command language to access data.  
  
 You might consider using the ADO-based data-access controls rather than the RDO data-access controls.  
  
 The following table shows the main differences between ADO and RDO data controls.  
  
 **Data-bound controls**  
 RDO data-bound controls use the **ICursor** interfaces; ADO controls use the OLE DB <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> interface. In both cases, the interfaces used by the controls return a rowset.  
  
 The RDO-based data-bound controls were designed to work best with Visual Basic. As such, some functionality of RDO data-bound controls, most notably in formatting, is not available in Visual C++ applications. This problem is not present in the ADO databinding controls.  
  
 **Data controls**  
 ADO data controls implement the **IDataSource** interface and RDO data controls implement the **IVBDSC** interface. You can call an **IDataSource** method to receive an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface pointer. Similarly, you can call an IVBDSC method to get an **ICursor** interface pointer.  
  
## See Also  
 [Databinding with ActiveX Controls in Visual C++](../vs140/databinding-with-activex-controls-in-visual-c--.md)