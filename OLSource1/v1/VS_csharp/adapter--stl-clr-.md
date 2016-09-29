---
title: "adapter (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "adapter (STL/CLR)"
f1_keywords: 
  - "<cliext/adapter>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "<adapter> header [STL/CLR]"
  - "adapter [STL/CLR]"
  - "<cliext/adapter> header [STL/CLR]"
ms.assetid: 71ce7e51-42b6-4f70-9595-303791a97677
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# adapter (STL-CLR)
The STL/CLR header `<cliext/adapter>` specifies two template classes (`collection_adapter` and `range_adapter`), and the template function `make_collection`.  
  
## Syntax  
  
```  
#include <cliext/adapter>  
```  
  
## Remarks  
  
|Class|Description|  
|-----------|-----------------|  
|[collection_adapter](../VS_csharp/collection_adapter--stl-clr-.md)|Wraps the Base Class Library (BCL) collection as a range.|  
|[range_adapter](../VS_csharp/range_adapter--stl-clr-.md)|Wraps the range as a BCL collection.|  
  
|Function|Description|  
|--------------|-----------------|  
|[make_collection](../VS_csharp/make_collection--stl-clr-.md)|Creates a range adapter using an iterator pair.|  
  
## Requirements  
 **Header:** <cliext/adapter>  
  
 **Namespace:** cliext  
  
## See Also  
 [STL/CLR Library Reference](../VS_csharp/stl-clr-library-reference.md)