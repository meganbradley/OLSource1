---
title: "CDynamicParameterAccessor::CDynamicParameterAccessor"
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
  - "CDynamicParameterAccessor::CDynamicParameterAccessor"
  - "CDynamicParameterAccessor.CDynamicParameterAccessor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDynamicParameterAccessor class, constructor"
  - "CDynamicParameterAccessor method"
ms.assetid: a1cce5e4-dfb9-43a2-bfb8-0435c653674a
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDynamicParameterAccessor::CDynamicParameterAccessor
The constructor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies how the BLOB data is to be handled. The default value is **DBBLOBHANDLING_DEFAULT**. See [CDynamicAccessor::SetBlobHandling](../vs140/cdynamicaccessor--setblobhandling.md) for a description of the **DBBLOBHANDLINGENUM** values.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The maximum BLOB size in bytes; column data over this value is treated as a BLOB. The default value is 8,000. See [CDynamicAccessor::SetBlobSizeLimit](../vs140/cdynamicaccessor--setblobsizelimit.md) for details.  
  
## Remarks  
 See the [CDynamicAccessor::CDynamicAccessor](../vs140/cdynamicaccessor--cdynamicaccessor.md) constructor for more information on BLOB handling.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CDynamicParameterAccessor Class](../vs140/cdynamicparameteraccessor-class.md)