---
title: "no_injected_text"
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
  - "vc-attr.no_injected_text"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "no_injected_text attribute"
ms.assetid: 5256f808-e41e-4f4a-9ea5-e447919f5696
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# no_injected_text
Prevents the compiler from injecting code as a result of attribute use.  
  
## Syntax  
  
```  
  
      [ no_injected_text(  
   boolean  
) ];  
```  
  
#### Parameters  
 `boolean`(optional)  
 **true** if you want no code injected, **false** to allow code to be injected. **true** is the default.  
  
## Remarks  
 The most common use of the **no_injected_text** C++ attribute is by the [/Fx](../vs140/-fx--merge-injected-code-.md) compiler option, which inserts the **no_injected_text** attribute into the .mrg file.  
  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|Anywhere|  
|**Repeatable**|No|  
|**Required attributes**|None|  
|**Invalid attributes**|None|  
  
 For more information about the attribute contexts, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [Compiler Attributes](../vs140/compiler-attributes.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)