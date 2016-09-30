---
title: "CAccessorBase Class"
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
  - "CAccessorBase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAccessorBase class"
ms.assetid: 389b65be-11ca-4ae0-9290-60c621c4982b
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAccessorBase Class
All accessors in the OLE DB Templates derive from this class. <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> allows one rowset to manage multiple accessors. It also provides binding for both parameters and output columns.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[Close](../vs140/caccessorbase--close.md)|Closes the accessors.|  
|[GetHAccessor](../vs140/caccessorbase--gethaccessor.md)|Retrieves the accessor handle.|  
|[GetNumAccessors](../vs140/caccessorbase--getnumaccessors.md)|Retrieves the number of accessors created by the class.|  
|[IsAutoAccessor](../vs140/caccessorbase--isautoaccessor.md)|Tests whether the specified accessor is an autoaccessor.|  
|[ReleaseAccessors](../vs140/caccessorbase--releaseaccessors.md)|Releases the accessors.|  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [OLE DB Consumer Templates](../vs140/ole-db-consumer-templates--c---.md)   
 [Consumer Architecture Chart](../vs140/ole-db-consumer-templates-reference.md)