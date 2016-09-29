---
title: "Class Hierarchy of Symbol Types"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "symbols [DIA SDK], class hierarchies"
ms.assetid: 0ccd6990-4654-44cd-a6f3-bdd82fe90f6c
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Class Hierarchy of Symbol Types
The following table describes the symbol types in the class hierarchy.  
  
## Symbol Types  
  
|Symbol type|Description|  
|-----------------|-----------------|  
|[UDT](../vs140/udt.md)|Symbol used to represent each class, structure, and union.|  
|[Enum (Debug Interface Access SDK)](../vs140/enum--debug-interface-access-sdk-.md)|Symbol for enumerated types.|  
|[PointerType](../vs140/pointertype.md)|Symbol for pointer types.|  
|[ArrayType](../vs140/arraytype.md)|Symbol for array types.|  
|[BaseType](../vs140/basetype.md)|Symbol for base types|  
|[Typedef (Debug Interface Access SDK)](../vs140/typedef--debug-interface-access-sdk-.md)|Symbol that introduces names for other types.|  
|[BaseClass](../vs140/baseclass.md)|Symbol used for each base class of a user-defined type (UDT).|  
|[Friend (Debug Interface Access SDK)](../vs140/friend--debug-interface-access-sdk-.md)|Symbol for friend classes and friend functions.|  
|[FunctionType](../vs140/functiontype.md)|Symbol for each unique function signature.|  
|[FunctionArgType](../vs140/functionargtype.md)|Symbol for each parameter to a function.|  
|[VTableShape](../vs140/vtableshape.md)|Symbol for the size of the virtual table.|  
|[VTable](../vs140/vtable.md)|Symbol for a virtual table.|  
|[CustomType](../vs140/customtype.md)|Symbol for vendor-defined type.|  
|[ManagedType](../vs140/managedtype.md)|Symbol for a type defined in metadata.|  
|[Dimension](../vs140/dimension.md)|Symbol for array dimensions.|  
  
> [!NOTE]
>  Each symbol can have properties that hold information about the symbol, as well as references to other symbols. These properties are listed in the individual symbol topics.  
  
## See Also  
 [CV_access_e Enumeration](../vs140/cv_access_e.md)   
 [Lexical Hierarchy of Symbol Types](../vs140/lexical-hierarchy-of-symbol-types.md)   
 [Symbols and Symbol Tags](../vs140/symbols-and-symbol-tags.md)