---
title: "Late Binding in Office Solutions"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "objects [Office development in Visual Studio], casting"
  - "types [Office development in Visual Studio], casting"
  - "automation [Office development in Visual Studio], casting objects"
  - "casting, object to specific type"
ms.assetid: 80b0d23e-df68-4ea9-a02b-238aee8ca9c0
caps.latest.revision: 49
ms.author: "normesta"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Late Binding in Office Solutions
  Some types in the object models of Office applications provide functionality that is available through late-binding features. For example, some methods and properties can return different types of objects depending on the context of the Office application, and some types can expose different methods or properties in different contexts.  
  
 [!INCLUDE[appliesto_all](../VS_officedev/includes/appliesto_all_md.md)]  
  
 Visual Basic projects where **Option Strict** is off and Visual C# projects that target the [!INCLUDE[net_v40_short](../VS_officedev/includes/net_v40_short_md.md)] or the [!INCLUDE[net_v45](../VS_officedev/includes/net_v45_md.md)] can work directly with types that employ these late-binding features.  
  
## Implicit and Explicit Casting of Object Return Values  
 Many methods and properties in the Microsoft Office primary interop assemblies (PIAs) return \<xref:System.Object> values, because they can return several different types of objects. For example, the \<xref:Microsoft.Office.Tools.Excel.Workbook.ActiveSheet*> property returns an \<xref:System.Object> because its return value can be a \<xref:Microsoft.Office.Interop.Excel.Worksheet> or \<xref:Microsoft.Office.Interop.Excel.Chart> object, depending on what the active sheet is.  
  
 When a method or property returns a \<xref:System.Object>, you must explicitly convert (in Visual Basic) the object to the correct type in Visual Basic projects where **Option Strict** is on. You do not have to explicitly cast \<xref:System.Object> return values in Visual Basic projects where **Option Strict** is off.  
  
 In most cases, the reference documentation lists the possible types of the return value for a member that returns an \<xref:System.Object>. Converting or casting the object enables IntelliSense for the object in the Code Editor.  
  
 For information about conversion in Visual Basic, see [Implicit and Explicit Conversions &#40;Visual Basic&#41;](../Topic/Implicit%20and%20Explicit%20Conversions%20(Visual%20Basic).md) and [CType Function &#40;Visual Basic&#41;](../Topic/CType%20Function%20(Visual%20Basic).md).  
  
### Examples  
 The following code example demonstrates how to cast an object to a specific type in a Visual Basic project where **Option Strict** is on. In this type of project, you must explicitly cast the \<xref:Microsoft.Office.Tools.Excel.WorksheetBase.Cells*> property to a \<xref:Microsoft.Office.Interop.Excel.Range>. This example requires a document-level Excel project with a worksheet class named `Sheet1`.  
  
 [!code[Trin_VstcoreProgramming#9](../VS_officedev/codesnippet/VisualBasic/late-binding-in-office-solutions_1.vb)]  
  
 The following code example demonstrates how to implicitly cast an object to a specific type in a Visual Basic project where **Option Strict** is off or in a Visual C# project that targets the [!INCLUDE[net_v40_short](../VS_officedev/includes/net_v40_short_md.md)]. In these types of projects, the \<xref:Microsoft.Office.Tools.Excel.WorksheetBase.Cells*> property is implicitly cast to a \<xref:Microsoft.Office.Interop.Excel.Range>. This example requires a document-level Excel project with a worksheet class named `Sheet1`.  
  
 [!code[Trin_VstcoreProgramming#10](../VS_officedev/codesnippet/VisualBasic/late-binding-in-office-solutions_2.vb)]
[!code[Trin_VstcoreProgramming#10](../VS_officedev/codesnippet/CSharp/late-binding-in-office-solutions_2.cs)]  
  
## Accessing Members That Are Available Only Through Late Binding  
 Some properties and methods in the Office PIAs are available only through late binding. In Visual Basic projects where **Option Strict** is off or in Visual C# projects that target the [!INCLUDE[net_v40_short](../VS_officedev/includes/net_v40_short_md.md)] or the [!INCLUDE[net_v45](../VS_officedev/includes/net_v45_md.md)], you can use the late binding features in these languages to access late-bound members. In Visual Basic projects where **Option Strict** is on, you must use reflection to access these members.  
  
### Examples  
 The following code example demonstrates how to access late-bound members in a Visual Basic project where **Option Strict** is off or in a Visual C# project that targets the [!INCLUDE[net_v40_short](../VS_officedev/includes/net_v40_short_md.md)]. This example accesses the late-bound **Name** property of the **File Open** dialog box in Word. To use this example, run it from the `ThisDocument` or `ThisAddIn` class in a Word project.  
  
 [!code[Trin_VstcoreWordAutomation#122](../VS_officedev/codesnippet/VisualBasic/late-binding-in-office-solutions_3.vb)]
[!code[Trin_VstcoreWordAutomation#122](../VS_officedev/codesnippet/CSharp/late-binding-in-office-solutions_3.cs)]  
  
 The following code example demonstrates how to use reflection to accomplish the same task in a Visual Basic project where **Option Strict** is on.  
  
 [!code[Trin_VstcoreWordAutomation#102](../VS_officedev/codesnippet/VisualBasic/late-binding-in-office-solutions_4.vb)]  
  
## See Also  
 [Writing Code in Office Solutions](../VS_officedev/writing-code-in-office-solutions.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)   
 [Using Type dynamic &#40;C&#35; Programming Guide&#41;](../Topic/Using%20Type%20dynamic%20(C%23%20Programming%20Guide).md)   
 [Option Strict Statement](../Topic/Option%20Strict%20Statement.md)   
 [Reflection &#40;C&#35; and Visual Basic&#41;](../Topic/Reflection%20(C%23%20and%20Visual%20Basic).md)   
 [Designing and Creating Office Solutions](../VS_officedev/designing-and-creating-office-solutions.md)  
  
  