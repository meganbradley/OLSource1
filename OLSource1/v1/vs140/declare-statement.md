---
title: "Declare Statement"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vb.Declare
  - vb.Lib
  - vb.Any
dev_langs: 
  - VB
helpviewer_keywords: 
  - Lib keyword
  - declaring procedures, Declare statement
  - functions [Visual Basic], function procedures
  - declarations, procedures
  - procedures, declaration
  - procedures, external
  - Alias keyword
  - external references, Visual Basic
  - DLLs, declaring procedures
  - Declare statement
  - declarations, external
  - Visual Basic code, Function procedures
  - As keyword, in Declare statement
  - resources [Visual Basic], declaring
  - Public keyword, Declare statement
  - platform invoke, Visual Basic external references
  - Sub procedures, declarations
  - APIs, declaring API functions
  - Visual Basic code, Sub procedures
  - Function procedures, declaring
ms.assetid: d3f21fb0-b804-4c99-97ed-583b23894cf1
caps.latest.revision: 34
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Declare Statement
Declares a reference to a procedure implemented in an external file.  
  
## Syntax  
  
```  
[ <attributelist> ] [ accessmodifier ] [ Shadows ] [ Overloads ] _  
Declare [ charsetmodifier ] [ Sub ] name Lib "libname" _  
[ Alias "aliasname" ] [ ([ parameterlist ]) ]  
' -or-  
[ <attributelist> ] [ accessmodifier ] [ Shadows ] [ Overloads ] _  
Declare [ charsetmodifier ] [ Function ] name Lib "libname" _  
[ Alias "aliasname" ] [ ([ parameterlist ]) ] [ As returntype ]  
```  
  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|`attributelist`|Optional. See [Attribute List](../vs140/attribute-list--visual-basic-.md).|  
|`accessmodifier`|Optional. Can be one of the following:<br /><br /> -   [Public](../vs140/public--visual-basic-.md)<br />-   [Protected](../vs140/protected--visual-basic-.md)<br />-   [Friend](../vs140/friend--visual-basic-.md)<br />-   [Private](../vs140/private--visual-basic-.md)<br />-   `Protected Friend`<br /><br /> See [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md).|  
|`Shadows`|Optional. See [Shadows](../vs140/shadows--visual-basic-.md).|  
|`charsetmodifier`|Optional. Specifies character set and file search information. Can be one of the following:<br /><br /> -   [Ansi](../vs140/ansi--visual-basic-.md) (default)<br />-   [Unicode (Visual Basic)](../vs140/unicode--visual-basic-.md)<br />-   [Auto](../vs140/auto--visual-basic-.md)|  
|`Sub`|Optional, but either `Sub` or `Function` must appear. Indicates that the external procedure does not return a value.|  
|`Function`|Optional, but either `Sub` or `Function` must appear. Indicates that the external procedure returns a value.|  
|`name`|Required. Name of this external reference. For more information, see [Declared Element Names](../vs140/declared-element-names--visual-basic-.md).|  
|`Lib`|Required. Introduces a `Lib` clause, which identifies the external file (DLL or code resource) that contains an external procedure.|  
|`libname`|Required. Name of the file that contains the declared procedure.|  
|`Alias`|Optional. Indicates that the procedure being declared cannot be identified within its file by the name specified in `name`. You specify its identification in `aliasname`.|  
|`aliasname`|Required if you use the `Alias` keyword. String that identifies the procedure in one of two ways:<br /><br /> The entry point name of the procedure within its file, within quotes (`""`)<br /><br /> -or-<br /><br /> A number sign (`#`) followed by an integer specifying the ordinal number of the procedure's entry point within its file|  
|`parameterlist`|Required if the procedure takes parameters. See [Parameter List](../vs140/parameter-list--visual-basic-.md).|  
|`returntype`|Required if `Function` is specified and `Option Strict` is `On`. Data type of the value returned by the procedure.|  
  
