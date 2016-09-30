---
title: "code_seg (__declspec)"
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
  - "code_seg_cpp"
  - "code_seg"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "code_seg __declspec keyword"
ms.assetid: ad3c1105-15d3-4e08-b7b9-e4bd9d7b6aa0
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# code_seg (__declspec)
**Microsoft Specific**  
  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> declaration attribute names an executable text segment in the .obj file in which the object code for the function or class member functions will be stored.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> attribute enables the placement of code into separate named segments that can be paged or locked in memory individually. You can use this attribute to control the placement of instantiated templates and compiler-generated code.  
  
 A *segment* is a named block of data in an .obj file that is loaded into memory as a unit. A *text segment* is a segment that contains executable code. The term *section* is often used interchangeably with segment.  
  
 Object code that's generated when <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is defined is put in the text segment specified by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, which is a narrow-string literal. The name <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> does not have to be specified in a [section](../vs140/section.md) pragma before it can be used in a declaration. By default, when no <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is specified, object code is put in a segment named .text. A <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> attribute overrides any existing [#pragma code_seg](../vs140/code_seg.md) directive. A <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> attribute applied to a member function overrides any <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> attribute applied to the enclosing class.  
  
 If an entity has a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> attribute, all declarations and definitions of the same entity must have identical <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> attributes. If a base-class has a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> attribute, derived classes must have the same attribute.  
  
 When a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> attribute is applied to a namespace-scope function or a member function, the object code for that function is put in the specified text segment. When this attribute is applied to a class, all member functions of the class and nested classes—this includes compiler-generated special member functions—are put in the specified segment. Locally defined classes—for example, classes defined in a member function body—do not inherit the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> attribute of the enclosing scope.  
  
 When a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> attribute is applied to a template class or template function, all implicit specializations of the template are put in the specified segment. Explicit or partial specializations do not inherit the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> attribute from the primary template. You may specify the same or a different <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> attribute on the specialization. A <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> attribute can’t be applied to an explicit template instantiation.  
  
 By default, compiler-generated code such as a special member function is put in the .text segment. The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> directive does not override this default. Use the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> attribute on the class, class template, or function template to control where compiler-generated code is put.  
  
 Lambdas inherit <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> attributes from their enclosing scope. To specify a segment for a lambda, apply a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> attribute after the parameter-declaration clause and before any mutable or exception specification, any trailing return-type specification, and the lambda body. For more information, see [Lambda Expression Syntax](../vs140/lambda-expression-syntax.md). This example defines a lambda in a segment named PagedMem:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Be careful when you put specific member functions—especially virtual member functions—in different segments. If you define a virtual function in a derived class that resides in a paged segment when the base class method resides in a non-paged segment, other base class methods or user code may assume that invoking the virtual method will not trigger a page fault.  
  
## Example  
 This example shows how a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> attribute controls segment placement when implicit and explicit template specialization is used:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **END Microsoft Specific**  
  
## See Also  
 [__declspec](../vs140/__declspec.md)   
 [Keywords](../vs140/keywords--c---.md)