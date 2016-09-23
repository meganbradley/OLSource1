---
title: "Visual Basic Coding Conventions"
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
  - coding conventions, Visual Basic
  - examples [Visual Basic], coding conventions
  - Visual Basic code, conventions
ms.assetid: c1df130b-fec6-49a5-becf-0a7e494a1d0f
caps.latest.revision: 52
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Visual Basic Coding Conventions
Microsoft develops samples and documentation that follow the guidelines in this topic. If you follow the same coding conventions, you may gain the following benefits:  
  
-   Your code will have a consistent look, so that readers can better focus on content, not layout.  
  
-   Readers understand your code more quickly because they can make assumptions based on previous experience.  
  
-   You can copy, change, and maintain the code more easily.  
  
-   You help ensure that your code demonstrates "best practices" for Visual Basic.  
  
## Naming Conventions  
  
-   For information about naming guidelines, see [Guidelines for Names](assetId:///fc076d66-9b5f-42d3-aa65-61d970c794a3) topic.  
  
-   Do not use "My" or "my" as part of a variable name. This practice creates confusion with the `My` objects.  
  
-   You do not have to change the names of objects in auto-generated code to make them fit the guidelines.  
  
## Layout Conventions  
  
-   Insert tabs as spaces, and use smart indenting with four-space indents.  
  
-   Use **Pretty listing (reformatting) of code** to reformat your code in the code editor. For more information, see [Visual Basic-Specific, Basic, Text Editor, Options Dialog Box](../vs140/options--text-editor--basic--visual-basic-.md).  
  
-   Use only one statement per line. Don't use the Visual Basic line separator character (:).  
  
-   Avoid using the explicit line continuation character "_" in favor of implicit line continuation wherever the language allows it.  
  
-   Use only one declaration per line.  
  
-   If **Pretty listing (reformatting) of code** doesn't format continuation lines automatically, manually indent continuation lines one tab stop. However, always left-align items in a list.  
  
    ```  
    a As Integer,  
    b As Integer  
    ```  
  
-   Add at least one blank line between method and property definitions.  
  
## Commenting Conventions  
  
-   Put comments on a separate line instead of at the end of a line of code.  
  
-   Start comment text with an uppercase letter, and end comment text with a period.  
  
-   Insert one space between the comment delimiter (') and the comment text.  
  
     [!code[VbVbalrGuidelines#2](../vs140/codesnippet/VisualBasic/visual-basic-coding-conventions_1.vb)]
  
  
-   Do not surround comments with formatted blocks of asterisks.  
  
## Program Structure  
  
-   When you use the `Main` method, use the default construct for new console applications, and use `My` for command-line arguments.  
  
     [!code[VbVbalrGuidelines#3](../vs140/codesnippet/VisualBasic/visual-basic-coding-conventions_2.vb)]
  
  
## Language Guidelines  
  
### String Data Type  
  
-   To concatenate strings, use an ampersand (&).  
  
     [!code[VbVbalrGuidelines#4](../vs140/codesnippet/VisualBasic/visual-basic-coding-conventions_3.vb)]
  
  
-   To append strings in loops, use the <xref:System.Text.StringBuilder?qualifyHint=False> object.  
  
     [!code[VbVbalrGuidelines#5](../vs140/codesnippet/VisualBasic/visual-basic-coding-conventions_4.vb)]
  
  
### Relaxed Delegates in Event Handlers  
 Do not explicitly qualify the arguments (Object and EventArgs) to event handlers. If you are not using the event arguments that are passed to an event (for example, sender as Object, e as EventArgs), use relaxed delegates, and leave out the event arguments in your code:  
  
 [!code[VbVbalrGuidelines#7](../vs140/codesnippet/VisualBasic/visual-basic-coding-conventions_5.vb)]
  
  
### Unsigned Data Type  
  
-   Use `Integer` rather than unsigned types, except where they are necessary.  
  
### Arrays  
  
-   Use the short syntax when you initialize arrays on the declaration line. For example, use the following syntax.  
  
     [!code[VbVbalrGuidelines#8](../vs140/codesnippet/VisualBasic/visual-basic-coding-conventions_6.vb)]
  
  
     Do not use the following syntax.  
  
     [!code[VbVbalrGuidelines#9](../vs140/codesnippet/VisualBasic/visual-basic-coding-conventions_7.vb)]
  
  
-   Put the array designator on the type, not on the variable. For example, use the following syntax:  
  
     [!code[VbVbalrGuidelines#11](../vs140/codesnippet/VisualBasic/visual-basic-coding-conventions_8.vb)]
  
  
     Do not use the following syntax:  
  
     [!code[VbVbalrGuidelines#10](../vs140/codesnippet/VisualBasic/visual-basic-coding-conventions_9.vb)]
  
  
-   Use the { } syntax when you declare and initialize arrays of basic data types. For example, use the following syntax:  
  
     [!code[VbVbalrGuidelines#12](../vs140/codesnippet/VisualBasic/visual-basic-coding-conventions_10.vb)]
  
  
     Do not use the following syntax:  
  
     [!code[VbVbalrGuidelines#13](../vs140/codesnippet/VisualBasic/visual-basic-coding-conventions_11.vb)]
  
  
### Use the With Keyword  
 When you make a series of calls to one object, consider using the `With` keyword:  
  
 [!code[VbVbalrGuidelines#15](../vs140/codesnippet/VisualBasic/visual-basic-coding-conventions_12.vb)]
  
  
### Use the Try...Catch and Using Statements when you use Exception Handling  
 Do not use `On Error Goto`.  
  
### Use the IsNot Keyword  
 Use the `IsNot` keyword instead of `Not...Is Nothing`.  
  
### New Keyword  
  
-   Use short instantiation. For example, use the following syntax:  
  
     [!code[VbVbalrGuidelines#21](../vs140/codesnippet/VisualBasic/visual-basic-coding-conventions_13.vb)]
  
  
     The preceding line is equivalent to this:  
  
     [!code[VbVbalrGuidelines#22](../vs140/codesnippet/VisualBasic/visual-basic-coding-conventions_14.vb)]
  
  
-   Use object initializers for new objects instead of the parameterless constructor:  
  
     [!code[VbVbalrGuidelines#23](../vs140/codesnippet/VisualBasic/visual-basic-coding-conventions_15.vb)]
  
  
### Event Handling  
  
-   Use `Handles` rather than `AddHandler`:  
  
     [!code[VbVbalrGuidelines#24](../vs140/codesnippet/VisualBasic/visual-basic-coding-conventions_16.vb)]
  
  
-   Use `AddressOf`, and do not instantiate the delegate explicitly:  
  
     [!code[VbVbalrGuidelines#25](../vs140/codesnippet/VisualBasic/visual-basic-coding-conventions_17.vb)]
  
  
-   When you define an event, use the short syntax, and let the compiler define the delegate:  
  
     [!code[VbVbalrGuidelines#26](../vs140/codesnippet/VisualBasic/visual-basic-coding-conventions_18.vb)]
  
  
-   Do not verify whether an event is `Nothing` (null) before you call the `RaiseEvent` method. `RaiseEvent` checks for `Nothing` before it raises the event.  
  
### Using Shared Members  
 Call `Shared` members by using the class name, not from an instance variable.  
  
### Use XML Literals  
 XML literals simplify the most common tasks that you encounter when you work with XML (for example, load, query, and transform). When you develop with XML, follow these guidelines:  
  
-   Use XML literals to create XML documents and fragments instead of calling XML APIs directly.  
  
-   Import XML namespaces at the file or project level to take advantage of the performance optimizations for XML literals.  
  
-   Use the XML axis properties to access elements and attributes in an XML document.  
  
-   Use embedded expressions to include values and to create XML from existing values instead of using API calls such as the `Add` method:  
  
     [!code[VbVbalrGuidelines#27](../vs140/codesnippet/VisualBasic/visual-basic-coding-conventions_19.vb)]
  
  
### LINQ Queries  
  
-   Use meaningful names for query variables:  
  
     [!code[VbVbalrGuidelines#28](../vs140/codesnippet/VisualBasic/visual-basic-coding-conventions_20.vb)]
  
  
-   Provide names for elements in a query to make sure that property names of anonymous types are correctly capitalized using Pascal casing:  
  
     [!code[VbVbalrGuidelines#29](../vs140/codesnippet/VisualBasic/visual-basic-coding-conventions_21.vb)]
  
  
-   Rename properties when the property names in the result would be ambiguous. For example, if your query returns a customer name and an order ID, rename them instead of leaving them as `Name` and `ID` in the result:  
  
     [!code[VbVbalrGuidelines#30](../vs140/codesnippet/VisualBasic/visual-basic-coding-conventions_22.vb)]
  
  
-   Use type inference in the declaration of query variables and range variables:  
  
     [!code[VbVbalrGuidelines#31](../vs140/codesnippet/VisualBasic/visual-basic-coding-conventions_23.vb)]
  
  
-   Align query clauses under the `From` statement:  
  
     [!code[VbVbalrGuidelines#32](../vs140/codesnippet/VisualBasic/visual-basic-coding-conventions_24.vb)]
  
  
-   Use `Where` clauses before other query clauses so that later query clauses operate on the filtered set of data:  
  
     [!code[VbVbalrGuidelines#33](../vs140/codesnippet/VisualBasic/visual-basic-coding-conventions_25.vb)]
  
  
-   Use the `Join` clause to explicitly define a join operation instead of using the `Where` clause to implicitly define a join operation:  
  
     [!code[VbVbalrGuidelines#34](../vs140/codesnippet/VisualBasic/visual-basic-coding-conventions_26.vb)]
  
  
## See Also  
 [Secure Coding Guidelines](assetId:///4f882d94-262b-4494-b0a6-ba9ba1f5f177)