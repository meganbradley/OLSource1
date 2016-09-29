---
title: "CColumnAccessor Class"
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
  - "CColumnAccessor"
  - "ATL::CColumnAccessor"
  - "ATL.CColumnAccessor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CColumnAccessor class"
ms.assetid: 6ce1e67f-6a20-490d-9326-c168b43eee7e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CColumnAccessor Class
Generates injected consumer code.  
  
## Syntax  
  
```  
class CColumnAccessor : public CAccessorBase  
```  
  
## Remarks  
 In the injected code, every column is bound as a separate accessor. You should be aware that this class is used in the injected code (for example, you might encounter it when debugging), but you typically never have to use it or its methods directly.  
  
 `CColumnAccessor` implements the following stub methods, each of which correspond in functionality to other accessor class methods:  
  
-   `CColumnAccessor` The constructor; instantiates and initializes the `CColumnAccessor` object.  
  
-   `CreateAccessor` Allocates memory for the column binding structures and initializes the column data members.  
  
-   **BindColumns** Binds columns to accessors.  
  
-   **SetParameterBuffer** Allocates buffers for parameters.  
  
-   `AddParameter` Adds a parameter entry to the parameter entry structures.  
  
-   **HasOutputColumns** Determines whether the accessor has output columns  
  
-   **HasParameters** Determines whether the accessor has parameters.  
  
-   `BindParameters` Binds the created parameters to columns.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [OLE DB Consumer Templates](../VS_csharp/ole-db-consumer-templates--c---.md)   
 [Consumer Architecture Chart](../VS_csharp/ole-db-consumer-templates-reference.md)