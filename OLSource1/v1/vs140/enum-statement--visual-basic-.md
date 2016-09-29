---
title: "Enum Statement (Visual Basic)"
ms.custom: na
ms.date: "09/23/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.Enum"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "enumerated constants"
  - "Enum statement"
  - "Private keyword, Enum statements"
  - "Public keyword, in Enum statement"
  - "variables [Visual Basic], enumeration"
  - "constants, enumerated"
ms.assetid: a45e51f1-65ff-48e1-bf32-79130f137377
caps.latest.revision: 48
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Enum Statement (Visual Basic)
Declares an enumeration and defines the values of its members.  
  
## Syntax  
  
```  
[ <attributelist> ] [ accessmodifier ]  [ Shadows ]   
Enum enumerationname [ As datatype ]   
   memberlist  
End Enum  
```  
  
## Parts  
  
-   `attributelist`  
  
     Optional. List of attributes that apply to this enumeration. You must enclose the [attribute list](../vs140/attribute-list--visual-basic-.md) in angle brackets ("`<`" and "`>`").  
  
     The <xref:System.FlagsAttribute*> attribute indicates that the value of an instance of the enumeration can include multiple enumeration members, and that each member represents a bit field in the enumeration value.  
  
-   `accessmodifier`  
  
     Optional. Specifies what code can access this enumeration. Can be one of the following:  
  
    -   [Public](../vs140/public--visual-basic-.md)  
  
    -   [Protected](../vs140/protected--visual-basic-.md)  
  
    -   [Friend](../vs140/friend--visual-basic-.md)  
  
    -   [Private](../vs140/private--visual-basic-.md)  
  
     You can specify `Protected``Friend` to allow access from code within the enumeration's class, a derived class, or the same assembly.  
  
-   `Shadows`  
  
     Optional. Specifies that this enumeration redeclares and hides an identically named programming element, or set of overloaded elements, in a base class. You can specify [Shadows](../vs140/shadows--visual-basic-.md) only on the enumeration itself, not on any of its members.  
  
-   `enumerationname`  
  
     Required. Name of the enumeration. For information on valid names, see [Declared Element Names](../vs140/declared-element-names--visual-basic-.md).  
  
-   `datatype`  
  
     Optional. Data type of the enumeration and all its members.  
  
-   `memberlist`  
  
     Required. List of member constants being declared in this statement. Multiple members appear on individual source code lines.  
  
     Each `member` has the following syntax and parts: `[<attribute list>] member name [ = initializer ]`  
  
    |||  
    |-|-|  
    |Part|Description|  
    |`membername`|Required. Name of this member.|  
    |`initializer`|Optional. Expression that is evaluated at compile time and assigned to this member.|  
  
-   `End` `Enum`  
  
     Terminates the `Enum` block.  
  
## Remarks  
 If you have a set of unchanging values that are logically related to each other, you can define them together in an enumeration. This provides meaningful names for the enumeration and its members, which are easier to remember than their values. You can then use the enumeration members in many places in your code.  
  
 The benefits of using enumerations include the following:  
  
-   Reduces errors caused by transposing or mistyping numbers.  
  
-   Makes it easy to change values in the future.  
  
-   Makes code easier to read, which means it is less likely that errors will be introduced.  
  
-   Ensures forward compatibility. If you use enumerations, your code is less likely to fail if in the future someone changes the values corresponding to the member names.  
  
 An enumeration has a name, an underlying data type, and a set of members. Each member represents a constant.  
  
 An enumeration declared at class, structure, module, or interface level, outside any procedure, is a *member enumeration*. It is a member of the class, structure, module, or interface that declares it.  
  
 Member enumerations can be accessed from anywhere within their class, structure, module, or interface. Code outside a class, structure, or module must qualify a member enumeration's name with the name of that class, structure, or module. You can avoid the need to use fully qualified names by adding an [Imports](../vs140/imports-statement--.net-namespace-and-type-.md) statement to the source file.  
  
 An enumeration declared at namespace level, outside any class, structure, module, or interface, is a member of the namespace in which it appears.  
  
 The *declaration context* for an enumeration must be a source file, namespace, class, structure, module, or interface, and cannot be a procedure. For more information, see [Declaration Contexts and Default Access Levels](../vs140/declaration-contexts-and-default-access-levels--visual-basic-.md).  
  
 You can apply attributes to an enumeration as a whole, but not to its members individually. An attribute contributes information to the assembly's metadata.  
  
## Data Type  
 The `Enum` statement can declare the data type of an enumeration. Each member takes the enumeration's data type. You can specify `Byte`, `Integer`, `Long`, `SByte`, `Short`, `UInteger`, `ULong`, or `UShort`.  
  
 If you do not specify `datatype` for the enumeration, each member takes the data type of its `initializer`. If you specify both `datatype` and `initializer`, the data type of `initializer` must be convertible to `datatype`. If neither `datatype` nor `initializer` is present, the data type defaults to `Integer`.  
  
