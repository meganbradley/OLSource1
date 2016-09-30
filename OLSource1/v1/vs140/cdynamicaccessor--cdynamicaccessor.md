---
title: "CDynamicAccessor::CDynamicAccessor"
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
  - "CDynamicAccessor::CDynamicAccessor"
  - "ATL::CDynamicAccessor::CDynamicAccessor"
  - "ATL.CDynamicAccessor.CDynamicAccessor"
  - "CDynamicAccessor.CDynamicAccessor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDynamicAccessor class, constructor"
ms.assetid: bf40fe81-2c85-473e-9075-51ad9b060b39
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDynamicAccessor::CDynamicAccessor
Instantiates and initializes the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies how the binary large object (BLOB) data is to be handled. The default value is **DBBLOBHANDLING_DEFAULT**. See [SetBlobHandling](../vs140/cdynamicaccessor--setblobhandling.md) for a description of the **DBBLOBHANDLINGENUM** values.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The maximum BLOB size in bytes; column data over this value is treated as a BLOB. The default value is 8,000. See [SetBlobSizeLimit](../vs140/cdynamicaccessor--setblobsizelimit.md) for details.  
  
## Remarks  
 If you use the constructor to initialize the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object, you can specify how it will bind BLOBs. BLOBs can contain binary data such as graphics, sound, or compiled code. The default behavior is to treat columns more than 8,000 bytes as BLOBs and try to bind them to an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object. However, you can specify a different value to be the BLOB size.  
  
 You can also specify how <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> handles column data that qualifies as BLOB data: it can handle BLOB data in the default manner; it can skip (does not bind) BLOB data; or it can bind BLOB data in provider-allocated memory.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CDynamicAccessor Class](../vs140/cdynamicaccessor-class.md)