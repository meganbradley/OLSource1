---
title: "Const Statement (Visual Basic)"
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
  - "vb.Const"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Const statement [Visual Basic]"
ms.assetid: 495b318d-b7c5-4198-94f8-0790a541b07a
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Const Statement (Visual Basic)
Declares and defines one or more constants.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Optional. List of attributes that apply to all the constants declared in this statement. See [Attribute List](../vs140/attribute-list--visual-basic-.md) in angle brackets ("<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>" and "<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>").  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Optional. Use this to specify what code can access these constants. Can be [Public](../vs140/public--visual-basic-.md), [Protected](../vs140/protected--visual-basic-.md), [Friend](../vs140/friend--visual-basic-.md), <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, or [Private](../vs140/private--visual-basic-.md).  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Optional. Use this to redeclare and hide a programming element in a base class. See [Shadows](../vs140/shadows--visual-basic-.md).  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Required. List of constants being declared in this statement.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 Each <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> has the following syntax and parts:  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
|Part|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Required. Name of the constant. See [Declared Element Names](../vs140/declared-element-names--visual-basic-.md).|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Required if <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. Data type of the constant.|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Required. Expression that is evaluated at compile time and assigned to the constant.|  
  
## Remarks  
 If you have a value that never changes in your application, you can define a named constant and use it in place of a literal value. A name is easier to remember than a value. You can define the constant just once and use it in many places in your code. If in a later version you need to redefine the value, the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> statement is the only place you need to make a change.  
  
 You can use <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> only at module or procedure level. This means the *declaration context* for a variable must be a class, structure, module, procedure, or block, and cannot be a source file, namespace, or interface. For more information, see [Declaration Contexts and Default Access Levels](../vs140/declaration-contexts-and-default-access-levels--visual-basic-.md).  
  
 Local constants (inside a procedure) default to public access, and you cannot use any access modifiers on them. Class and module member constants (outside any procedure) default to private access, and structure member constants default to public access. You can adjust their access levels with the access modifiers.  
  
## Rules  
  
-   **Declaration Context.** A constant declared at module level, outside any procedure, is a *member constant*; it is a member of the class, structure, or module that declares it.  
  
     A constant declared at procedure level is a *local constant*; it is local to the procedure or block that declares it.  
  
-   **Attributes.** You can apply attributes only to member constants, not to local constants. An attribute contributes information to the assembly's metadata, which is not meaningful for temporary storage such as local constants.  
  
-   **Modifiers.** By default, all constants are <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. You cannot use any of these keywords when declaring a constant.  
  
     At procedure level, you cannot use <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> or any access modifiers to declare local constants.  
  
-   **Multiple Constants.** You can declare several constants in the same declaration statement, specifying the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> part for each one. Multiple constants are separated by commas.  
  
## Data Type Rules  
  
-   **Data Types.** The <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> statement can declare the data type of a variable. You can specify any data type or the name of an enumeration.  
  
-   **Default Type.** If you do not specify <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, the constant takes the data type of <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. If you specify both <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, the data type of <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> must be convertible to <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. If neither <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> nor <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is present, the data type defaults to <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
-   **Different Types.** You can specify different data types for different constants by using a separate <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> clause for each variable you declare. However, you cannot declare several constants to be of the same type by using a common <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> clause.  
  
-   **Initialization.** You must initialize the value of every constant in <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. You use <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> to supply an expression to be assigned to the constant. The expression can be any combination of literals, other constants that are already defined, and enumeration members that are already defined. You can use arithmetic and logical operators to combine such elements.  
  
     You cannot use variables or functions in <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>. However, you can use conversion keywords such as <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>. You can also use <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> if you call it with a constant <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> argument, since that can be evaluated at compile time.  
  
## Behavior  
  
-   **Scope.** Local constants are accessible only from within their procedure or block. Member constants are accessible from anywhere within their class, structure, or module.  
  
-   **Qualification.** Code outside a class, structure, or module must qualify a member constant's name with the name of that class, structure, or module. Code outside a procedure or block cannot refer to any local constants within that procedure or block.  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> statement to declare constants for use in place of literal values.  
  
 [!code[VbVbalrStatements#13](../vs140/codesnippet/VisualBasic/const-statement--visual-basic-_1.vb)]  
  
## Example  
 If you define a constant with data type <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, the Visual Basic compiler gives it the type of <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, instead of <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>. In the following example, the constant <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> has the run-time type <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrStatements#87](../vs140/codesnippet/VisualBasic/const-statement--visual-basic-_2.vb)]  
  
 The preceding example uses the \<xref:System.Type.ToString*> method on the \<xref:System.Type*> object returned by the [GetType Operator](../vs140/gettype-operator--visual-basic-.md), because \<xref:System.Type*> cannot be converted to <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> using <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
## See Also  
 \<xref:Microsoft.VisualBasic.Strings.Asc*>   
 \<xref:Microsoft.VisualBasic.Strings.AscW*>   
 [Enum Statement](../vs140/enum-statement--visual-basic-.md)   
 [#Const Directive](../vs140/sharpconst-directive.md)   
 [Dim Statement](../vs140/dim-statement--visual-basic-.md)   
 [ReDim Statement](../vs140/redim-statement--visual-basic-.md)   
 [Implicit and Explicit Conversions](../vs140/implicit-and-explicit-conversions--visual-basic-.md)   
 [Constants and Enumerations](../vs140/constants-and-enumerations-in-visual-basic.md)   
 [Constants and Enumerations](../vs140/constants-and-enumerations--visual-basic-.md)   
 [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md)