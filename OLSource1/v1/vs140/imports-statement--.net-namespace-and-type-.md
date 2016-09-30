---
title: "Imports Statement (.NET Namespace and Type)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.Imports"
  - "imports"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "declared element names [Visual Basic], qualification"
  - "imports [Visual Basic]"
  - "Imports statement [Visual Basic]"
  - "aliases [Visual Basic], Imports statement"
  - "container elements [Visual Basic]"
  - "namespaces [Visual Basic], importing"
  - "Imports statement [Visual Basic], syntax"
  - "import aliases [Visual Basic]"
  - "aliases [Visual Basic], import"
  - "declared elements [Visual Basic], container elements"
ms.assetid: 7062f8aa-d890-4232-9eed-92836e13fb6e
caps.latest.revision: 44
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Imports Statement (.NET Namespace and Type)
Enables type names to be referenced without namespace qualification.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Optional. An *import alias* or name by which code can refer to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> instead of the full qualification string. See [Declared Element Names](../vs140/declared-element-names--visual-basic-.md).|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Required. The fully qualified name of the namespace being imported. Can be a string of namespaces nested to any level.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Optional. The name of a programming element declared in the namespace. Can be any container element.|  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  statement enables types that are contained in a given namespace to be referenced directly.  
  
 You can supply a single namespace name or a string of nested namespaces. Each nested namespace is separated from the next higher level namespace by a period (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>), as the following example illustrates.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 Each source file can contain any number of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statements. These must follow any option declarations, such as the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statement, and they must precede any programming element declarations, such as <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> statements.  
  
 You can use <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> only at file level. This means the declaration context for importation must be a source file, and cannot be a namespace, class, structure, module, interface, procedure, or block.  
  
 Note that the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> statement does not make elements from other projects and assemblies available to your project. Importing does not take the place of setting a reference. It only removes the need to qualify names that are already available to your project. For more information, see "Importing Containing Elements" in [References to Declared Elements](../vs140/references-to-declared-elements--visual-basic-.md).  
  
> [!NOTE]
>  You can define implicit <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> statements by using the [References Page, Project Designer (Visual Basic)](../vs140/references-page--project-designer--visual-basic-.md). For more information, see [How to: Add or Remove Imported Namespaces (Visual Basic)](../vs140/how-to--add-or-remove-imported-namespaces--visual-basic-.md).  
  
## Import Aliases  
 An *import alias* defines the alias for a namespace or type. Import aliases are useful when you need to use items with the same name that are declared in one or more namespaces. For more information and an example, see "Qualifying an Element Name" in [References to Declared Elements](../vs140/references-to-declared-elements--visual-basic-.md).  
  
 You should not declare a member at module level with the same name as <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. If you do, the Visual Basic compiler uses <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> only for the declared member and no longer recognizes it as an import alias.  
  
 Although the syntax used for declaring an import alias is like that used for importing an XML namespace prefix, the results are different. An import alias can be used as an expression in your code, whereas an XML namespace prefix can be used only in XML literals or XML axis properties as the prefix for a qualified element or attribute name.  
  
### Element Names  
 If you supply <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, it must represent a *container element*, that is, a programming element that can contain other elements. Container elements include classes, structures, modules, interfaces, and enumerations.  
  
 The scope of the elements made available by an <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> statement depends on whether you specify <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. If you specify only <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, all uniquely named members of that namespace, and members of container elements within that namespace, are available without qualification. If you specify both <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, only the members of that element are available without qualification.  
  
## Example  
 The following example returns all the folders in the C:\ directory by using the \<xref:System.IO.DirectoryInfo*> class.  
  
 The code has no <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> statements at the top of the file. Therefore, the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, \<xref:System.Text.StringBuilder*>, and \<xref:Microsoft.VisualBasic.ControlChars.CrLf*> references are all fully qualified with the namespaces.  
  
 [!code[VbVbalrStatements#152](../vs140/codesnippet/VisualBasic/imports-statement--.net-namespace-and-type-_1.vb)]  
  
## Example  
 The following example includes <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> statements for the referenced namespaces. Therefore, the types do not have to be fully qualified with the namespaces.  
  
 [!code[VbVbalrStatements#153](../vs140/codesnippet/VisualBasic/imports-statement--.net-namespace-and-type-_2.vb)]  
  
 [!code[VbVbalrStatements#154](../vs140/codesnippet/VisualBasic/imports-statement--.net-namespace-and-type-_3.vb)]  
  
## Example  
 The following example includes <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> statements that create aliases for the referenced namespaces. The types are qualified with the aliases.  
  
 [!code[VbVbalrStatements#155](../vs140/codesnippet/VisualBasic/imports-statement--.net-namespace-and-type-_4.vb)]  
  
 [!code[VbVbalrStatements#156](../vs140/codesnippet/VisualBasic/imports-statement--.net-namespace-and-type-_5.vb)]  
  
## Example  
 The following example includes <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> statements that create aliases for the referenced types. Aliases are used to specify the types.  
  
 [!code[VbVbalrStatements#157](../vs140/codesnippet/VisualBasic/imports-statement--.net-namespace-and-type-_6.vb)]  
  
 [!code[VbVbalrStatements#158](../vs140/codesnippet/VisualBasic/imports-statement--.net-namespace-and-type-_7.vb)]  
  
## See Also  
 [Namespace Statement](../vs140/namespace-statement.md)   
 [Namespaces in Visual Basic](../vs140/namespaces-in-visual-basic.md)   
 [References and the Imports Statement](../vs140/references-and-the-imports-statement--visual-basic-.md)   
 [Imports Statement (XML Namespace)](../vs140/imports-statement--xml-namespace-.md)   
 [References to Declared Elements (Visual Basic)](../vs140/references-to-declared-elements--visual-basic-.md)