## Initializing Members  
 The `Enum` statement can initialize the contents of selected members in `memberlist`. You use `initializer` to supply an expression to be assigned to the member.  
  
 If you do not specify `initializer` for a member, Visual Basic initializes it either to zero (if it is the first `member` in `memberlist`), or to a value greater by one than that of the immediately preceding `member`.  
  
 The expression supplied in each `initializer` can be any combination of literals, other constants that are already defined, and enumeration members that are already defined, including a previous member of this enumeration. You can use arithmetic and logical operators to combine such elements.  
  
 You cannot use variables or functions in `initializer`. However, you can use conversion keywords such as `CByte` and `CShort`. You can also use `AscW` if you call it with a constant `String` or `Char` argument, since that can be evaluated at compile time.  
  
 Enumerations cannot have floating-point values. If a member is assigned a floating-point value and `Option Strict` is set to on, a compiler error occurs. If `Option Strict` is off, the value is automatically converted to the `Enum` type.  
  
 If the value of a member exceeds the allowable range for the underlying data type, or if you initialize any member to the maximum value allowed by the underlying data type, the compiler reports an error.  
  
## Modifiers  
 Class, structure, module, and interface member enumerations default to public access. You can adjust their access levels with the access modifiers. Namespace member enumerations default to friend access. You can adjust their access levels to public, but not to private or protected. For more information, see [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md).  
  
 All enumeration members have public access, and you cannot use any access modifiers on them. However, if the enumeration itself has a more restricted access level, the specified enumeration access level takes precedence.  
  
 By default, all enumerations are types and their fields are constants. Therefore the `Shared`, `Static`, and `ReadOnly` keywords cannot be used when declaring an enumeration or its members.  
  
## Assigning Multiple Values  
 Enumerations typically represent mutually exclusive values. By including the <xref:System.FlagsAttribute*> attribute in the `Enum` declaration, you can instead assign multiple values to an instance of the enumeration. The <xref:System.FlagsAttribute*> attribute specifies that the enumeration be treated as a bit field, that is, a set of flags. These are called *bitwise* enumerations.  
  
 When you declare an enumeration by using the <xref:System.FlagsAttribute*> attribute, we recommend that you use powers of 2, that is, 1, 2, 4, 8, 16, and so on, for the values. We also recommend that "None" be the name of a member whose value is 0. For additional guidelines, see <xref:System.FlagsAttribute*> and <xref:System.Enum*>.  
  
## Example  
 The following example shows how to use the `Enum` statement. Note that the member is referred to as `EggSizeEnum.Medium`, and not as `Medium`.  
  
 [!code[VbEnumsTask#41](../vs140/codesnippet/VisualBasic/enum-statement--visual-basic-_1.vb)]  
  
## Example  
 The method in the following example is outside the `Egg` class. Therefore, `EggSizeEnum` is fully qualified as `Egg.EggSizeEnum`.  
  
 [!code[VbEnumsTask#42](../vs140/codesnippet/VisualBasic/enum-statement--visual-basic-_2.vb)]  
  
## Example  
 The following example uses the `Enum` statement to define a related set of named constant values. In this case, the values are colors you might choose to design data entry forms for a database.  
  
 [!code[VbEnumsTask#30](../vs140/codesnippet/VisualBasic/enum-statement--visual-basic-_3.vb)]  
  
## Example  
 The following example shows values that include both positive and negative numbers.  
  
 [!code[VbEnumsTask#31](../vs140/codesnippet/VisualBasic/enum-statement--visual-basic-_4.vb)]  
  
## Example  
 In the following example, an `As` clause is used to specify the `datatype` of an enumeration.  
  
 [!code[VbEnumsTask#6](../vs140/codesnippet/VisualBasic/enum-statement--visual-basic-_5.vb)]  
  
## Example  
 The following example shows how to use a bitwise enumeration. Multiple values can be assigned to an instance of a bitwise enumeration. The `Enum` declaration includes the <xref:System.FlagsAttribute*> attribute, which indicates that the enumeration can be treated as a set of flags.  
  
 [!code[VbEnumsTask#61](../vs140/codesnippet/VisualBasic/enum-statement--visual-basic-_6.vb)]  
  
## Example  
 The following example iterates through an enumeration. It uses the <xref:System.Enum.GetNames*> method to retrieve an array of member names from the enumeration, and <xref:System.Enum.GetValues*> to retrieve an array of member values.  
  
 [!code[VbEnumsTask#51](../vs140/codesnippet/VisualBasic/enum-statement--visual-basic-_7.vb)]  
  
## See Also  
 <xref:System.Enum*>   
 <xref:Microsoft.VisualBasic.Strings.AscW*>   
 [Const Statement](../vs140/const-statement--visual-basic-.md)   
 [Dim Statement](../vs140/dim-statement--visual-basic-.md)   
 [Implicit and Explicit Conversions](../vs140/implicit-and-explicit-conversions--visual-basic-.md)   
 [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md)   
 [Constants and Enumerations](../vs140/constants-and-enumerations--visual-basic-.md)