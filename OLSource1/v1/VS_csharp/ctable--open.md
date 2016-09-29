---
title: "CTable::Open"
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
  - "ATL.CTable.Open"
  - "ATL::CTable::Open"
  - "CTable::Open"
  - "CTable.Open"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Open method"
ms.assetid: 5d006d95-74d7-4e2b-b243-a33bc53b5455
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTable::Open
Opens the table.  
  
## Syntax  
  
```  
  
      HRESULT Open(  
   const CSession& session,  
   LPCWSTR wszTableName,  
   DBPROPSET* pPropSet = NULL,  
   ULONG ulPropSets = 0  
) throw ( );  
HRESULT Open(  
   const CSession& session,  
   LPCSTR szTableName,  
   DBPROPSET* pPropSet = NULL,  
   ULONG ulPropSets = 0  
) throw ( );  
HRESULT Open(  
   const CSession& session,  
   DBID& dbid,  
   DBPROPSET* pPropSet = NULL,  
   ULONG ulPropSets = 0  
) throw ( );  
```  
  
#### Parameters  
 `session`  
 [in] The session for which the table is opened.  
  
 *wszTableName*  
 [in] The name of the table to open, passed as a Unicode string.  
  
 *szTableName*  
 [in] The name of the table to open, passed as an ANSI string.  
  
 *dbid*  
 [in] The **DBID** of the table to open.  
  
 *pPropSet*  
 [in] A pointer to an array of [DBPROPSET](https://msdn.microsoft.com/en-us/library/ms714367.aspx) structures containing properties and values to be set. See [Property Sets and Property Groups](https://msdn.microsoft.com/en-us/library/ms713696.aspx) in the *OLE DB Programmer's Reference* in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)]. The default value of NULL specifies no properties.  
  
 `ulPropSets`  
 [in] The number of [DBPROPSET](https://msdn.microsoft.com/en-us/library/ms714367.aspx) structures passed in the *pPropSet* argument.  
  
## Return Value  
 A standard `HRESULT`.  
  
## Remarks  
 For more details, see [IOpenRowset::OpenRowset](https://msdn.microsoft.com/en-us/library/ms716724.aspx) in the *OLE DB Programmer's Reference*.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CTable Class](../VS_csharp/ctable-class.md)