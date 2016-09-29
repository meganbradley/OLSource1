---
title: "CDataSource::OpenFromFileName"
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
  - "CDataSource::OpenFromFileName"
  - "ATL::CDataSource::OpenFromFileName"
  - "OpenFromFileName"
  - "CDataSource.OpenFromFileName"
  - "ATL.CDataSource.OpenFromFileName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OpenFromFileName method"
ms.assetid: c4226de6-59da-4368-9c15-c5afab86f68b
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataSource::OpenFromFileName
Opens a data source from a file specified by the user-supplied file name.  
  
## Syntax  
  
```  
  
      HRESULT OpenFromFileName(   
   LPCOLESTR szFileName    
) throw( );  
```  
  
#### Parameters  
 `szFileName`  
 [in] The name of a file, usually a data source connection (.UDL) file.  
  
 For more information about data link files (.udl files), see [Data Link API Overview](https://msdn.microsoft.com/en-us/library/ms718102.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 A standard `HRESULT`.  
  
## Remarks  
 This method opens a data source object using the service components in oledb32.dll; this DLL contains the implementation of Service Components features such as Resource Pooling, Automatic Transaction Enlistment, and so on. For more information, see "OLE DB Services" in the OLE DB Programmer's Reference at [http://msdn.microsoft.com/library/default.asp?url=/library/oledb/htm/oledbole_db_services.asp?frame=true](http://msdn.microsoft.com/library/default.asp?url=/library/oledb/htm/oledbole_db_services.asp?frame=true).  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CDataSource Class](../vs140/cdatasource-class.md)