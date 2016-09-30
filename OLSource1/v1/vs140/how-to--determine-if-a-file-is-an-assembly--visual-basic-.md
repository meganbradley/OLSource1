---
title: "How to: Determine If a File Is an Assembly (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: de26f410-9bd1-4b55-a343-cc82f81684be
caps.latest.revision: 10
---
# How to: Determine If a File Is an Assembly (Visual Basic)
A file is an assembly if and only if it is managed, and contains an assembly entry in its metadata. For more information on assemblies and metadata, see the topic [Assembly Manifest](assetId:///8e40fab9-549d-4731-aec2-ffa47a382de0).  
  
### How to manually determine if a file is an assembly  
  
1.  Start the [MSIL Disassembler (Ildasm.exe)](assetId:///db27f6b2-f1ec-499e-be3a-7eecf95ca42b).  
  
2.  Load the file you wish to test.  
  
3.  If **ILDASM** reports that the file is not a portable executable (PE) file, then it is not an assembly. For more information, see the topic [How to: View Assembly Contents](assetId:///fb7baaab-4c0d-47ad-8fd3-4591cf834709).  
  
### How to programmatically determine if a file is an assembly  
  
1.  Call the \<xref:System.Reflection.AssemblyName.GetAssemblyName*> method, passing the full file path and name of the file you are testing.  
  
2.  If a \<xref:System.BadImageFormatException*> exception is thrown, the file is not an assembly.  
  
## Example  
 This example tests a DLL to see if it is an assembly.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The \<xref:System.Reflection.AssemblyName.GetAssemblyName*> method loads the test file, and then releases it once the information is read.  
  
## See Also  
 \<xref:System.Reflection.AssemblyName*>   
 [Visual Basic Programming Guide](../vs140/visual-basic-programming-guide.md)   
 [Assemblies and the Global Assembly Cache (Visual Basic)](../vs140/assemblies-and-the-global-assembly-cache--visual-basic-.md)