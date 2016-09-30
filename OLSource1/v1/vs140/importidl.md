---
title: "importidl"
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
  - "vc-attr.importidl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "importidl attribute"
ms.assetid: 4b0a4b55-6c57-4e6e-bc7b-a12cc8063941
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# importidl
Inserts the specified .idl file into the generated .idl file.  
  
## Syntax  
  
```  
  
      [ importidl(  
   idl_file  
) ];  
```  
  
#### Parameters  
 `idl_file`  
 Identifies the name of the .idl file that you want to merge with the .idl file that will be generated for your application.  
  
## Remarks  
 The **importidl** C++ attribute places the section outside of the library block (in `idl_file`) into your program's generated .idl file and the library section (in `idl_file`) into the library section of your program's generated .idl file.  
  
 You may want to use **importidl**, for example, if you want to use a hand-coded .idl file with your generated .idl file.  
  
## Example  
  
```  
// cpp_attr_ref_importidl.cpp  
// compile with: /LD  
[module(name="MyLib")];  
[importidl("import.idl")];  
```  
  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|Anywhere|  
|**Repeatable**|No|  
|**Required attributes**|None|  
|**Invalid attributes**|None|  
  
 For more information, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [Compiler Attributes](../vs140/compiler-attributes.md)   
 [Stand-Alone Attributes](../vs140/stand-alone-attributes.md)   
 [import](../vs140/import.md)   
 [importlib](../vs140/importlib.md)   
 [include](../vs140/include--c---.md)   
 [includelib](../vs140/includelib--c---.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)