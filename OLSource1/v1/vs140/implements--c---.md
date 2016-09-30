---
title: "implements (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "vc-attr.implements"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "implements attribute"
ms.assetid: 9cf0858b-cb7d-4d3c-81a6-97d87ed00d25
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# implements (C++)
Specifies dispatch interfaces that are forced to be members of the IDL coclass.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 **interfaces**  
 A comma separated list of the interfaces that will be a member of the IDL coclass. A shorthand method for specifying a single interface is **implements(***interface_name***)**.  
  
 **dispinterfaces**  
 A comma separated list of the dispinterface that will be a member of the IDL coclass. A shorthand method for specifying a single dispinterface is **implements(dispinterfaces** *= dispinterface_name***)**.  
  
## Remarks  
 By default, only COM-interfaces that are base classes of the coclass are added in the IDL coclass. **implements** lets you force other interfaces to be IDL coclass members.  
  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|**class**, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|  
|**Repeatable**|Yes|  
|**Required attributes**|None|  
|**Invalid attributes**|None|  
  
 For more information, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## Example  
 The following example is in three parts: an .idl file and its associated .h file, and a C++ file.  
  
 Assume the following .idl file, which will be available to the compiler.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 And the following .h file, which also needs to be available to the compiler.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 In the following program, without implements, IBar1, IBar2, and ISna will not be in the coclass in the generated IDL.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Compiler Attributes](../vs140/compiler-attributes.md)   
 [Class Attributes](../vs140/class-attributes.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)