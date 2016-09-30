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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Identifies the name of the .idl file that you want to merge with the .idl file that will be generated for your application.  
  
## Remarks  
 The **importidl** C++ attribute places the section outside of the library block (in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) into your program's generated .idl file and the library section (in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) into the library section of your program's generated .idl file.  
  
 You may want to use **importidl**, for example, if you want to use a hand-coded .idl file with your generated .idl file.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
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