## Remarks  
 Sometimes you need to call a procedure defined in a file (such as a DLL or code resource) outside your project. When you do this, the Visual Basic compiler does not have access to the information it needs to call the procedure correctly, such as where the procedure is located, how it is identified, its calling sequence and return type, and the string character set it uses. The `Declare` statement creates a reference to an external procedure and supplies this necessary information.  
  
 You can use `Declare` only at module level. This means the *declaration context* for an external reference must be a class, structure, or module, and cannot be a source file, namespace, interface, procedure, or block. For more information, see [Declaration Contexts and Default Access Levels](../vs140/declaration-contexts-and-default-access-levels--visual-basic-.md).  
  
 External references default to [Public (Visual Basic)](../vs140/public--visual-basic-.md) access. You can adjust their access levels with the access modifiers.  
  
## Rules  
  
-   **Attributes.** You can apply attributes to an external reference. Any attribute you apply has effect only in your project, not in the external file.  
  
-   **Modifiers.** External procedures are implicitly [Shared (Visual Basic)](../vs140/shared--visual-basic-.md). You cannot use the `Shared` keyword when declaring an external reference, and you cannot alter its shared status.  
  
     An external procedure cannot participate in overriding, implement interface members, or handle events. Accordingly, you cannot use the `Overrides`, `Overridable`, `NotOverridable`, `MustOverride`, `Implements`, or `Handles` keyword in a `Declare` statement.  
  
-   **External Procedure Name.** You do not have to give this external reference the same name (in `name`) as the procedure's entry-point name within its external file (`aliasname`). You can use an `Alias` clause to specify the entry-point name. This can be useful if the external procedure has the same name as a Visual Basic reserved modifier or a variable, procedure, or any other programming element in the same scope.  
  
    > [!NOTE]
    >  Entry-point names in most DLLs are case-sensitive.  
  
-   **External Procedure Number.** Alternatively, you can use an `Alias` clause to specify the ordinal number of the entry point within the export table of the external file. To do this, you begin `aliasname` with a number sign (`#`). This can be useful if any character in the external procedure name is not allowed in Visual Basic, or if the external file exports the procedure without a name.  
  
## Data Type Rules  
  
-   **Parameter Data Types.** If `Option Strict` is `On`, you must specify the data type of each parameter in `parameterlist`. This can be any data type or the name of an enumeration, structure, class, or interface. Within `parameterlist`, you use an `As` clause to specify the data type of the argument to be passed to each parameter.  
  
    > [!NOTE]
    >  If the external procedure was not written for the .NET Framework, you must take care that the data types correspond. For example, if you declare an external reference to a Visual Basic 6.0 procedure with an `Integer` parameter (16 bits in Visual Basic 6.0), you must identify the corresponding argument as `Short` in the `Declare` statement, because that is the 16-bit integer type in Visual Basic. Similarly, `Long` has a different data width in Visual Basic 6.0, and `Date` is implemented differently.  
  
-   **Return Data Type.** If the external procedure is a `Function` and `Option Strict` is `On`, you must specify the data type of the value returned to the calling code. This can be any data type or the name of an enumeration, structure, class, or interface.  
  
    > [!NOTE]
    >  The Visual Basic compiler does not verify that your data types are compatible with those of the external procedure. If there is a mismatch, the common language runtime generates a <xref:System.Runtime.InteropServices.MarshalDirectiveException?qualifyHint=False> exception at run time.  
  
-   **Default Data Types.** If `Option Strict` is `Off` and you do not specify the data type of a parameter in `parameterlist`, the Visual Basic compiler converts the corresponding argument to the [Object Data Type](../vs140/object-data-type.md). Similarly, if you do not specify `returntype`, the compiler takes the return data type to be `Object`.  
  
    > [!NOTE]
    >  Because you are dealing with an external procedure that might have been written on a different platform, it is dangerous to make any assumptions about data types or to allow them to default. It is much safer to specify the data type of every parameter and of the return value, if any. This also improves the readability of your code.  
  
## Behavior  
  
-   **Scope.** An external reference is in scope throughout its class, structure, or module.  
  
