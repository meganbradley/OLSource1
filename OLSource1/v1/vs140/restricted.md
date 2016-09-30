---
title: "restricted"
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
  - "vc-attr.restricted"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "restricted attribute"
ms.assetid: 504a96be-b904-4269-8be1-920feba201b4
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# restricted
Specifies that a member of a module, interface, or dispinterface cannot be called arbitrarily.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 One or more interfaces that may not be called arbitrarily on a COM object. This parameter is only valid when applied to a class.  
  
## Remarks  
 The **restricted** C++ attribute has the same functionality as the [restricted](http://msdn.microsoft.com/library/windows/desktop/aa367157) MIDL attribute.  
  
## Example  
 The following code shows how to use the **restricted** attribute:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|Interface method, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, **class**, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|  
|**Repeatable**|No|  
|**Required attributes**|**coclass** (when applied to **class** or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>)|  
|**Invalid attributes**|None|  
  
 For more information about the attribute contexts, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [IDL Attributes](../vs140/idl-attributes.md)   
 [Interface Attributes](../vs140/interface-attributes.md)   
 [Method Attributes](../vs140/method-attributes.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)