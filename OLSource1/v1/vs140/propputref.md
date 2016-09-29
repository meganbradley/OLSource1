---
title: "propputref"
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
  - "vc-attr.propputref"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "propputref attribute"
ms.assetid: 9b0aed74-fdc7-4e59-9117-949bea4f86dd
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# propputref
Specifies a property setting function that uses a reference instead of a value.  
  
## Syntax  
  
```  
  
[propputref]  
  
```  
  
## Remarks  
 The **propputref** C++ attribute has the same functionality as the [propputref](http://msdn.microsoft.com/library/windows/desktop/aa367147) MIDL attribute.  
  
## Example  
 See the example for [bindable](../vs140/bindable.md) for a sample use of **propputref**.  
  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|Method|  
|**Repeatable**|No|  
|**Required attributes**|None|  
|**Invalid attributes**|**propget**, **propput**|  
  
 For more information about the attribute contexts, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [IDL Attributes](../vs140/idl-attributes.md)   
 [Method Attributes](../vs140/method-attributes.md)   
 [propget](../vs140/propget.md)   
 [propput](../vs140/propput.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)