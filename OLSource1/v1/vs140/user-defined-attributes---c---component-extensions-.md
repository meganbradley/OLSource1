---
title: "User-Defined Attributes  (C++ Component Extensions)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "metadata, extending"
  - "custom attributes, extending metadata"
ms.assetid: 98b29048-a3ea-4698-8441-f149cdaec9fb
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# User-Defined Attributes  (C++ Component Extensions)
Custom attributes enable you to extend the metadata of an interface, class or structure, method, parameter, or enumeration.  
  
## All Runtimes  
 All Runtimes support custom attributes.  
  
## Windows Runtime  
 C++/CX attributes support only properties, but not attribute constructors or methods.  
  
### Remarks  
  
### Requirements  
 Compiler option: **/ZW**  
  
## Common Language Runtime  
 Custom attributes let you extend the metadata of a managed element. For more information, see [Extending Metadata Using Attributes](assetId:///30386922-1e00-4602-9ebf-526b271a8b87).  
  
### Remarks  
 The information and syntax presented in this topic is meant to supersede the information presented in [attribute](../vs140/attribute.md).  
  
 You can define a custom attribute by defining a type and making \<xref:System.Attribute*> a base class for the type and optionally applying the \<xref:System.AttributeUsageAttribute*> attribute.  
  
 For example, in Microsoft Transaction Server (MTS) 1.0, behavior with respect to transactions, synchronization, load balancing, and so on was specified through custom GUIDs inserted into the type library by using the ODL custom attribute. Hence, a client of an MTS server could determine its characteristics by reading the type library. In the .NET Framework, the analog of the type library is metadata, and the analog of the ODL custom attribute is custom attributes. Also, reading the type library is analogous to using reflection on the types.  
  
 For more information, see,  
  
-   [Attribute Targets](../vs140/attribute-targets--c---component-extensions-.md)  
  
-   [Attribute Parameter Types](../vs140/attribute-parameter-types---c---component-extensions-.md)  
  
 For information on signing assemblies in Visual C++, see [Strong Name Assemblies (Assembly Signing)](../vs140/strong-name-assemblies--assembly-signing---c---cli-.md).  
  
### Requirements  
 Compiler option: **/clr**  
  
### Examples  
 **Example**  
  
 The following sample shows how to define a custom attribute.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Example**  
  
 The following example illustrates some important features of custom attributes. For example, this example shows a common usage of the custom attributes: instantiating a server that can fully describe itself to clients.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Output**  
  
 **Service Priority = 0**   
 **Service Access = Write**   
 **Service Priority = 3**   
 **Service Access = Write**   
 **Service Priority = 1**   
 **Service Access = Read** **Example**  
  
 The Object^ type replaces the variant data type. The following example defines a custom attribute that takes an array of Object^ as parameters.  
  
 Attribute arguments must be compile-time constants; in most cases, they should be constant literals.  
  
 See [typeid<>](../vs140/typeid---c---component-extensions-.md) for information on how to return a value of System::Type from a custom attribute block.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Example**  
  
 The runtime requires that the public part of the custom attribute class must be serializable.  When authoring custom attributes, named arguments of your custom attribute are limited to compile-time constants.  (Think of it as a sequence of bits appended to your class layout in the metadata.)  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Component Extensions for Runtime Platforms](../vs140/component-extensions-for-runtime-platforms.md)