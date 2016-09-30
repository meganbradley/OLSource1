---
title: "nameof (C# and Visual Basic Reference)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: 33601bf3-cc2c-4496-846d-f9679bccf2a7
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# nameof (C# and Visual Basic Reference)
Used to obtain the simple (unqualified) string name of a variable, type, or member.  When reporting errors in code, hooking up model-view-controller (MVC) links, firing property changed events, etc., you often want to capture the string name of a method.  Using <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> helps keep your code valid when renaming definitions.  Before you had to use string literals to refer to definitions, which is brittle when renaming code elements because tools do not know to check these string literals.  
  
 A <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> expression has this form:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Key Use Cases  
 These examples show the key use cases for <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 Validate parameters:  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 MVC Action links:  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 INotifyPropertyChanged:  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 XAML dependency property:  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Logging:  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Attributes:  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## Examples  
 Some C# examples:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Many of the above samples apply to Visual Basic.  Here are some specific Visual Basic examples:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
## Remarks  
 The argument to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> must be a simple name, qualified name, member access, base access with a specified member, or this access with a specified member.  The argument expression identifies a code definition, but it is never evaluated.  
  
 Because the argument needs to be an expression syntactically, there are many things disallowed that are not useful to list.  The following are worth mentioning that produce errors: predefined types (for example, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>), nullable types (<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>), array types (<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>), pointer types (<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>), qualified alias (<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>), and unbound generic types (<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>), preprocessing symbols (<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>), and labels (<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>).  
  
 If you need to get the fully-qualified name, you can use the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> expression along with <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
 In the examples you see that you can use a type name and access an instance method name.  You do not need to have an instance of the type, as required in evaluated expressions.  Using the type name can be very convenient in some situations, and since you are just referring to the name and not using instance data, you do not need to contrive an instance variable or expression.  
  
 You can reference the members of a class in attribute expressions on the class.  
  
 There is no way to get a signatures information such as "<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>".  One way to do that is to use an Expression, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, and pull the MemberInfo from the resulting expression tree.  
  
## Language Specifications  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
 For more information, see the [Visual Basic Language Reference](../vs140/visual-basic-language-reference.md).  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [typeof](../vs140/typeof--csharp-reference-.md)   
 [Visual Basic Language Reference](../vs140/visual-basic-language-reference.md)   
 [Visual Basic Programming Guide](../vs140/visual-basic-programming-guide.md)