---
title: "Attribute Targets (C++ Component Extensions)"
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
  - "custom attributes, targets"
ms.assetid: b4e6e224-da77-4520-b6e6-b96846e0ebc1
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Attribute Targets (C++ Component Extensions)
Attribute usage specifiers let you specify attribute targets.  Each attribute is defined to apply to certain language elements. For example, an attribute might be defined to apply only to classes and structs.  The following list shows the possible syntactic elements on which a custom attribute can be used. Combinations of these values (using logical or) may be used.  
  
 To specify attribute target, to pass one or more \<xref:System.AttributeTargets*> enumerators to \<xref:System.AttributeUsageAttribute*> when defining the attribute.  
  
 The following is a list of the valid attribute targets:  
  
-   <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> (applies to all constructs)  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> (applies to an assembly as a whole)  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> (applies to a module as a whole)  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Typically, an attribute directly precedes the language element to which it applies. In some cases, however, the position of an attribute is not sufficient to determine the attribute's intended target. Consider this example:  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Syntactically, there is no way to tell if the attribute is intended to apply to the method or to the method's return value (in this case, it defaults to the method). In such cases, an attribute usage specifier may be used. For example, to make the attribute apply to the return value, use the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> specifier, as follows:  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Attribute usage specifiers are required in the following situations:  
  
-   To specify an assembly- or module-level attribute.  
  
-   To specify that an attribute applies to a method's return value, not the method:  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
-   To specify that an attribute applies to a property's accessor, not the property:  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
-   To specify that an attribute applies to an event's accessor, not the event:  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 An attribute usage specifier applies only to the attribute that immediately follows it; that is,  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 is different from  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
## Example  
  
### Description  
 This sample shows how to specify multiple targets.  
  
### Code  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
## See Also  
 [User-Defined Attributes](../vs140/user-defined-attributes---c---component-extensions-.md)