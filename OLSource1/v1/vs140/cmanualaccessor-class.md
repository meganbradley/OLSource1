---
title: "CManualAccessor Class"
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
  - "ATL::CManualAccessor"
  - "ATL.CManualAccessor"
  - "CManualAccessor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CManualAccessor class"
ms.assetid: a0088074-7135-465c-b228-69097a50b8cc
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CManualAccessor Class
Represents an accessor type designed for advanced use.  
  
## Syntax  
  
```  
class CManualAccessor : public CAccessorBase  
```  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[AddBindEntry](../vs140/cmanualaccessor--addbindentry.md)|Adds a bind entry to the output columns.|  
|[AddParameterEntry](../vs140/cmanualaccessor--addparameterentry.md)|Adds a parameter entry to the parameter accessor.|  
|[CreateAccessor](../vs140/cmanualaccessor--createaccessor.md)|Allocates memory for the column bind structures and initializes the column data members.|  
|[CreateParameterAccessor](../vs140/cmanualaccessor--createparameteraccessor.md)|Allocates memory for the parameter bind structures and initializes the parameter data members.|  
  
## Remarks  
 Using `CManualAccessor`, you can specify the parameter and output column binding by run-time function calls.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [DBViewer](../vs140/visual-c---samples.md)   
 [OLE DB Consumer Templates](../vs140/ole-db-consumer-templates--c---.md)   
 [Consumer Architecture Chart](../vs140/ole-db-consumer-templates-reference.md)   
 [CAccessor Class](../vs140/caccessor-class.md)   
 [CDynamicAccessor Class](../vs140/cdynamicaccessor-class.md)   
 [CDynamicParameterAccessor Class](../vs140/cdynamicparameteraccessor-class.md)