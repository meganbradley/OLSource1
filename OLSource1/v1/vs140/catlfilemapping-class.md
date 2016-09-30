---
title: "CAtlFileMapping Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATL::CAtlFileMapping<T>"
  - "ATL.CAtlFileMapping"
  - "ATL::CAtlFileMapping"
  - "CAtlFileMapping"
  - "ATL.CAtlFileMapping<T>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAtlFileMapping class"
ms.assetid: 899fc058-e05e-48b5-aca9-340403bb9e26
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlFileMapping Class
This class represents a memory-mapped file, adding a cast operator to the methods of [CAtlFileMappingBase](../vs140/catlfilemappingbase-class.md).  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type of data used for the cast operator.  
  
## Members  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlFileMapping::operator T*](../vs140/catlfilemapping--operator-t-.md)|Allows implicit conversion of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> objects to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>**\***.|  
  
## Remarks  
 This class adds a single cast operator to allow implicit conversion of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> objects to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>**\***. Other members are supplied by the base class, [CAtlFileMappingBase](../vs140/catlfilemappingbase-class.md).  
  
## Inheritance Hierarchy  
 [CAtlFileMappingBase](../vs140/catlfilemappingbase-class.md)  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlfile.h  
  
##  \<a name="catlfilemapping__operator_t_star">\</a>  CAtlFileMapping::operator T*  
 Allows implicit conversion of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> objects to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>**\***.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 Returns a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>**\*** pointer to the start of the memory-mapped file.  
  
### Remarks  
 Calls [CAtlFileMappingBase::GetData](../vs140/catlfilemappingbase--getdata.md) and reinterprets the returned pointer as a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>**\*** where *T* is the type used as the template parameter of this class.  
  
## See Also  
 [CAtlFileMappingBase Class](../vs140/catlfilemappingbase-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)