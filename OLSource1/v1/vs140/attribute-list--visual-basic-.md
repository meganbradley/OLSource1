---
title: "Attribute List (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - VB
helpviewer_keywords: 
  - attribute list
  - attributes [Visual Basic], applying
ms.assetid: 5880073a-68a4-4b6b-8a07-ace32959a4e2
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Attribute List (Visual Basic)
Specifies the attributes to be applied to a declared programming element. Multiple attributes are separated by commas. Following is the syntax for one attribute.  
  
## Syntax  
  
```  
[ attributemodifier ] attributename [ ( attributearguments | attributeinitializer ) ]  
```  
  
## Parts  
 `attributemodifier`  
 Required for attributes applied at the beginning of a source file. Can be [Assembly](../vs140/assembly--visual-basic-.md) or [Module](../vs140/module--keyword---visual-basic-.md).  
  
 `attributename`  
 Required. Name of the attribute.  
  
 `attributearguments`  
 Optional. List of positional arguments for this attribute. Multiple arguments are separated by commas.  
  
 `attributeinitializer`  
 Optional. List of variable or property initializers for this attribute. Multiple initializers are separated by commas.  
  
## Remarks  
 You can apply one or more attributes to nearly any programming element (types, procedures, properties, and so forth). Attributes appear in your assembly's metadata, and they can help you annotate your code or specify how to use a particular programming element. You can apply attributes defined by Visual Basic and the .NET Framework, and you can define your own attributes.  
  
 For more information on when to use attributes, see [Attributes (C# and Visual Basic)](../vs140/attributes--csharp-and-visual-basic-.md). For information on attribute names, see [Declared Element Names](../vs140/declared-element-names--visual-basic-.md).  
  
## Rules  
  
-   **Placement.** You can apply attributes to most declared programming elements. To apply one or more attributes, you place an *attribute block* at the beginning of the element declaration. Each entry in the attribute list specifies an attribute you wish to apply, and the modifier and arguments you are using for this invocation of the attribute.  
  
-   **Angle Brackets.** If you supply an attribute list, you must enclose it in angle brackets ("`<`" and "`>`").  
  
-   **Part of the Declaration.** The attribute must be part of the element declaration, not a separate statement. You can use the line-continuation sequence (" `_`") to extend the declaration statement onto multiple source-code lines.  
  
-   **Modifiers.** An attribute modifier (`Assembly` or `Module`) is required on every attribute applied to a programming element at the beginning of a source file. Attribute modifiers are not allowed on attributes applied to elements that are not at the beginning of a source file.  
  
-   **Arguments.** All positional arguments for an attribute must precede any variable or property initializers.  
  
## Example  
 The following example applies the <xref:System.Runtime.InteropServices.DllImportAttribute?qualifyHint=False> attribute to a skeleton definition of a `Function` procedure.  
  
 [!code[VbVbalrStatements#1](../vs140/codesnippet/VisualBasic/attribute-list--visual-basic-_1.vb)]
  
  
 <xref:System.Runtime.InteropServices.DllImportAttribute?qualifyHint=False> indicates that the attributed procedure represents an entry point in an unmanaged dynamic-link library (DLL). The attribute supplies the DLL name as a positional argument and the other information as variable initializers.  
  
## See Also  
 [Assembly](../vs140/assembly--visual-basic-.md)   
 [Module <keyword\>](../vs140/module--keyword---visual-basic-.md)   
 [Attributes (C# and Visual Basic)](../vs140/attributes--csharp-and-visual-basic-.md)   
 [How to: Break and Combine Statements in Code](../vs140/how-to--break-and-combine-statements-in-code--visual-basic-.md)