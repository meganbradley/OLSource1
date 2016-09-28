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
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IErrorRecordsImpl Class
Implements the OLE DB [IErrorRecords](https://msdn.microsoft.com/en-us/library/ms718112.aspx) interface, adding records to and retrieving records from a data member ([m_rgErrors](../vs140/ierrorrecordsimpl--m_rgerrors.md)) of type **CAtlArray<**`RecordClass`**>**.  
  
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
|[GetErrorDescriptionString](../vs140/ierrorrecordsimpl--geterrordescriptionstring.md)|Gets the error description string from an error record.|  
|[GetErrorGUID](../vs140/ierrorrecordsimpl--geterrorguid.md)|Gets the error GUID from an error record.|  
|[GetErrorHelpContext](../vs140/ierrorrecordsimpl--geterrorhelpcontext.md)|Gets the help context ID from an error record.|  
|[GetErrorHelpFile](../vs140/ierrorrecordsimpl--geterrorhelpfile.md)|Gets the full pathname of the help file from an error record.|  
|[GetErrorSource](../vs140/ierrorrecordsimpl--geterrorsource.md)|Gets the error source code from an error record.|  
  
### Interface Methods  
  
|||  
|-|-|  
|[AddErrorRecord](../vs140/ierrorrecordsimpl--adderrorrecord.md)|Adds a record to the OLE DB error object.|  
|[GetBasicErrorInfo](../vs140/cdberrorinfo--getbasicerrorinfo.md)|Returns basic information about the error, such as the return code and provider-specific error number.|  
|[GetCustomErrorObject](../vs140/cdberrorinfo--getcustomerrorobject.md)|Returns a pointer to an interface on a custom error object.|  
|[GetErrorInfo](../vs140/cdberrorinfo--geterrorinfo.md)|Returns an [IErrorInfo](https://msdn.microsoft.com/en-us/library/ms718112.aspx) interface pointer on the specified record.|  
|[GetErrorParameters](../vs140/cdberrorinfo--geterrorparameters.md)|Returns the error parameters.|  
|[GetRecordCount](../vs140/cdaorecordset--getrecordcount.md)|Returns the number of records in the OLE DB record object.|  
  
### Data Members  
  
|||  
|-|-|  
|[m_rgErrors](../vs140/ierrorrecordsimpl--m_rgerrors.md)|An array of error records.|  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [OLE DB Provider Templates](../vs140/ole-db-provider-templates--c---.md)   
 [OLE DB Provider Template Architecture](../vs140/ole-db-provider-template-architecture.md)