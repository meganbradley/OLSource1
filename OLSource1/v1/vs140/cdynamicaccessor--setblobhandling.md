---
title: "CDynamicAccessor::SetBlobHandling"
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
  - "CDynamicAccessor::SetBlobHandling"
  - "CDynamicAccessor.SetBlobHandling"
  - "ATL::CDynamicAccessor::SetBlobHandling"
  - "SetBlobHandling"
  - "ATL.CDynamicAccessor.SetBlobHandling"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetBlobHandling method"
ms.assetid: fa8b0bb3-a21b-4d64-aeef-e79bf61d079c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDynamicAccessor::SetBlobHandling
Sets the BLOB handling value for the current row.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies how the BLOB data is to be handled. It can take the following values:  
  
-   **DBBLOBHANDLING_DEFAULT**: Handle column data larger than <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> (as set by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) as BLOB data and retrieve it through an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object. This option will attempt to bind every column containing data larger than <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or listed as **DBTYPE_IUNKNOWN** as BLOB data.  
  
-   **DBBLOBHANDLING_NOSTREAMS**: Handle column data larger than <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> (as set by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>) as BLOB data and retrieve it through reference in provider-allocated, consumer-owned memory. This option is useful for tables that have more than one BLOB column, and the provider supports only one <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object per accessor.  
  
-   **DBBLOBHANDLING_SKIP**: Skip (do not bind) columns qualifying as containing BLOBs (the accessor will not bind or retrieve the column value but it will still retrieve the column status and length).  
  
## Remarks  
 You should call <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> before calling **Open**.  
  
 The constructor method [CDynamicAccessor](../vs140/cdynamicaccessor-class.md) sets the BLOB handling value to **DBBLOBHANDLING_DEFAULT**.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CDynamicAccessor Class](../vs140/cdynamicaccessor-class.md)