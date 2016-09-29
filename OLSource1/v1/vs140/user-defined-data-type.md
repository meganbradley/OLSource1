---
title: "User-Defined Data Type"
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
  - "UserDefined"
  - "UDT"
  - "vb.UDT"
  - "User-Defined"
  - "vb.UserDefined"
  - "vb.User-Defined"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "user-defined data types, Visual Basic"
  - "user-defined types"
  - "structures, as user-defined data types"
  - "user-defined types, Visual Basic"
  - "user-defined types, structure declaration"
  - "user-defined types, structures in Visual Basic"
  - "user-defined data types, structure declaration"
  - "data types [Visual Basic], assigning"
  - "Structure statement"
  - "data types [Visual Basic], user-defined"
  - "user-defined data types, structures in Visual Basic"
  - "user-defined data types"
  - "types [Visual Basic], user-defined"
ms.assetid: be913dca-a364-4a51-96a1-549a1b390b0a
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# User-Defined Data Type
Holds data in a format you define. The `Structure` statement defines the format.  
  
 Previous versions of Visual Basic support the user-defined type (UDT). The current version expands the UDT to a *structure*. A structure is a concatenation of one or more *members* of various data types. Visual Basic treats a structure as a single unit, although you can also access its members individually.  
  
## Remarks  
 Define and use a structure data type when you need to combine various data types into a single unit, or when none of the elementary data types serve your needs.  
  
 The default value of a structure data type consists of the combination of the default values of each of its members.  
  
## Declaration Format  
 A structure declaration starts with the [Structure Statement](../vs140/structure-statement.md) and ends with the `End``Structure` statement. The `Structure` statement supplies the name of the structure, which is also the identifier of the data type the structure is defining. Other parts of the code can use this identifier to declare variables, parameters, and function return values to be of this structure's data type.  
  
 The declarations between the `Structure` and `End``Structure` statements define the members of the structure.  
  
## Member Access Levels  
 You must declare every member using a [Dim Statement (Visual Basic)](../vs140/dim-statement--visual-basic-.md) or a statement that specifies access level, such as [Public (Visual Basic)](../vs140/public--visual-basic-.md), [Friend (Visual Basic)](../vs140/friend--visual-basic-.md), or [Private (Visual Basic)](../vs140/private--visual-basic-.md). If you use a `Dim` statement, the access level defaults to public.  
  
## Programming Tips  
  
-   **Memory Consumption.** As with all composite data types, you cannot safely calculate the total memory consumption of a structure by adding together the nominal storage allocations of its members. Furthermore, you cannot safely assume that the order of storage in memory is the same as your order of declaration. If you need to control the storage layout of a structure, you can apply the <xref:System.Runtime.InteropServices.StructLayoutAttribute*> attribute to the `Structure` statement.  
  
-   **Interop Considerations.** If you are interfacing with components not written for the .NET Framework, for example Automation or COM objects, keep in mind that user-defined types in other environments are not compatible with Visual Basic structure types.  
  
-   **Widening.** There is no automatic conversion to or from any structure data type. You can define conversion operators on your structure using the [Operator Statement](../vs140/operator-statement.md), and you can declare each conversion operator to be `Widening` or `Narrowing`.  
  
-   **Type Characters.** Structure data types have no literal type character or identifier type character.  
  
-   **Framework Type.** There is no corresponding type in the .NET Framework. All structures inherit from the .NET Framework class <xref:System.ValueType*?displayProperty=fullName>, but no individual structure corresponds to <xref:System.ValueType*?displayProperty=fullName>.  
  
## Example  
 The following paradigm shows the outline of the declaration of a structure.  
  
```  
[Public | Protected | Friend | Protected Friend | Private] Structure structname  
    {Dim | Public | Friend | Private} member1 As datatype1  
    ' ...  
    {Dim | Public | Friend | Private} memberN As datatypeN  
End Structure  
```  
  
## See Also  
 <xref:System.ValueType*>   
 <xref:System.Runtime.InteropServices.StructLayoutAttribute*>   
 [Data Types](../vs140/data-type-summary--visual-basic-.md)   
 [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md)   
 [Conversion Summary](../vs140/conversion-summary--visual-basic-.md)   
 [Structure Statement](../vs140/structure-statement.md)   
 [Widening](../vs140/widening--visual-basic-.md)   
 [Narrowing](../vs140/narrowing--visual-basic-.md)   
 [Structures](../vs140/structures--visual-basic-.md)   
 [Efficient Use of Data Types](../vs140/efficient-use-of-data-types--visual-basic-.md)