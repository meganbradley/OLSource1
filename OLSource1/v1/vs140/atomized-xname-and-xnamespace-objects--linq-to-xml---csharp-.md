---
title: "Atomized XName and XNamespace Objects (LINQ to XML) (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: a5b21433-b49d-415c-b00e-bcbfb0d267d7
caps.latest.revision: 3
---
# Atomized XName and XNamespace Objects (LINQ to XML) (C#)
\<xref:System.Xml.Linq.XName*> and \<xref:System.Xml.Linq.XNamespace*> objects are *atomized*; that is, if they contain the same qualified name, they refer to the same object. This yields performance benefits for queries: When you compare two atomized names for equality, the underlying intermediate language only has to determine whether the two references point to the same object. The underlying code does not have to do string comparisons, which would be time consuming.  
  
## Atomization Semantics  
 Atomization means that if two \<xref:System.Xml.Linq.XName*> objects have the same local name, and they are in the same namespace, they share the same instance. In the same way, if two \<xref:System.Xml.Linq.XNamespace*> objects have the same namespace URI, they share the same instance.  
  
 For a class to enable atomized objects, the constructor for the class must be private, not public. This is because if the constructor were public, you could create a non-atomized object. The \<xref:System.Xml.Linq.XName*> and \<xref:System.Xml.Linq.XNamespace*> classes implement an implicit conversion operator to convert a string into an \<xref:System.Xml.Linq.XName*> or \<xref:System.Xml.Linq.XNamespace*>. This is how you get an instance of these objects. You cannot get an instance by using a constructor, because the constructor is inaccessible.  
  
 \<xref:System.Xml.Linq.XName*> and \<xref:System.Xml.Linq.XNamespace*> also implement the equality and inequality operators, to determine whether the two objects being compared are references to the same instance.  
  
## Example  
 The following code creates some \<xref:System.Xml.Linq.XElement*> objects and demonstrates that identical names share the same instance.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 As mentioned earlier, the benefit of atomized objects is that when you use one of the axis methods that take an \<xref:System.Xml.Linq.XName*> as a parameter, the axis method only has to determine that two names reference the same instance to select the desired elements.  
  
 The following example passes an \<xref:System.Xml.Linq.XName*> to the \<xref:System.Xml.Linq.XContainer.Descendants*> method call, which then has better performance because of the atomization pattern.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Performance (LINQ to XML) (C#)](../vs140/performance--linq-to-xml---csharp-.md)