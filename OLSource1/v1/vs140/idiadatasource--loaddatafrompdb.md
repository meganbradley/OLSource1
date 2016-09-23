---
title: "IDiaDataSource::loadDataFromPdb"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - IDiaDataSource::loadDataFromPdb method
ms.assetid: 02159073-8144-47f8-a0b0-aa0edcb92b5b
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IDiaDataSource::loadDataFromPdb
Opens and prepares a program database (.pdb) file as a debug data source.  
  
## Syntax  
  
```cpp#  
HRESULT loadDataFromPdb (  
   LPCOLESTR pdbPath  
);  
```  
  
#### Parameters  
 pdbPath  
 [in] The path to the .pdb file.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code. The following table shows the possible return values for this method.  
  
|Value|Description|  
|-----------|-----------------|  
|E_PDB_NOT_FOUND|Failed to open the file, or determined that the file has an invalid format.|  
|E_PDB_FORMAT|Attempted to access a file with an obsolete format.|  
|E_INVALIDARG|Invalid parameter.|  
|E_UNEXPECTED|Data source has already been prepared.|  
  
## Remarks  
 This method loads the debug data directly from a .pdb file.  
  
 To validate the .pdb file against specific criteria, use the [IDiaDataSource::loadAndValidateDataFromPdb](../vs140/idiadatasource--loadandvalidatedatafrompdb.md) method.  
  
 To gain access to the data load process (through a callback mechanism), use the [IDiaDataSource::loadDataForExe](../vs140/idiadatasource--loaddataforexe.md) method.  
  
 To load a .pdb file directly from memory, use the [IDiaDataSource::loadDataFromIStream](../vs140/idiadatasource--loaddatafromistream.md) method.  
  
## Example  
  
```cpp#  
HRESULT hr = pSource->loadDataFromPdb( L"myprog.pdb" );  
if (FAILED(hr))  
{  
    // report error  
}  
```  
  
## See Also  
 [IDiaDataSource](../vs140/idiadatasource.md)   
 [IDiaDataSource::loadDataForExe](../vs140/idiadatasource--loaddataforexe.md)   
 [IDiaDataSource::loadAndValidateDataFromPdb](../vs140/idiadatasource--loadandvalidatedatafrompdb.md)   
 [IDiaDataSource::loadDataFromIStream](../vs140/idiadatasource--loaddatafromistream.md)