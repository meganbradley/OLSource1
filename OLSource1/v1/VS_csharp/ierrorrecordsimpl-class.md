---
title: "IErrorRecordsImpl Class"
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
  - "ATL::IErrorRecordsImpl"
  - "ATL.IErrorRecordsImpl"
  - "IErrorRecordsImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IErrorRecordsImpl class"
ms.assetid: dea8e938-c5d8-45ab-86de-eb8fbf534ffb
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IErrorRecordsImpl Class
Implements the OLE DB [IErrorRecords](https://msdn.microsoft.com/en-us/library/ms718112.aspx) interface, adding records to and retrieving records from a data member ([m_rgErrors](../VS_csharp/ierrorrecordsimpl--m_rgerrors.md)) of type **CAtlArray<**`RecordClass`**>**.  
  
## Syntax  
  
```  
template <  
   class T,   
   class RecordClass = ATLERRORINFO  
>  
class IErrorRecordsImpl : public IErrorRecords  
```  
  
#### Parameters  
 `T`  
 A class derived from `IErrorRecordsImpl`.  
  
 `RecordClass`  
 A class that represents an OLE DB error object.  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[GetErrorDescriptionString](../VS_csharp/ierrorrecordsimpl--geterrordescriptionstring.md)|Gets the error description string from an error record.|  
|[GetErrorGUID](../VS_csharp/ierrorrecordsimpl--geterrorguid.md)|Gets the error GUID from an error record.|  
|[GetErrorHelpContext](../VS_csharp/ierrorrecordsimpl--geterrorhelpcontext.md)|Gets the help context ID from an error record.|  
|[GetErrorHelpFile](../VS_csharp/ierrorrecordsimpl--geterrorhelpfile.md)|Gets the full pathname of the help file from an error record.|  
|[GetErrorSource](../VS_csharp/ierrorrecordsimpl--geterrorsource.md)|Gets the error source code from an error record.|  
  
### Interface Methods  
  
|||  
|-|-|  
|[AddErrorRecord](../VS_csharp/ierrorrecordsimpl--adderrorrecord.md)|Adds a record to the OLE DB error object.|  
|[GetBasicErrorInfo](../VS_csharp/cdberrorinfo--getbasicerrorinfo.md)|Returns basic information about the error, such as the return code and provider-specific error number.|  
|[GetCustomErrorObject](../VS_csharp/cdberrorinfo--getcustomerrorobject.md)|Returns a pointer to an interface on a custom error object.|  
|[GetErrorInfo](../VS_csharp/cdberrorinfo--geterrorinfo.md)|Returns an [IErrorInfo](https://msdn.microsoft.com/en-us/library/ms718112.aspx) interface pointer on the specified record.|  
|[GetErrorParameters](../VS_csharp/cdberrorinfo--geterrorparameters.md)|Returns the error parameters.|  
|[GetRecordCount](../Topic/CDaoRecordset::GetRecordCount.md)|Returns the number of records in the OLE DB record object.|  
  
### Data Members  
  
|||  
|-|-|  
|[m_rgErrors](../VS_csharp/ierrorrecordsimpl--m_rgerrors.md)|An array of error records.|  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [OLE DB Provider Templates](../VS_csharp/ole-db-provider-templates--c---.md)   
 [OLE DB Provider Template Architecture](../VS_csharp/ole-db-provider-template-architecture.md)