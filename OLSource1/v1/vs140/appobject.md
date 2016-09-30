---
title: "appobject"
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
  - "vc-attr.appobject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "appobject attribute"
ms.assetid: 8ce30b73-e945-403e-a755-6bc78078a695
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# appobject
Identifies the coclass as an application object, which is associated with a full .exe application, and indicates that the functions and properties of the coclass are globally available in this [type library](../vs140/automation-clients--using-type-libraries.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The **appobject** C++ attribute has the same functionality as the [appobject](http://msdn.microsoft.com/library/windows/desktop/aa366726) MIDL attribute.  
  
## Example  
 The following code shows a simple class definition preceded by an attribute block that includes **appobject**:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|**class**, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|  
|**Repeatable**|No|  
|**Required attributes**|**coclass**|  
|**Invalid attributes**|None|  
  
 For more information about the attribute contexts, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [IDL Attributes](../vs140/idl-attributes.md)   
 [Class Attributes](../vs140/class-attributes.md)   
 [Typedef, Enum, Union, and Struct Attributes](../vs140/typedef--enum--union--and-struct-attributes.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)