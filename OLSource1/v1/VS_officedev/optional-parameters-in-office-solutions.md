---
title: "Optional Parameters in Office Solutions"
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
  - "Office applications [Office development in Visual Studio], optional parameters"
  - "Visual C# [Office development in Visual Studio], optional parameters"
  - "Visual Basic [Office development in Visual Studio], optional parameters"
  - "application development [Office development in Visual Studio], optional parameters"
  - "missing field [Office development in Visual Studio]"
  - "optional parameters [Office development in Visual Studio]"
  - "parameters [Office development in Visual Studio], optional"
ms.assetid: 109eaef6-08bb-4b59-a29e-921f856027cc
caps.latest.revision: 43
ms.author: "normesta"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Optional Parameters in Office Solutions
  Many of the methods in the object models of Microsoft Office applications accept optional parameters. If you use Visual Basic to develop an Office solution in Visual Studio, you do not have to pass a value for optional parameters because the default values are automatically used for each missing parameter. In most cases, you can also omit optional parameters in Visual C# projects. However, you cannot omit optional **ref** parameters of the `ThisDocument` class in document-level Word projects.  
  
 [!INCLUDE[appliesto_all](../VS_officedev/includes/appliesto_all_md.md)]  
  
 For more information about working with optional parameters in Visual C# and Visual Basic projects, see [Named and Optional Arguments &#40;C&#35; Programming Guide&#41;](../Topic/Named%20and%20Optional%20Arguments%20(C%23%20Programming%20Guide).md) and [Optional Parameters &#40;Visual Basic&#41;](../Topic/Optional%20Parameters%20(Visual%20Basic).md).  
  
> [!NOTE]  
>  In earlier versions of Visual Studio, you must pass a value for every optional parameter in Visual C# projects. For convenience, these projects include a global variable named `missing` that you can pass to an optional parameter when you want to use the default value of the parameter. Visual C# projects for Office in Visual Studio still include the `missing` variable, but you typically do not need to use it when you develop Office solutions in [!INCLUDE[vs_dev12](../VS_officedev/includes/vs_dev12_md.md)], except when you call methods with optional **ref** parameters in the `ThisDocument` class in document-level projects for Word.  
  
## Example in Excel  
 The \<xref:Microsoft.Office.Tools.Excel.Worksheet.CheckSpelling*> method has many optional parameters. You can specify values for some parameters and accept the default value of others as shown in the following code example. This example requires a document-level project with a worksheet class named `Sheet1`.  
  
 [!code[Trin_VstrefGeneralExcel#1](../VS_officedev/codesnippet/CSharp/optional-parameters-in-office-solutions_1.cs)]
[!code[Trin_VstrefGeneralExcel#1](../VS_officedev/codesnippet/VisualBasic/optional-parameters-in-office-solutions_1.vb)]  
  
## Example in Word  
 The \<xref:Microsoft.Office.Interop.Word.Find.Execute*> method has many optional parameters. You can specify values for some parameters and accept the default value of others as shown in the following code example.  
  
 [!code[Trin_VstrefGeneralWord#1](../VS_officedev/codesnippet/VisualBasic/optional-parameters-in-office-solutions_2.vb)]
[!code[Trin_VstrefGeneralWord#1](../VS_officedev/codesnippet/CSharp/optional-parameters-in-office-solutions_2.cs)]  
  
## Using Optional Parameters of Methods in the ThisDocument Class in Visual C# Document-Level Projects for Word  
 The Word object model contains many methods with optional **ref** parameters that accept \<xref:System.Object> values. However, you cannot omit optional **ref** parameters of methods of the generated `ThisDocument` class in Visual C# document-level projects for Word. Visual C# enables you to omit optional **ref** parameters only for methods of interfaces, not classes. For example, the following code example does not compile, because you cannot omit optional **ref** parameters of the \<xref:Microsoft.Office.Tools.Word.DocumentBase.CheckSpelling*> method of the `ThisDocument` class.  
  
 [!code[Trin_VstrefGeneralWord#3](../VS_officedev/codesnippet/CSharp/optional-parameters-in-office-solutions_3.cs)]  
  
 When you call methods of the `ThisDocument` class, follow these guidelines:  
  
-   To accept the default value of an optional **ref** parameter, pass the `missing` variable to the parameter. The `missing` variable is automatically defined in Visual C# Office projects and is assigned to the value \<xref:System.Type.Missing> in the generated project code.  
  
-   To specify your own value for an optional **ref** parameter, declare an object that is assigned to the value that you want to specify, and then pass the object to the parameter.  
  
 The following code example demonstrates how to call the \<xref:Microsoft.Office.Tools.Word.DocumentBase.CheckSpelling*> method by specifying a value for the *ignoreUppercase* parameter and accepting the default value for the other parameters.  
  
 [!code[Trin_VstrefGeneralWord#4](../VS_officedev/codesnippet/CSharp/optional-parameters-in-office-solutions_4.cs)]  
  
 If you want to write code that omits optional **ref** parameters of a method in the `ThisDocument` class, you can alternatively call the same method on the \<xref:Microsoft.Office.Interop.Word.Document> object returned by the \<xref:Microsoft.Office.Tools.Word.Document.InnerObject*> property, and omit the parameters from that method. You can do this because \<xref:Microsoft.Office.Interop.Word.Document> is an interface, rather than a class.  
  
 [!code[Trin_VstrefGeneralWord#5](../VS_officedev/codesnippet/CSharp/optional-parameters-in-office-solutions_5.cs)]  
  
 For more information about value and reference type parameters, see [Passing Arguments by Value and by Reference &#40;Visual Basic&#41;](../Topic/Passing%20Arguments%20by%20Value%20and%20by%20Reference%20(Visual%20Basic).md) (for Visual Basic) and [Passing Parameters &#40;C&#35; Programming Guide&#41;](../Topic/Passing%20Parameters%20(C%23%20Programming%20Guide).md).  
  
## See Also  
 [Developing Office Solutions](../VS_officedev/developing-office-solutions.md)   
 [Writing Code in Office Solutions](../VS_officedev/writing-code-in-office-solutions.md)  
  
  