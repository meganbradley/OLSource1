---
title: "-link (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/link (Visual Basic)"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "l compiler option [Visual Basic]"
  - "EmbedInteropTypes"
  - "embed interop types [COM Interop]"
  - "-link compiler option [Visual Basic]"
  - "/link compiler option [Visual Basic]"
  - "link compiler option [Visual Basic]"
  - "-l compiler option [Visual Basic]"
  - "/l compiler option [Visual Basic]"
ms.assetid: 1885f24a-86f5-486c-a064-9fb7e455ccec
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -link (Visual Basic)
Causes the compiler to make COM type information in the specified assemblies available to the project that you are currently compiling.  
  
## Syntax  
  
```  
/link:fileList  
' -or-  
/l:fileList  
```  
  
## Arguments  
  
|||  
|-|-|  
|Term|Definition|  
|`fileList`|Required. Comma-delimited list of assembly file names. If the file name contains a space, enclose the name in quotation marks.|  
  
## Remarks  
 The `/link` option enables you to deploy an application that has embedded type information. The application can then use types in a runtime assembly that implement the embedded type information without requiring a reference to the runtime assembly. If various versions of the runtime assembly are published, the application that contains the embedded type information can work with the various versions without having to be recompiled. For an example, see [Walkthrough: Embedding Types from Managed Assemblies](../vs140/walkthrough--embedding-types-from-managed-assemblies--csharp-and-visual-basic-.md).  
  
 Using the `/link` option is especially useful when you are working with COM interop. You can embed COM types so that your application no longer requires a primary interop assembly (PIA) on the target computer. The `/link` option instructs the compiler to embed the COM type information from the referenced interop assembly into the resulting compiled code. The COM type is identified by the CLSID (GUID) value. As a result, your application can run on a target computer that has installed the same COM types with the same CLSID values. Applications that automate Microsoft Office are a good example. Because applications like Office usually keep the same CLSID value across different versions, your application can use the referenced COM types as long as .NET Framework 4 or later is installed on the target computer and your application uses methods, properties, or events that are included in the referenced COM types.  
  
 The `/link` option embeds only interfaces, structures, and delegates. Embedding COM classes is not supported.  
  
> [!NOTE]
>  When you create an instance of an embedded COM type in your code, you must create the instance by using the appropriate interface. Attempting to create an instance of an embedded COM type by using the CoClass causes an error.  
  
 To set the `/link` option in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], add an assembly reference and set the `Embed Interop Types` property to **true**. The default for the `Embed Interop Types` property is **false**.  
  
 If you link to a COM assembly (Assembly A) which itself references another COM assembly (Assembly B), you also have to link to Assembly B if either of the following is true:  
  
-   A type from Assembly A inherits from a type or implements an interface from Assembly B.  
  
-   A field, property, event, or method that has a return type or parameter type from Assembly B is invoked.  
  
 Use [/libpath](../vs140/-libpath.md) to specify the directory in which one or more of your assembly references is located.  
  
 Like the [/reference](../vs140/-reference--visual-basic-.md) compiler option, the `/link` compiler option uses the Vbc.rsp response file, which references frequently used [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] assemblies. Use the [/noconfig](../vs140/-noconfig.md) compiler option if you do not want the compiler to use the Vbc.rsp file.  
  
 The short form of `/link` is `/l`.  
  
## Generics and Embedded Types  
 The following sections describe the limitations on using generic types in applications that embed interop types.  
  
### Generic Interfaces  
 Generic interfaces that are embedded from an interop assembly cannot be used. This is shown in the following example.  
  
 [!code[VbLinkCompiler#1](../vs140/codesnippet/VisualBasic/-link--visual-basic-_1.vb)]  
  
### Types That Have Generic Parameters  
 Types that have a generic parameter whose type is embedded from an interop assembly cannot be used if that type is from an external assembly. This restriction does not apply to interfaces. For example, consider the <xref:Microsoft.Office.Interop.Excel.Range*> interface that is defined in the <xref:Microsoft.Office.Interop.Excel*> assembly. If a library embeds interop types from the <xref:Microsoft.Office.Interop.Excel*> assembly and exposes a method that returns a generic type that has a parameter whose type is the <xref:Microsoft.Office.Interop.Excel.Range*> interface, that method must return a generic interface, as shown in the following code example.  
  
 [!code[VbLinkCompiler#2](../vs140/codesnippet/VisualBasic/-link--visual-basic-_2.vb)]  
[!code[VbLinkCompiler#3](../vs140/codesnippet/VisualBasic/-link--visual-basic-_3.vb)]  
[!code[VbLinkCompiler#4](../vs140/codesnippet/VisualBasic/-link--visual-basic-_4.vb)]  
  
 In the following example, client code can call the method that returns the <xref:System.Collections.IList*> generic interface without error.  
  
 [!code[VbLinkCompiler#5](../vs140/codesnippet/VisualBasic/-link--visual-basic-_5.vb)]  
  
## Example  
 The following code compiles source file `OfficeApp.vb` and reference assemblies from `COMData1.dll` and `COMData2.dll` to produce `OfficeApp.exe`.  
  
```vb#  
vbc /link:COMData1.dll,COMData2.dll /out:OfficeApp.exe OfficeApp.vb  
```  
  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [Walkthrough: Embedding Types from Managed Assemblies](../vs140/walkthrough--embedding-types-from-managed-assemblies--csharp-and-visual-basic-.md)   
 [/reference](../vs140/-reference--visual-basic-.md)   
 [/noconfig](../vs140/-noconfig.md)   
 [/libpath](../vs140/-libpath.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)   
 [Introduction to COM Interop](../vs140/introduction-to-com-interop--visual-basic-.md)