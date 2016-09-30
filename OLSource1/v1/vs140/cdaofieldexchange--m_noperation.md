---
title: "CDaoFieldExchange::m_nOperation"
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
  - "CDaoFieldExchange::m_nOperation"
  - "m_nOperation"
  - "CDaoFieldExchange.m_nOperation"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddToSelectList DFX operation"
  - "MaxDFXOperation DFX operation"
  - "BindParam DFX operation"
  - "DFX operations"
  - "MarkForEdit DFX operation"
  - "field exchange"
  - "MarkForAddNew DFX operation"
  - "COleDateTime class, and DFX PSEUDO NULL value"
  - "PSEUDO NULL values in DFX operations"
  - "m_nOperation"
  - "DumpField DFX operation"
  - "LoadField DFX operation"
  - "field exchange, DFX operations"
  - "GetFieldIndex DFX operation"
  - "SetFieldNull DFX operation"
  - "FreeCache DFX operation"
  - "SetDirtyField DFX operation"
  - "StoreField DFX operation"
  - "Fixup DFX operation"
  - "BindField DFX operation"
  - "AddToParameterList DFX operation"
  - "AllocCache DFX operation"
  - "COleCurrency class, DFX PSEUDO NULL value"
ms.assetid: 7dec3198-00ad-4e26-9bd5-ac8ba5c8a90c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoFieldExchange::m_nOperation
Identifies the operation to be performed on the [CDaoRecordset](../vs140/cdaorecordset-class.md) object associated with the field exchange object.  
  
## Remarks  
 The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> object supplies the context for a number of different DFX operations on the recordset.  
  
> [!NOTE]
>  The **PSEUDO NULL** value described under the MarkForAddNew and SetFieldNull operations below is a value used to mark fields Null. The DAO record field exchange mechanism (DFX) uses this value to determine which fields have been explicitly marked Null. **PSEUDO NULL** is not required for [COleDateTime](../vs140/coledatetime-class.md) and [COleCurrency](../vs140/colecurrency-class.md) fields.  
  
 Possible values of **m_nOperation** are:  
  
|Operation|Description|  
|---------------|-----------------|  
|**AddToParameterList**|Builds the **PARAMETERS** clause of the SQL statement.|  
|**AddToSelectList**|Builds the **SELECT** clause of the SQL statement.|  
|**BindField**|Binds a field in the database to a memory location in your application.|  
|**BindParam**|Sets parameter values for the recordset's query.|  
|**Fixup**|Sets the Null status for a field.|  
|**AllocCache**|Allocates the cache used to check for "dirty" fields in the recordset.|  
|**StoreField**|Saves the current record to the cache.|  
|**LoadField**|Restores the cached data member variables in the recordset.|  
|**FreeCache**|Frees the cache used to check for "dirty" fields in the recordset.|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Sets a field's status to Null and value to **PSEUDO NULL**.|  
|**MarkForAddNew**|Marks fields "dirty" if not **PSEUDO NULL**.|  
|**MarkForEdit**|Marks fields "dirty" if they do not match the cache.|  
|**SetDirtyField**|Sets field values marked as "dirty."|  
|**DumpField**|Dumps a field's contents (debug only).|  
|**MaxDFXOperation**|Used for input checking.|  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoFieldExchange Class](../vs140/cdaofieldexchange-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoFieldExchange::IsValidOperation](../vs140/cdaofieldexchange--isvalidoperation.md)   
 [CDaoFieldExchange::m_prs](../vs140/cdaofieldexchange--m_prs.md)   
 [CDaoRecordset::DoFieldExchange](../vs140/cdaorecordset--dofieldexchange.md)