---
title: "Verbose Syntax (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "verbose syntax [F#]"
  - "lightweight syntax [F#]"
ms.assetid: 50c4da30-580d-4049-affa-bcc78d8c1029
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Verbose Syntax (F#)
There are two forms of syntax available for many constructs in the F# language: *verbose syntax* and *lightweight syntax*. The verbose syntax is not as commonly used, but has the advantage of being less sensitive to indentation. The lightweight syntax is shorter and uses indentation to signal the beginning and end of constructs, rather than additional keywords like `begin`, `end`, `in`, and so on. The default syntax is the lightweight syntax. This topic describes the syntax for F# constructs when lightweight syntax is not enabled. Verbose syntax is always enabled, so even if you enable lightweight syntax, you can still use verbose syntax for some constructs. You can disable lightweight syntax by using the `#light "off"` directive.  
  
## Table of Constructs  
 The following table shows the lightweight and verbose syntax for F# language constructs in contexts where there is a difference between the two forms. In this table, angle brackets (<>) enclose user-supplied syntax elements. Refer to the documentation for each language construct for more detailed information about the syntax used within these constructs.  
  
|Language construct|Lightweight syntax|Verbose syntax|  
|------------------------|------------------------|--------------------|  
|compound expressions|`<expression1> <expression2>`|`<expression1>; <expression2>`|  
|nested `let` bindings|`let f x =     let a = 1     let b = 2     x + a + b`|`let f x =     let a = 1 in     let b = 2 in     x + a + b`|  
|code block|`<expression1>     <expression2>     ...`|`begin         <expression1>;         <expression2>;     end`|  
|`for...do`|`for counter = start to finish do     ...`|`for counter = start .. finish do     ...     done`|  
|`while...do`|`while <condition> do     ...`|`while <condition> do     ...     done`|  
|`for...in`|`for var in start .. finish do     ...`|`for var in start .. finish do     ...     done`|  
|`do`|`do ...`|`do ... in`|  
|record|`type <record-name> =     {         <field-declarations>     }     <value-or-member-definitions>`|`type <record-name> =     {         <field-declarations>     }     with         <value-or-member-definitions>     end`|  
|class|`type <class-name>(<params>) =     ...`|`type <class-name>(<params>) =     class         ...     end`|  
|structure|`[<StructAttribute>] type <structure-name> =     ...`|`type <structure-name> =     struct         ...     end`|  
|discriminated union|`type <union-name> =     &#124; ...     &#124; ...     ...     <value-or-member definitions>`|`type <union-name> =     &#124; ...     &#124; ...     ...     with          <value-or-member-definitions>`<br /><br /> `end`|  
|interface|`type <interface-name> =     ...`|`type <interface-name> =     interface         ...     end`|  
|object expression|`{ new <type-name>     with         <value-or-member-definitions>     <interface-implementations> }`|`{ new <type-name>     with         <value-or-member-definitions>     end     <interface-implementations> }`|  
|interface implementation|`interface <interface-name>     with         <value-or-member-definitions>`|`interface <interface-name>     with         <value-or-member-definitions>     end`|  
|type extension|`type <type-name>     with         <value-or-member-definitions>`|`type <type-name>     with         <value-or-member-definitions>     end`|  
|module|`module <module-name> =     ...`|`module <module-name> =     begin         ...     end`|  
  
## See Also  
 [F# Language Reference](../vs140/fsharp-language-reference.md)   
 [Compiler Directives](../vs140/compiler-directives--fsharp-.md)   
 [Code Formatting Guidelines](../vs140/code-formatting-guidelines--fsharp-.md)