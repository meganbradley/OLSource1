---
title: "IDiaDataSource::openSession"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaDataSource::openSession method"
ms.assetid: a3319ed0-3979-483b-9852-c0af96852c48
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaDataSource::openSession
Opens a session for querying symbols.  
  
## Syntax  
  
```cpp#  
HRESULT openSession (   
   IDiaSession** ppSession  
);  
```  
  
#### Parameters  
 ppSession  
 [out] Returns an [IDiaSession](../vs140/idiasession.md) object representing the open session.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code. The following table shows the possible return values for this method.  
  
|Value|Description|  
|-----------|-----------------|  
|E_UNEXPECTED|The [IDiaDataSource](../vs140/idiadatasource.md) object has not previously been initialized with a source of symbols.|  
|E_INVALIDARG|Invalid `ppSession` parameter.|  
|E_OUTOFMEMORY|Insufficient memory to open the session.|  
  
## Remarks  
 This method opens an [IDiaSession](../vs140/idiasession.md) object for a data source.  
  
 `IDiaSession` objects implement queries into the data source. A session manages one address space for each set of debug symbols. If the .exe or .dll file described by the data source symbols is active in multiple address ranges (for example, because multiple processes have it loaded), then one session for each address range should be used.  
  
## Example  
  
```cpp#  
IDiaSession* pSession;  
HRESULT hr = pSource->openSession( &pSession );  
if (FAILED(hr))  
{  
   // report error  
}  
```  
  
## See Also  
 [IDiaDataSource](../vs140/idiadatasource.md)   
 [Overview](../vs140/overview--debug-interface-access-sdk-.md)   
 [IDiaSession](../vs140/idiasession.md)   
 [Querying the .Pdb File](../vs140/querying-the-.pdb-file.md)