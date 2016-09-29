---
title: "IDBCreateCommandImpl::CreateCommand"
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
  - "IDBCreateCommandImpl.CreateCommand"
  - "CreateCommand"
  - "IDBCreateCommandImpl::CreateCommand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateCommand method"
ms.assetid: 50ffbf8b-2c07-4bcb-96c5-ffce4519c7f7
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDBCreateCommandImpl::CreateCommand
Creates a new command and returns the requested interface.  
  
## Syntax  
  
```  
  
      STDMETHOD(CreateCommand)(   
   IUnknown * pUnkOuter,   
   REFIID riid,   
   IUnknown ** ppvCommand    
);  
```  
  
#### Parameters  
 See [IDBCreateCommand::CreateCommand](https://msdn.microsoft.com/en-us/library/ms709772.aspx) in the *OLE DB Programmer's Reference*.  
  
 Some parameters correspond to *OLE DB Programmer's Reference* parameters of different names, which are described in **IDBCreateCommand::CreateCommand**:  
  
|OLE DB Template parameters|*OLE DB Programmer's Reference* parameters|  
|--------------------------------|------------------------------------------------|  
|*ppvCommand*|*ppCommand*|  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [IDBCreateCommandImpl Class](../vs140/idbcreatecommandimpl-class.md)