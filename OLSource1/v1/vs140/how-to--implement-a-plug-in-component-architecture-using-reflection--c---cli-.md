---
title: "How to: Implement a Plug-In Component Architecture using Reflection (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Implement a Plug-In Component Architecture using Reflection (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "plug-ins [C++]"
  - "reflection [C++}, plug-ins"
ms.assetid: 4f31e42b-78d1-48b9-8fdc-f28c75e8e77e
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Implement a Plug-In Component Architecture using Reflection (C++-CLI)
The following code examples demonstrate the use of reflection to implement a simple "plug-in" architecture. The first listing is the application, and the second is the plug-in. The application is a multiple document form that populates itself using any form-based classes found in the plug-in DLL provided as a command-line argument.  
  
 The application attempts to load the provided assembly using the \<xref:System.Reflection.Assembly.Load*?displayProperty=fullName> method. If successful, the types inside the assembly are enumerated using the \<xref:System.Reflection.Assembly.GetTypes*?displayProperty=fullName> method. Each type is then checked for compatibility using the \<xref:System.Type.IsAssignableFrom*?displayProperty=fullName> method. In this example, classes found in the provided assembly must be derived from the \<xref:System.Windows.Forms.Form*> class to qualify as a plug-in.  
  
 Compatible classes are then instantiated with the \<xref:System.Activator.CreateInstance*?displayProperty=fullName> method, which accepts a \<xref:System.Type*> as an argument and returns a pointer to a new instance. Each new instance is then attached to the form and displayed.  
  
 Note that the \<xref:System.Reflection.Assembly.Load*> method does not accept assembly names that include the file extension. The main function in the application trims any provided extensions, so the following code example works in either case.  
  
## Example  
 The following code defines the application that accepts plug-ins. An assembly name must be provided as the first argument. This assembly should contain at least one public \<xref:System.Windows.Forms.Form*> derived type.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following code defines three classes derived from \<xref:System.Windows.Forms.Form*>. When the name of the resulting assembly name is passed to the executable in the previous listing, each of these three classes will be discovered and instantiated, despite the fact that they were all unknown to the hosting application at compile time.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Reflection in C++](../vs140/reflection--c---cli-.md)