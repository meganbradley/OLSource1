---
title: "CManualAccessor::AddParameterEntry"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CManualAccessor::AddParameterEntry
  - ATL.CManualAccessor.AddParameterEntry
  - CManualAccessor.AddParameterEntry
  - AddParameterEntry
  - ATL::CManualAccessor::AddParameterEntry
dev_langs: 
  - C++
helpviewer_keywords: 
  - AddParameterEntry method
ms.assetid: 9048b164-052b-41b1-a861-227fc529e0b5
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CManualAccessor::AddParameterEntry
Adds a parameter entry to the parameter entry structures.  
  
## Syntax  
  
```  
  
      void AddParameterEntry(  
   DBORDINAL nOrdinal,  
   DBTYPE wType,  
   DBLENGTH nColumnSize,  
   void* pData,  
   void* pLength = NULL,  
   void* pStatus = NULL,  
   DBPARAMIO eParamIO = DBPARAMIO_INPUT   
) throw ( );  
```  
  
#### Parameters  
 See [DBBINDING](https://msdn.microsoft.com/en-us/library/ms716845.aspx) in the *OLE DB Programmer's Reference*.  
  
 `nOrdinal`  
 [in] Parameter number.  
  
 `wType`  
 [in] Data type.  
  
 `nColumnSize`  
 [in] Column size in bytes.  
  
 `pData`  
 [in] A pointer to the column data stored in the buffer.  
  
 `pLength`  
 [in] A pointer to the field length, if required.  
  
 `pStatus`  
 [in] A pointer to the variable to be bound to the column status, if required.  
  
 *eParamIO*  
 [in] Specifies whether the parameter with which the binding is associated is an input, input/output, or output parameter.  
  
## Remarks  
 To use this function, you must first call [CreateParameterAccessor](../vs140/cmanualaccessor--createparameteraccessor.md).  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CManualAccessor Class](../vs140/cmanualaccessor-class.md)   
 [CManualAccessor::AddBindEntry](../vs140/cmanualaccessor--addbindentry.md)   
 [DBViewer sample](../vs140/visual-c---samples.md)