-   **Lifetime.** An external reference has the same lifetime as the class, structure, or module in which it is declared.  
  
-   **Calling an External Procedure.** You call an external procedure the same way you call a `Function` or `Sub` procedure—by using it in an expression if it returns a value, or by specifying it in a [Call Statement (Visual Basic)](../vs140/call-statement--visual-basic-.md) if it does not return a value.  
  
     You pass arguments to the external procedure exactly as specified by `parameterlist` in the `Declare` statement. Do not take into account how the parameters were originally declared in the external file. Similarly, if there is a return value, use it exactly as specified by `returntype` in the `Declare` statement.  
  
-   **Character Sets.** You can specify in `charsetmodifier` how Visual Basic should marshal strings when it calls the external procedure. The `Ansi` modifier directs Visual Basic to marshal all strings to ANSI values, and the `Unicode` modifier directs it to marshal all strings to Unicode values. The `Auto` modifier directs Visual Basic to marshal strings according to .NET Framework rules based on the external reference `name`, or `aliasname` if specified. The default value is `Ansi`.  
  
     `charsetmodifier` also specifies how Visual Basic should look up the external procedure within its external file. `Ansi` and `Unicode` both direct Visual Basic to look it up without modifying its name during the search. `Auto` directs Visual Basic to determine the base character set of the run-time platform and possibly modify the external procedure name, as follows:  
  
    -   On an ANSI platform, such as Windows 95, Windows 98, or Windows Millennium Edition, first look up the external procedure with no name modification. If that fails, append "A" to the end of the external procedure name and look it up again.  
  
    -   On a Unicode platform, such as Windows NT, Windows 2000, or Windows XP, first look up the external procedure with no name modification. If that fails, append "W" to the end of the external procedure name and look it up again.  
  
-   **Mechanism.** Visual Basic uses the .NET Framework *platform invoke* (PInvoke) mechanism to resolve and access external procedures. The `Declare` statement and the <xref:System.Runtime.InteropServices.DllImportAttribute?qualifyHint=False> class both use this mechanism automatically, and you do not need any knowledge of PInvoke. For more information, see [Walkthrough: Calling Windows APIs](../vs140/walkthrough--calling-windows-apis--visual-basic-.md).  
  
> [!IMPORTANT]
>  If the external procedure runs outside the common language runtime (CLR), it is *unmanaged code*. When you call such a procedure, for example a Win32 API function or a COM method, you might expose your application to security risks. For more information, see [Unmanaged Code](assetId:///a8d15139-d368-4c9c-a747-ba757781117c).  
  
## Example  
 The following example declares an external reference to a `Function` procedure that returns the current user name. It then calls the external procedure `GetUserNameA` as part of the `getUser` procedure.  
  
 [!code[VbVbalrStatements#15](../vs140/codesnippet/VisualBasic/declare-statement_1.vb)]
  
  
## Example  
 The <xref:System.Runtime.InteropServices.DllImportAttribute?qualifyHint=False> provides an alternative way of using functions in unmanaged code. The following example declares an imported function without using a `Declare` statement.  
  
 [!code[VbVbalrStatements#16](../vs140/codesnippet/VisualBasic/declare-statement_2.vb)]
  
  
 [!code[VbVbalrStatements#1](../vs140/codesnippet/VisualBasic/declare-statement_3.vb)]
  
  
## See Also  
 <xref:Microsoft.VisualBasic.ErrObject.LastDllError?qualifyHint=False>   
 [Imports Statement](../vs140/imports-statement--.net-namespace-and-type-.md)   
 [AddressOf Operator](../vs140/addressof-operator--visual-basic-.md)   
 [Function Statement](../vs140/function-statement--visual-basic-.md)   
 [Sub Statement](../vs140/sub-statement--visual-basic-.md)   
 [Parameter List](../vs140/parameter-list--visual-basic-.md)   
 [Call Statement](../vs140/call-statement--visual-basic-.md)   
 [Walkthrough: Calling Windows APIs](../vs140/walkthrough--calling-windows-apis--visual-basic-.md)