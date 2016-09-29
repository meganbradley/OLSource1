---
title: "How to: Use the My Namespace (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "C# language, My namespace access"
ms.assetid: e7152414-0ea5-4c8e-bf02-c8d5bbe45ff4
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use the My Namespace (C# Programming Guide)
The <xref:Microsoft.VisualBasic.MyServices*> namespace (`My` in Visual Basic) provides easy and intuitive access to a number of .NET Framework classes, enabling you to write code that interacts with the computer, application, settings, resources, and so on. Although originally designed for use with Visual Basic, the `MyServices` namespace can be used in C# applications.  
  
 For more information about using the `MyServices` namespace from Visual Basic, see [Shortcuts to Visual Basic Development with My](../vs140/development-with-my--visual-basic-.md).  
  
## Adding a Reference  
 Before you can use the `MyServices` classes in your solution, you must add a reference to the Visual Basic library.  
  
#### To add a reference to the Visual Basic library  
  
1.  In **Solution Explorer**, right-click the **References** node, and select **Add Reference**.  
  
2.  When the **References** dialog box appears, scroll down the list, and select Microsoft.VisualBasic.dll.  
  
     You might also want to include the following line in the `using` section at the start of your program.  
  
     [!code[csProgGuideNamespaces#18](../vs140/codesnippet/CSharp/how-to--use-the-my-namespace--csharp-programming-guide-_1.cs)]  
  
## Example  
 This example calls various static methods contained in the `MyServices` namespace. For this code to compile, a reference to Microsoft.VisualBasic.DLL must be added to the project.  
  
 [!code[csProgGuideNamespaces#19](../vs140/codesnippet/CSharp/how-to--use-the-my-namespace--csharp-programming-guide-_2.cs)]  
  
 Not all the classes in the `MyServices` namespace can be called from a C# application: for example, the <xref:Microsoft.VisualBasic.MyServices.FileSystemProxy*> class is not compatible. In this particular case, the static methods that are part of <xref:Microsoft.VisualBasic.FileIO.FileSystem*>, which are also contained in VisualBasic.dll, can be used instead. For example, here is how to use one such method to duplicate a directory:  
  
 [!code[csProgGuideNamespaces#20](../vs140/codesnippet/CSharp/how-to--use-the-my-namespace--csharp-programming-guide-_3.cs)]  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Namespaces (C#)](../vs140/namespaces--csharp-programming-guide-.md)   
 [Using Namespaces (C#)](../vs140/using-namespaces--csharp-programming-guide-.md)