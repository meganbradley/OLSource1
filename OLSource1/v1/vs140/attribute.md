---
title: "attribute"
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
  - "vc-attr.attribute"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__typeof keyword"
  - "custom attributes, creating"
  - "attribute attribute"
  - "attributes [C++], custom"
ms.assetid: 8cb3489f-65c4-44ea-b0aa-3c3c6b15741d
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# attribute
Allows you to create a custom attribute.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *AllowOn*  
 Specifies the language elements to which the custom attribute can be applied. Default is **System::AttributeTargets::All** (see [System::AttributeTargets](https://msdn.microsoft.com/en-us/library/system.attributetargets.aspx)).  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Specifies whether the custom attribute can be applied repeatedly to a construct. Default is **FALSE**.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Indicates if the attribute is to be inherited by subclasses. The compiler provides no special support for this functionality; it is the job of the attribute consumers (Reflection, for example) to respect this information. If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is **TRUE**, the attribute is inherited. If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is **TRUE**, the attribute will accumulate on the derived member; if <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is **FALSE**, the attribute will override (or replace) in inheritance. If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is **FALSE**, the attribute will not be inherited. Default is **TRUE**.  
  
## Remarks  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> attribute is now deprecated.  Use the common language runtime attribute System.Attribute to directly to create user-defined attirbutes.  For more information, see [Extending Metadata with Custom Attributes](../vs140/user-defined-attributes---c---component-extensions-.md).  
  
 You define a [custom attribute](../vs140/custom-attributes--c---.md) by placing the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> attribute on a managed class or struct definition. The name of the class is the custom attribute. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 defines an attribute called MyAttr that can be applied to function parameters. The class must be public if the attribute is going to be used in other assemblies.  
  
> [!NOTE]
>  To prevent namespace collisions, all attribute names implicitly end with "Attribute"; in this example, the name of the attribute and class is actually MyAttrAttribute, but MyAttr and MyAttrAttribute can be used interchangeably.  
  
 The class's public constructors define the attribute's unnamed parameters. Overloaded constructors allow multiple ways of specifying the attribute, so a custom attribute that is defined the following way:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The class's public data members and properties are the attribute's optional named parameters:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 For a list of possible attribute parameter types, see [Custom Attributes](../vs140/custom-attributes--c---.md).  
  
 See [Extending Metadata with Custom Attributes](../vs140/user-defined-attributes---c---component-extensions-.md) for a discussion on attribute targets.  
  
 The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> attribute has an <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> parameter that specifies whether the custom attribute is single use or multiuse (can appear more than once on the same entity).  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Custom attribute classes are derived directly or indirectly from \<xref:System.ComponentModel.AttributeCollection.#ctor*>, which makes identifying attribute definitions in metadata fast and easy. The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> attribute implies inheritance from System::Attribute, so explicit derivation is not necessary:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 is equivalent to  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is an alias for \<xref:System.AttributeUsageAttribute*?displayProperty=fullName> (not AttributeAttribute; this is an exception to the attribute naming rule).  
  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder> **class**, **ref struct**|  
|**Repeatable**|No|  
|**Required attributes**|None|  
|**Invalid attributes**|None|  
  
 For more information about the attribute contexts, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
## Example  
 The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> named argument specifies whether a custom attribute applied on a base class will show up on reflection of a derived class.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 **2**   
## See Also  
 [Attributes Alphabetical Reference](../vs140/attributes-alphabetical-reference.md)   
 [Custom Attributes](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)