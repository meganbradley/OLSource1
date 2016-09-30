---
title: "How to: Retrieve the Value of an Element (LINQ to XML) (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: 76b9b2a5-b3ba-49da-ba74-82100e1bd21c
caps.latest.revision: 7
---
# How to: Retrieve the Value of an Element (LINQ to XML) (Visual Basic)
This topic shows how to get the value of elements. There are two main ways to do this. One way is to cast an \<xref:System.Xml.Linq.XElement*> or an \<xref:System.Xml.Linq.XAttribute*> to the desired type. The explicit conversion operator then converts the contents of the element or attribute to the specified type and assigns it to your variable. Alternatively, you can use the \<xref:System.Xml.Linq.XElement.Value*?displayProperty=fullName> property or the \<xref:System.Xml.Linq.XAttribute.Value*?displayProperty=fullName> property.  
  
 With Visual Basic, the best approach is to use the \<xref:System.Xml.Linq.XElement.Value*?displayProperty=fullName> property.  
  
## Example  
 To retrieve the value of an element, you just cast the \<xref:System.Xml.Linq.XElement*> object to your desired type. You can always cast an element to a string, as follows:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 You can also cast elements to types other than string. For example, if you have an element that contains an integer, you can cast it to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, as shown in the following code:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] provides explicit cast operators for the following data types: <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
 [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] provides the same cast operators for \<xref:System.Xml.Linq.XAttribute*> objects.  
  
## Example  
 You can use the \<xref:System.Xml.Linq.XElement.Value*> property to retrieve the contents of an element:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## Example  
 Sometimes you try to retrieve the value of an element even though you are not sure it exists. In this case, when you assign the casted element to a nullable type (either <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> or one of the nullable types in the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)]), if the element does not exist the assigned variable is just set to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>. The following code shows that when the element might or might not exist, it is easier to use casting than to use the \<xref:System.Xml.Linq.XElement.Value*> property.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 This code produces the following output:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 In general, you can write simpler code when using casting to retrieve the contents of elements and attributes.  
  
## See Also  
 [LINQ to XML Axes (Visual Basic)](../vs140/linq-to-xml-axes--visual-basic-.md)