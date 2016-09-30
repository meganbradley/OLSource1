---
title: "Working with Global Namespaces (Visual Basic) (LINQ to XML)2"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Working with Global Namespaces (Visual Basic) (LINQ to XML)"
dev_langs: 
  - "VB"
ms.assetid: 0a8064d5-e02f-4315-ad48-6deaa443a2f0
caps.latest.revision: 7
---
# Working with Global Namespaces (Visual Basic) (LINQ to XML)2
One of the key features of XML literals in Visual Basic is the capability to declare XML namespaces by using the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> statement. Using this feature, you can declare an XML namespace that uses a prefix, or you can declare a default XML namespace.  
  
 This capability is useful in two situations. First, namespaces declared in XML literals do not carry over into embedded expressions. Declaring global namespaces reduces the amount of work that you have to do to use embedded expressions with namespaces. Second, you must declare global namespaces in order to use namespaces with XML properties.  
  
 You can declare global namespaces at the project level. You can also declare global namespaces at the module level, which overrides the project-level global namespaces. Finally, you can override global namespaces in an XML literal.  
  
 When using XML literals or XML properties that are in globally-declared namespaces, you can see the expanded name of XML literals or properties by hovering over them in Visual Studio. You will see the expanded name in a tooltip.  
  
 You can get an \<xref:System.Xml.Linq.XNamespace*> object that corresponds to a global namespace using the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> method.  
  
## Examples of Global Namespaces  
 The following example declares a default global namespace by using the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> statement, and then uses an XML literal to initialize an \<xref:System.Xml.Linq.XElement*> object in that namespace:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following example declares a global namespace with a prefix, and then uses an XML literal to initialize an element:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Global Namespaces and Embedded Expressions  
 Namespaces that are declared in XML literals do not carry over into embedded expressions. The following example declares a default namespace. It then uses an embedded expression for the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> element.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 As you can see, the resulting XML includes a declaration of a default namespace so that the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> element is in no namespace.  
  
 You could re-declare the namespace in the embedded expression, as follows:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 However, this is more cumbersome to use than the global default namespace, which is a better approach. With the global default namespace, you can use XML literals without declaring namespaces. The resulting XML will be in the globally-declared default namespace.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
## Using Namespaces with XML Properties  
 If you are working with an XML tree that is in a namespace, and you use XML properties, then you must use a global namespace so that the XML properties will also be in the correct namespace. The following example declares an XML tree in a namespace. It then prints the count of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> elements.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 This example indicates that there are no <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> elements. It produces the following output:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 If, however, you declare a default global namespace, then both the XML literal and the XML property are in the default global namespace:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 This example indicates that there is one <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> element. It produces the following output:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 If you declare a global namespace that has a prefix, you can use the prefix for both XML literals and XML properties:  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
## XNamespace and Global Namespaces  
 You can get an \<xref:System.Xml.Linq.XNamespace*> object by using the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> method:  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
## See Also  
 [Working with XML Namespaces (Visual Basic)](../vs140/working-with-xml-namespaces--visual-basic-.md)