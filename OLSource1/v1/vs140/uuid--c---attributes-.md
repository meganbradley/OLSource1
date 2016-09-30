---
title: "uuid (C++ Attributes)"
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
  - "vc-attr.uuid"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "uuid attribute"
ms.assetid: 90562a94-5e28-451b-a4b0-cadda7f66efe
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# uuid (C++ Attributes)
Specifies the unique ID for a class or interface.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *uuid*  
 A 128-bit, unique identifier.  
  
## Remarks  
 If the definition of an interface or class does not specify the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> C++ attribute, then the Visual C++ compiler will provide one. When you specify a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, you must include the quotes.  
  
 If you do not specify <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, then the compiler will generate the same GUID for interfaces or classes with the same name in different attribute projects on a machine.  
  
 You can use Uuidgen.exe or Guidgen.exe to generate your own unique IDs. (To run either of these tools, click **Start** and click **Run** on the menu. Then enter the name of the required tool.)  
  
 When used in a project that does not also use ATL, specifying the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> attribute is the same as specifying the [uuid](../vs140/uuid--c---.md) __declspec modifier. To retrieve the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> of a class, you can use [__uuidof](../vs140/__uuidof-operator.md)  
  
## Example  
 See the [bindable](../vs140/bindable.md) example for a sample use of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|**class**, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, **union**, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|**Repeatable**|No|  
|**Required attributes**|None|  
|**Invalid attributes**|None|  
  
 For more information about the attribute contexts, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [IDL Attributes](../vs140/idl-attributes.md)   
 [Interface Attributes](../vs140/interface-attributes.md)   
 [Class Attributes](../vs140/class-attributes.md)   
 [Typedef, Enum, Union, and Struct Attributes](../vs140/typedef--enum--union--and-struct-attributes.md)   
 [uuid](http://msdn.microsoft.com/library/windows/desktop/aa367302)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)