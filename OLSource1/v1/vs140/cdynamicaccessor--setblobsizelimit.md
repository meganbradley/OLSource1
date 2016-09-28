---
title: "CDynamicAccessor::SetBlobSizeLimit"
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
  - "CDynamicAccessor::SetBlobSizeLimit"
  - "SetBlobSizeLimit"
  - "CDynamicAccessor.SetBlobSizeLimit"
  - "ATL.CDynamicAccessor.SetBlobSizeLimit"
  - "ATL::CDynamicAccessor::SetBlobSizeLimit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetBlobSizeLimit method"
ms.assetid: fb8cb85d-f841-408e-a344-37895b10993f
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDynamicAccessor::SetBlobSizeLimit
Sets the maximum BLOB size in bytes.  
  
## Syntax  
  
```  
  
      void SetBlobSizeLimit(  
   DBLENGTH nBlobSize   
);  
```  
  
#### Parameters  
 `nBlobSize`  
 Specifies the BLOB size limit.  
  
## Remarks  
 Sets the maximum BLOB size in bytes; column data larger than this value is treated as a BLOB. Some providers give extremely large sizes for columns (such as 2 GB). Rather than attempting to allocate memory for a column this size, you would typically try to bind these columns as BLOBs. In that way you don't have to allocate all the memory, but you can still read all the data without fear of truncation. However, there are some cases in which you might want to force `CDynamicAccessor` to bind large columns in their native data types. To do this, call `SetBlobSizeLimit` before calling **Open**.  
  
 The constructor method [CDynamicAccessor](../vs140/cdynamicaccessor-class.md) sets the maximum BLOB size to a default value of 8,000 bytes.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CDynamicAccessor Class](../vs140/cdynamicaccessor-class.md)