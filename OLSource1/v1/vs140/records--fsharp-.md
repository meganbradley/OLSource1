---
title: "Records (F#)"
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
  - "records [F#]"
ms.assetid: 1c0ac404-c6d6-4b28-b2dc-c94213fc6f39
caps.latest.revision: 36
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Records (F#)
Records represent simple aggregates of named values, optionally with members.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 In the previous syntax, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is the name of the record type, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> are names of values, referred to as *labels*, and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> are the types of these values. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is the optional list of members for the type.  
  
 Following are some examples.  
  
 [!code[FsLangRef1#1901](../vs140/codesnippet/FSharp/records--fsharp-_1.fs)]  
  
 When each label is on a separate line, the semicolon is optional.  
  
 You can set values in expressions known as *record expressions*. The compiler infers the type from the labels used (if the labels are sufficiently distinct from those of other record types). Braces ({ }) enclose the record expression. The following code shows a record expression that initializes a record with three float elements with labels <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 [!code[FsLangRef1#1907](../vs140/codesnippet/FSharp/records--fsharp-_2.fs)]  
  
 Do not use the shortened form if there could be another type that also has the same labels.  
  
 [!code[FsLangRef1#1903](../vs140/codesnippet/FSharp/records--fsharp-_3.fs)]  
  
 The labels of the most recently declared type take precedence over those of the previously declared type, so in the preceding example, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is inferred to be <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. You can explicitly specify the record type, as in the following code.  
  
 [!code[FsLangRef1#1908](../vs140/codesnippet/FSharp/records--fsharp-_4.fs)]  
  
 Methods can be defined for record types just as for class types.  
  
## Creating Records by Using Record Expressions  
 You can initialize records by using the labels that are defined in the record. An expression that does this is referred to as a *record expression*. Use braces to enclose the record expression and use the semicolon as a delimiter.  
  
 The following example shows how to create a record.  
  
 [!code[FsLangRef1#1904](../vs140/codesnippet/FSharp/records--fsharp-_5.fs)]  
  
 The semicolons after the last field in the record expression and in the type definition are optional, regardless of whether the fields are all in one line.  
  
 When you create a record, you must supply values for each field. You cannot refer to the values of other fields in the initialization expression for any field.  
  
 In the following code, the type of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is inferred from the names of the fields. Optionally, you can specify the type name explicitly.  
  
 [!code[FsLangRef1#1905](../vs140/codesnippet/FSharp/records--fsharp-_6.fs)]  
  
 Another form of record construction can be useful when you have to copy an existing record, and possibly change some of the field values. The following line of code illustrates this.  
  
 [!code[FsLangRef1#1906](../vs140/codesnippet/FSharp/records--fsharp-_7.fs)]  
  
 This form of the record expression is called the *copy and update record expression*.  
  
 Records are immutable by default; however, you can easily create modified records by using a copy and update expression. You can also explicitly specify a mutable field.  
  
 [!code[FsLangRef1#1909](../vs140/codesnippet/FSharp/records--fsharp-_8.fs)]  
  
 Don't use the DefaultValue attribute with record fields. A better approach is to define default instances of records with fields that are initialized to default values and then use a copy and update record expression to set any fields that differ from the default values.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Pattern Matching with Records  
 Records can be used with pattern matching. You can specify some fields explicitly and provide variables for other fields that will be assigned when a match occurs. The following code example illustrates this.  
  
 [!code[FsLangRef1#1910](../vs140/codesnippet/FSharp/records--fsharp-_9.fs)]  
  
 The output of this code is as follows.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Differences Between Records and Classes  
 Record fields differ from classes in that they are automatically exposed as properties, and they are used in the creation and copying of records. Record construction also differs from class construction. In a record type, you cannot define a constructor. Instead, the construction syntax described in this topic applies. Classes have no direct relationship between constructor parameters, fields, and properties.  
  
 Like union and structure types, records have structural equality semantics. Classes have reference equality semantics. The following code example demonstrates this.  
  
 [!code[FsLangRef1#1911](../vs140/codesnippet/FSharp/records--fsharp-_10.fs)]  
  
 If you write the same code with classes, the two class objects would be unequal because the two values would represent two objects on the heap and only the addresses would be compared (unless the class type overrides the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> method).  
  
## See Also  
 [F# Types](../vs140/fsharp-types.md)   
 [Classes (F#)](../vs140/classes--fsharp-.md)   
 [F# Language Reference](../vs140/fsharp-language-reference.md)   
 [Patterns (F#)](../vs140/pattern-matching--fsharp-.md)