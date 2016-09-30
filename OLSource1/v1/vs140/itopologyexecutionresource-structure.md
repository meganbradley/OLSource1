---
title: "ITopologyExecutionResource Structure"
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
  - "concrtrm/concurrency::ITopologyExecutionResource"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ITopologyExecutionResource structure"
ms.assetid: e36756f7-4cd9-4fa6-ba60-23fea58ef2bf
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ITopologyExecutionResource Structure
An interface to an execution resource as defined by the Resource Manager.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[ITopologyExecutionResource::GetId Method](#itopologyexecutionresource__getid_method)|Returns the Resource Manager's unique identifier for this execution resource.|  
|[ITopologyExecutionResource::GetNext Method](#itopologyexecutionresource__getnext_method)|Returns an interface to the next execution resource in enumeration order.|  
  
## Remarks  
 This interface is typically utilized to walk the topology of the system as observed by the Resource Manager.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
##  \<a name="itopologyexecutionresource__getid_method">\</a>  ITopologyExecutionResource::GetId Method  
 Returns the Resource Manager's unique identifier for this execution resource.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 The Resource Manager's unique identifier for this execution resource.  
  
##  \<a name="itopologyexecutionresource__getnext_method">\</a>  ITopologyExecutionResource::GetNext Method  
 Returns an interface to the next execution resource in enumeration order.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 An interface to the next execution resource in enumeration order. If there are no more nodes in enumeration order of the node to which this execution resource belongs, this method will return the value                         <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)