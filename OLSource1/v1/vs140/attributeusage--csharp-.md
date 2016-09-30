---
title: "AttributeUsage (C#)"
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
ms.assetid: 22c45568-9a6a-4c2f-8480-f38c1caa0a99
caps.latest.revision: 7
---
# AttributeUsage (C#)
Determines how a custom attribute class can be used. <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is an attribute that can be applied to custom attribute definitions to control how the new attribute can be applied. The default settings look like this when applied explicitly:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In this example, the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> class can be applied to any attribute-able code entity, but can be applied only once to each entity. It is inherited by derived classes when applied to a base class.  
  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> arguments are optional, so this code has the same effect:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The first <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> argument must be one or more elements of the \<xref:System.AttributeTargets*> enumeration. Multiple target types can be linked together with the OR operator, like this:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 If the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> argument is set to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, then the resulting attribute can be applied more than once to a single entity, like this:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 In this case <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> can be applied repeatedly because <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. Both formats shown for applying multiple attributes are valid.  
  
 If <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, then the attribute is not inherited by classes that are derived from a class that is attributed. For example:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 In this case <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is not applied to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> via inheritance.  
  
## Remarks  
 The <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> attribute is a single-use attribute--it cannot be applied more than once to the same class. <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is an alias for \<xref:System.AttributeUsageAttribute*>.  
  
 For more information, see [Accessing Attributes by Using Reflection (C#)](../vs140/accessing-attributes-by-using-reflection--csharp-.md).  
  
## Example  
 The following example demonstrates the effect of the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> arguments to the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> attribute, and how the custom attributes applied to a class can be enumerated.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Attribute*>   
 \<xref:System.Reflection*>   
 [C# Programming](../vs140/csharp-programming-guide.md)   
 [Extending Metadata Using Attributes](assetId:///30386922-1e00-4602-9ebf-526b271a8b87)   
 [Reflection (C#)](../vs140/reflection--csharp-.md)   
 [Attributes (C#)](../vs140/attributes--csharp-and-visual-basic-.md)   
 [Creating Custom Attributes (C#)](../vs140/creating-custom-attributes--csharp-.md)   
 [Accessing Attributes by Using Reflection (C#)](../vs140/accessing-attributes-by-using-reflection--csharp-.md)